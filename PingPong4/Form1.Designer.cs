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
            this.picSchlaegerRechts = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrSpiel = new System.Windows.Forms.Timer(this.components);
            this.vsbSchlaegerRechts = new System.Windows.Forms.VScrollBar();
            this.txtPunkte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHoch = new System.Windows.Forms.Button();
            this.btnRunter = new System.Windows.Forms.Button();
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnRechts = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSteuerung = new System.Windows.Forms.GroupBox();
            this.rdbSchlaeger = new System.Windows.Forms.RadioButton();
            this.rdbBall = new System.Windows.Forms.RadioButton();
            this.pnlSpiel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSchlaegerRechts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.grpSteuerung.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSpiel
            // 
            this.pnlSpiel.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlSpiel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpiel.Controls.Add(this.picSchlaegerRechts);
            this.pnlSpiel.Controls.Add(this.picBall);
            this.pnlSpiel.Location = new System.Drawing.Point(26, 25);
            this.pnlSpiel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlSpiel.Name = "pnlSpiel";
            this.pnlSpiel.Size = new System.Drawing.Size(1282, 814);
            this.pnlSpiel.TabIndex = 0;
            // 
            // picSchlaegerRechts
            // 
            this.picSchlaegerRechts.BackColor = System.Drawing.Color.Black;
            this.picSchlaegerRechts.Location = new System.Drawing.Point(1244, 363);
            this.picSchlaegerRechts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picSchlaegerRechts.Name = "picSchlaegerRechts";
            this.picSchlaegerRechts.Size = new System.Drawing.Size(8, 77);
            this.picSchlaegerRechts.TabIndex = 1;
            this.picSchlaegerRechts.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.picBall.Location = new System.Drawing.Point(554, 240);
            this.picBall.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(50, 48);
            this.picBall.TabIndex = 0;
            this.picBall.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(26, 946);
            this.btnStart.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 44);
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
            // vsbSchlaegerRechts
            // 
            this.vsbSchlaegerRechts.Location = new System.Drawing.Point(1324, 25);
            this.vsbSchlaegerRechts.Name = "vsbSchlaegerRechts";
            this.vsbSchlaegerRechts.Size = new System.Drawing.Size(17, 815);
            this.vsbSchlaegerRechts.TabIndex = 2;
            this.vsbSchlaegerRechts.Value = 50;
            this.vsbSchlaegerRechts.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbSchlaegerRechts_Scroll);
            // 
            // txtPunkte
            // 
            this.txtPunkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPunkte.Location = new System.Drawing.Point(178, 852);
            this.txtPunkte.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPunkte.Name = "txtPunkte";
            this.txtPunkte.Size = new System.Drawing.Size(196, 44);
            this.txtPunkte.TabIndex = 3;
            this.txtPunkte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 858);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Punkte:";
            // 
            // btnHoch
            // 
            this.btnHoch.BackColor = System.Drawing.Color.White;
            this.btnHoch.Location = new System.Drawing.Point(1438, 302);
            this.btnHoch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnHoch.Name = "btnHoch";
            this.btnHoch.Size = new System.Drawing.Size(150, 44);
            this.btnHoch.TabIndex = 5;
            this.btnHoch.Tag = "ho";
            this.btnHoch.Text = "btnHoch";
            this.btnHoch.UseVisualStyleBackColor = false;
            this.btnHoch.Click += new System.EventHandler(this.btnUDLR_Click);
            // 
            // btnRunter
            // 
            this.btnRunter.BackColor = System.Drawing.Color.White;
            this.btnRunter.Location = new System.Drawing.Point(1438, 413);
            this.btnRunter.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRunter.Name = "btnRunter";
            this.btnRunter.Size = new System.Drawing.Size(150, 44);
            this.btnRunter.TabIndex = 6;
            this.btnRunter.Tag = "ru";
            this.btnRunter.Text = "btnRunter";
            this.btnRunter.UseVisualStyleBackColor = false;
            this.btnRunter.Click += new System.EventHandler(this.btnUDLR_Click);
            // 
            // btnLinks
            // 
            this.btnLinks.BackColor = System.Drawing.Color.White;
            this.btnLinks.Location = new System.Drawing.Point(1364, 358);
            this.btnLinks.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(150, 44);
            this.btnLinks.TabIndex = 7;
            this.btnLinks.Tag = "li";
            this.btnLinks.Text = "btnLinks";
            this.btnLinks.UseVisualStyleBackColor = false;
            this.btnLinks.Click += new System.EventHandler(this.btnUDLR_Click);
            // 
            // btnRechts
            // 
            this.btnRechts.BackColor = System.Drawing.Color.White;
            this.btnRechts.Location = new System.Drawing.Point(1526, 358);
            this.btnRechts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(150, 44);
            this.btnRechts.TabIndex = 8;
            this.btnRechts.Tag = "re";
            this.btnRechts.Text = "btnRechts";
            this.btnRechts.UseVisualStyleBackColor = false;
            this.btnRechts.Click += new System.EventHandler(this.btnUDLR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 854);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(377, 150);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tastatursteuerung:\r\nTaste\r\nH   horizontale Flugrichtung umkehren\r\nV   vertikale F" +
    "lugrichtung umkehren\r\nP   Spiel pausieren\r\nS   Spiel weiterlaufen lassen";
            // 
            // grpSteuerung
            // 
            this.grpSteuerung.Controls.Add(this.rdbSchlaeger);
            this.grpSteuerung.Controls.Add(this.rdbBall);
            this.grpSteuerung.Location = new System.Drawing.Point(1364, 852);
            this.grpSteuerung.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpSteuerung.Name = "grpSteuerung";
            this.grpSteuerung.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grpSteuerung.Size = new System.Drawing.Size(312, 152);
            this.grpSteuerung.TabIndex = 10;
            this.grpSteuerung.TabStop = false;
            this.grpSteuerung.Text = "Wahl der Steuerung";
            // 
            // rdbSchlaeger
            // 
            this.rdbSchlaeger.AutoSize = true;
            this.rdbSchlaeger.Location = new System.Drawing.Point(14, 85);
            this.rdbSchlaeger.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbSchlaeger.Name = "rdbSchlaeger";
            this.rdbSchlaeger.Size = new System.Drawing.Size(224, 29);
            this.rdbSchlaeger.TabIndex = 1;
            this.rdbSchlaeger.TabStop = true;
            this.rdbSchlaeger.Text = "Schlägersteuerung";
            this.rdbSchlaeger.UseVisualStyleBackColor = true;
            this.rdbSchlaeger.CheckedChanged += new System.EventHandler(this.rdbSchlaeger_CheckedChanged);
            // 
            // rdbBall
            // 
            this.rdbBall.AutoSize = true;
            this.rdbBall.Location = new System.Drawing.Point(14, 38);
            this.rdbBall.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rdbBall.Name = "rdbBall";
            this.rdbBall.Size = new System.Drawing.Size(175, 29);
            this.rdbBall.TabIndex = 0;
            this.rdbBall.TabStop = true;
            this.rdbBall.Text = "Ballsteuerung";
            this.rdbBall.UseVisualStyleBackColor = true;
            this.rdbBall.CheckedChanged += new System.EventHandler(this.rdbBall_CheckedChanged);
            // 
            // frmPingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1798, 1081);
            this.Controls.Add(this.grpSteuerung);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.btnLinks);
            this.Controls.Add(this.btnRunter);
            this.Controls.Add(this.btnHoch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPunkte);
            this.Controls.Add(this.vsbSchlaegerRechts);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlSpiel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmPingPong";
            this.Text = "Ping-Pong Spiel";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPingPong_KeyDown);
            this.pnlSpiel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSchlaegerRechts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.grpSteuerung.ResumeLayout(false);
            this.grpSteuerung.PerformLayout();
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
        private System.Windows.Forms.Button btnHoch;
        private System.Windows.Forms.Button btnRunter;
        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnRechts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSteuerung;
        private System.Windows.Forms.RadioButton rdbSchlaeger;
        private System.Windows.Forms.RadioButton rdbBall;
    }
}

