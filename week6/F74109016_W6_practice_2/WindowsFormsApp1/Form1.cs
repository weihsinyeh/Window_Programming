//F74109016 葉惟欣 Homework#2
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
        private int current;
        private int location;
        private bool bold;
        private bool italic;
        private string style;
        private int text_size;
        private string text;
        private Class1 font;
        public Form1()
        {
            InitializeComponent();
            current = 1;
            location = 0;
            bold = false;
            italic = false;
            text_size = 12;
            Text_change.Text = "早安"; //預設為早安
            font = new Class1();
            Picture_Show();
            change();
        }
        public void Picture_Show()
        {
            try
            {
                pictureBox1.Image =  Image.FromFile(@"..\..\pic\pic_0" + current + ".png");
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(current == 1)
            {
                current = 5;
            }
            else
            {
                current--;
            }
            Picture_Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(current == 5)
            {
                current = 1;
            }
            else
            {
                current++;
            }
            Picture_Show();
        }

        private void topleft_CheckedChanged(object sender, EventArgs e)
        {
            if (topleft.Checked)
            {
                location = 0;
                font.ChangeAlignment(location);
                change();
            }
        }

        private void topcenter_CheckedChanged(object sender, EventArgs e)
        {
            if (topcenter.Checked)
            {
                location = 1;
                font.ChangeAlignment(location);
                change();
            }
        }

        private void topright_CheckedChanged(object sender, EventArgs e)
        {
            if (topright.Checked)
            {
                location = 2;
                font.ChangeAlignment(location);
                change();
            }
        }

        private void buttonleft_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonleft.Checked)
            {
                location = 3;
                font.ChangeAlignment(location);
                change();
            }
        }

        private void buttoncenter_CheckedChanged(object sender, EventArgs e)
        {
            if (buttoncenter.Checked)
            {
                location = 4;
                font.ChangeAlignment(location);
                change();
            }
        }

        private void buttonright_CheckedChanged(object sender, EventArgs e)
        {
            if (buttonright.Checked)
            {
                location = 5;
                font.ChangeAlignment(location);
                change();
            }
        }

        private void Boldbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (Boldbutton.Checked)
            {
                bold = true;
                change();
            }
            else
            {
                bold = false;
                change();
            }
        }

        private void ItalicButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ItalicButton.Checked)
            {
                italic = true;
                change();
            }
            else
            {
                italic = false;
                change();
            }
        }

        private void first_style_CheckedChanged(object sender, EventArgs e)
        {
            style = "標楷體";
            change();
        }

        private void second_style_CheckedChanged(object sender, EventArgs e)
        {
            style = "新細明體";
            change();
        }

        private void third_style_CheckedChanged(object sender, EventArgs e)
        {
            style = "微軟正黑體";
            change();
        }

        private void textsize_TextChanged(object sender, EventArgs e)
        {
            try
            {
                toolTip1.SetToolTip(textsize, "請輸入1~32的整數");
                text_size = int.Parse(textsize.Text);
                if ((text_size >= 1) && (text_size <= 32))
                {
                    font.ChangeSize(text_size);
                }
                else
                {
                    font.ChangeSize(12);
                }
                change();
            }
            catch { }
        }

        private void input_text_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input_text.Text))
            {
                toolTip1.SetToolTip(input_text, "文字隨意，不為空字串即可");
            }
            else { 
                Text_change.Text = input_text.Text;
            }
            change();
        }
        private void change()
        {
            Picture_Show();
            font.ChangeAlignment(location);
            font.ChangeStyle(bold, italic);
            font.ChangeFamily(style);
            Text_change = font.ChangeLabel(Text_change);
        }
    }
}
