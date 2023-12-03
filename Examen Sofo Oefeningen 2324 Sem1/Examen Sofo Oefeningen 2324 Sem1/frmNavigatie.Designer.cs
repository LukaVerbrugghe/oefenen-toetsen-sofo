namespace Examen_Sofo_Oefeningen_2324_Sem1 {
    partial class frmNavigatie {
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
            this.btnHoofdstuk1 = new System.Windows.Forms.Button();
            this.btnHoofdstuk2 = new System.Windows.Forms.Button();
            this.btnHoofdstuk3 = new System.Windows.Forms.Button();
            this.btnHoofdstuk4 = new System.Windows.Forms.Button();
            this.btnAfsluiten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHoofdstuk1
            // 
            this.btnHoofdstuk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoofdstuk1.ForeColor = System.Drawing.Color.Yellow;
            this.btnHoofdstuk1.Location = new System.Drawing.Point(13, 13);
            this.btnHoofdstuk1.Name = "btnHoofdstuk1";
            this.btnHoofdstuk1.Size = new System.Drawing.Size(775, 68);
            this.btnHoofdstuk1.TabIndex = 0;
            this.btnHoofdstuk1.Text = "01_Inleiding programmeren";
            this.btnHoofdstuk1.UseVisualStyleBackColor = true;
            this.btnHoofdstuk1.Click += new System.EventHandler(this.btnHoofdstuk1_Click);
            // 
            // btnHoofdstuk2
            // 
            this.btnHoofdstuk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoofdstuk2.ForeColor = System.Drawing.Color.Red;
            this.btnHoofdstuk2.Location = new System.Drawing.Point(12, 87);
            this.btnHoofdstuk2.Name = "btnHoofdstuk2";
            this.btnHoofdstuk2.Size = new System.Drawing.Size(775, 68);
            this.btnHoofdstuk2.TabIndex = 1;
            this.btnHoofdstuk2.Text = "02_Variabelen en constanten - Interactie met de gebruiker";
            this.btnHoofdstuk2.UseVisualStyleBackColor = true;
            this.btnHoofdstuk2.Click += new System.EventHandler(this.btnHoofdstuk2_Click);
            // 
            // btnHoofdstuk3
            // 
            this.btnHoofdstuk3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoofdstuk3.ForeColor = System.Drawing.Color.Yellow;
            this.btnHoofdstuk3.Location = new System.Drawing.Point(12, 161);
            this.btnHoofdstuk3.Name = "btnHoofdstuk3";
            this.btnHoofdstuk3.Size = new System.Drawing.Size(775, 68);
            this.btnHoofdstuk3.TabIndex = 2;
            this.btnHoofdstuk3.Text = "03_Ingebouwde procedures en functies";
            this.btnHoofdstuk3.UseVisualStyleBackColor = true;
            this.btnHoofdstuk3.Click += new System.EventHandler(this.btnHoofdstuk3_Click);
            // 
            // btnHoofdstuk4
            // 
            this.btnHoofdstuk4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoofdstuk4.ForeColor = System.Drawing.Color.Red;
            this.btnHoofdstuk4.Location = new System.Drawing.Point(12, 235);
            this.btnHoofdstuk4.Name = "btnHoofdstuk4";
            this.btnHoofdstuk4.Size = new System.Drawing.Size(775, 68);
            this.btnHoofdstuk4.TabIndex = 3;
            this.btnHoofdstuk4.Text = "04_Controlestructuren";
            this.btnHoofdstuk4.UseVisualStyleBackColor = true;
            this.btnHoofdstuk4.Click += new System.EventHandler(this.btnHoofdstuk4_Click);
            // 
            // btnAfsluiten
            // 
            this.btnAfsluiten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfsluiten.Location = new System.Drawing.Point(12, 309);
            this.btnAfsluiten.Name = "btnAfsluiten";
            this.btnAfsluiten.Size = new System.Drawing.Size(775, 39);
            this.btnAfsluiten.TabIndex = 4;
            this.btnAfsluiten.Text = "Sluit af";
            this.btnAfsluiten.UseVisualStyleBackColor = true;
            this.btnAfsluiten.Click += new System.EventHandler(this.btnAfsluiten_Click);
            // 
            // frmNavigatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.btnAfsluiten);
            this.Controls.Add(this.btnHoofdstuk4);
            this.Controls.Add(this.btnHoofdstuk3);
            this.Controls.Add(this.btnHoofdstuk2);
            this.Controls.Add(this.btnHoofdstuk1);
            this.Name = "frmNavigatie";
            this.Text = "Hoofdmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHoofdstuk1;
        private System.Windows.Forms.Button btnHoofdstuk2;
        private System.Windows.Forms.Button btnHoofdstuk3;
        private System.Windows.Forms.Button btnHoofdstuk4;
        private System.Windows.Forms.Button btnAfsluiten;
    }
}

