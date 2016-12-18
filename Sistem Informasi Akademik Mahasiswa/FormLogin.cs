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
    public partial class FormLogin : Form
    {

        //Attribute
        private string connectionString;
        private string query;
        private MySqlConnection databaseConnection;
        private MySqlCommand commandDatabase;
        FormAkademik akademik;

        public FormLogin()
        {
            InitializeComponent();
            // Change the username, password and database according to your needs
            // You can ignore the database option if you want to access all of them.
            // 127.0.0.1 stands for localhost and the default port to connect.
            connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=siam;";
        }

        private void buttonMasuk_Click(object sender, EventArgs e)
        {
            // Your query,
            if (textBoxNim.Text.Equals("admin") && textBoxPassword.Text.Equals("admin"))
            {
                query = "SELECT * FROM administrator";
            }
            else if(textBoxNim.Text != null)
            {
                query = "SELECT * FROM mahasiswa WHERE nim = '"+ textBoxNim.Text +"' AND password = '"+textBoxPassword.Text+"'";
            }

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
                        // As our database, the array will contain : ID 0, FIRST_NAME 1,LAST_NAME 2, ADDRESS 3
                        // Do something with every received database ROW
                        string[] row = { reader.GetString(1)};
                        akademik = new FormAkademik(row[0]);
                    }
                    this.Hide();
                    akademik.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Username atau Password Salah!");
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
