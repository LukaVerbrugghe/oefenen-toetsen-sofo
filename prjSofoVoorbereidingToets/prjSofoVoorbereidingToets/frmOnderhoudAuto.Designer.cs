namespace prjSofoVoorbereidingToets {
    partial class frmOnderhoudAuto {
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
            this.lblControleDagen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblControleDatum = new System.Windows.Forms.Label();
            this.btnBereken = new System.Windows.Forms.Button();
            this.txtLaatsteControle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laatste controle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Volgende controle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Over";
            // 
            // lblControleDagen
            // 
            this.lblControleDagen.AutoSize = true;
            this.lblControleDagen.Location = new System.Drawing.Point(56, 102);
            this.lblControleDagen.Name = "lblControleDagen";
            this.lblControleDagen.Size = new System.Drawing.Size(10, 13);
            this.lblControleDagen.TabIndex = 3;
            this.lblControleDagen.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "dagen";
            // 
            // lblControleDatum
            // 
            this.lblControleDatum.AutoSize = true;
            this.lblControleDatum.Location = new System.Drawing.Point(132, 73);
            this.lblControleDatum.Name = "lblControleDatum";
            this.lblControleDatum.Size = new System.Drawing.Size(10, 13);
            this.lblControleDatum.TabIndex = 5;
            this.lblControleDatum.Text = ".";
            // 
            // btnBereken
            // 
            this.btnBereken.Location = new System.Drawing.Point(13, 39);
            this.btnBereken.Name = "btnBereken";
            this.btnBereken.Size = new System.Drawing.Size(193, 23);
            this.btnBereken.TabIndex = 6;
            this.btnBereken.Text = "Bereken datum";
            this.btnBereken.UseVisualStyleBackColor = true;
            this.btnBereken.Click += new System.EventHandler(this.btnBereken_Click);
            // 
            // txtLaatsteControle
            // 
            this.txtLaatsteControle.Location = new System.Drawing.Point(106, 13);
            this.txtLaatsteControle.Name = "txtLaatsteControle";
            this.txtLaatsteControle.Size = new System.Drawing.Size(100, 20);
            this.txtLaatsteControle.TabIndex = 7;
            // 
            // frmOnderhoudAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 163);
            this.Controls.Add(this.txtLaatsteControle);
            this.Controls.Add(this.btnBereken);
            this.Controls.Add(this.lblControleDatum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblControleDagen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOnderhoudAuto";
            this.Text = "frmOnderhoudAuto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblControleDagen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblControleDatum;
        private System.Windows.Forms.Button btnBereken;
        private System.Windows.Forms.TextBox txtLaatsteControle;
    }
}