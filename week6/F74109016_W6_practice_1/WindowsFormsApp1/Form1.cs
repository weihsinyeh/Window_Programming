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
        private int tall, width;
        private int total_tall = 300 , total_width = 170;
        private Button[,] decimal_display = new Button[10,10];
        private Button[,] one_display = new Button[10,10];
        public void set_tall(int tall)
        {
            this.tall = tall;
        }
        public void set_width(int width)
        {
            this.width = width;
        }
        public int get_tall()
        {
            return tall;
        }
        public int get_width()
        {
            return width;
        }
        public Form1()
        {
            InitializeComponent();
            textBox3.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            change();
        }
        private void change()
        {
            try
            {
                int number = int.Parse(textBox3.Text);
                if (number <= 99 && number >= -9)
                {
                    if (number >= 0)
                    {
                        int decimal_num = number / 10;
                        int one_num = number % 10;
                        change_display(decimal_num, decimal_display);
                        change_display(one_num, one_display);
                    }
                    else
                    {
                        display_minus(decimal_display);
                        change_display(-number, one_display);
                    }
                }
                else
                {
                    int i, j;
                    for (i = 0; i < tall; i++)
                    {
                        for (j = 0; j < width; j++)
                        {
                            one_display[i,j].BackColor = Color.FromArgb(255, 255, 255);
                            decimal_display[i,j].BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                }
            }
            catch
            {
                int i, j;
                for (i = 0; i < tall; i++)
                {
                    for (j = 0; j < width; j++)
                    {
                        one_display[i, j].BackColor = Color.FromArgb(255, 255, 255);
                        decimal_display[i, j].BackColor = Color.FromArgb(255, 255, 255);
                    }
                }
            }
        }
        private void display_minus(Button [,] arr)
        {
            int i, j;
            for (i = 0; i < tall; i++)
            {
                for (j = 0; j < width; j++)
                {
                    arr[i, j].BackColor = Color.FromArgb(255, 255, 255);
                }
            }
            display_four(arr);
        }
        private void display_one(Button[,] arr)
        {
            int i = 0;
            for (i = 1; i < tall / 2; i++)
            {
                arr[i, 0].BackColor = Color.FromArgb(0, 0, 255);
            }
        }
        private void display_two(Button[,] arr)
        {
            int i = 0;
            for (i = 1; i < width-1; i++)
            {
                arr[0, i].BackColor = Color.FromArgb(0, 0, 255);
            }
        }
        private void display_three(Button[,] arr)
        {
            int i = 0;
            for (i = 1; i < tall / 2; i++)
            {
                arr[i, width-1].BackColor = Color.FromArgb(0, 0, 255);
            }
        }
        private void display_four(Button[,] arr)
        {
            int i = 0;
            for (i = 1; i < width-1; i++)
            {
                arr[tall/2,i].BackColor = Color.FromArgb(0, 0, 255);
            }
        }
        private void display_five(Button[,] arr)
        {
            int i = 0;
            for (i = tall / 2 + 1; i < tall-1; i++)
            {
                arr[i, 0].BackColor = Color.FromArgb(0, 0, 255);
            }
        }
        private void display_six(Button[,] arr)
        {
            int i = 0;
            for (i = tall / 2 + 1; i < tall-1; i++)
            {
                arr[i, width-1].BackColor = Color.FromArgb(0, 0, 255);
            }
        }
        private void display_seven(Button[,] arr)
        {
            int i = 0;
            for (i = 1; i < width-1; i++)
            {
                arr[tall-1,i].BackColor = Color.FromArgb(0, 0, 255);
            }
        }
        private void change_display(int num,Button [,] arr)
        {
            int i, j;
            switch (num) {
                case 0:
                    for (i = 0; i < tall; i++)
                    {
                        for (j = 0; j < width; j++)
                        {
                            arr[i, j].BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                    display_one(arr);
                    display_two(arr);
                    display_three(arr);
                    display_five(arr);
                    display_six(arr);
                    display_seven(arr);
                    break;
                case 1:
                    for (i = 0; i < tall; i++)
                    {
                        for (j = 0; j < width; j++)
                        {
                            arr[i, j].BackColor = Color.FromArgb(255, 255, 255);                          
                        }
                    }
                    display_three(arr);
                    display_six(arr);
                    break;
                case 2:
                    for (i = 0; i < tall; i++)
                    {
                        for (j = 0; j < width; j++)
                        {
                            arr[i, j].BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                    display_two(arr);
                    display_three(arr);
                    display_four(arr);
                    display_five(arr);
                    display_seven(arr);
                    break;
                case 3:
                    for (i = 0; i < tall; i++)
                    {
                        for (j = 0; j < width; j++)
                        {
                            arr[i, j].BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                    display_two(arr);
                    display_three(arr);
                    display_four(arr);
                    display_six(arr);
                    display_seven(arr);
                    break;
                case 4:
                    for (i = 0; i < tall; i++)
                    {
                        for (j = 0; j < width; j++)
                        {
                            arr[i, j].BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                    display_one(arr);
                    display_three(arr);
                    display_four(arr);
                    display_six(arr);
                    break;
                case 5:
                    for (i = 0; i < tall; i++)
                    {
                        for (j = 0; j < width; j++)
                        {
                            arr[i, j].BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                    display_one(arr);
                    display_two(arr);
                    display_four(arr);
                    display_six(arr);
                    display_seven(arr);
                    break;
                case 6:
                    for (i = 0; i < tall; i++)
                    {
                        for (j = 0; j < width; j++)
                        {
                            arr[i, j].BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                    display_one(arr);
                    display_two(arr);
                    display_four(arr);
                    display_five(arr);
                    display_six(arr);
                    display_seven(arr);
                    break;
                case 7:
                    for (i = 0; i < tall; i++)
                    {
                        for (j = 0; j < width; j++)
                        {
                            arr[i, j].BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                    display_two(arr);
                    display_three(arr);
                    display_six(arr);
                    break;
                case 8:
                    for (i = 0; i < tall; i++)
                    {
                        for (j = 0; j < width; j++)
                        {
                            arr[i, j].BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                    display_one(arr);
                    display_two(arr);
                    display_three(arr);
                    display_four(arr);
                    display_five(arr);
                    display_six(arr);
                    display_seven(arr);
                    break;
                case 9:
                    for (i = 0; i < tall; i++)
                    {
                        for (j = 0; j < width; j++)
                        {
                            arr[i, j].BackColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                    display_one(arr);
                    display_two(arr);
                    display_three(arr);
                    display_four(arr);
                    display_six(arr);
                    display_seven(arr);
                    break;
            }
        }

        private void create_display()
        {
            for(int i = 0; i < tall; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    one_display[i,j].Dispose();
                    decimal_display[i, j].Dispose();
                }
            }
            set_tall(int.Parse(textBox1.Text));
            set_width(int.Parse(textBox2.Text));
            one_display = new Button[get_tall(),get_width()];//10 button
            decimal_display = new Button[get_tall(), get_width()];
            for (int i = 0; i < tall; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    
                    one_display[i,j] = new Button();
                    one_display[i, j].BackColor = Color.FromArgb(255, 255, 255);
                    decimal_display[i, j] = new Button();
                    decimal_display[i,j].BackColor = Color.FromArgb(255, 255, 255);
                    decimal_display[i,j].SetBounds(300 + (total_width / width) * j, 40+ (total_tall / tall) *i, total_width / width, total_tall / tall); //(starting point X, starting point Y, width, heigth)
                    one_display[i, j].SetBounds(480 + (total_width / width) * j, 40 + (total_tall / tall) * i, total_width / width, total_tall / tall); //(starting point X, starting point Y, width, heigth)
                    Controls.Add(decimal_display[i, j]);
                    Controls.Add(one_display[i, j]);
                }
            }
            change();
        }
        //textBox1 高 textBox2 寬
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox1.Text))
                {
                    MessageBox.Show("“請輸入數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (((int.Parse(textBox1.Text) >= 7) && (int.Parse(textBox1.Text) <= 15)) && ((int.Parse(textBox2.Text) >= 5) && (int.Parse(textBox2.Text) <= 10)))
                {
                    if (int.Parse(textBox1.Text) % 2 == 1)
                    {
                        create_display();
                        textBox3.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("高不能是偶數", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("請輸入範圍內的數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch
            {
                MessageBox.Show("請輸入數字", "警告", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
