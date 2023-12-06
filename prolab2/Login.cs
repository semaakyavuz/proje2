using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prolab2
{
    public partial class Login : UserControl
    {
        public AdminPanel adminPanel;
        public CompanyPanel companyPanel;
        public kullanicisayfasi kullanicisayfasi;
        public List<Company> companyList;
       
        public Login()
        {
            InitializeComponent();
        }

        private void girişButonu_Click(object sender, EventArgs e)
        {
            if (rdadmin.Checked)
            {
                if (textBox2.Text == "admin" && textBox1.Text == "0")
                {
                    Program.AdminPanel.Visible = true;
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
                }

            }
            if (rdfirma.Checked)
            {
                int a = 0;
                foreach (Company company in Program.AdminPanel.companies)
                {
                    if (company.Username == textBox2.Text && company.Password == textBox1.Text)
                    {
                        
                        Program.CurrentCompanyPanel.Company = company;
                        Program.CurrentCompanyPanel.Visible = true;
                        this.Visible = false;
                        a++;
                    }

                }
                if (a == 0)
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");

            }
            
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdkullanici_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kullanicisayfasi form = new kullanicisayfasi(Program.AdminPanel.companies);
            form.Show();
            this.Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdfirma_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
