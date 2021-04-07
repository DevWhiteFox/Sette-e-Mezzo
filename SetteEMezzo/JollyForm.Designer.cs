
namespace SetteEMezzo
{
    partial class JollyForm
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
            this.NumberCard = new System.Windows.Forms.NumericUpDown();
            this.AssignNumber = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberCard)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberCard
            // 
            this.NumberCard.Location = new System.Drawing.Point(12, 12);
            this.NumberCard.Name = "NumberCard";
            this.NumberCard.Size = new System.Drawing.Size(137, 20);
            this.NumberCard.TabIndex = 0;
            // 
            // AssignNumber
            // 
            this.AssignNumber.Location = new System.Drawing.Point(12, 38);
            this.AssignNumber.Name = "AssignNumber";
            this.AssignNumber.Size = new System.Drawing.Size(137, 23);
            this.AssignNumber.TabIndex = 1;
            this.AssignNumber.Text = "Assegna";
            this.AssignNumber.UseVisualStyleBackColor = true;
            this.AssignNumber.Click += new System.EventHandler(this.AssignNumber_Click);
            // 
            // JollyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 72);
            this.Controls.Add(this.AssignNumber);
            this.Controls.Add(this.NumberCard);
            this.Name = "JollyForm";
            this.Text = "Jolly";
            ((System.ComponentModel.ISupportInitialize)(this.NumberCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumberCard;
        private System.Windows.Forms.Button AssignNumber;
    }
}