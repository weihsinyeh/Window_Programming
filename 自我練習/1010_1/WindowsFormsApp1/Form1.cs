﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCapi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double money = double.Parse(txtCapi.Text); //本金
            double years = double.Parse(txtYear.Text); //年期
            double yrate = double.Parse(txtRate.Text); //年利率
            double total;
            total = money * Math.Pow((1 + yrate / 100), years);
            label4.Text = " accumulated amount = NT$ " + total.ToString("#,#.0") + " 元";
            label4.Text += "\n Total interest = NT$ " + (total - money).ToString("#,#.0") + "元";//總利息
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
