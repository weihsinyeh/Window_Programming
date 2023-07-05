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
    public partial class Form2 : Form
    {
        public Button [,] buttonarray = new Button[10,4];
        public int [] array_num = new int[4];
        public Form2()
        {
            InitializeComponent();
        }
        private void set_time()
        {
            timer1.Interval = 500;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    buttonarray[i, j] = new Button();
                    buttonarray[i, j].SetBounds(100 + 90 * j, 50 + 30 * i, 80, 20);
                    buttonarray[i, j].Text = j.ToString() + "," + i.ToString();
                    buttonarray[i, j].TextAlign = ContentAlignment.MiddleLeft;
                    buttonarray[i, j].BackColor = Color.Transparent;
                    buttonarray[i, j].FlatStyle = FlatStyle.Flat;
                    buttonarray[i, j].FlatAppearance.BorderSize = 0;
                    this.Controls.Add(buttonarray[i, j]);
                }
            }
            set_time();
            timer1.Start();
            for(int j = 0; j < 4; j++)
            {
                array_num[j] = 0;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {

        }
        private void display()
        {
            for (int j = 0; j < 4; j++)
            {
                Random r = new Random(int.Parse(DateTime.Now.ToString("HHmmssfff")) + j);
                array_num[j] = r.Next(50000) % (trackBar1.Value +1);

                for (int i = 0; i < 10; i++)
                {
                    buttonarray[i, j].BackColor = Color.Transparent;

                }
                for (int i = 0; i < array_num[j]; i++)
                {
                    buttonarray[9-i, j].BackColor = Color.Blue;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            display();
        }
    }
}
