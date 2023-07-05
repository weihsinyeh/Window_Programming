using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace StuScore
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
                "AttachDbFilename=|DataDirectory|TestDB.mdf;" +
                "Integrated Security=True";        
            DataSet ds = new DataSet();

            SqlDataAdapter daScore = new SqlDataAdapter("SELECT * FROM 成績", cn);
            daScore.Fill(ds, "成績");

            txtId.DataBindings.Add("Text", ds, "成績.學號");
            txtName.DataBindings.Add("Text", ds, "成績.姓名");
            txtChi.DataBindings.Add("Text", ds, "成績.國文");
            txtEng.DataBindings.Add("Text", ds, "成績.英文");
            txtMath.DataBindings.Add("Text", ds, "成績.數學");
            bm = this.BindingContext[ds, "成績"];
            hScrollBar1.SmallChange = 1;
            hScrollBar1.LargeChange = 1;
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = bm.Count-1 ;
            lblCount.Text = (bm.Position+1).ToString ()  +" / "+ bm.Count.ToString ();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            bm.Position = hScrollBar1.Value;
            lblCount.Text = (bm.Position + 1).ToString() + " / " + bm.Count.ToString();
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            txtChi.Text = "";
            txtEng.Text = "";
            txtMath.Text = "";
        }

        void Edit(string sqlstr)
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|TestDB.mdf;" +
                    "Integrated Security=True";
                cn.Open();
                SqlCommand cmd = new SqlCommand(sqlstr, cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void DataBindingsClear()
        {
            txtId.DataBindings.Clear();
            txtName.DataBindings.Clear();
            txtChi.DataBindings.Clear();
            txtEng.DataBindings.Clear();
            txtMath.DataBindings.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Edit("INSERT INTO 成績(學號,姓名,國文,英文,數學)VALUES('" +
                txtId.Text.Replace("'", "''") + "','" +
                txtName.Text.Replace("'", "''") + "'," +
                txtChi.Text + "," +
                txtEng.Text + "," +
                txtMath.Text + ")");
            DataBindingsClear();
            Form1_Load(sender, e);  
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Edit("UPDATE 成績 SET 姓名='" + txtName.Text.Replace ("'", "''") + 
                "',國文=" + txtChi.Text + 
                ",英文=" + txtEng.Text + 
                ",數學="+txtMath.Text + 
                " WHERE 學號='" +txtId.Text.Replace("'", "''") + "'");
            DataBindingsClear();
            Form1_Load(sender, e);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Edit("DELETE FROM 成績 WHERE 學號='" +
                txtId.Text.Replace("'", "''") + "'");
            DataBindingsClear();
            Form1_Load(sender, e);
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
}
