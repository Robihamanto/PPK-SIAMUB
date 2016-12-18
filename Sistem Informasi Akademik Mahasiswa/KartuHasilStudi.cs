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
    public partial class FormKartuHasilStudi : Form
    { 
        //Attribute
        private string connectionString;
        private string query;
        private MySqlConnection databaseConnection;
        private MySqlCommand commandDatabase;
        private String nim;


        public FormKartuHasilStudi(String nim)
        {
            InitializeComponent();
            flowLayoutPanelCrud.Visible = false;
            this.nim = nim;
            if (nim == "admin")
            {
                flowLayoutPanelCrud.Visible = true;
                listNilai();
            }
            else
            {
                listNilaiMahasiswa();
            }
            
        }


        public void listNilai()
        {
            String connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            query = "SELECT MK.kode, M.fullname FROM matakuliah MK JOIN mahasiswa M ON 1=1 ";

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
                        string[] row = {no++.ToString(), reader.GetString(2), reader.GetString(1), reader.GetString(3)};
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

        

        public void listNilaiMahasiswa()
        {
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";

            query = "select mk.kode, mk.nama, mk.sks, k.nilai from khs k join matakuliah mk on mk.kode = k.kode where k.nim = " + nim+"";

            // Prepare the connection
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
                    int jumSks = 0;
                    while (reader.Read())
                    {
                        //No, Kode, Nama Mata Kuliah, Sks, Nilai
                        string[] row = {no++.ToString(), reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                        jumSks += Convert.ToInt32(reader.GetString(2));
                    }
                    string[] rows = { "", "", "                           JUMLAH SKS : ", jumSks.ToString(), ""};
                    var listViewItems = new ListViewItem(rows);
                    listView1.Items.Add(listViewItems);
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

        private void listUsers()
        {
            listView1.Items.Clear();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=connecting;";
            // Select all
            string query = "SELECT * FROM user";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
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
                        //ID First name Last Name Address
                        Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                        // Example to save in the listView1 :
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
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

        public void status(String id)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=media_sosial;";
            // Your query,
            //string query = "SELECT s.status, s.date FROM status s JOIN user u JOIN friend f ON u.id = "+id+ " AND f.userid = "+id+"";  
            string query = "SELECT s.status, s.date FROM user u JOIN friend f ON u.id = " + id + " AND f.userid = " + id + " JOIN status s ON f.friendid = s.userid";

            // Prepare the connection
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
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
                        //ID First name Last Name Address
                        Console.WriteLine(reader.GetString(0) + " - " + reader.GetString(1) + " - " + reader.GetString(2) + " - " + reader.GetString(3));
                        // Example to save in the listView1 :
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            string query = "INSERT INTO matakuliah(`id`, `nim`, `kode`, `nilai`) VALUES (NULL, '" + comboBoxNim.Text + "', '"+comboBoxMataKuliah.Text+"', '" + comboBoxNilai.Text + "')";
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
            comboBoxMataKuliah.Text = item.SubItems[0].Text;
            comboBoxNim.Text = item.SubItems[1].Text;
            comboBoxNilai.Text = item.SubItems[2].Text;
        }
    }
}
