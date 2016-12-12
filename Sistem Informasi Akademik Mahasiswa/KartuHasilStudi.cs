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
            this.nim = nim;
            listNilai();
        }

        public void listNilai()
        {

            // Change the username, password and database according to your needs
            // You can ignore the database option if you want to access all of them.
            // 127.0.0.1 stands for localhost and the default port to connect.
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
            // Your query,
            //string query = "SELECT s.status, s.date FROM user u JOIN friend f ON u.id = " + id + " AND f.userid = " + id + " JOIN status s ON f.friendid = s.userid";
            //query = "SELECT MK.nama, K.nilai FROM mahasiswa M WHERE M.nim = '" + nim + "' JOIN khs K ON M.nim = K.nim JOIN matakuliah MK ON K.kode = MK.kode";
            //query = "SELECT Kkode FROM mahasiswa M JOIN khs K ON M.nim = " + nim + "AND K.nim = "+ nim+"";
            //query = "SELECT * from Mahasiswa WHERE nim ="+nim+"";
            //query = "SELECT MK.nama FROM khs K JOIN matakuliah MK ON K.nim = MK.nim";// '"+nim+"'";
            query = "SELECT MK.nama FROM matakuliah MK WHERE MK.nim =" + nim + "";
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
                    while (reader.Read())
                    {
                        //ID First name Last Name Address
                        Console.WriteLine(reader.GetString(1) + " - " + reader.GetString(3));
                        // Example to save in the listView1 :
                        string[] row = {reader.GetString(2), reader.GetString(3)};
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
    }
}
