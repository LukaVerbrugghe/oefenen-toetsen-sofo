namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_4 {
    partial class frmNavigatieHoofdstuk4 {
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
            this.btnSequentie = new System.Windows.Forms.Button();
            this.btnSelectie = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSequentie
            // 
            this.btnSequentie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSequentie.ForeColor = System.Drawing.Color.Red;
            this.btnSequentie.Location = new System.Drawing.Point(13, 12);
            this.btnSequentie.Name = "btnSequentie";
            this.btnSequentie.Size = new System.Drawing.Size(775, 68);
            this.btnSequentie.TabIndex = 1;
            this.btnSequentie.Text = "01_Sequentie";
            this.btnSequentie.UseVisualStyleBackColor = true;
            this.btnSequentie.Click += new System.EventHandler(this.btnSequentie_Click);
            // 
            // btnSelectie
            // 
            this.btnSelectie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectie.ForeColor = System.Drawing.Color.Red;
            this.btnSelectie.Location = new System.Drawing.Point(13, 86);
            this.btnSelectie.Name = "btnSelectie";
            this.btnSelectie.Size = new System.Drawing.Size(775, 68);
            this.btnSelectie.TabIndex = 2;
            this.btnSelectie.Text = "02_Selectie";
            this.btnSelectie.UseVisualStyleBackColor = true;
            this.btnSelectie.Click += new System.EventHandler(this.btnSelectie_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(12, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(775, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "03_Iteratie";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmNavigatieHoofdstuk4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 239);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSelectie);
            this.Controls.Add(this.btnSequentie);
            this.Name = "frmNavigatieHoofdstuk4";
            this.Text = "frmNavigatieHoofdstuk4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSequentie;
        private System.Windows.Forms.Button btnSelectie;
        private System.Windows.Forms.Button button2;
    }
}