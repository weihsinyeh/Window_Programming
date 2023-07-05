using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace EmpNav
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
               "AttachDbFilename=|DataDirectory|Northwind.mdf;" +
                "Integrated Security=True";

            DataSet ds = new DataSet();
            SqlDataAdapter daEmp = new SqlDataAdapter("SELECT * FROM 員工", cn);
            daEmp.Fill(ds, "員工");
            cboName.DataSource = ds;
            cboName.DisplayMember = "員工.姓名";
            txtId.DataBindings.Add("Text", ds, "員工.員工編號");
            txtP.DataBindings.Add("Text", ds, "員工.職稱");
            txtBirthDay.DataBindings.Add("Text", ds, "員工.出生日期");
            txtAdd.DataBindings.Add("Text", ds, "員工.地址");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "員工";
            /* public Binding(
　             string propertyName,
　             object dataSource,
　             string dataMember,
　             bool formattingEnabled,
　             string formatString,);
               參數1（string propertyName）：要綁定的控制項屬性的名稱，如常用的控制項的Text屬性；
               參數2（object dataSource）：要綁定的數據源對象；
               參數3（string dataMember）：要綁定到的數據源中的屬性或列表；
               參數4（bool formattingEnabled）：指示是否啟用格式化數據，啟用之後，參數5的設置才能生效；
               參數5（string formatString）：一個或多個格式說明符，指示如何顯示值，如時間格式字符串「yyyy/MM/dd HH:mm」，數字格式字符串「E2」、"F2"之類的；
            */
        }
    }
}
