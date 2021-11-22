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
    public partial class scoreOpslaan : Form
    {
        public scoreOpslaan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into scores VALUES(id, 'naam', now(), '@score');";
            using (MySqlConnection connection = new MySqlConnection())
            {
                connection.ConnectionString = "Data Source = localhost; Initial Catalog = testdatabase; User ID = root; Password = ";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    connection.Open();
                    int resultaat = command.ExecuteNonQuery();
                    if (resultaat == 1)
                    {
                        MessageBox.Show("Je score is met succes opgeslagen.");
                    }
                    else
                    {
                        MessageBox.Show("Er is een fout opgetreden, de score is niet opgeslagen");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
