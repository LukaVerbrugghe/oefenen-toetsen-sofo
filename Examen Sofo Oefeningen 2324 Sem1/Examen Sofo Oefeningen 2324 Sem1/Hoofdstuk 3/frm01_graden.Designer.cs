namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_3 {
    partial class frm01_graden {
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
            this.txtGraden = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            this.btnFahrenehit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Graden Celsius:";
            // 
            // txtGraden
            // 
            this.txtGraden.Location = new System.Drawing.Point(127, 34);
            this.txtGraden.Name = "txtGraden";
            this.txtGraden.Size = new System.Drawing.Size(100, 20);
            this.txtGraden.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Graden Fahrenheit:";
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(148, 74);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(10, 13);
            this.lblFahrenheit.TabIndex = 3;
            this.lblFahrenheit.Text = ".";
            // 
            // btnFahrenehit
            // 
            this.btnFahrenehit.Location = new System.Drawing.Point(43, 112);
            this.btnFahrenehit.Name = "btnFahrenehit";
            this.btnFahrenehit.Size = new System.Drawing.Size(184, 23);
            this.btnFahrenehit.TabIndex = 4;
            this.btnFahrenehit.Text = "Fahrenheit";
            this.btnFahrenehit.UseVisualStyleBackColor = true;
            this.btnFahrenehit.Click += new System.EventHandler(this.btnFahrenehit_Click);
            // 
            // frm01_graden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 149);
            this.Controls.Add(this.btnFahrenehit);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGraden);
            this.Controls.Add(this.label1);
            this.Name = "frm01_graden";
            this.Text = "Graden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGraden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFahrenheit;
        private System.Windows.Forms.Button btnFahrenehit;
    }
}