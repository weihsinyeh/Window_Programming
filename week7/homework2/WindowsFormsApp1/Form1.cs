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
    public partial class form : Form
    {
        private Button [,] button_array = new Button[6,4];
        private int[] number= { -1, -1, -1, -1 };
        //private Simple simple;
        //private General general;
        private int mode = 0;
        private int current_col=0,current_row=0;
        public form()
        {
            InitializeComponent();
            button1.Visible = false;
        }
        
        private void simple_mode_Click(object sender, EventArgs e)
        {
            /********************
                mode = 0;
                simple_mode.Visible = false;
                general_mode.Visible = false;
                simple = new Simple();
                simple.set_score();
                simple.set_current_num();
                score.Text = simple.get_score().ToString();
                current_num.Text = simple.get_current_num().ToString();
                *******************/
        }
            
        private void form_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    button_array[i, j] = new Button();
                    button_array[i, j].SetBounds(100 + 40 * j, 100 + 40 * i, 30, 30); //(starting point X, starting point Y, width, heigth)
                    button_array[i, j].Visible = false;
                    this.Controls.Add(button_array[i, j]);
                }
            }
        }
        
        private void general_mode_Click(object sender, EventArgs e)
        {
        /************************
            mode = 1;
            simple_mode.Visible = false;
            general_mode.Visible = false;
            general = new General();
            ************************/
        }

 

        private void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                button1.Visible = true;
            }
            /***************
            switch (e.KeyCode)
            {
                case Keys.A:
                    button_array[1, 1].Visible = true;
                    if (mode == 0)
                    {
                        simple.set_current_num(2);
                    }
                    else
                    {
                        general.set_current_num(2);
                    }
                    break;

                case Keys.S:
                    if (mode == 0)
                    {
                        simple.set_current_num(4);
                    }
                    else
                    {
                        general.set_current_num(4);
                    }
                    break;
                case Keys.D:
                    if (mode == 0)
                    {
                        simple.set_current_num(8);
                    }
                    else
                    {
                        general.set_current_num(8);
                    }
                    break;
                case Keys.Q:
                    current_col = 0;
                    number[0]++;
                    current_row = number[0];
                    break;
                case Keys.W:
                    current_col = 1;
                    number[1]++;
                    current_row = number[1];
                    break;
                case Keys.E:
                    current_col = 2;
                    number[2]++;
                    current_row = number[2];
                    break;
                case Keys.R:
                    current_col = 3;
                    number[3]++;
                    current_row = number[3];
                    break;
            }
            button_array[current_row, current_col].Visible = true;
            if (mode == 0)
            {
                button_array[current_row, current_col].Text = simple.get_current_num().ToString();
            }
            else
            {
                button_array[current_row, current_col].Text = general.get_current_num().ToString();
            }
            ****************/
            button_array[current_row, current_col].Visible = true;
        }
    }
}
