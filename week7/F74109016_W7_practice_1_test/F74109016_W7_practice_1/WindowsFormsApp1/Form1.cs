//F74109016 W4 practice 1
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
    public partial class Form : System.Windows.Forms.Form
    {
        public Button[,] button_array = new Button[6, 4];
        public int [,]value = new int[6, 4];
        private int[] number = { -1, -1, -1, -1 };
        private Simple simple;
        private General general;
        private int mode = -1;
        private int current_col = 0;
        bool change = false;
        private int sec = 0;
        public void ReSet_time()
        {
            sec = 3;
            timer1.Interval = 1000;
            if (mode == 1)
            {
                clock.Text = sec.ToString();
            }
        }
        public Form()
        {
            InitializeComponent();
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            clock.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D)&&mode==0)
            {
                switch (e.KeyCode)
                {
                    case Keys.A:
                        simple.set_current_num(2);
                        break;

                    case Keys.S:
                        simple.set_current_num(4);
                        break;
                    case Keys.D:
                        simple.set_current_num(8);
                        break;
                }
                current_number.Text = simple.get_current_num().ToString();
            }
            else if (e.KeyCode == Keys.Q || e.KeyCode == Keys.W || e.KeyCode == Keys.E || e.KeyCode == Keys.R)
            {
                if (mode == 1) {
                    general.set_time();
                    clock.Text = general.get_time().ToString();
                }
                switch (e.KeyCode)
                {
                    case Keys.Q:
                        number[0]++;
                        if(mode==0)
                            value[number[0], 0] = simple.get_current_num();
                        else
                            value[number[0], 0] = general.get_current_num();
                        button_array[number[0], 0].Visible = true;
                        button_array[number[0], 0].Text = value[number[0], 0].ToString();
                        break;
                    case Keys.W:
                        number[1]++;
                        if (mode == 0)
                            value[number[1], 1] = simple.get_current_num();
                        else
                            value[number[1], 1] = general.get_current_num();
                        button_array[number[1], 1].Visible = true;
                        button_array[number[1], 1].Text = value[number[1], 1].ToString();
                        break;
                    case Keys.E:
                        number[2]++;
                        if (mode == 0)
                            value[number[2], 2] = simple.get_current_num();
                        else
                            value[number[2], 2] = general.get_current_num();
                        button_array[number[2], 2].Visible = true;
                        button_array[number[2], 2].Text = value[number[2], 2].ToString();
                        break;
                    case Keys.R:
                        number[3]++;
                        if (mode == 0)
                            value[number[3], 3] = simple.get_current_num();
                        else
                            value[number[3], 3] = general.get_current_num();
                        button_array[number[3], 3].Visible = true;
                        button_array[number[3], 3].Text = value[number[3], 3].ToString();
                        break;
                }
                do
                {
                    change = false;
                    check();
                    check_horizontal();
                } while (change == true);
                if (mode == 0) {
                    simple.set_current_num();
                    current_number.Text = simple.get_current_num().ToString();
                }
                else
                {
                    general.set_current_num();
                    current_number.Text = general.get_current_num().ToString();
                }
                warning();
            }
        }
        private void warning()
        {
            for (int i = 0; i < 4; i++)
            {
                DialogResult result;
                if (number[i] == 5 && mode == 0)
                {
                    timer1.Enabled = false;
                    result = MessageBox.Show("遊戲結束!!!\n你的分數:" + simple.get_score().ToString(),"", MessageBoxButtons.OK);
                    if (DialogResult.OK == result)
                    {
                        System.Environment.Exit(0);
                    }
                }
                else if (number[i] == 5 && mode == 1)
                {
                    timer1.Enabled = false;
                    result =MessageBox.Show("遊戲結束!!!\n你的分數:" + general.get_score().ToString(),"", MessageBoxButtons.OK);
                    if (DialogResult.OK == result)
                    {
                        System.Environment.Exit(0);
                    }
                }
            }
        }
        private void check_horizontal()
        {
            for(int row = 0; row <= number[0]; row++) {
                int temp = value[row, 0];
                if (value[row, 0] == temp && value[row, 1] == temp && value[row, 2] == temp && value[row, 3] == temp) //從最底開始合併，合併後與底部不留空隙
                {
                    change = true;
                    if (mode == 0)
                    {
                        simple.change_score(temp * temp);
                        score.Text = simple.get_score().ToString();
                    }
                    else
                    {
                        general.change_score(temp * temp);
                        score.Text = general.get_score().ToString();
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        value[row, i] = 0;
                    }
                    for(int j = 0; j < 4; j++)
                    {
                        for(int i = row + 1; i <= number[j]; i++)
                        {
                            value[i-1, j] = value[i, j];
                            value[i, j] = 0;
                            button_array[i - 1, j].Text = value[i-1, j].ToString();
                        }
                        button_array[number[j], j].Visible = false;
                        number[j]--;
                    }
                }
            }
        }    
            
        
        private void check()
        {
            for (int i = 0; i < 4; i++)
            {
                if (number[i] > 0 )
                {
                    if (value[number[i],i] == value[number[i]-1,i])
                    {
                        change = true;
                        try
                        {
                            while (value[number[i], i] == value[number[i] - 1, i])
                            {
                                value[number[i] - 1, i] *= 2;
                                value[number[i], i] = 0;
                                button_array[number[i] - 1, i].Text = value[number[i] - 1, i].ToString();
                                button_array[number[i], i].Visible = false;
                                number[i]--;
                                if (number[i] == 0)
                                {
                                    break;
                                }
                            }
                        }
                        catch{

                        }
                    }
                }
            }
        }
        void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    button_array[i, j] = new Button();
                    button_array[i, j].SetBounds(100 + 40 * j, 300 - 40 * i, 30, 30); //(starting point X, starting point Y, width, heigth)
                    button_array[i, j].Visible = false;
                    value[i, j] = 0;
                    this.Controls.Add(button_array[i, j]);
                }
            }
        }
        void random()
        {
            warning();
            number[1]++;
            if (mode == 0)
            {
                value[number[1], 1] = simple.get_current_num();
            }
            else if (mode == 1)
            {
                value[number[1], 1] = general.get_current_num();
            }
            button_array[number[1], 1].Visible = true;
            button_array[number[1], 1].Text = value[number[1], 1].ToString();
            do
            {
                change = false;
                check();
                check_horizontal();
            } while (change == true);
            general.set_current_num();
            current_number.Text = general.get_current_num().ToString();
        }
        void simple_mode_Click(object sender, EventArgs e)
        {
            if (mode == -1)
            {
                mode = 0;
                simple = new Simple();
                simple_mode.Dispose();
                general_mode.Dispose();
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                simple.set_score();
                simple.set_current_num();
                score.Text = simple.get_score().ToString();
                current_number.Text = simple.get_current_num().ToString();
                timer1.Enabled = false;
                clock.Visible = false;
            }
        }

        void general_mode_Click(object sender, EventArgs e)
        {
            if (mode == -1)
            {
                mode = 1;
                general = new General();
                simple_mode.Dispose();
                general_mode.Dispose();
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                clock.Visible = true;
                general.set_score();
                general.set_current_num();
                score.Text = general.get_score().ToString();
                current_number.Text = general.get_current_num().ToString();
                timer1.Enabled = true;
                clock.Text = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mode == 1)
            {
                clock.Text = sec.ToString();
                if (sec == 0)
                {
                    ReSet_time();
                    random();
                }
                sec--;
            }
            else
            {
                timer1.Enabled = false;
                clock.Visible = false;
                label3.Visible = false;
            }
        }
    }

    class Simple
    {
        private int score=0;
        private int current_num=0;
        public int[] number_array = new int[3];
        Random myObject = new Random();
        public void set_score()
        {
            this.score = 0;
        }
        public void change_score(int change)
        {
            this.score += change;
        }
        public int get_score()
        {
            return score;
        }
        public void set_current_num()
        {
            number_array[0] = 2;
            number_array[1] = 4;
            number_array[2] = 8;
            int num = myObject.Next(0, 2);
            this.current_num = number_array[num];
        }
        public void set_current_num(int num)
        {
            this.current_num = num;
        }
        public int get_current_num()
        {
            return this.current_num;
        }
    }
    class General
    {
        private int score;
        private int current_num;
        public int[] number_array = new int[3];
        public int time;
        Random myObject = new Random();
        public void set_time()
        {
            this.time = 3;
        }
        public int get_time()
        {
            return time;
        }
        public void set_score()
        {
            this.score = 0;
        }
        public void change_score(int change)
        {
            this.score += change;
        }
        public int get_score()
        {
            return score;
        }
        public void set_current_num()
        {
            number_array[0] = 2;
            number_array[1] = 4;
            number_array[2] = 8;
            int num = myObject.Next(0, 2);
            this.current_num = number_array[num];
        }
        public int get_current_num()
        {
            return this.current_num;
        }
    }
}
