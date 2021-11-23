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
    }
}
