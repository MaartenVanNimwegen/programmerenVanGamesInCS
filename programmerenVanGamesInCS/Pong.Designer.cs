namespace programmerenVanGamesInCS
{
    partial class Pong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.PlayerLeft = new System.Windows.Forms.PictureBox();
            this.PlayerRight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerRight)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.White;
            this.Ball.Location = new System.Drawing.Point(302, 148);
            this.Ball.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(20, 18);
            this.Ball.TabIndex = 2;
            this.Ball.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(301, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(382, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 258);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.MovePaddleLeft);
            // 
            // timer2
            // 
            this.timer2.Interval = 5;
            this.timer2.Tick += new System.EventHandler(this.MoveBall);
            // 
            // timer3
            // 
            this.timer3.Interval = 5;
            this.timer3.Tick += new System.EventHandler(this.MovePaddleRight);
            // 
            // PlayerLeft
            // 
            this.PlayerLeft.BackColor = System.Drawing.Color.White;
            this.PlayerLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerLeft.Location = new System.Drawing.Point(0, 122);
            this.PlayerLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerLeft.Name = "PlayerLeft";
            this.PlayerLeft.Size = new System.Drawing.Size(18, 64);
            this.PlayerLeft.TabIndex = 7;
            this.PlayerLeft.TabStop = false;
            // 
            // PlayerRight
            // 
            this.PlayerRight.BackColor = System.Drawing.Color.White;
            this.PlayerRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerRight.Location = new System.Drawing.Point(628, 122);
            this.PlayerRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayerRight.Name = "PlayerRight";
            this.PlayerRight.Size = new System.Drawing.Size(18, 64);
            this.PlayerRight.TabIndex = 8;
            this.PlayerRight.TabStop = false;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(645, 322);
            this.Controls.Add(this.PlayerRight);
            this.Controls.Add(this.PlayerLeft);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ball);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Pong";
            this.Text = "Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PressedLeft);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ReleasedLeft);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox PlayerLeft;
        private System.Windows.Forms.PictureBox PlayerRight;
    }
}

