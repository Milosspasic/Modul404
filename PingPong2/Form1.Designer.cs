namespace PingPong
{
    partial class frmPingPong
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
            this.components = new System.ComponentModel.Container();
            this.pnlSpiel = new System.Windows.Forms.Panel();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.picSchlaegerRechts = new System.Windows.Forms.PictureBox();
            this.vsbSchlaegerRechts = new System.Windows.Forms.VScrollBar();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSchlaegerRechts)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.picSchlaegerRechts);
            this.pnlSpiel.Controls.Add(this.picBall);
            this.pnlSpiel.Location = new System.Drawing.Point(13, 13);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(642, 424);
            this.pnlSpiel.TabIndex = 0;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picBall.Location = new System.Drawing.Point(277, 125);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(25, 25);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 492);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Spiel Starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmrSpiel
            // 
            this.tmrSpiel.Interval = 120;
            this.tmrSpiel.Tick += new System.EventHandler(this.tmrSpiel_Tick);
            // 
            // picSchlaegerRechts
            // 
            this.picSchlaegerRechts.BackColor = System.Drawing.Color.Black;
            this.picSchlaegerRechts.Location = new System.Drawing.Point(622, 189);
            this.picSchlaegerRechts.Name = "picSchlaegerRechts";
            this.picSchlaegerRechts.Size = new System.Drawing.Size(4, 40);
            this.picSchlaegerRechts.TabIndex = 1;
            this.picSchlaegerRechts.TabStop = false;
            // 
            // vsbSchlaegerRechts
            // 
            this.vsbSchlaegerRechts.Location = new System.Drawing.Point(662, 13);
            this.vsbSchlaegerRechts.Name = "vsbSchlaegerRechts";
            this.vsbSchlaegerRechts.Size = new System.Drawing.Size(17, 424);
            this.vsbSchlaegerRechts.TabIndex = 2;
            this.vsbSchlaegerRechts.Value = 50;
            this.vsbSchlaegerRechts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbSchlaegerRechts_Scroll);
            // 
            // txtPunkte
            // 
            this.txtPunkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPunkte.Location = new System.Drawing.Point(89, 443);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(100, 26);
            this.txtPunkte.TabIndex = 3;
            this.txtPunkte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Punkte:";
            // 
            // frmPingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.vsbSchlaegerRechts);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlSpiel);
            this.Name = "frmPingPong";
            this.Text = "Ping-Pong Spiel";
            this.pnlSpiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSchlaegerRechts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSpiel;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmrSpiel;
        private System.Windows.Forms.PictureBox picSchlaegerRechts;
        private System.Windows.Forms.VScrollBar vsbSchlaegerRechts;
        private System.Windows.Forms.TextBox txtPunkte;
        private System.Windows.Forms.Label label1;
    }
}

