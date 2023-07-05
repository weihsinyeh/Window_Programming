//F74109016_W5_practice_2  葉惟欣
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
    public partial class Form1 : Form {
        bird elebird;                                               //宣告一個變數名為elebird的bird物件
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = true;                                 //開放元件
            button2.Enabled = false;                                //禁用元件
            button3.Enabled = false;                                //禁用元件
            button4.Enabled = false;                                //禁用元件
            button5.Enabled = false;                                //禁用元件
            button6.Enabled = false;                                //禁用元件
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //建立電子雞的物件
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                elebird = new bird( "電子雞");
            }
            else
            {
                elebird = new bird(textBox2.Text);
            }
            button1.Enabled = false;                               //禁用元件
            button2.Enabled = true;                                //開放元件
            button3.Enabled = true;                                //開放元件
            button4.Enabled = true;                                //開放元件
            button5.Enabled = true;                                //開放元件
            button6.Enabled = true;                                //開放元件
            state_change();                                        //數值狀態的改變顯示
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label2.Text = elebird.get_Money().ToString() + "元";
            label5.Text = elebird.get_Health().ToString()+"%";
            label7.Text = elebird.get_Weight().ToString()+"g";
            label9.Text = elebird.get_Satisfaction().ToString() + "%";
            label11.Text = elebird.get_Emotion().ToString() + "%";
            label13.Text = elebird.get_Event();
            textBox1.Text = elebird.get_Calendar();
        }

        private void button2_Click(object sender, EventArgs e)   //餵食
        {
            elebird.Feed();                                      //呼叫餵食
            state_change();                                      //數值狀態的改變顯示
        }

        private void button3_Click(object sender, EventArgs e)   //玩耍
        {
            elebird.Play();                                      //呼叫玩耍
            state_change();                                      //數值狀態的改變顯示
        }

        private void button4_Click(object sender, EventArgs e)   //打掃
        {
            elebird.Clean();                                     //呼叫清掃
            state_change();                                      //數值狀態的改變顯示
        }

        private void button5_Click(object sender, EventArgs e)   //看醫生
        {
            elebird.GoToDoctor();                                //呼叫看醫生
            state_change();                                      //數值狀態的改變顯示
        }

        private void button6_Click(object sender, EventArgs e)   //結束這天
        {
            elebird.end_day();                                   //呼叫結束這天的函數
            state_change();                                      //數值狀態的改變顯示
            if (elebird.get_IsDead())                            //如果已經死了，禁用所有按紐
            {
                button2.Enabled = false;                                //禁用元件
                button3.Enabled = false;                                //禁用元件
                button4.Enabled = false;                                //禁用元件
                button5.Enabled = false;                                //禁用元件
                button6.Enabled = false;                                //禁用元件
            }
        }
        /****************旁邊的數值與事件與日歷的改變********************************/
        private void state_change()
        {
            label2.Text = elebird.get_Money().ToString() + "元";        
            label5.Text = elebird.get_Health().ToString() + "%";
            label7.Text = elebird.get_Weight().ToString() + "g";
            label9.Text = elebird.get_Satisfaction().ToString() + "%";
            label11.Text = elebird.get_Emotion().ToString() + "%";
            label13.Text = elebird.get_Event();
            textBox1.Text = "";
            textBox1.AppendText (elebird.get_Calendar());
        }
    }
}
