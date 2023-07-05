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
        private string random_order = "";
        private char[] origin = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'e', 'd', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        private int[] random = new int[52];
        public Form1()
        {
            InitializeComponent();
            legal_label.Visible = false;
        }
        public void create_random_order()
        {
            Random r = new Random();
            for(int i = 0; i < 52; i++)
            {
                random[i] = -1;
            }
            bool Ok = true;
            for (int i = 0; i < 52; i++)
            {
                int num;
                do
                {
                    Ok = true;
                    num = r.Next(52);
                    for (int j = 0; j < i; j++)
                    {
                        if (num == random[j])
                        {
                            Ok = false;
                        }
                    }
                } while (!Ok);
                random[i] = num;
                textBox1.Text += origin[random[i]].ToString();
            }
        }

        private void random_create_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            create_random_order();
        }

        private void sure_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 52; i++)
            {
                bool Ok = true;
                for (int j = 0; j < i; j++)
                {
                    if (random[i]== random[j])
                    {
                        Ok = false;
                        break;
                    }
                }
                if(Ok == false)
                {
                    legal_label.Text = "替換表不合法，請重新輸入";
                }
                else
                {
                    legal_label.Text = "合法替換表";

                }
            }
        }
    }
}
