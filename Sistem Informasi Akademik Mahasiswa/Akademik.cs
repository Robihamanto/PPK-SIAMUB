using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Informasi_Akademik_Mahasiswa
{
    public partial class FormAkademik : Form
    {

        //Attribute
        private string connectionString;
        private string query;
        private MySqlConnection databaseConnection;
        private MySqlCommand commandDatabase;
        private String nim;
        //private object openFileDialogImage;

        public FormAkademik(String nim)
        {
            InitializeComponent();
            linkLabelMataKuliah.Visible = false;
            linkLabelMahasiswa.Visible = false;
            linkLabelKelas.Visible = false;
            this.nim = nim;
            if(nim == "admin")
            {
              linkLabelMataKuliah.Visible = true;
              linkLabelMahasiswa.Visible = true;
              linkLabelKelas.Visible = true;
                labelNim.Text = "";
                labelNama.Text = "Administrator";
            }
            else
            {
                mahasiswa();
            }
        }
    
        private void mahasiswa()
        {
            // Change the username, password and database according to your needs
            // You can ignore the database option if you want to access all of them.
            // 127.0.0.1 stands for localhost and the default port to connect.
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            // Your query,
            query = "SELECT * FROM mahasiswa WHERE nim = '" + nim + "'"; ;

            // Prepare the connection
            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            // Let's do it !
            try
            {
                // Open the database
                databaseConnection.Open();

                // Execute the query
                reader = commandDatabase.ExecuteReader();

                // All succesfully executed, now do something

                // IMPORTANT : 
                // If your query returns result, use the following processor :

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // As our database, the array will contain : ID 0, NIM 1,PASSWORD 2, FULLNAME 3, FAKULTAS 4, JURUSAN 5, SELEKSI 6, STATUS 7
                        // Do something with every received database ROW
                        string[] row = { reader.GetString(1), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetString(8)};
                        labelNim.Text = row[0];
                        labelNama.Text = row[1];
                        labelFakultas.Text = "Jenjang/Fakultas > S1/ " + row[2];
                        LabelJurusan.Text = "Jurusan > " + row[3];
                        labelSeleksi.Text = "Seleksi > " + row[4];
                        Labelstatus.Text = row[5];
                        if(row[6] != null)
                        {
                            pictureBoxFoto.Image = imgFromBase64(row[6]);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                // Finally close the connection
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabelMahasiswa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.MdiParent = this;
            mhs.Show();
        }

        private void linkLabelKartuRencanaStudi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KartuRencanaStudi krs = new KartuRencanaStudi(nim);
            krs.MdiParent = this;
            krs.Show();
        }

        private void linkLabelJadwalKuliah_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormJadwal jadwal = new FormJadwal(nim);
            jadwal.MdiParent = this;
            jadwal.Show();
        }

        private void linkLabelKartuHasilStudi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(nim == "admin")
            {
                FormKartuHasilStudiAdmin khs = new FormKartuHasilStudiAdmin(nim);
                khs.MdiParent = this;
                khs.Show();
            }
            else
            {
                FormKartuHasilStudi khs = new FormKartuHasilStudi(nim);
                khs.MdiParent = this;
                khs.Show();
            }
        }

        private void FormAkademik_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void linkLabelMataKuliah_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormMataKuliah matkul = new FormMataKuliah(nim);
            matkul.MdiParent = this;
            matkul.Show();
        }

        private void buttonUbahFoto_Click(object sender, EventArgs e)
        {
            openFileDialogFoto.ShowDialog();
            string path = openFileDialogFoto.FileName;
            //Checking file size
            if(openFileDialogFoto.FileName.Length > 307200)
            {
                MessageBox.Show("Ukuran file terlalu besar");
                return;
            }

            //Image to Base64
            using (Image image = Image.FromFile(path))
            {
                using (MemoryStream m = new MemoryStream())
                {
                    image.Save(m, image.RawFormat);
                    byte[] imageBytes = m.ToArray();

                    // Convert byte[] to Base64 String
                    string base64String = Convert.ToBase64String(imageBytes);
                    //return base64String;
                    pictureBoxFoto.Image = imgFromBase64(base64String);
                    updateImage(base64String);
                }
            }
        }

        private void updateImage(string base64)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            // Update the properties of the row with ID 1
            string query = "UPDATE `mahasiswa` SET `foto_profil`='" + base64 + "' WHERE `nim`='" + labelNim.Text + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                // Succesfully updated
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }
    
        private Image imgFromBase64(string base64)
        {
            Image image;
            using (var ms = new MemoryStream(Convert.FromBase64String(base64)))
            {
                image = Image.FromStream(ms, true);
                //pictureBox1.Image = image;
            }
            return image;
        }

        private void linkLabelNilai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kelas kelas = new Kelas("admin");
            kelas.MdiParent = this;
            kelas.Show();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin form = new FormLogin();
            form.Show();
        }
    }
}
