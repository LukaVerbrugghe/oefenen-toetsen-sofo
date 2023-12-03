namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_3 {
    partial class frm05_Geboortejaar {
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblGeboortejaar = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ik wordt/ben dit jaar:";
            // 
            // txtLeeftijd
            // 
            this.txtLeeftijd.Location = new System.Drawing.Point(155, 34);
            this.txtLeeftijd.Name = "txtLeeftijd";
            this.txtLeeftijd.Size = new System.Drawing.Size(100, 20);
            this.txtLeeftijd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Geboortejaar:";
            // 
            // lblGeboortejaar
            // 
            this.lblGeboortejaar.AutoSize = true;
            this.lblGeboortejaar.Location = new System.Drawing.Point(126, 85);
            this.lblGeboortejaar.Name = "lblGeboortejaar";
            this.lblGeboortejaar.Size = new System.Drawing.Size(10, 13);
            this.lblGeboortejaar.TabIndex = 3;
            this.lblGeboortejaar.Text = ".";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(38, 59);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(102, 23);
            this.btnBereken.TabIndex = 4;
            this.btnBereken.Text = "Bereken";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // frm05_Geboortejaar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 126);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lblGeboortejaar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLeeftijd);
            this.Controls.Add(this.label1);
            this.Name = "frm05_Geboortejaar";
            this.Text = "Geboortejaar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeeftijd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblGeboortejaar;
        private System.Windows.Forms.Button btnBereken;
    }
}