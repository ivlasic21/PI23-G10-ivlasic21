﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluationManagerG10
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnLogin_Click(object sender, EventArgs e) {
            if(txtUsername.Text== "") 
                {
                MessageBox.Show("korisničko ime nije uneseno", "problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
