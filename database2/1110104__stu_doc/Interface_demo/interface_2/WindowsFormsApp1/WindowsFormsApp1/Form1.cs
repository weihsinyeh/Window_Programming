using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
           Creature c = new Villager();
       //     Creature c = new Monster();  //取得moster 定義的 say()
            Iattack someone = new Monster();
            someone.Iattack(c);
            MessageBox.Show(c.say());
        }
    }
}
