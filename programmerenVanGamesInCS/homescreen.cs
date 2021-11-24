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


namespace programmerenVanGamesInCS
{
    public partial class homescreen : Form
    {
        public homescreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lingo myForm = new Lingo();
            myForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pong myForm = new Pong();
            myForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FlappyBird myForm = new FlappyBird();
            myForm.ShowDialog();
        }

        private void homescreen_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM scores";

            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = "Data Source = localhost; Initial Catalog = testdatabase; User ID = root; Password = ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    //int resultaat = command.ExecuteNonQuery();
                    MySqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListViewItem myItem = new ListViewItem(new string[]
                            {
                                reader.GetString(1).ToString(),
                                reader.GetString(2).ToString(),
                                reader.GetString(3).ToString(),
                                reader.GetString(4).ToString()
                            });


                            lvHighscores.Items.Add(myItem);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Geen highscore resultatgen gevonden.");
                    }
                    reader.Close();

                }
            }

        }
    }
}
