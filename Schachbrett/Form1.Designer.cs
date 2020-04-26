namespace Schachbrett
{
    partial class frmSchachbrett
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudAnzahlZeilen = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlSchachbrett = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnzahlZeilen)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudAnzahlZeilen
            // 
            this.nudAnzahlZeilen.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAnzahlZeilen.Location = new System.Drawing.Point(3, 6);
            this.nudAnzahlZeilen.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudAnzahlZeilen.Name = "nudAnzahlZeilen";
            this.nudAnzahlZeilen.Size = new System.Drawing.Size(120, 20);
            this.nudAnzahlZeilen.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.nudAnzahlZeilen);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 31);
            this.panel1.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(129, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pnlSchachbrett
            // 
            this.pnlSchachbrett.BackColor = System.Drawing.Color.White;
            this.pnlSchachbrett.Location = new System.Drawing.Point(13, 51);
            this.pnlSchachbrett.Name = "pnlSchachbrett";
            this.pnlSchachbrett.Size = new System.Drawing.Size(452, 387);
            this.pnlSchachbrett.TabIndex = 2;
            // 
            // frmSchachbrett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.pnlSchachbrett);
            this.Controls.Add(this.panel1);
            this.Name = "frmSchachbrett";
            this.Text = "Schachbrett";
            ((System.ComponentModel.ISupportInitialize)(this.nudAnzahlZeilen)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAnzahlZeilen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlSchachbrett;
    }
}

