namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_1 {
    partial class frmNavigatieHoofdstuk1 {
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
            this.btnOefening1 = new System.Windows.Forms.Button();
            this.btnOefening2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOefening1
            // 
            this.btnOefening1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOefening1.ForeColor = System.Drawing.Color.Red;
            this.btnOefening1.Location = new System.Drawing.Point(13, 13);
            this.btnOefening1.Name = "btnOefening1";
            this.btnOefening1.Size = new System.Drawing.Size(182, 74);
            this.btnOefening1.TabIndex = 0;
            this.btnOefening1.Text = "Oefening 1";
            this.btnOefening1.UseVisualStyleBackColor = true;
            // 
            // btnOefening2
            // 
            this.btnOefening2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOefening2.ForeColor = System.Drawing.Color.Red;
            this.btnOefening2.Location = new System.Drawing.Point(13, 93);
            this.btnOefening2.Name = "btnOefening2";
            this.btnOefening2.Size = new System.Drawing.Size(182, 74);
            this.btnOefening2.TabIndex = 1;
            this.btnOefening2.Text = "Oefening 2";
            this.btnOefening2.UseVisualStyleBackColor = true;
            // 
            // frmNavigatieHoofdstuk1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 181);
            this.Controls.Add(this.btnOefening2);
            this.Controls.Add(this.btnOefening1);
            this.Name = "frmNavigatieHoofdstuk1";
            this.Text = "Navigatie";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOefening1;
        private System.Windows.Forms.Button btnOefening2;
    }
}