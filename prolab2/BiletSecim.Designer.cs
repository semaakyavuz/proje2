namespace prolab2
{
    partial class BiletSecim
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
            this.btnRezerve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRezerve
            // 
            this.btnRezerve.Location = new System.Drawing.Point(583, 391);
            this.btnRezerve.Name = "btnRezerve";
            this.btnRezerve.Size = new System.Drawing.Size(114, 35);
            this.btnRezerve.TabIndex = 0;
            this.btnRezerve.Text = "Rezerve Et";
            this.btnRezerve.UseVisualStyleBackColor = true;
            this.btnRezerve.Click += new System.EventHandler(this.btnRezerve_Click);
            // 
            // BiletSecim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRezerve);
            this.Name = "BiletSecim";
            this.Text = "BiletSecim";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRezerve;
    }
}