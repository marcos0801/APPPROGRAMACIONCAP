﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppIUWIN
{
    public partial class Form1 : Form
    {
        private object res;

        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
          int  num;
            num = int.Parse(this.txtnum.Text);

            res = APPPROGRAMACIONCAP.Class1.fact(num);

            this.txtRes.Text = res.ToString();


        }
    }
}
