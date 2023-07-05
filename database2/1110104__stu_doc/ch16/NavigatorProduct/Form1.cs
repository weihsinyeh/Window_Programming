using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace NavigatorProduct
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
            SqlDataAdapter daProduct = new SqlDataAdapter("SELECT * FROM 產品資料", cn);
            daProduct.Fill(ds, "產品資料");
            //https://msdn.microsoft.com/zh-tw/library/system.windows.forms.controlbindingscollection(v=vs.110).aspx
            txtId.DataBindings.Add("Text", ds, "產品資料.產品編號");
            txtName.DataBindings.Add("Text", ds, "產品資料.產品");
            txtPrice.DataBindings.Add("Text", ds, "產品資料.單價");
            txtQty.DataBindings.Add("Text", ds, "產品資料.庫存量");
            bm = this.BindingContext[ds, "產品資料"];
            //this 代表 form1 , 使用form1的BindingContext屬性指定bm(BindingManaterBase)物件瀏覽產品資料表
            //https://msdn.microsoft.com/zh-tw/library/system.windows.forms.bindingmanagerbase(v=vs.110).aspx
            CheckButton();
        }

        private void CheckButton()
        {
            if (bm.Position == 0)
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            else if (bm.Position == bm.Count - 1)
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            lblCount.Text =  (bm.Position + 1).ToString() + " / " + bm.Count.ToString() ;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            bm.Position = 0;
            CheckButton();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (bm.Position > 0)
            {
                bm.Position -= 1;
            }
            CheckButton();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (bm.Position < bm.Count - 1)
            {
                bm.Position += 1;
            }
            CheckButton();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            bm.Position = bm.Count - 1;
            CheckButton();
        }
    }
}
