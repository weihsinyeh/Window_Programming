﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'database1DataSet.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter.Fill(this.database1DataSet.書目);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.出版者' 資料表。您可以視需要進行移動或移除。
            this.出版者TableAdapter.Fill(this.database1DataSet.出版者);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter.Fill(this.database1DataSet.書目);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.出版者' 資料表。您可以視需要進行移動或移除。
            this.出版者TableAdapter.Fill(this.database1DataSet.出版者);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter.Fill(this.database1DataSet.書目);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.出版者' 資料表。您可以視需要進行移動或移除。
            this.出版者TableAdapter.Fill(this.database1DataSet.出版者);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.書目' 資料表。您可以視需要進行移動或移除。
            this.書目TableAdapter.Fill(this.database1DataSet.書目);
            // TODO: 這行程式碼會將資料載入 'database1DataSet.出版者' 資料表。您可以視需要進行移動或移除。
            this.出版者TableAdapter.Fill(this.database1DataSet.出版者);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
