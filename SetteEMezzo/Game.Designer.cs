
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
            this.Player1 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.Player4 = new System.Windows.Forms.Label();
            this.Player5 = new System.Windows.Forms.Label();
            this.Master = new System.Windows.Forms.Label();
            this.OwnCardList = new System.Windows.Forms.ListBox();
            this.Tavolo = new System.Windows.Forms.Panel();
            this.Tavolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(2, 103);
            this.Player1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(35, 13);
            this.Player1.TabIndex = 0;
            this.Player1.Text = "label1";
            this.Player1.UseWaitCursor = true;
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(53, 216);
            this.Player2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(35, 13);
            this.Player2.TabIndex = 1;
            this.Player2.Text = "label2";
            this.Player2.UseWaitCursor = true;
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Location = new System.Drawing.Point(199, 274);
            this.Player3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(35, 13);
            this.Player3.TabIndex = 2;
            this.Player3.Text = "label3";
            this.Player3.UseWaitCursor = true;
            // 
            // Player4
            // 
            this.Player4.AutoSize = true;
            this.Player4.Location = new System.Drawing.Point(345, 216);
            this.Player4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(35, 13);
            this.Player4.TabIndex = 3;
            this.Player4.Text = "label4";
            this.Player4.UseWaitCursor = true;
            // 
            // Player5
            // 
            this.Player5.AutoSize = true;
            this.Player5.Location = new System.Drawing.Point(391, 103);
            this.Player5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player5.Name = "Player5";
            this.Player5.Size = new System.Drawing.Size(35, 13);
            this.Player5.TabIndex = 4;
            this.Player5.Text = "label5";
            this.Player5.UseWaitCursor = true;
            // 
            // Master
            // 
            this.Master.AutoSize = true;
            this.Master.Location = new System.Drawing.Point(199, 53);
            this.Master.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(38, 13);
            this.Master.TabIndex = 5;
            this.Master.Text = "Banco";
            this.Master.UseWaitCursor = true;
            // 
            // OwnCardList
            // 
            this.OwnCardList.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.OwnCardList.FormattingEnabled = true;
            this.OwnCardList.Location = new System.Drawing.Point(49, 336);
            this.OwnCardList.Margin = new System.Windows.Forms.Padding(2);
            this.OwnCardList.Name = "OwnCardList";
            this.OwnCardList.Size = new System.Drawing.Size(353, 82);
            this.OwnCardList.TabIndex = 6;
            this.OwnCardList.UseWaitCursor = true;
            // 
            // Tavolo
            // 
            this.Tavolo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tavolo.BackgroundImage")));
            this.Tavolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tavolo.Controls.Add(this.Master);
            this.Tavolo.Controls.Add(this.Player5);
            this.Tavolo.Controls.Add(this.Player1);
            this.Tavolo.Controls.Add(this.Player4);
            this.Tavolo.Controls.Add(this.Player3);
            this.Tavolo.Controls.Add(this.Player2);
            this.Tavolo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Tavolo.Location = new System.Drawing.Point(8, 8);
            this.Tavolo.Margin = new System.Windows.Forms.Padding(2);
            this.Tavolo.Name = "Tavolo";
            this.Tavolo.Size = new System.Drawing.Size(430, 324);
            this.Tavolo.TabIndex = 7;
            // 
            // Game
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(448, 424);
            this.Controls.Add(this.Tavolo);
            this.Controls.Add(this.OwnCardList);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Game";
            this.Text = "SetteEMezzo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Tavolo.ResumeLayout(false);
            this.Tavolo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.Label Player4;
        private System.Windows.Forms.Label Player5;
        private System.Windows.Forms.Label Master;
        private System.Windows.Forms.ListBox OwnCardList;
        private System.Windows.Forms.Panel Tavolo;
    }
}