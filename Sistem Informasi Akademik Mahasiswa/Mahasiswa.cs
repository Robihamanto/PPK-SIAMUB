using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistem_Informasi_Akademik_Mahasiswa
{
    public partial class Mahasiswa : Form
    {
        //Attribute
        private string connectionString;
        private string query;
        private MySqlConnection databaseConnection;
        private MySqlCommand commandDatabase;
        public Mahasiswa()
        {
            InitializeComponent();
            listMahasiswa();
        }

        public void listMahasiswa()
        {
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            query = "SELECT M.nim, M.fullname, F.nama as fakultas, J.nama as jurusan FROM mahasiswa M LEFT OUTER JOIN fakultas F ON M.fakultas=F.nama LEFT OUTER JOIN jurusan J ON M.jurusan=J.nama";

            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                // Success, now list 
                // If there are available rows
                if (reader.HasRows)
                {
                    listView1.Items.Clear();
                    int no = 1;
                    while (reader.Read())
                    {
                        //ID First name Last Name Address
                        Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1));

                        //Insert Nilai to Listview
                        string[] row = {no++.ToString(), reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)};
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);

                        //Make Combobox Items
                        //comboBoxFakultas.Items.Add(reader["fakultas"]).ToString();
                        //comboBoxJurusan.Items.Add(reader["jurusan"]).ToString();
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView1.SelectedItems[0];
            //fill the text boxes
            textBoxNim.Text = item.SubItems[1].Text;
            textBoxNama.Text = item.SubItems[2].Text;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            //string query = "INSERT INTO mahasiswa(`id`, `nim`, `password`, `fullname`, `fakultas`, `jurusan`) VALUES (NULL, '" + textBoxNim.Text + "', '" + textBoxNim.Text.ToString().Substring(8,13) +"', '" + textBoxNama.Text + "', '" + comboBoxFakultas.Text + "', '" + comboBoxJurusan.Text + "')";
            string query = "INSERT INTO mahasiswa(`id`, `nim`, `password`, `fullname`, `fakultas`, `jurusan`, `seleksi`, `status`) VALUES (NULL, '" + textBoxNim.Text + "', '" + textBoxNim.Text + "', '" + textBoxNama.Text + "', '" + comboBoxFakultas.Text + "', '" + comboBoxJurusan.Text + "', '" + "SELEKSI NASIONAL MASUK PERGURUAN TINGGI NEGERI Brawijaya - Malang" + "', '" + "Aktif" + "')";
            // Which could be translated manually to :

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                listMahasiswa();
            }
            catch (Exception ex)
            {
                // Show any error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            // Update the properties of the row with ID 1
            string query = "UPDATE mahasiswa SET nim = '" + textBoxNim.Text + "', fullname = '" + textBoxNama.Text + "', fakultas ='" + comboBoxFakultas.Text + "', jurusan = '"+comboBoxJurusan.Text+"' WHERE nim = '" +textBoxNim.Text+"'";

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
                listMahasiswa();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            // Delete the item with ID 1
            string query = "DELETE FROM mahasiswa WHERE nim ='" + textBoxNim.Text + "'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Succesfully deleted
                databaseConnection.Close();
                listMahasiswa();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }
    }
}
