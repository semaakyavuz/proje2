namespace prolab2
{
    partial class CompanyPanel
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
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleAddButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkapasite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.çıkışButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.seferEkle = new System.Windows.Forms.Button();
            this.seferSil = new System.Windows.Forms.Button();
            this.aracYakıttür = new System.Windows.Forms.Label();
            this.txtyakit = new System.Windows.Forms.TextBox();
            this.araçİd = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgarac = new System.Windows.Forms.DataGridView();
            this.Tur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Araçlar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kapasite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yakit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgAcilanSeferler = new System.Windows.Forms.DataGridView();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guzergah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lvGuzergah = new System.Windows.Forms.ListView();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgarac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAcilanSeferler)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(201, 91);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(100, 22);
            this.txtmodel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model";
            // 
            // vehicleAddButton
            // 
            this.vehicleAddButton.Location = new System.Drawing.Point(99, 252);
            this.vehicleAddButton.Name = "vehicleAddButton";
            this.vehicleAddButton.Size = new System.Drawing.Size(75, 23);
            this.vehicleAddButton.TabIndex = 2;
            this.vehicleAddButton.Text = "Ekle";
            this.vehicleAddButton.UseVisualStyleBackColor = true;
            this.vehicleAddButton.Click += new System.EventHandler(this.vehicleAddButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kapasite";
            // 
            // txtkapasite
            // 
            this.txtkapasite.Location = new System.Drawing.Point(201, 123);
            this.txtkapasite.Name = "txtkapasite";
            this.txtkapasite.Size = new System.Drawing.Size(100, 22);
            this.txtkapasite.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tür";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(190, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Araç Ekle";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 252);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // çıkışButton
            // 
            this.çıkışButton.Location = new System.Drawing.Point(26, 9);
            this.çıkışButton.Name = "çıkışButton";
            this.çıkışButton.Size = new System.Drawing.Size(75, 62);
            this.çıkışButton.TabIndex = 10;
            this.çıkışButton.Text = "çıkış";
            this.çıkışButton.UseVisualStyleBackColor = true;
            this.çıkışButton.Click += new System.EventHandler(this.çıkışButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Araçlar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(930, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Güzergah";
            // 
            // seferEkle
            // 
            this.seferEkle.Location = new System.Drawing.Point(1176, 221);
            this.seferEkle.Name = "seferEkle";
            this.seferEkle.Size = new System.Drawing.Size(75, 23);
            this.seferEkle.TabIndex = 16;
            this.seferEkle.Text = "Ekle";
            this.seferEkle.UseVisualStyleBackColor = true;
            this.seferEkle.Click += new System.EventHandler(this.seferEkle_Click);
            // 
            // seferSil
            // 
            this.seferSil.Location = new System.Drawing.Point(1049, 279);
            this.seferSil.Name = "seferSil";
            this.seferSil.Size = new System.Drawing.Size(75, 23);
            this.seferSil.TabIndex = 17;
            this.seferSil.Text = "Sil";
            this.seferSil.UseVisualStyleBackColor = true;
            this.seferSil.Click += new System.EventHandler(this.seferSil_Click);
            // 
            // aracYakıttür
            // 
            this.aracYakıttür.AutoSize = true;
            this.aracYakıttür.Location = new System.Drawing.Point(101, 160);
            this.aracYakıttür.Name = "aracYakıttür";
            this.aracYakıttür.Size = new System.Drawing.Size(54, 16);
            this.aracYakıttür.TabIndex = 19;
            this.aracYakıttür.Text = "Yakıt tür";
            // 
            // txtyakit
            // 
            this.txtyakit.Location = new System.Drawing.Point(201, 157);
            this.txtyakit.Name = "txtyakit";
            this.txtyakit.Size = new System.Drawing.Size(100, 22);
            this.txtyakit.TabIndex = 18;
            // 
            // araçİd
            // 
            this.araçİd.AutoSize = true;
            this.araçİd.Location = new System.Drawing.Point(101, 69);
            this.araçİd.Name = "araçİd";
            this.araçİd.Size = new System.Drawing.Size(18, 16);
            this.araçİd.TabIndex = 21;
            this.araçİd.Text = "İd";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(201, 63);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Açılan Seferler";
            // 
            // dgarac
            // 
            this.dgarac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgarac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgarac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tur,
            this.Araçlar,
            this.Model,
            this.Kapasite,
            this.Yakit});
            this.dgarac.Location = new System.Drawing.Point(359, 51);
            this.dgarac.MultiSelect = false;
            this.dgarac.Name = "dgarac";
            this.dgarac.RowHeadersWidth = 51;
            this.dgarac.RowTemplate.Height = 24;
            this.dgarac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgarac.Size = new System.Drawing.Size(553, 150);
            this.dgarac.TabIndex = 24;
            this.dgarac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgarac.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Tur
            // 
            this.Tur.HeaderText = "Tür";
            this.Tur.MinimumWidth = 6;
            this.Tur.Name = "Tur";
            // 
            // Araçlar
            // 
            this.Araçlar.HeaderText = "ID";
            this.Araçlar.MinimumWidth = 6;
            this.Araçlar.Name = "Araçlar";
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            // 
            // Kapasite
            // 
            this.Kapasite.HeaderText = "Kapasite";
            this.Kapasite.MinimumWidth = 6;
            this.Kapasite.Name = "Kapasite";
            // 
            // Yakit
            // 
            this.Yakit.HeaderText = "Yakit";
            this.Yakit.MinimumWidth = 6;
            this.Yakit.Name = "Yakit";
            // 
            // dgAcilanSeferler
            // 
            this.dgAcilanSeferler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAcilanSeferler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAcilanSeferler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tarih,
            this.Guzergah,
            this.Arac});
            this.dgAcilanSeferler.Location = new System.Drawing.Point(359, 279);
            this.dgAcilanSeferler.Name = "dgAcilanSeferler";
            this.dgAcilanSeferler.RowHeadersWidth = 51;
            this.dgAcilanSeferler.RowTemplate.Height = 24;
            this.dgAcilanSeferler.Size = new System.Drawing.Size(684, 150);
            this.dgAcilanSeferler.TabIndex = 26;
            this.dgAcilanSeferler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAcilanSeferler_CellContentClick);
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.MinimumWidth = 6;
            this.Tarih.Name = "Tarih";
            // 
            // Guzergah
            // 
            this.Guzergah.HeaderText = "Güzergah";
            this.Guzergah.MinimumWidth = 6;
            this.Guzergah.Name = "Guzergah";
            // 
            // Arac
            // 
            this.Arac.HeaderText = "Araç";
            this.Arac.MinimumWidth = 6;
            this.Arac.Name = "Arac";
            // 
            // lvGuzergah
            // 
            this.lvGuzergah.HideSelection = false;
            this.lvGuzergah.Location = new System.Drawing.Point(933, 51);
            this.lvGuzergah.MultiSelect = false;
            this.lvGuzergah.Name = "lvGuzergah";
            this.lvGuzergah.Size = new System.Drawing.Size(565, 154);
            this.lvGuzergah.TabIndex = 27;
            this.lvGuzergah.UseCompatibleStateImageBehavior = false;
            this.lvGuzergah.View = System.Windows.Forms.View.List;
            // 
            // dtTarih
            // 
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(949, 222);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 22);
            this.dtTarih.TabIndex = 28;
            // 
            // CompanyPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.lvGuzergah);
            this.Controls.Add(this.dgAcilanSeferler);
            this.Controls.Add(this.dgarac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.araçİd);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.aracYakıttür);
            this.Controls.Add(this.txtyakit);
            this.Controls.Add(this.seferSil);
            this.Controls.Add(this.seferEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.çıkışButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtkapasite);
            this.Controls.Add(this.vehicleAddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmodel);
            this.Name = "CompanyPanel";
            this.Size = new System.Drawing.Size(1606, 547);
            this.Load += new System.EventHandler(this.CompanyPanel_Load);
            this.VisibleChanged += new System.EventHandler(this.CompanyPanel_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgarac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAcilanSeferler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vehicleAddButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkapasite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button çıkışButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button seferEkle;
        private System.Windows.Forms.Button seferSil;
        private System.Windows.Forms.Label aracYakıttür;
        private System.Windows.Forms.TextBox txtyakit;
        private System.Windows.Forms.Label araçİd;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgarac;
        private System.Windows.Forms.DataGridView dgAcilanSeferler;
        private System.Windows.Forms.ListView lvGuzergah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Araçlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kapasite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yakit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn Guzergah;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arac;
        private System.Windows.Forms.DateTimePicker dtTarih;
    }
}
