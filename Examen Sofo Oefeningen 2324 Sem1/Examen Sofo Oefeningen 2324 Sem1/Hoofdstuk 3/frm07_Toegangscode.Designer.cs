namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_3 {
    partial class frm07_Toegangscode {
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtZonenr = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.btnCode = new System.Windows.Forms.Button();
            this.lblWachtwoord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Familienaam:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Zonenr. telefoon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Postcode:";
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(126, 19);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(128, 20);
            this.txtNaam.TabIndex = 3;
            // 
            // txtZonenr
            // 
            this.txtZonenr.Location = new System.Drawing.Point(126, 58);
            this.txtZonenr.Name = "txtZonenr";
            this.txtZonenr.Size = new System.Drawing.Size(128, 20);
            this.txtZonenr.TabIndex = 4;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(126, 102);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(128, 20);
            this.txtPostcode.TabIndex = 5;
            // 
            // btnCode
            // 
            this.btnCode.Location = new System.Drawing.Point(31, 147);
            this.btnCode.Name = "btnCode";
            this.btnCode.Size = new System.Drawing.Size(223, 23);
            this.btnCode.TabIndex = 6;
            this.btnCode.Text = "Genereer code";
            this.btnCode.UseVisualStyleBackColor = true;
            this.btnCode.Click += new System.EventHandler(this.btnCode_Click);
            // 
            // lblWachtwoord
            // 
            this.lblWachtwoord.AutoSize = true;
            this.lblWachtwoord.Location = new System.Drawing.Point(31, 191);
            this.lblWachtwoord.Name = "lblWachtwoord";
            this.lblWachtwoord.Size = new System.Drawing.Size(87, 13);
            this.lblWachtwoord.TabIndex = 7;
            this.lblWachtwoord.Text = "Uw wachtwoord:";
            // 
            // frm07_Toegangscode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 240);
            this.Controls.Add(this.lblWachtwoord);
            this.Controls.Add(this.btnCode);
            this.Controls.Add(this.txtPostcode);
            this.Controls.Add(this.txtZonenr);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm07_Toegangscode";
            this.Text = "Toegangscode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtZonenr;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Button btnCode;
        private System.Windows.Forms.Label lblWachtwoord;
    }
}