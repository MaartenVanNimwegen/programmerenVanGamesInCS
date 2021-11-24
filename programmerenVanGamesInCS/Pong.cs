using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programmerenVanGamesInCS
{
    public partial class Pong : Form
    {
        public Pong()
        {
            InitializeComponent();

            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PressedRight);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ReleasedRight);

            this.KeyPreview = true;
        }
        const int limit_Pad = 208;
        const int limit_Ball = 245;
        const int x = 227, y = 120;

        int computer_won = 0;
        int player_won = 0;

        int speed_Top;
        int speed_Left;

        bool upLeft = false;
        bool downLeft = false;
        bool upRight = false;
        bool downRight = false;
        bool game = false;

        Random r = new Random();
        private void PressedLeft(object sender, KeyEventArgs e)
        {
            if (game)
            {

                switch (e.KeyCode)
                {
                    case Keys.W:
                        upLeft = true;
                        timer1.Start();
                        break;
                    case Keys.S:
                        downLeft = true;
                        timer1.Start();
                        break;
                    default:
                        break;
                }
            }
        }
        private void PressedRight(object sender, KeyEventArgs e)
        {
            if (game)
            {

                switch (e.KeyCode)
                { 
                    case Keys.Up:
                        upRight = true;
                        timer3.Start();
                        break;
                    case Keys.Down:
                        downRight = true;
                        timer3.Start();
                        break;

                    default:
                        break;
                }
            }
        }
        private void MovePaddleLeft(object sender, EventArgs e)
        {
            if (game)
            {
                if (upLeft && PlayerLeft.Location.Y > 0)
                {
                    PlayerLeft.Top -= 3;
                }
                else if (downLeft && PlayerLeft.Location.Y < limit_Pad)
                {
                    PlayerLeft.Top += 3;
                }
            }
        }
        private void MovePaddleRight(object sender, EventArgs e)
        {
            if (game)
            {
                if (upRight && PlayerRight.Location.Y > 0)
                {
                    PlayerRight.Top -= 3;
                }
                else if (downRight && PlayerRight.Location.Y < limit_Pad)
                {
                    PlayerRight.Top += 3;
                }
            }
        }

        private void ReleasedLeft(object sender, KeyEventArgs e)
        {
            if (game)
            {
                switch (e.KeyCode)
                {
                    case Keys.W:
                        upLeft = false;
                        timer1.Stop();
                        break;
                    case Keys.S:
                        downLeft = false;
                        timer1.Stop();
                        break;
                }
            }
        }

        private void ReleasedRight(object sender, KeyEventArgs e)
        {
            if (game)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        upRight = false;
                        timer3.Stop();
                        break;
                    case Keys.Down:
                        downRight = false;
                        timer3.Stop();
                        break;
                }
            }
        }
        
        private void MoveBall(object sender, EventArgs e)
        {
            if (Ball.Bounds.IntersectsWith(PlayerLeft.Bounds))
            {
                Collision(PlayerLeft);
            }
            else if (Ball.Bounds.IntersectsWith(PlayerRight.Bounds))
            {
                Collision(PlayerRight);
            }
            HitBorder();
            BallLeftField();
            BallMoves();
        }

        private void Collision(PictureBox Paddle) 
        {
            switch (true)
            {
                case true when Upper(Paddle):
                    speed_Top = Negative(4, 6);
                    speed_Left = AdjustCoordinates(5, 6);
                    break;
                case true when High(Paddle):
                    speed_Top = Negative(2, 3);
                    speed_Left = AdjustCoordinates(6, 7);
                    break;
                case true when Middle(Paddle):
                    speed_Top = 0;
                    speed_Left = AdjustCoordinates(5, 5);
                    break;
                case true when Low(Paddle):
                    speed_Top = r.Next(2, 3);
                    speed_Left = AdjustCoordinates(6, 7);
                    break;
                case true when Bot(Paddle):
                    speed_Top = r.Next(4, 6);
                    speed_Left = AdjustCoordinates(5, 6);
                    break;                   
            }
            Edge(); 
        }
        private int AdjustCoordinates(int i,int n)
        {
            int res = 0; 

            if (Ball.Location.X < this.Width / 2)
            {
                res = r.Next(i, n);
            }
            else if (Ball.Location.X > this.Width / 2)
            {
                res = Negative(i, n);
            }
            return res;
        }
        private int Negative(int i,int n)
        {
            int myval = r.Next(i, n) * -1;
            return myval; 
        }
        private bool Upper(PictureBox Pad)
        {
            return Ball.Location.Y >= Pad.Top - Ball.Height && Ball.Location.Y <= Pad.Top + Ball.Height;
        }
        private bool High(PictureBox Pad)
        {
            return Ball.Location.Y > Pad.Top + Ball.Height && Ball.Location.Y <= Pad.Top + 2 * Ball.Height;
        }
        private bool Middle(PictureBox Pad)
        {
            return Ball.Location.Y > Pad.Top + 2 * Ball.Height && Ball.Location.Y <= Pad.Top + 3 * Ball.Height;
        }
        private bool Low(PictureBox Pad)
        {
            return Ball.Location.Y > Pad.Top + 3 * Ball.Height && Ball.Location.Y <= Pad.Top + 4 * Ball.Height;
        }
        private bool Bot(PictureBox Pad)
        {
            return Ball.Location.Y > Pad.Top + 4 * Ball.Height && Ball.Location.Y <= Pad.Bottom + Ball.Height;
        }
        private void HitBorder()
        {
            if (Ball.Location.Y <= 0 || Ball.Location.Y >= limit_Ball)
            {
                speed_Top *= -1; 
            }
        }
        private void BallLeftField()
        {
            if (player_won == 10 || computer_won == 10)
            {
                EndGame();
            }

            if (Ball.Location.X < 0 - PlayerLeft.Width && Ball.Location.X < this.Width / 2)
            {
                NewPoint(5);
                ComputerWon(); 
            }
            else if (Ball.Location.X > PlayerRight.Location.X + PlayerRight.Width && Ball.Location.X > this.Width / 2)
            {
                NewPoint(-5);
                PlayerWon(); 
            }
        }
        private void Edge()
        {
            if (Ball.Location.X < this.Width / 2)
            {
                if (Ball.Location.X < 0 + Ball.Height / 3)
                {
                    speed_Left *= -1; 
                }
            }
            else if (Ball.Location.X > this.Width / 2)
            {
                if (Ball.Location.X > PlayerRight.Location.X + (Ball.Width /3))
                {
                    speed_Left *= -1;
                }
            }
        }
        private void NewPoint(int n)
        { 
            Ball.Location = new Point(x, y);
            speed_Top = 0;
            speed_Left = n;
        }
        private void StartValues()
        {
            speed_Top = 0;
            speed_Left = -5; 
        }
        private void BallMoves()
        {
            Ball.Top += speed_Top;
            Ball.Left += speed_Left; 
        }

        private void PlayerWon()
        {
            player_won++;
            label1.Text = player_won.ToString();
        }
        private void ComputerWon()
        {
            computer_won++;
            label3.Text = computer_won.ToString(); 
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StartValues(); 
            game = true;
            button1.Visible = false;
            timer1.Start();
            timer2.Start();
            timer3.Start(); 
        }

        private void EndGame()
        {
            PlayerLeft.Location = new Point(0, 75);
            PlayerRight.Location = new Point(454, 75);
            game = false;
            player_won = 0;
            computer_won = 0;
            label1.Text = player_won.ToString();
            label3.Text = computer_won.ToString();
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            button1.Visible = true; 
        }
    }
}
