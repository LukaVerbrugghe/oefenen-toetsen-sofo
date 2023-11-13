namespace prjSofoVoorbereidingToets
{
    partial class frmIngebouwdeFuncties
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
            this.btnOef3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOef3
            // 
            this.btnOef3.Location = new System.Drawing.Point(13, 13);
            this.btnOef3.Name = "btnOef3";
            this.btnOef3.Size = new System.Drawing.Size(111, 60);
            this.btnOef3.TabIndex = 0;
            this.btnOef3.Text = "03 - Grootste Getal";
            this.btnOef3.UseVisualStyleBackColor = true;
            this.btnOef3.Click += new System.EventHandler(this.btnOef3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "04 -Datum Voluit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 60);
            this.button2.TabIndex = 2;
            this.button2.Text = "05 - Geboortejaar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 211);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 60);
            this.button3.TabIndex = 3;
            this.button3.Text = "06 - Onderhoud Auto";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmIngebouwdeFuncties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(138, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOef3);
            this.Name = "frmIngebouwdeFuncties";
            this.Text = "Hoofdstuk 3: Ingebouwde Functies";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOef3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}