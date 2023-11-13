namespace prjSofoVoorbereidingToets {
    partial class frmIngebouwdeFuncties_GrootsteGetal {
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtGetal1 = new System.Windows.Forms.TextBox();
            this.txtGetal2 = new System.Windows.Forms.TextBox();
            this.btnBereken = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGrootsteGetal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Getal 2 :";
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(91, 13);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(100, 20);
            this.txtGetal1.TabIndex = 2;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(91, 43);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(100, 20);
            this.txtGetal2.TabIndex = 3;
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(91, 80);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(100, 23);
            this.btnBereken.TabIndex = 4;
            this.btnBereken.Text = "Grootste getal";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Grootste getal:";
            // 
            // lblGrootsteGetal
            // 
            this.lblGrootsteGetal.AutoSize = true;
            this.lblGrootsteGetal.Location = new System.Drawing.Point(102, 124);
            this.lblGrootsteGetal.Name = "lblGrootsteGetal";
            this.lblGrootsteGetal.Size = new System.Drawing.Size(10, 13);
            this.lblGrootsteGetal.TabIndex = 6;
            this.lblGrootsteGetal.Text = ".";
            // 
            // frmIngebouwdeFuncties_GrootsteGetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGrootsteGetal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmIngebouwdeFuncties_GrootsteGetal";
            this.Text = "Grootste Getal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGrootsteGetal;
    }
}