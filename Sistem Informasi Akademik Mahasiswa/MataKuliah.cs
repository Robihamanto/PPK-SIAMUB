using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Informasi_Akademik_Mahasiswa
{
    public partial class FormMataKuliah : Form
    {
        private string connectionString;
        private string query;
        private MySqlConnection databaseConnection;
        private MySqlCommand commandDatabase;
        private String nim;

        public FormMataKuliah(String nim)
        {
            this.nim = nim;
            InitializeComponent();
            flowLayoutPanelCrud.Visible = false;
            this.nim = nim;
            if (nim == "admin")
            {
                flowLayoutPanelCrud.Visible = true;
                listMataKuliah();
            }
            else
            {
                listMataKuliahMahasiswa();
            }
        }

        private void listMataKuliah()
        {
            {
                connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
                query = "SELECT * FROM matakuliah";

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
                        while (reader.Read())
                        {
                            //ID First name Last Name Address
                            Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1));

                            //Insert Nilai to Listview
                            string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)};
                            var listViewItem = new ListViewItem(row);
                            listView1.Items.Add(listViewItem);
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
        }

        private void listMataKuliahMahasiswa()
        {
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            query = "SELECT * FROM matakuliah";

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
                    while (reader.Read())
                    {
                        //ID First name Last Name Address
                        Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1));

                        //Insert Nilai to Listview
                        string[] row = { reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            string query = "INSERT INTO matakuliah(`id`, `kode`, `nama`, `sks`) VALUES (NULL, '" + textBoxKode.Text + "', '" + textBoxNamaMatkul.Text + "', '" + textBoxJumlahSks.Text + "')";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                listMataKuliah();
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
            string query = "UPDATE `matakuliah` SET `kode`='" + textBoxKode.Text + "', `nama`='" + textBoxNamaMatkul.Text + "', `sks`='" + textBoxJumlahSks.Text + "' WHERE `id`='" + labelId.Text+"'";

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
                listMataKuliah();
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
            string query = "DELETE FROM `matakuliah` WHERE `id`='" + labelId.Text +"'";

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
                listMataKuliah();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView1.SelectedItems[0];
            //fill the text boxes
            labelId.Text = item.SubItems[0].Text;
            textBoxKode.Text = item.SubItems[1].Text;
            textBoxNamaMatkul.Text = item.SubItems[2].Text;
            textBoxJumlahSks.Text = item.SubItems[3].Text;
        }
    }
}
