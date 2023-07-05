using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace SqlQueryTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripTextBox1.Text = "SELECT * FROM 產品資料";
            toolStripButton1_Click(sender, e);  //呼叫toolStripButton1_Click事件函式
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //為防止SQL語法錯誤, 或資料庫連接失敗...等例外
            //故將相關程式碼置於try...catch內
            try
            {
                //建立SqlConnection物件cn
                SqlConnection cn = new SqlConnection();
                //設定cn連接Northwind.mdf資料庫檔案
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|Northwind.mdf;" +
                     "Integrated Security=True";
                //建立DataAdapter物件da
                //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                SqlDataAdapter da = new SqlDataAdapter(toolStripTextBox1.Text, cn);
                //建立DataSet物件ds
                DataSet ds = new DataSet();
                //將da物件所取得的資料填入ds物件
                da.Fill(ds);
                //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
