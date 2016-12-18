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
    public partial class FormKartuHasilStudiAdmin : Form
    { 
        //Attribute
        private string connectionString;
        private string query;
        private MySqlConnection databaseConnection;
        private MySqlCommand commandDatabase;
        private String nim;


        public FormKartuHasilStudiAdmin(String nim)
        {
            InitializeComponent();
            flowLayoutPanelCrud.Visible = false;
            this.nim = nim;
            if (nim == "admin")
            {
                flowLayoutPanelCrud.Visible = true;
                listNilai();
            } 
        }


        public void listNilai()
        {
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            query = "SELECT KHS.kode, MK.nama, KHS.nim, M.fullname, KHS.nilai FROM khs KHS JOIN matakuliah MK ON KHS.kode = MK.kode JOIN mahasiswa M ON KHS.nim = M.nim";

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
                        string[] row = {no++.ToString(), reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                    //Make Combo Box
                    comboItemKode();
                    comboItemNim();
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

        private void comboItemKode()
        {
            String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            query = "SELECT MK.kode FROM matakuliah MK";

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
                    while (reader.Read())
                    {
                        //Insert Nilai to Listview
                        string[] row = { reader.GetString(0) };

                        //Make Combobox Items
                        comboBoxMataKuliah.Items.Add(reader["kode"]).ToString();
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

        private void comboItemNim()
        {
            String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            query = "SELECT M.nim FROM mahasiswa M ";

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
                    while (reader.Read())
                    {
                        //Insert Nilai to Listview
                        string[] row = { reader.GetString(0) };

                        //Make Combobox Items
                        comboBoxNim.Items.Add(reader["nim"]).ToString();
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
            string query = "INSERT INTO khs(`id`, `nim`, `kode`, `nilai`) VALUES (NULL, '" + comboBoxNim.Text + "', '"+comboBoxMataKuliah.Text+"', '" + comboBoxNilai.Text + "')";
            // Which could be translated manually to :
            
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            try
            {
                databaseConnection.Open();
                MySqlDataReader myReader = commandDatabase.ExecuteReader();
                databaseConnection.Close();
                listNilai();
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
            string query = "UPDATE `khs` SET `nilai`='" + comboBoxNilai.Text + "' WHERE `nim`='" + comboBoxNim.Text + "' AND `kode`='"+comboBoxMataKuliah.Text+"'";

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
                listNilai();
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
            string query = "DELETE FROM `khs` WHERE `nim`='" + comboBoxNim.Text + "' AND `kode`='" + comboBoxMataKuliah.Text + "'";

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
                listNilai();
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
            comboBoxMataKuliah.Text = item.SubItems[1].Text;
            comboBoxNim.Text = item.SubItems[3].Text;
            comboBoxNilai.Text = item.SubItems[5].Text;
        }
    }
}
