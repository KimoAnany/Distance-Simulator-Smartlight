
namespace SL_Abstandssimluator
{
    partial class Form1
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
            this.lblDistanz = new System.Windows.Forms.Label();
            this.txtboxDistanz = new System.Windows.Forms.TextBox();
            this.btnAuswerten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDistanz
            // 
            this.lblDistanz.AutoSize = true;
            this.lblDistanz.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblDistanz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDistanz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDistanz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanz.Location = new System.Drawing.Point(128, 249);
            this.lblDistanz.Name = "lblDistanz";
            this.lblDistanz.Size = new System.Drawing.Size(350, 57);
            this.lblDistanz.TabIndex = 0;
            this.lblDistanz.Text = "Distanz [in CM]";
            this.lblDistanz.Click += new System.EventHandler(this.lblDistanz_Click);
            // 
            // txtboxDistanz
            // 
            this.txtboxDistanz.Location = new System.Drawing.Point(678, 249);
            this.txtboxDistanz.Multiline = true;
            this.txtboxDistanz.Name = "txtboxDistanz";
            this.txtboxDistanz.Size = new System.Drawing.Size(369, 57);
            this.txtboxDistanz.TabIndex = 2;
            this.txtboxDistanz.TextChanged += new System.EventHandler(this.txtboxDistanz_TextChanged);
            // 
            // btnAuswerten
            // 
            this.btnAuswerten.Location = new System.Drawing.Point(471, 587);
            this.btnAuswerten.Name = "btnAuswerten";
            this.btnAuswerten.Size = new System.Drawing.Size(369, 91);
            this.btnAuswerten.TabIndex = 4;
            this.btnAuswerten.Text = "Auswerten";
            this.btnAuswerten.UseVisualStyleBackColor = true;
            this.btnAuswerten.Click += new System.EventHandler(this.btnAuswerten_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 855);
            this.Controls.Add(this.btnAuswerten);
            this.Controls.Add(this.txtboxDistanz);
            this.Controls.Add(this.lblDistanz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Abstandscheck";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDistanz;
        private System.Windows.Forms.TextBox txtboxDistanz;
        private System.Windows.Forms.Button btnAuswerten;
    }
}

