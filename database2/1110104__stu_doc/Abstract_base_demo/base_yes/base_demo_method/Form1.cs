using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace base_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    Monster1 m1 = new Monster1();
            //      MessageBox.Show("" + m1.introduceSelf());
            //------------------
               Monster1 m = new Monster1();
               MessageBox.Show("" + m.introduceSelf());

        }
    }
}
