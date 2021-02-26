
namespace SetteEMezzo
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.player1 = new System.Windows.Forms.Label();
            this.player2 = new System.Windows.Forms.Label();
            this.player3 = new System.Windows.Forms.Label();
            this.player4 = new System.Windows.Forms.Label();
            this.player5 = new System.Windows.Forms.Label();
            this.master = new System.Windows.Forms.Label();
            this.carteInMano = new System.Windows.Forms.ListBox();
            this.tavolo = new System.Windows.Forms.Panel();
            this.tavolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.AutoSize = true;
            this.player1.Location = new System.Drawing.Point(2, 103);
            this.player1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(35, 13);
            this.player1.TabIndex = 0;
            this.player1.Text = "label1";
            this.player1.UseWaitCursor = true;
            // 
            // player2
            // 
            this.player2.AutoSize = true;
            this.player2.Location = new System.Drawing.Point(53, 216);
            this.player2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(35, 13);
            this.player2.TabIndex = 1;
            this.player2.Text = "label2";
            this.player2.UseWaitCursor = true;
            // 
            // player3
            // 
            this.player3.AutoSize = true;
            this.player3.Location = new System.Drawing.Point(199, 274);
            this.player3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(35, 13);
            this.player3.TabIndex = 2;
            this.player3.Text = "label3";
            this.player3.UseWaitCursor = true;
            // 
            // player4
            // 
            this.player4.AutoSize = true;
            this.player4.Location = new System.Drawing.Point(345, 216);
            this.player4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player4.Name = "player4";
            this.player4.Size = new System.Drawing.Size(35, 13);
            this.player4.TabIndex = 3;
            this.player4.Text = "label4";
            this.player4.UseWaitCursor = true;
            // 
            // player5
            // 
            this.player5.AutoSize = true;
            this.player5.Location = new System.Drawing.Point(391, 103);
            this.player5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.player5.Name = "player5";
            this.player5.Size = new System.Drawing.Size(35, 13);
            this.player5.TabIndex = 4;
            this.player5.Text = "label5";
            this.player5.UseWaitCursor = true;
            // 
            // master
            // 
            this.master.AutoSize = true;
            this.master.Location = new System.Drawing.Point(199, 53);
            this.master.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.master.Name = "master";
            this.master.Size = new System.Drawing.Size(38, 13);
            this.master.TabIndex = 5;
            this.master.Text = "Banco";
            this.master.UseWaitCursor = true;
            // 
            // carteInMano
            // 
            this.carteInMano.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.carteInMano.FormattingEnabled = true;
            this.carteInMano.Location = new System.Drawing.Point(49, 336);
            this.carteInMano.Margin = new System.Windows.Forms.Padding(2);
            this.carteInMano.Name = "carteInMano";
            this.carteInMano.Size = new System.Drawing.Size(353, 82);
            this.carteInMano.TabIndex = 6;
            this.carteInMano.UseWaitCursor = true;
            // 
            // tavolo
            // 
            this.tavolo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tavolo.BackgroundImage")));
            this.tavolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tavolo.Controls.Add(this.master);
            this.tavolo.Controls.Add(this.player5);
            this.tavolo.Controls.Add(this.player1);
            this.tavolo.Controls.Add(this.player4);
            this.tavolo.Controls.Add(this.player3);
            this.tavolo.Controls.Add(this.player2);
            this.tavolo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.tavolo.Location = new System.Drawing.Point(8, 8);
            this.tavolo.Margin = new System.Windows.Forms.Padding(2);
            this.tavolo.Name = "tavolo";
            this.tavolo.Size = new System.Drawing.Size(430, 324);
            this.tavolo.TabIndex = 7;
            this.tavolo.UseWaitCursor = true;
            // 
            // Game
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(448, 424);
            this.Controls.Add(this.tavolo);
            this.Controls.Add(this.carteInMano);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game";
            this.Text = "SetteEMezzo";
            this.UseWaitCursor = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.tavolo.ResumeLayout(false);
            this.tavolo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label player1;
        private System.Windows.Forms.Label player2;
        private System.Windows.Forms.Label player3;
        private System.Windows.Forms.Label player4;
        private System.Windows.Forms.Label player5;
        private System.Windows.Forms.Label master;
        private System.Windows.Forms.ListBox carteInMano;
        private System.Windows.Forms.Panel tavolo;
    }
}