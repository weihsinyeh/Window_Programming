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
        private Role role1, role2;
        private bool player1_mode = true ;
        private Chess[,] table = new Chess[19, 19];
        private int player1_chess_category = 1;
        private int player2_chess_category = 1;

        public Form1()
        {
            InitializeComponent();
            //預設
            role1 = new Warrier(362, 0, 0, 5, 1);
            player1.Text = "P1:戰士";
            //預設
            role2 = new Warrier(362, 0, 0, 5, 1);
            player2.Text = "P2:戰士";
        }

        private void warrior1_Click(object sender, EventArgs e)
        {
            role1 = new Warrier(362,0, 0, 5,1);
            player1.Text = "P1:戰士";
        }
        private void warrior2_Click(object sender, EventArgs e)
        {
            role2 = new Warrier(362, 0, 0, 6, 1);
            player2.Text = "P2:戰士";
        }        
        private void mage1_Click(object sender, EventArgs e)
        {
            role1 = new Mage(362, 1, 2, 2, 2);
            player1.Text = "P1:法師";
        }

        private void mage2_Click(object sender, EventArgs e)
        {
            role2 = new Mage(362, 1, 2, 3, 2);
            player2.Text = "P2:法師";
        }
        private void archer1_Click(object sender, EventArgs e)
        {
            role1 = new Archer(362, 1, 1, 3, 3);
            player1.Text = "P1:弓箭手";
        }
        private void archer2_Click(object sender, EventArgs e)
        {
            role2 = new Archer(362, 1, 1, 4, 3);
            player2.Text = "P2:弓箭手";
        }
        private void start_Click(object sender, EventArgs e)
        {
            warrior1.Enabled = false;
            warrior2.Enabled = false;
            mage1.Enabled = false;
            mage2.Enabled = false;
            archer1.Enabled = false;
            archer2.Enabled = false;
            start.Enabled = false;

            warrior1.Visible = false;
            warrior2.Visible = false;
            mage1.Visible = false;
            mage2.Visible = false;
            archer1.Visible = false;
            archer2.Visible = false;
            start.Visible = false;

            normal1.Visible = true;
            normal2.Visible = true;
            horizental1.Visible = true;
            horizental2.Visible = true;
            vertical1.Visible = true;
            vertical2.Visible = true;
            cover1.Visible = true;
            cover2.Visible = true;
            enable();
            display();
            for (int i = 0; i < 19; i++)
            {
                for(int j = 0; j < 19; j++)
                {
                    table[i, j] = new Chess();
                    table[i, j].SetBounds(150 + j * 21, 70 + i * 21, 21, 21);
                    table[i, j].set_row(i);
                    table[i, j].set_col(j);
                    table[i, j].set_player(0);
                    table[i, j].Click += new EventHandler(this.Dynamic_Btn_Click);
                    Controls.Add(table[i, j]);
                }
            }
        }
        public void display()
        {
            horizental1.Text = "橫向棋子:" + role1.getB().ToString() + "顆";
            vertical1.Text = "縱向棋子:" + role1.getC().ToString() + "顆";
            cover1.Text = "覆蓋棋子:" + role1.getD().ToString() + "顆";
            horizental2.Text = "橫向棋子:" + role2.getB().ToString() + "顆";
            vertical2.Text = "縱向棋子:" + role2.getC().ToString() + "顆";
            cover2.Text = "覆蓋棋子:" + role2.getD().ToString() + "顆";
        }
        private void Dynamic_Btn_Click(object sender, EventArgs e)
        {
            bool enter = true;
            Chess Button = (Chess)(sender);
            if(player1_mode == true) //玩家一
            {
                if (Button.get_player() == 0) //位置沒人用過
                {
                    Button.set_role(role1.get_role());
                    Button.set_player(1);
                    Button.set();
                    check(Button.get_row(), Button.get_col());
                    if (player1_chess_category == 2) //橫向棋
                    {
                        bool OK = role1.changeB();
                        if (OK == false)
                        {
                            horizental1.Enabled = false;
                        }
                        if (Button.get_col() + 1 != 19&&table[Button.get_row(), Button.get_col() + 1].get_player() == 0)
                        {
                            table[Button.get_row(), Button.get_col() + 1].set_role(role1.get_role());
                            table[Button.get_row(), Button.get_col() + 1].set_player(1);
                            table[Button.get_row(), Button.get_col() + 1].set();
                            check(Button.get_row(), Button.get_col());
                        }
                    }
                    else if(player1_chess_category == 3) //縱向棋
                    {
                        bool OK = role1.changeC();
                        if (OK == false)
                        {
                            vertical1.Enabled = false;
                        }
                        if (Button.get_row() + 1 != 19&&table[Button.get_row() + 1, Button.get_col()].get_player() == 0)
                        {
                            table[Button.get_row() + 1, Button.get_col()].set_role(role1.get_role());
                            table[Button.get_row() + 1, Button.get_col()].set_player(1);
                            table[Button.get_row() + 1, Button.get_col()].set();
                            check(Button.get_row() + 1, Button.get_col());
                        }
                    }
                    else if (player1_chess_category == 4)
                    {
                        bool OK = role1.changeD();
                        if (OK == false)
                        {
                            horizental2.Enabled = false;
                        }
                        table[Button.get_row(), Button.get_col()].set_role(role1.get_role());
                        table[Button.get_row(), Button.get_col()].set_player(1);
                        table[Button.get_row(), Button.get_col()].set();
                        check(Button.get_row(), Button.get_col());
                    }
                }
                else //位置有人用過
                {
                    if(player1_chess_category == 4&&Button.get_player() != 1) //覆蓋
                    {
                        bool OK = role1.changeD();
                        if (OK == false)
                        {
                            cover1.Enabled = false;
                        }
                        Button.set_role(role1.get_role());
                        Button.set_player(1);
                        Button.set();
                        check(Button.get_row(), Button.get_col());
                    }
                    else
                    {
                        enter = false;
                    }
                }
            }
            else //玩家二
            {
                if (Button.get_player() == 0) //位置沒人用過
                {
                    Button.set_role(role2.get_role());
                    Button.set_player(2);
                    Button.set();
                    check(Button.get_row(), Button.get_col());
                    if (player2_chess_category == 2) //橫向棋
                    {
                        bool OK = role2.changeB();
                        if (OK == false)
                        {
                            horizental2.Enabled = false;
                        }
                        if (Button.get_col() + 1 != 19&&table[Button.get_row(), Button.get_col() + 1].get_player() == 0)
                        {
                            table[Button.get_row(), Button.get_col() + 1].set_role(role2.get_role());
                            table[Button.get_row(), Button.get_col() + 1].set_player(2);
                            table[Button.get_row(), Button.get_col() + 1].set();
                            check(Button.get_row(), Button.get_col());
                        }
                    }
                    else if (player2_chess_category == 3)//縱向棋
                    {
                        bool OK = role2.changeC();
                        if (OK == false)
                        {
                            horizental2.Enabled = false;
                        }
                        if (Button.get_row() + 1 != 19&&table[Button.get_row() + 1, Button.get_col()].get_player() == 0)
                        {
                            table[Button.get_row() + 1, Button.get_col()].set_role(role2.get_role());
                            table[Button.get_row() + 1, Button.get_col()].set_player(2);
                            table[Button.get_row() + 1, Button.get_col()].set();
                            check(Button.get_row() + 1, Button.get_col());
                        }
                    }
                    else if (player2_chess_category == 4)
                    {
                        bool OK = role2.changeD();
                        if (OK == false)
                        {
                            horizental2.Enabled = false;
                        }
                        table[Button.get_row() , Button.get_col()].set_role(role2.get_role());
                        table[Button.get_row() , Button.get_col()].set_player(2);
                        table[Button.get_row() , Button.get_col()].set();
                        check(Button.get_row() , Button.get_col());
                    }
                }
                else //位置有人用過
                {
                    if (player2_chess_category == 4&& Button.get_player()!=2) //覆蓋
                    {
                        bool OK = role2.changeD();
                        if (OK == false)
                        {
                            horizental2.Enabled = false;
                        }
                        Button.set_role(role2.get_role());
                        Button.set_player(2);
                        Button.set();
                        check(Button.get_row(), Button.get_col());
                    }
                    else
                    {
                        enter = false;
                    }
                }
            }
            if (enter == true)
            {
                display();
                player1_mode = !player1_mode;
                enable();
                player1_chess_category = 1;
                player2_chess_category = 1;
            }
        }
        public void enable()
        {
            if (player1_mode == true)
            {
                normal1.Enabled = true;
                if (role1.getB() != 0) { horizental1.Enabled = true; }
                else { horizental1.Enabled = false; }
                if (role1.getC() != 0) { vertical1.Enabled = true; }
                else { vertical1.Enabled = false; }
                if (role1.getD() != 0) { cover1.Enabled = true; }
                else { cover1.Enabled = false; }
                normal2.Enabled = false;
                horizental2.Enabled = false;
                vertical2.Enabled = false;
                cover2.Enabled = false;
            }
            else
            {
                normal2.Enabled = true;
                if (role2.getB() != 0) { horizental2.Enabled = true; }
                else { horizental2.Enabled = false; }
                if (role2.getC() != 0) { vertical2.Enabled = true; }
                else { vertical2.Enabled = false; }
                if (role2.getD() != 0) { cover2.Enabled = true; }
                else { cover2.Enabled = false; }
                normal1.Enabled = false;
                horizental1.Enabled = false;
                vertical1.Enabled = false;
                cover1.Enabled = false;
            }
        }
        private void check(int row,int col)
        {
            int now_player = table[row, col].get_player();
            int end_point_row1, end_point_col1;
            int end_point_row2, end_point_col2;
            int i = 0,counter;
            do
            {
                if (row - i == 0 || col - i == 0)
                {
                    end_point_row1 = row-i;
                    end_point_col1 = col-i;
                    break;
                }
                i++;
            } while (true);
            i = 0;
            do
            {
                if (row - i == 0 || col + i == 18)
                {
                    end_point_row2 = row-i;
                    end_point_col2 = col+i;
                    break;
                }
                i++;
            } while (true);
            
            //橫
            i = 0;
            counter =0;
            while(i<19)
            {
                if(table[row,  i].get_player() != now_player)
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                    if (counter == 5)
                    {
                        end_game(now_player);
                    }
                }
                i++;
            }
            //直
            i = 0;
            counter = 0;
            while (i < 19)
            {
                if (table[i, col].get_player() != now_player)
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                    if (counter == 5)
                    {
                        end_game(now_player);
                    }
                }
                i++;
            }
            //左上到右下
            i = 0;
            counter = 0;
            while (i < 19)
            {
                if (table[end_point_row1 + i, end_point_col1 + i].get_player() != now_player)
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                    if (counter == 5)
                    {
                        end_game(now_player);
                    }
                }
                i++;
                if (end_point_row1 + i == 19 || end_point_col1 + i == 19)
                {
                    break;
                }
            }
            //右上到左下

            i = 0;
            counter = 0;
            while ( i < 19)
            {
                if (table[end_point_row2 + i, end_point_col2 - i].get_player() != now_player)
                {
                    counter = 0;
                }
                else
                {
                    counter++;
                    if (counter == 5)
                    {
                        end_game(now_player);
                    }
                }
                i++;
                if (end_point_row2 + i == 19 || end_point_col2 - i == -1)
                {
                    break;
                }
            }
        }

        private void normal1_Click(object sender, EventArgs e)
        {
            player1_chess_category = 1;
        }

        private void normal2_Click(object sender, EventArgs e)
        {
            player2_chess_category = 1;
        }

        private void horizental1_Click(object sender, EventArgs e)
        {
            player1_chess_category = 2;
        }

        private void horizental2_Click(object sender, EventArgs e)
        {
            player2_chess_category = 2;
        }

        private void vertical1_Click(object sender, EventArgs e)
        {
            player1_chess_category = 3;
        }

        private void vertical2_Click(object sender, EventArgs e)
        {
            player2_chess_category = 3;
        }

        private void cover1_Click(object sender, EventArgs e)
        {
            player1_chess_category = 4;
        }

        private void cover2_Click(object sender, EventArgs e)
        {
            player2_chess_category = 4;
        }

        public void end_game(int now_player)
        {
            DialogResult result = MessageBox.Show("P"+ now_player.ToString()+ "獲勝", "遊戲結束", MessageBoxButtons.OK);
            if (DialogResult.OK == result)
            {
                System.Environment.Exit(0);
            }
        }

    }
}
