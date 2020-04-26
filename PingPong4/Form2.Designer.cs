namespace PingPong
{
    partial class frmGameOver
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPunkte = new System.Windows.Forms.Label();
            this.lblErgebnisse = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnEintragen = new System.Windows.Forms.Button();
            this.btnSchliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Punkte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // lblPunkte
            // 
            this.lblPunkte.AutoSize = true;
            this.lblPunkte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPunkte.Location = new System.Drawing.Point(12, 33);
            this.lblPunkte.Name = "lblPunkte";
            this.lblPunkte.Size = new System.Drawing.Size(39, 15);
            this.lblPunkte.TabIndex = 2;
            this.lblPunkte.Text = "64738";
            // 
            // lblErgebnisse
            // 
            this.lblErgebnisse.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblErgebnisse.Location = new System.Drawing.Point(13, 65);
            this.lblErgebnisse.Name = "lblErgebnisse";
            this.lblErgebnisse.Size = new System.Drawing.Size(199, 139);
            this.lblErgebnisse.TabIndex = 3;
            this.lblErgebnisse.Text = "label4";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 4;
            // 
            // btnEintragen
            // 
            this.btnEintragen.Location = new System.Drawing.Point(218, 28);
            this.btnEintragen.Name = "btnEintragen";
            this.btnEintragen.Size = new System.Drawing.Size(75, 23);
            this.btnEintragen.TabIndex = 5;
            this.btnEintragen.Text = "Eintragen";
            this.btnEintragen.UseVisualStyleBackColor = true;
            this.btnEintragen.Click += new System.EventHandler(this.btnEintragen_Click);
            // 
            // btnSchliessen
            // 
            this.btnSchliessen.Location = new System.Drawing.Point(218, 181);
            this.btnSchliessen.Name = "btnSchliessen";
            this.btnSchliessen.Size = new System.Drawing.Size(75, 23);
            this.btnSchliessen.TabIndex = 6;
            this.btnSchliessen.Text = "Zurück";
            this.btnSchliessen.UseVisualStyleBackColor = true;
            this.btnSchliessen.Click += new System.EventHandler(this.btnSchliessen_Click);
            // 
            // frmGameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 217);
            this.Controls.Add(this.btnSchliessen);
            this.Controls.Add(this.btnEintragen);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblErgebnisse);
            this.Controls.Add(this.lblPunkte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmGameOver";
            this.Text = "Game Over !!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPunkte;
        private System.Windows.Forms.Label lblErgebnisse;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnEintragen;
        private System.Windows.Forms.Button btnSchliessen;
    }
}