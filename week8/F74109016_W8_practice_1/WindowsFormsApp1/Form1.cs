//F74109016 葉惟欣 week8 practice 1
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Card[,] button_array;
        private int mode=1,row_num,col_num;
        private int first=0, last=0;
        private bool islast = false;
        private int player1_score=0, player2_score=0;
        private Card [] round_card = new Card[2];
        private int sec=3,flip;
        int round = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void Reset_time()
        {
            timer1.Interval = 1000; //一秒
            flip = 2;
        }
        private void Set_time()
        {
            timer1.Interval = 1000; //一秒
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            sec--;
            flip--;
            if (flip == 0)
            {
                display();
                fresh();
            }
            if(sec == 0)
            {
                gone();
                fresh();
            }
        }
        private void forze()
        {
            for (int i = 0; i < row_num; i++)
            {
                for (int j = 0; j < col_num; j++)
                {
                    button_array[i, j].Enabled = false;
                }
            }
        }
        private void fresh()
        {
            int exist_number = 0;
            for (int i = 0; i < row_num; i++)
            {
                for (int j = 0; j < col_num; j++)
                {
                    if (button_array[i, j].get_exist())
                    {
                        exist_number++;
                        button_array[i, j].Enabled = true;
                        button_array[i, j].hideNumber();
                    }
                }
            }
            if(exist_number <= row_num * col_num / 2)
            {
                display();
                end_game();
            }
        }
        private void end_game()
        {
            if (player1_score > player2_score)
            {
                DialogResult result = MessageBox.Show("P1獲勝","遊戲結束", MessageBoxButtons.OK);
                if (DialogResult.OK == result)
                {
                    System.Environment.Exit(0);
                }
            }
            else if(player1_score<player2_score)
            {
                DialogResult result = MessageBox.Show("P2獲勝", "遊戲結束", MessageBoxButtons.OK);
                if (DialogResult.OK == result)
                {
                    System.Environment.Exit(0);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("平手", "遊戲結束", MessageBoxButtons.OK);
                if (DialogResult.OK == result)
                {
                    System.Environment.Exit(0);
                }
            }
        }
        private void gone()
        {
            for (int i = 0; i < row_num; i++)
            {
                for (int j = 0; j < col_num; j++)
                {
                    button_array[i, j].hideNumber();
                }
            }
        }
        string filename = @"..\..\..\card.map";
        private void start_Click(object sender, EventArgs e)
        {
            mode = 1;
            StreamReader sr = new StreamReader(filename);
            string ch;
            char row = (char)sr.Read();
            if ((char)sr.Read() ==  ' ') ;
            char col = (char)sr.Read();

            round_show.Visible = true;
            player_next.Visible = true;
            P1_score.Visible = true;
            P2_score.Visible = true;

            button_array = new Card[row, col];
            start.Visible = false;
            row_num = (int)Char.GetNumericValue(row);
            string[] line = new string[row_num];
            col_num = (int)Char.GetNumericValue(col);

            ch = sr.ReadLine();           // 讀取一個字元資料

            for (int i = 0; i < row_num; i++) {
                ch = sr.ReadLine();
                string[] inputnum = ch.Split(' '); //輸入兩個以空白區隔的整數
                for (int j = 0; j < col_num; j++)
                {
                    try
                    {
                        button_array[i, j] = new Card();
                        button_array[i, j].set_number(int.Parse(inputnum[j]));
                        button_array[i, j].showNumber();
                        button_array[i, j].SetBounds(200 + 60 * j, 100 + 60 * i, 60, 60);
                        button_array[i, j].Visible = true;
                        Controls.Add(button_array[i, j]);
                        button_array[i, j].Click  += new EventHandler(this.Dynamic_Btn_Click);
                        button_array[i, j].BackColor = Color.Blue;
                        button_array[i, j].Enabled = false;
                    }
                    catch {

                    }
                }
            }
            sr.Close();
            timer1.Start();
            Set_time();
        }
        private void Dynamic_Btn_Click(object sender, EventArgs e)
        {

            Card player = (Card)(sender);
            player.showNumber();
            player.Enabled = false;
            if (islast == false) //機
            {
                round_card[0] = player;
                first = player.get_number();
                islast = true;
            }
            else{
                round_card[1] = player;
                last = player.get_number();
                check();
                islast = false;
            }
            if (islast == true)
            {
                if (round % 2 == 1)
                {
                    player_next.Text = "輪到P2";
                }
                else
                {
                    player_next.Text = "輪到P1";
                }
            }
        }  
        private void check()
        {
            forze(); //凍結所有
            Reset_time();
            //Thread.Sleep(2000);
            //display();
            //fresh();
        }
        void display()
        {
            if (round % 2 == 1) //奇數回
            {
                if (last > first)
                {
                    player2_score += last - first;
                    P2_score.Text = "P2: " + player2_score.ToString() + "分";
                    round_card[0].set_exist(false);
                    round_card[1].set_exist(false);
                    round_card[0].Visible = false;
                    round_card[1].Visible = false;
                }
            }
            else
            {
                if (last > first)
                {
                    player1_score += last - first;
                    P1_score.Text = "P1: " + player1_score.ToString() + "分";
                    round_card[0].set_exist(false);
                    round_card[1].set_exist(false);
                    round_card[0].Visible = false;
                    round_card[1].Visible = false;
                }
            }
            //Reset_time();
            round++;

            round_show.Text = "第" + round.ToString() + "回合";
            last = 0;
            first = 0;
            if (round % 2 == 1)
            {
                player_next.Text = "輪到P1";
            }
            else
            {
                player_next.Text = "輪到P2";
            }
        }
    }
}
