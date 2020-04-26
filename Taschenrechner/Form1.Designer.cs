namespace Taschenrechner
{
    partial class frmTaschenrechner
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
            this.txtOperand1 = new System.Windows.Forms.TextBox();
            this.txtOperand2 = new System.Windows.Forms.TextBox();
            this.lblOperator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErgebnis = new System.Windows.Forms.Label();
            this.btnAddition = new System.Windows.Forms.Button();
            this.btnSubtraktion = new System.Windows.Forms.Button();
            this.btnMittelwert = new System.Windows.Forms.Button();
            this.btnPotenz = new System.Windows.Forms.Button();
            this.btnMaximum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOperand1
            // 
            this.txtOperand1.Location = new System.Drawing.Point(12, 12);
            this.txtOperand1.Name = "txtOperand1";
            this.txtOperand1.Size = new System.Drawing.Size(100, 20);
            this.txtOperand1.TabIndex = 0;
            // 
            // txtOperand2
            // 
            this.txtOperand2.Location = new System.Drawing.Point(157, 12);
            this.txtOperand2.Name = "txtOperand2";
            this.txtOperand2.Size = new System.Drawing.Size(100, 20);
            this.txtOperand2.TabIndex = 1;
            // 
            // lblOperator
            // 
            this.lblOperator.AutoSize = true;
            this.lblOperator.Location = new System.Drawing.Point(118, 15);
            this.lblOperator.Name = "lblOperator";
            this.lblOperator.Size = new System.Drawing.Size(0, 13);
            this.lblOperator.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ergebnis:";
            // 
            // lblErgebnis
            // 
            this.lblErgebnis.BackColor = System.Drawing.Color.White;
            this.lblErgebnis.Location = new System.Drawing.Point(118, 50);
            this.lblErgebnis.Name = "lblErgebnis";
            this.lblErgebnis.Size = new System.Drawing.Size(100, 23);
            this.lblErgebnis.TabIndex = 4;
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(12, 84);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 23);
            this.btnAddition.TabIndex = 5;
            this.btnAddition.Text = "Addition";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // btnSubtraktion
            // 
            this.btnSubtraktion.Location = new System.Drawing.Point(93, 84);
            this.btnSubtraktion.Name = "btnSubtraktion";
            this.btnSubtraktion.Size = new System.Drawing.Size(75, 23);
            this.btnSubtraktion.TabIndex = 6;
            this.btnSubtraktion.Text = "Subtraktion";
            this.btnSubtraktion.UseVisualStyleBackColor = true;
            this.btnSubtraktion.Click += new System.EventHandler(this.btnSubtraktion_Click);
            // 
            // btnMittelwert
            // 
            this.btnMittelwert.Location = new System.Drawing.Point(12, 113);
            this.btnMittelwert.Name = "btnMittelwert";
            this.btnMittelwert.Size = new System.Drawing.Size(75, 23);
            this.btnMittelwert.TabIndex = 7;
            this.btnMittelwert.Text = "Mittelwert";
            this.btnMittelwert.UseVisualStyleBackColor = true;
            this.btnMittelwert.Click += new System.EventHandler(this.btnMittelwert_Click);
            // 
            // btnPotenz
            // 
            this.btnPotenz.Location = new System.Drawing.Point(93, 113);
            this.btnPotenz.Name = "btnPotenz";
            this.btnPotenz.Size = new System.Drawing.Size(75, 23);
            this.btnPotenz.TabIndex = 8;
            this.btnPotenz.Text = "Potenz";
            this.btnPotenz.UseVisualStyleBackColor = true;
            this.btnPotenz.Click += new System.EventHandler(this.btnPotenz_Click);
            // 
            // btnMaximum
            // 
            this.btnMaximum.Location = new System.Drawing.Point(12, 142);
            this.btnMaximum.Name = "btnMaximum";
            this.btnMaximum.Size = new System.Drawing.Size(75, 23);
            this.btnMaximum.TabIndex = 9;
            this.btnMaximum.Text = "Maximum";
            this.btnMaximum.UseVisualStyleBackColor = true;
            this.btnMaximum.Click += new System.EventHandler(this.btnMaximum_Click);
            // 
            // frmTaschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 178);
            this.Controls.Add(this.btnMaximum);
            this.Controls.Add(this.btnPotenz);
            this.Controls.Add(this.btnMittelwert);
            this.Controls.Add(this.btnSubtraktion);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.lblErgebnis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOperator);
            this.Controls.Add(this.txtOperand2);
            this.Controls.Add(this.txtOperand1);
            this.Name = "frmTaschenrechner";
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOperand1;
        private System.Windows.Forms.TextBox txtOperand2;
        private System.Windows.Forms.Label lblOperator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErgebnis;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Button btnSubtraktion;
        private System.Windows.Forms.Button btnMittelwert;
        private System.Windows.Forms.Button btnPotenz;
        private System.Windows.Forms.Button btnMaximum;
    }
}

