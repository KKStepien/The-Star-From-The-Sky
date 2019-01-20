namespace TheStarFromTheSky
{
    partial class FormGame
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
            this.LogoPanel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.AllScoreLabel5 = new System.Windows.Forms.Label();
            this.LiveLabel4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.GamePanel6 = new System.Windows.Forms.Panel();
            this.gamer1 = new TheStarFromTheSky.Gamer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ScoresLabel11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clock1 = new TheStarFromTheSky.Clock();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.LogoPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.GamePanel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPanel1
            // 
            this.LogoPanel1.Controls.Add(this.label6);
            this.LogoPanel1.Controls.Add(this.AllScoreLabel5);
            this.LogoPanel1.Controls.Add(this.LiveLabel4);
            this.LogoPanel1.Controls.Add(this.label3);
            this.LogoPanel1.Controls.Add(this.label2);
            this.LogoPanel1.Controls.Add(this.label1);
            this.LogoPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogoPanel1.Location = new System.Drawing.Point(0, 0);
            this.LogoPanel1.Name = "LogoPanel1";
            this.LogoPanel1.Size = new System.Drawing.Size(1354, 50);
            this.LogoPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(950, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 44);
            this.label6.TabIndex = 5;
            this.label6.Text = "ALL SCORES:";
            // 
            // AllScoreLabel5
            // 
            this.AllScoreLabel5.AutoSize = true;
            this.AllScoreLabel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.AllScoreLabel5.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllScoreLabel5.ForeColor = System.Drawing.Color.White;
            this.AllScoreLabel5.Location = new System.Drawing.Point(1318, 0);
            this.AllScoreLabel5.Name = "AllScoreLabel5";
            this.AllScoreLabel5.Size = new System.Drawing.Size(36, 44);
            this.AllScoreLabel5.TabIndex = 4;
            this.AllScoreLabel5.Text = "1";
            // 
            // LiveLabel4
            // 
            this.LiveLabel4.AutoSize = true;
            this.LiveLabel4.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveLabel4.ForeColor = System.Drawing.Color.White;
            this.LiveLabel4.Location = new System.Drawing.Point(325, 0);
            this.LiveLabel4.Name = "LiveLabel4";
            this.LiveLabel4.Size = new System.Drawing.Size(36, 44);
            this.LiveLabel4.TabIndex = 3;
            this.LiveLabel4.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(222, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "LIVE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "LEVEL:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1354, 645);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.GamePanel6);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(175, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1004, 645);
            this.panel5.TabIndex = 2;
            // 
            // GamePanel6
            // 
            this.GamePanel6.Controls.Add(this.gamer1);
            this.GamePanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GamePanel6.Location = new System.Drawing.Point(0, 0);
            this.GamePanel6.Name = "GamePanel6";
            this.GamePanel6.Size = new System.Drawing.Size(1004, 617);
            this.GamePanel6.TabIndex = 1;
            this.GamePanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel6_Paint);
            // 
            // gamer1
            // 
            this.gamer1.ColorGamer = System.Drawing.Color.DodgerBlue;
            this.gamer1.dx = 0D;
            this.gamer1.Location = new System.Drawing.Point(0, 567);
            this.gamer1.Name = "gamer1";
            this.gamer1.Size = new System.Drawing.Size(50, 50);
            this.gamer1.SizeGamer = 50;
            this.gamer1.TabIndex = 0;
            this.gamer1.X = 0D;
            this.gamer1.Load += new System.EventHandler(this.gamer1_Load_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 617);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 28);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ScoresLabel11);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1179, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 645);
            this.panel4.TabIndex = 1;
            // 
            // ScoresLabel11
            // 
            this.ScoresLabel11.AutoSize = true;
            this.ScoresLabel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.ScoresLabel11.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoresLabel11.ForeColor = System.Drawing.Color.White;
            this.ScoresLabel11.Location = new System.Drawing.Point(135, 44);
            this.ScoresLabel11.Name = "ScoresLabel11";
            this.ScoresLabel11.Size = new System.Drawing.Size(40, 44);
            this.ScoresLabel11.TabIndex = 6;
            this.ScoresLabel11.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Kristen ITC", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 44);
            this.label9.TabIndex = 6;
            this.label9.Text = "SCORES:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.clock1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(175, 645);
            this.panel3.TabIndex = 0;
            // 
            // clock1
            // 
            this.clock1.Font = new System.Drawing.Font("Kristen ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock1.KolorKolka = System.Drawing.Color.White;
            this.clock1.KolorWartosci = System.Drawing.Color.Black;
            this.clock1.KolorWwskażnika = System.Drawing.Color.Yellow;
            this.clock1.Location = new System.Drawing.Point(12, 6);
            this.clock1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.clock1.Name = "clock1";
            this.clock1.Prog = 60;
            this.clock1.Size = new System.Drawing.Size(150, 150);
            this.clock1.TabIndex = 0;
            this.clock1.Wartosc = 0;
            this.clock1.WielkoscKolka = 40;
            this.clock1.PrzekroczonoProg += new System.Action<int>(this.clock1_PrzekroczonoProg);
            this.clock1.Load += new System.EventHandler(this.clock1_Load);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1354, 695);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.LogoPanel1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "The Star From The Sky";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.LogoPanel1.ResumeLayout(false);
            this.LogoPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.GamePanel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LogoPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel GamePanel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private Clock clock1;
        private Gamer gamer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AllScoreLabel5;
        private System.Windows.Forms.Label LiveLabel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ScoresLabel11;
        private System.Windows.Forms.Label label9;
    }
}