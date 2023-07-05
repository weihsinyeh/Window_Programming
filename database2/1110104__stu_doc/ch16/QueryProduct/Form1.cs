using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace QueryProduct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        BindingManagerBase bm;

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|Northwind.mdf;" +
                "Integrated Security=True"; 
            DataSet ds = new DataSet();
            SqlDataAdapter daCategory = new SqlDataAdapter("SELECT * FROM 產品類別", cn);
            daCategory.Fill(ds, "產品類別");
            SqlDataAdapter daProduct = new SqlDataAdapter("SELECT * FROM 產品資料", cn);
            daProduct.Fill(ds, "產品資料");
            ds.Relations.Add("FK_產品資料_產品類別", ds.Tables["產品類別"].Columns["類別編號"], ds.Tables["產品資料"].Columns["類別編號"]);
            //https://msdn.microsoft.com/zh-tw/library/ay82azad(v=vs.110).aspx
            cboCategory.DataSource = ds;
            cboCategory.DisplayMember = "產品類別.類別名稱";
            txtId.DataBindings.Add("Text", ds, "產品類別.FK_產品資料_產品類別.產品編號");
            txtName.DataBindings.Add("Text", ds, "產品類別.FK_產品資料_產品類別.產品");
            txtPrice.DataBindings.Add("Text", ds, "產品類別.FK_產品資料_產品類別.單價");

            bm = this.BindingContext[ds, "產品類別.FK_產品資料_產品類別"];
            ShowRecord();
        }

        private void ShowRecord()
        {
            lblCount.Text =  (bm.Position + 1).ToString() +" / " + bm.Count.ToString() ;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bm.Position = 0;
            ShowRecord();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (bm.Position > 0)
            {
                bm.Position -= 1;
            }
            ShowRecord();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (bm.Position < bm.Count - 1)
            {
                bm.Position += 1;
            }
            ShowRecord();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bm.Position = bm.Count - 1;
            ShowRecord();
        }

    }
}
