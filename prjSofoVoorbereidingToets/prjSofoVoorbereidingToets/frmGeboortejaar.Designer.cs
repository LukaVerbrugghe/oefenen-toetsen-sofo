namespace prjSofoVoorbereidingToets {
    partial class frmGeboortejaar {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeeftijd = new System.Windows.Forms.TextBox();
            this.btnGeboortejaar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGeboortejaar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ik ben/wordt dit jaar: ";
            // 
            // txtLeeftijd
            // 
            this.txtLeeftijd.Location = new System.Drawing.Point(128, 13);
            this.txtLeeftijd.Name = "txtLeeftijd";
            this.txtLeeftijd.Size = new System.Drawing.Size(100, 20);
            this.txtLeeftijd.TabIndex = 1;
            // 
            // btnGeboortejaar
            // 
            this.btnGeboortejaar.Location = new System.Drawing.Point(128, 52);
            this.btnGeboortejaar.Name = "btnGeboortejaar";
            this.btnGeboortejaar.Size = new System.Drawing.Size(100, 23);
            this.btnGeboortejaar.TabIndex = 2;
            this.btnGeboortejaar.Text = "Geboortejaar";
            this.btnGeboortejaar.UseVisualStyleBackColor = true;
            this.btnGeboortejaar.Click += new System.EventHandler(this.btnGeboortejaar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Je bent geboren in";
            // 
            // lblGeboortejaar
            // 
            this.lblGeboortejaar.AutoSize = true;
            this.lblGeboortejaar.Location = new System.Drawing.Point(118, 90);
            this.lblGeboortejaar.Name = "lblGeboortejaar";
            this.lblGeboortejaar.Size = new System.Drawing.Size(10, 13);
            this.lblGeboortejaar.TabIndex = 4;
            this.lblGeboortejaar.Text = ".";
            // 
            // frmGeboortejaar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGeboortejaar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGeboortejaar);
            this.Controls.Add(this.txtLeeftijd);
            this.Controls.Add(this.label1);
            this.Name = "frmGeboortejaar";
            this.Text = "Geboortejaar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeeftijd;
        private System.Windows.Forms.Button btnGeboortejaar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGeboortejaar;
    }
}