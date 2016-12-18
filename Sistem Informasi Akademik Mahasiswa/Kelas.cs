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
    public partial class Kelas : Form
    { 
        //Attribute
        private string connectionString;
        private string query;
        private MySqlConnection databaseConnection;
        private MySqlCommand commandDatabase;
        private String nim;


        public Kelas(String nim)
        {
            InitializeComponent();
            flowLayoutPanelCrud.Visible = false;
            this.nim = nim;
            if (nim == "admin")
            {
                flowLayoutPanelCrud.Visible = true;
                listKelas();
            }
        }


        public void listKelas()
        {
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            query = "SELECT * FROM kelas";

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
                        
                        //Insert Nilai to Listview
                        string[] row = {no++.ToString(), reader.GetString(1), reader.GetString(2), reader.GetString(3)};
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
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            string query = "INSERT INTO kelas(`id`, `kode`, `nama`, `kapasitas`) VALUES (NULL, '" + textBoxKode.Text+ "', '"+textBoxNama.Text+"', '" + textBoxKapasitas.Text + "')";
            // Which could be translated manually to :
            
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                listKelas();
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
            string query = "UPDATE `kelas` SET `nama`='" + textBoxNama.Text + "', `kapasitas` = '" + textBoxKapasitas.Text + "' WHERE `kode`='" + textBoxKode.Text + "'";

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
                listKelas();
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
            string query = "DELETE FROM `kelas` WHERE `kode`='" + textBoxKode.Text + "'";

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
                listKelas();
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
            textBoxKode.Text = item.SubItems[1].Text;
            textBoxNama.Text = item.SubItems[2].Text;
            textBoxKapasitas.Text = item.SubItems[3].Text;
        }
    }
}
