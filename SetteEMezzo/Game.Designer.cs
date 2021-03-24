
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
            this.PutCardOnTable = new System.Windows.Forms.Button();
            this.PlayTheCard = new System.Windows.Forms.Button();
            this.Tavolo = new System.Windows.Forms.Panel();
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
            this.OwnCardList.Size = new System.Drawing.Size(133, 134);
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
            // PutCardOnTable
            // 
            this.PutCardOnTable.BackgroundImage = global::SetteEMezzo.Properties.Resources.Hand_Holding_Playing_Cards_2_512;
            this.PutCardOnTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PutCardOnTable.Location = new System.Drawing.Point(311, 361);
            this.PutCardOnTable.Name = "PutCardOnTable";
            this.PutCardOnTable.Size = new System.Drawing.Size(136, 133);
            this.PutCardOnTable.TabIndex = 15;
            this.PutCardOnTable.UseVisualStyleBackColor = true;
            this.PutCardOnTable.Click += new System.EventHandler(this.PutCardOnTable_Click);
            // 
            // PlayTheCard
            // 
            this.PlayTheCard.BackgroundImage = global::SetteEMezzo.Properties.Resources.hand_card;
            this.PlayTheCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayTheCard.Location = new System.Drawing.Point(169, 361);
            this.PlayTheCard.Name = "PlayTheCard";
            this.PlayTheCard.Size = new System.Drawing.Size(136, 133);
            this.PlayTheCard.TabIndex = 11;
            this.PlayTheCard.UseVisualStyleBackColor = true;
            this.PlayTheCard.Click += new System.EventHandler(this.PlayTheCard_Click);
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
            this.Player5.Location = new System.Drawing.Point(403, 94);
            this.Player5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player5.Name = "Player5";
            this.Player5.Size = new System.Drawing.Size(42, 13);
            this.Player5.TabIndex = 4;
            this.Player5.Text = "Player5";
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(0, 94);
            this.Player1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(42, 13);
            this.Player1.TabIndex = 0;
            this.Player1.Text = "Player1";
            // 
            // Player4
            // 
            this.Player4.AutoSize = true;
            this.Player4.Location = new System.Drawing.Point(357, 207);
            this.Player4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(42, 13);
            this.Player4.TabIndex = 3;
            this.Player4.Text = "Player4";
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Location = new System.Drawing.Point(222, 265);
            this.Player3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(42, 13);
            this.Player3.TabIndex = 2;
            this.Player3.Text = "Player3";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(25, 207);
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
            this.Controls.Add(this.PutCardOnTable);
            this.Controls.Add(this.PlayTheCard);
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
        private System.Windows.Forms.Button PlayTheCard;
        private System.Windows.Forms.Button PutCardOnTable;
    }
}