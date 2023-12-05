namespace Examen_Sofo_Oefeningen_2324_Sem1.Hoofdstuk_4._03_Iteraties
{
    partial class frm03_Sterren
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAantalSterren = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSterren = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoeveel sterren wenst u?";
            // 
            // txtAantalSterren
            // 
            this.txtAantalSterren.Location = new System.Drawing.Point(184, 26);
            this.txtAantalSterren.Name = "txtAantalSterren";
            this.txtAantalSterren.Size = new System.Drawing.Size(95, 20);
            this.txtAantalSterren.TabIndex = 1;
            this.txtAantalSterren.TextChanged += new System.EventHandler(this.txtAantalSterren_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "sterren";
            // 
            // lblSterren
            // 
            this.lblSterren.Location = new System.Drawing.Point(30, 49);
            this.lblSterren.Name = "lblSterren";
            this.lblSterren.Size = new System.Drawing.Size(294, 728);
            this.lblSterren.TabIndex = 3;
            // 
            // frm03_Sterren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 786);
            this.Controls.Add(this.lblSterren);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAantalSterren);
            this.Controls.Add(this.label1);
            this.Name = "frm03_Sterren";
            this.Text = "Sterren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAantalSterren;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSterren;
    }
}