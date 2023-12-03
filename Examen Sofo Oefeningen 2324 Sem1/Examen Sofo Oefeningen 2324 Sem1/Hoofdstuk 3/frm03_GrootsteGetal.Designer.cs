namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_3 {
    partial class frm03_GrootsteGetal {
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblGrootste = new System.Windows.Forms.Label();
            this.btnZoekGrootste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Getal 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Getal 2:";
            // 
            // txtGetal1
            // 
            this.txtGetal1.Location = new System.Drawing.Point(77, 19);
            this.txtGetal1.Name = "txtGetal1";
            this.txtGetal1.Size = new System.Drawing.Size(100, 20);
            this.txtGetal1.TabIndex = 2;
            // 
            // txtGetal2
            // 
            this.txtGetal2.Location = new System.Drawing.Point(77, 50);
            this.txtGetal2.Name = "txtGetal2";
            this.txtGetal2.Size = new System.Drawing.Size(100, 20);
            this.txtGetal2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Grootste:";
            // 
            // lblGrootste
            // 
            this.lblGrootste.AutoSize = true;
            this.lblGrootste.Location = new System.Drawing.Point(77, 89);
            this.lblGrootste.Name = "lblGrootste";
            this.lblGrootste.Size = new System.Drawing.Size(10, 13);
            this.lblGrootste.TabIndex = 5;
            this.lblGrootste.Text = ".";
            // 
            // btnZoekGrootste
            // 
            this.btnZoekGrootste.Location = new System.Drawing.Point(27, 126);
            this.btnZoekGrootste.Name = "btnZoekGrootste";
            this.btnZoekGrootste.Size = new System.Drawing.Size(150, 23);
            this.btnZoekGrootste.TabIndex = 6;
            this.btnZoekGrootste.Text = "Zoek Grootste";
            this.btnZoekGrootste.UseVisualStyleBackColor = true;
            this.btnZoekGrootste.Click += new System.EventHandler(this.btnZoekGrootste_Click);
            // 
            // frm03_GrootsteGetal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(190, 164);
            this.Controls.Add(this.btnZoekGrootste);
            this.Controls.Add(this.lblGrootste);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGetal2);
            this.Controls.Add(this.txtGetal1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm03_GrootsteGetal";
            this.Text = "Grootste Getal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGetal1;
        private System.Windows.Forms.TextBox txtGetal2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGrootste;
        private System.Windows.Forms.Button btnZoekGrootste;
    }
}