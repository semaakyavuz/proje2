namespace prolab2
{
    partial class Login
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.girişButonu = new System.Windows.Forms.Button();
            this.rdadmin = new System.Windows.Forms.RadioButton();
            this.rdfirma = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(379, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(379, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // girişButonu
            // 
            this.girişButonu.Location = new System.Drawing.Point(391, 300);
            this.girişButonu.Name = "girişButonu";
            this.girişButonu.Size = new System.Drawing.Size(75, 23);
            this.girişButonu.TabIndex = 7;
            this.girişButonu.Text = "Giriş";
            this.girişButonu.UseVisualStyleBackColor = true;
            this.girişButonu.Click += new System.EventHandler(this.girişButonu_Click);
            // 
            // rdadmin
            // 
            this.rdadmin.AutoSize = true;
            this.rdadmin.Location = new System.Drawing.Point(246, 116);
            this.rdadmin.Name = "rdadmin";
            this.rdadmin.Size = new System.Drawing.Size(66, 20);
            this.rdadmin.TabIndex = 8;
            this.rdadmin.TabStop = true;
            this.rdadmin.Text = "Admin";
            this.rdadmin.UseVisualStyleBackColor = true;
            this.rdadmin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdfirma
            // 
            this.rdfirma.AutoSize = true;
            this.rdfirma.Location = new System.Drawing.Point(379, 116);
            this.rdfirma.Name = "rdfirma";
            this.rdfirma.Size = new System.Drawing.Size(62, 20);
            this.rdfirma.TabIndex = 9;
            this.rdfirma.TabStop = true;
            this.rdfirma.Text = "Firma";
            this.rdfirma.UseVisualStyleBackColor = true;
            this.rdfirma.CheckedChanged += new System.EventHandler(this.rdfirma_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 90);
            this.button1.TabIndex = 10;
            this.button1.Text = "Bilet Ara";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdfirma);
            this.Controls.Add(this.rdadmin);
            this.Controls.Add(this.girişButonu);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(936, 448);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button girişButonu;
        private System.Windows.Forms.RadioButton rdadmin;
        private System.Windows.Forms.RadioButton rdfirma;
        private System.Windows.Forms.Button button1;
    }
}
