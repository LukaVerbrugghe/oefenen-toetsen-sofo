namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_4._03_Iteraties
{
    partial class frmExamenscore
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultaat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultaat.Location = new System.Drawing.Point(31, 36);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(403, 20);
            this.lblResultaat.TabIndex = 0;
            this.lblResultaat.Text = "U gaf ... studenten in met een gemiddelde van ....";
            // 
            // frmExamenscore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultaat);
            this.Name = "frmExamenscore";
            this.Text = "Examenscore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultaat;
    }
}