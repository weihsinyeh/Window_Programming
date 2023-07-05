using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace DataAdapterSql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cn = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                 "AttachDbFilename=|DataDirectory|Database1.mdf;" +
                "Integrated Security=True"; //設為True 指定使用Windows 帳號認證連接資料庫
            SqlConnection db = new SqlConnection(cn);
            db.Open();
            SqlDataAdapter ap = new SqlDataAdapter
                ("SELECT * FROM 書目", db);
            DataSet ds = new DataSet();
            ap.Fill(ds, "書目");
            dataGridView1.DataSource = ds.Tables["書目"];
            db.Close();
        }
    }
}
