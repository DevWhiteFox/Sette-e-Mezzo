namespace SetteEMezzo
{
    partial class Lobby
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.Play = new System.Windows.Forms.Button();
            this.choiceNumberPlayers = new System.Windows.Forms.NumericUpDown();
            this.numPlayerLabel = new System.Windows.Forms.Label();
            this.namePlayer = new System.Windows.Forms.TextBox();
            this.playerLabel = new System.Windows.Forms.Label();
            this.addPlayer = new System.Windows.Forms.Button();
            this.confirmNPlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.choiceNumberPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // Play
            // 
            this.Play.Enabled = false;
            this.Play.Location = new System.Drawing.Point(35, 184);
            this.Play.Margin = new System.Windows.Forms.Padding(2);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(127, 46);
            this.Play.TabIndex = 0;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // choiceNumberPlayers
            // 
            this.choiceNumberPlayers.Location = new System.Drawing.Point(35, 32);
            this.choiceNumberPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.choiceNumberPlayers.Name = "choiceNumberPlayers";
            this.choiceNumberPlayers.Size = new System.Drawing.Size(127, 20);
            this.choiceNumberPlayers.TabIndex = 1;
            // 
            // numPlayerLabel
            // 
            this.numPlayerLabel.AutoSize = true;
            this.numPlayerLabel.Location = new System.Drawing.Point(35, 13);
            this.numPlayerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.numPlayerLabel.Name = "numPlayerLabel";
            this.numPlayerLabel.Size = new System.Drawing.Size(82, 13);
            this.numPlayerLabel.TabIndex = 2;
            this.numPlayerLabel.Text = "numPlayerLabel";
            // 
            // namePlayer
            // 
            this.namePlayer.Location = new System.Drawing.Point(35, 105);
            this.namePlayer.Margin = new System.Windows.Forms.Padding(2);
            this.namePlayer.Name = "namePlayer";
            this.namePlayer.Size = new System.Drawing.Size(129, 20);
            this.namePlayer.TabIndex = 3;
            // 
            // playerLabel
            // 
            this.playerLabel.AutoSize = true;
            this.playerLabel.Location = new System.Drawing.Point(33, 90);
            this.playerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.playerLabel.Name = "playerLabel";
            this.playerLabel.Size = new System.Drawing.Size(61, 13);
            this.playerLabel.TabIndex = 4;
            this.playerLabel.Text = "playerLabel";
            // 
            // addPlayer
            // 
            this.addPlayer.Location = new System.Drawing.Point(35, 126);
            this.addPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.addPlayer.Name = "addPlayer";
            this.addPlayer.Size = new System.Drawing.Size(127, 21);
            this.addPlayer.TabIndex = 5;
            this.addPlayer.Text = "Registra Nome";
            this.addPlayer.UseVisualStyleBackColor = true;
            this.addPlayer.Click += new System.EventHandler(this.addPlayer_Click);
            // 
            // confirmNPlayer
            // 
            this.confirmNPlayer.Location = new System.Drawing.Point(35, 54);
            this.confirmNPlayer.Margin = new System.Windows.Forms.Padding(2);
            this.confirmNPlayer.Name = "confirmNPlayer";
            this.confirmNPlayer.Size = new System.Drawing.Size(127, 20);
            this.confirmNPlayer.TabIndex = 6;
            this.confirmNPlayer.Text = "Conferma";
            this.confirmNPlayer.UseVisualStyleBackColor = true;
            this.confirmNPlayer.Click += new System.EventHandler(this.confirmNPlayer_Click);
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 243);
            this.Controls.Add(this.confirmNPlayer);
            this.Controls.Add(this.addPlayer);
            this.Controls.Add(this.playerLabel);
            this.Controls.Add(this.namePlayer);
            this.Controls.Add(this.numPlayerLabel);
            this.Controls.Add(this.choiceNumberPlayers);
            this.Controls.Add(this.Play);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lobby";
            this.Text = "SetteEMezzo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Lobby_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.choiceNumberPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.NumericUpDown choiceNumberPlayers;
        private System.Windows.Forms.Label numPlayerLabel;
        private System.Windows.Forms.TextBox namePlayer;
        private System.Windows.Forms.Label playerLabel;
        private System.Windows.Forms.Button addPlayer;
        private System.Windows.Forms.Button confirmNPlayer;
    }
}

