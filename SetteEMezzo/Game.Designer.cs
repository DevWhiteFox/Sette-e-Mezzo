
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
            this.OwnCardList = new System.Windows.Forms.ListBox();
            this.WhosTheTurn = new System.Windows.Forms.Label();
            this.PickCard = new System.Windows.Forms.Button();
            this.PassTurn = new System.Windows.Forms.Button();
            this.Tavolo = new System.Windows.Forms.Panel();
            this.WinBanner = new System.Windows.Forms.RichTextBox();
            this.Master = new System.Windows.Forms.Label();
            this.Player5 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player4 = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Tavolo.SuspendLayout();
            this.SuspendLayout();
            // 
            // OwnCardList
            // 
            this.OwnCardList.Cursor = System.Windows.Forms.Cursors.Default;
            this.OwnCardList.FormattingEnabled = true;
            this.OwnCardList.Location = new System.Drawing.Point(11, 361);
            this.OwnCardList.Margin = new System.Windows.Forms.Padding(2);
            this.OwnCardList.Name = "OwnCardList";
            this.OwnCardList.Size = new System.Drawing.Size(185, 82);
            this.OwnCardList.TabIndex = 8;
            this.OwnCardList.SelectedIndexChanged += new System.EventHandler(this.OwnCardList_SelectedIndexChanged);
            // 
            // WhosTheTurn
            // 
            this.WhosTheTurn.AutoSize = true;
            this.WhosTheTurn.Location = new System.Drawing.Point(12, 346);
            this.WhosTheTurn.Name = "WhosTheTurn";
            this.WhosTheTurn.Size = new System.Drawing.Size(76, 13);
            this.WhosTheTurn.TabIndex = 10;
            this.WhosTheTurn.Text = "WhosTheTurn";
            // 
            // PickCard
            // 
            this.PickCard.BackgroundImage = global::SetteEMezzo.Properties.Resources.card;
            this.PickCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PickCard.Location = new System.Drawing.Point(340, 361);
            this.PickCard.Name = "PickCard";
            this.PickCard.Size = new System.Drawing.Size(136, 133);
            this.PickCard.TabIndex = 15;
            this.PickCard.UseVisualStyleBackColor = true;
            this.PickCard.Click += new System.EventHandler(this.PickCard_Click);
            // 
            // PassTurn
            // 
            this.PassTurn.BackgroundImage = global::SetteEMezzo.Properties.Resources.hand;
            this.PassTurn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PassTurn.Location = new System.Drawing.Point(201, 361);
            this.PassTurn.Name = "PassTurn";
            this.PassTurn.Size = new System.Drawing.Size(133, 133);
            this.PassTurn.TabIndex = 11;
            this.PassTurn.UseVisualStyleBackColor = true;
            this.PassTurn.Click += new System.EventHandler(this.PassTurn_Click);
            // 
            // Tavolo
            // 
            this.Tavolo.BackgroundImage = global::SetteEMezzo.Properties.Resources.table;
            this.Tavolo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tavolo.Controls.Add(this.Master);
            this.Tavolo.Controls.Add(this.Player5);
            this.Tavolo.Controls.Add(this.Player1);
            this.Tavolo.Controls.Add(this.Player4);
            this.Tavolo.Controls.Add(this.Player3);
            this.Tavolo.Controls.Add(this.Player2);
            this.Tavolo.Cursor = System.Windows.Forms.Cursors.Default;
            this.Tavolo.Location = new System.Drawing.Point(11, 11);
            this.Tavolo.Margin = new System.Windows.Forms.Padding(2);
            this.Tavolo.Name = "Tavolo";
            this.Tavolo.Size = new System.Drawing.Size(468, 324);
            this.Tavolo.TabIndex = 9;
            // 
            // WinBanner
            // 
            this.WinBanner.BackColor = System.Drawing.Color.White;
            this.WinBanner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WinBanner.Cursor = System.Windows.Forms.Cursors.Default;
            this.WinBanner.Enabled = false;
            this.WinBanner.Font = new System.Drawing.Font("Mongolian Baiti", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinBanner.ForeColor = System.Drawing.SystemColors.InfoText;
            this.WinBanner.Location = new System.Drawing.Point(12, 448);
            this.WinBanner.MaxLength = 100;
            this.WinBanner.Multiline = false;
            this.WinBanner.Name = "WinBanner";
            this.WinBanner.ReadOnly = true;
            this.WinBanner.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.WinBanner.Size = new System.Drawing.Size(183, 46);
            this.WinBanner.TabIndex = 6;
            this.WinBanner.Text = "<WinBanner>";
            this.WinBanner.Visible = false;
            this.WinBanner.ZoomFactor = 1.4F;
            // 
            // Master
            // 
            this.Master.AutoSize = true;
            this.Master.BackColor = System.Drawing.SystemColors.Control;
            this.Master.Location = new System.Drawing.Point(222, 44);
            this.Master.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Master.Name = "Master";
            this.Master.Size = new System.Drawing.Size(39, 13);
            this.Master.TabIndex = 5;
            this.Master.Text = "Master";
            // 
            // Player5
            // 
            this.Player5.AutoSize = true;
            this.Player5.Location = new System.Drawing.Point(375, 96);
            this.Player5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player5.Name = "Player5";
            this.Player5.Size = new System.Drawing.Size(42, 13);
            this.Player5.TabIndex = 4;
            this.Player5.Text = "Player5";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(35, 96);
            this.Player1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(42, 13);
            this.Player1.TabIndex = 0;
            this.Player1.Text = "Player1";
            // 
            // Player4
            // 
            this.Player4.AutoSize = true;
            this.Player4.Location = new System.Drawing.Point(375, 205);
            this.Player4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(42, 13);
            this.Player4.TabIndex = 3;
            this.Player4.Text = "Player4";
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Location = new System.Drawing.Point(210, 267);
            this.Player3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(42, 13);
            this.Player3.TabIndex = 2;
            this.Player3.Text = "Player3";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(35, 205);
            this.Player2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(42, 13);
            this.Player2.TabIndex = 1;
            this.Player2.Text = "Player2";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 506);
            this.Controls.Add(this.WinBanner);
            this.Controls.Add(this.PickCard);
            this.Controls.Add(this.PassTurn);
            this.Controls.Add(this.WhosTheTurn);
            this.Controls.Add(this.Tavolo);
            this.Controls.Add(this.OwnCardList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "SetteEMezzo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Tavolo.ResumeLayout(false);
            this.Tavolo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Tavolo;
        private System.Windows.Forms.Label Master;
        private System.Windows.Forms.Label Player5;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player4;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.ListBox OwnCardList;
        private System.Windows.Forms.Label WhosTheTurn;
        private System.Windows.Forms.Button PassTurn;
        private System.Windows.Forms.Button PickCard;
        private System.Windows.Forms.RichTextBox WinBanner;
    }
}