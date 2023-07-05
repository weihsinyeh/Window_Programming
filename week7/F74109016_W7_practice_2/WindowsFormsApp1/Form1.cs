//F74109016 葉惟欣 week 7 pracitec_2
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
        public int score = 0;
        private int property=1;
        public Random myobject;
        public Role [] fole_character = new Role[4];
        public Button[] fole_array;
        public int sec,time_num=1;
        public Role player_role = new Role();
        public int player_col = 1;
        public Role[,] fire_role = new Role[4,10];
        public int[] fire_num = new int[4];
        public Button[,] fire_box = new Button[4,10];
        public DialogResult result;
        public int cool=0;
        public bool emit = true;
        public Form1()
        {
            InitializeComponent();
            label3.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            property_show.Visible = false;
            score_display.Visible = false;
            clock.Visible = false;
        }
        public void Set_time()
        {
            sec = 60;
            timer1.Interval = 100; //一秒
        }
        private void property1_CheckedChanged(object sender, EventArgs e)
        {
            if (property1.Checked == true)
            {
                property = 1;
            }
        }
        private void property2_CheckedChanged(object sender, EventArgs e)
        {
            if (property2.Checked == true)
            {
                property = 2;
            }
        }

        private void property3_CheckedChanged(object sender, EventArgs e)
        {
            if (property3.Checked == true)
            {
                property = 3;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            property1.Visible = false;
            property2.Visible = false;
            property3.Visible = false;
            button1.Visible = false;
            player.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            label1.Visible = true;
            property_show.Visible = true;
            score_display.Visible = true;
            clock.Visible = true;

            fole_array = new Button[4];
            switch (property)
            {
                case 1:
                    player_role = new Role_water();
                    break;
                case 2:
                    player_role = new Role_fire();
                    break;
                case 3:
                    player_role = new Role_tree();
                    break;
            }
            player.BackColor = player_role.get_color();
            player.Text = "你";
            player.ForeColor = Color.White;
            for (int i = 0; i < 4; i++)
            {
                create_fole(i);
                Controls.Add(fole_array[i]);
            }
            
            timer1.Enabled = true;
            Set_time();
        }
        private void create_fire(int i)
        {
            fire_box[i, fire_num[i]] = new Button();
            fire_box[i, fire_num[i]].Width = player.Width/2;
            fire_box[i, fire_num[i]].Height = player.Height / 2;
            switch (player_role.get_property())
            {
                case 1:
                    fire_role[i,fire_num[i]] = new Role_water();
                    break;
                case 2:
                    fire_role[i, fire_num[i]] = new Role_fire();
                    break;
                case 3:
                    fire_role[i, fire_num[i]] = new Role_tree();
                    break;
            }
            fire_box[i, fire_num[i]].BackColor = fire_role[i, fire_num[i]].get_color();
            fire_box[i, fire_num[i]].Location = new Point(player.Left+10, player.Top );
            fire_box[i, fire_num[i]].Visible = true;
            this.Controls.Add(fire_box[i, fire_num[i]]);
            fire_num[i]++;
        }
        private void create_fole(int i)
        {
            Random myobject = new Random(int.Parse(DateTime.Now.ToString("HHmmssfff"))+i);
            int temp = myobject.Next(1, 4);
            fole_array[i] = new Button();
            fole_array[i].ForeColor = Color.White;
            fole_array[i].Width= player.Width;
            fole_array[i].Height = player.Height;
            fole_array[i].Visible = true ;
            switch (temp)
            {
                case 1:
                    fole_character[i] = new Role_water();
                    break;
                case 2:
                    fole_character[i] = new Role_fire();
                    break;
                case 3:
                    fole_character[i] = new Role_tree();
                    break;
            }
            fole_array[i].BackColor = fole_character[i].get_color();
            this.Controls.Add(fole_array[i]);
            fole_array[i].Top = player.Top - 400;
            fole_array[i].Location = new Point(105 + i * 50, fole_array[i].Top + fole_character[i].get_speed());
            fole_array[i].Text = fole_character[i].get_text();
        }
       
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    if (player.Left - 50 > 100)
                    {
                        player_col--;
                        player.Left -= 50;
                    }
                    break;
                case Keys.D:
                    if (player.Left + 50 < 300)
                    {
                        player_col++;
                        player.Left += 50;
                    }
                    break;
                case Keys.W:
                    if(emit == true)
                    {
                        create_fire(player_col);
                        emit = false;
                    }
                    break;
            }
        }

        private void score_display_TextChanged(object sender, EventArgs e)
        {
            score_display.Text = score.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            clock.Text = sec.ToString();
            if(sec == 0)
            {
                timer1.Enabled = false;
                result = MessageBox.Show("遊戲結束\n你的分數:"+score,"遊戲結束",MessageBoxButtons.OK);
                if (DialogResult.OK == result)
                {
                    System.Environment.Exit(0);
                }
            }
            if(score < 0)
            {
                timer1.Enabled = false;
                string text_show ="";
                switch (player_role.get_property())
                {
                    case 1:
                        text_show = "你枯竭了!";
                        break;
                    case 2:
                        text_show = "你被熄滅了!";
                        break;
                    case 3:
                        text_show = "你燒起來了!";
                        break;
                }
                result = MessageBox.Show(text_show+"\n你的分數:"+score, "遊戲結束", MessageBoxButtons.OK);
                if (DialogResult.OK == result)
                {
                    System.Environment.Exit(0);
                }
                score = 0;
            }
            time_num++;
            if (time_num == 10)
            {
                sec--;
                time_num = 0;
                emit = true;
            }
            for (int i = 0; i < 4; i++)
            {
                
                property_show.Text = player_role.get_text();
                if (fole_array[i].Bottom > player.Top && player_col == i)
                {
                    if (player_role.get_fole_weak() == fole_character[i].get_property())
                    {
                        
                        score += 5;
                        switch (fole_character[i].get_property())
                        {
                            case 1:
                                player_role = new Role_water();
                                break;
                            case 2:
                                player_role = new Role_fire();
                                break;
                            case 3:
                                player_role = new Role_tree();
                                break;
                        }
                        player.BackColor = player_role.get_color();
                        player.Text = player_role.get_text();
                    }
                    else if (player_role.get_fole_strong() == fole_character[i].get_property())
                    {
                        score -= 5;
                    }
                    
                    fole_array[i].Dispose();
                    create_fole(i);
                    
                }
                else if (fole_array[i].Bottom > player.Bottom)
                {
                    fole_array[i].Dispose();
                    create_fole(i);
                }
                fole_array[i].Location = new Point(105 + i * 50, fole_array[i].Top + fole_character[i].get_speed());
                for (int j = 0; j < 10; j++) {
                    if (fire_box[i, j] != null && fire_box[i, j].Top < fole_array[i].Bottom)
                    {
                        if (fire_role[i, j].get_fole_weak() == fole_character[i].get_property())
                        {
                            score += 2;
                        }
                        else if (fire_role[i, j].get_fole_strong() == fole_character[i].get_property())
                        {
                            score -= 2;
                        }
                        this.Controls.Remove(fire_box[i, j]);
                        this.Controls.Remove(fole_array[i]);
                        fire_box[i, j].Dispose();
                        fole_array[i].Dispose();
                        fire_box[i, j] = null;
                        create_fole(i);
                    }
                    if (fire_box[i, j] != null)
                    {
                        fire_box[i, j].Location = new Point(115 + i * 50, fire_box[i, j].Top - fire_role[i, j].get_speed());
                    }
                    if(fire_num[i] == 10) //像circular的概念。
                    {
                        fire_num[i] = 0;
                    }
                    score_display.Text = score.ToString();
                }
            }
        }
    }
}
