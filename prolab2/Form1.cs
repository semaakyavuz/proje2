﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*login1.adminPanel = adminPanel1;
            adminPanel1.login = login1;
            login1.companyPanel = companyPanel1;
            companyPanel1.login = login1;*/
            Program.AdminPanel = adminPanel1;
            Program.LoginPanel = login1;
            Program.CurrentCompanyPanel = companyPanel1;
            adminPanel1.Visible = false;
            companyPanel1.Visible = false;
            login1.Visible = true;
        }

        private void companyPanel1_Load(object sender, EventArgs e)
        {

        }
    }
}
