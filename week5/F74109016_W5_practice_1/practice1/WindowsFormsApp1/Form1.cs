//F74109016_week5_practice_1 葉惟欣 資訊113
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
        public string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz"; //原本的字母對應表
        public string Alphabet_new = "";                                                 //新的字母對應表
        public int state;                                                                //狀態的改變
        int counter = 0;                                                                 //替換表產生確認的次數
        cipher table_create;                                                             //宣告table_create 為類別cipher的物件
        /************************************建構子************************************/
        public Form1()
        {
            InitializeComponent();
            table_create = new cipher();              //table_create new出一個物件
            label4.Visible = false;                   //先隱藏
            label5.Visible = false;
            textBox2.Visible = false;                 //輸入字串的先隱藏
            textBox3.Visible = false;                 //歷史紀錄先隱藏
            button7.Visible = true;                   //確認顯示
            //state 1:替換表  state 2:加密  state 3:解密
            state = 1; 
        }

        private void button6_Click(object sender, EventArgs e)                //按下隨機生成後，隨機產生替換表，但並未儲存
        {
            button7.Visible = true;                                           //確認顯示
            textBox1.Text = table_create.Generate();                          //將隨機產生的字母對應表放到新的字母對應表
            //但並未儲存可以自行修改 TextBox 內容
        }
        /*******************************************按下確認button*******************************************************/
        private void button7_Click(object sender, EventArgs e)                //確認鍵 當確認新的替換表、加密字串、解密字串，皆須增加紀錄到 textbox 中
        {
            switch (state) {
                /**********************************產生替換表*************************************************************************************/
                case 1:                                                      //當是state = 1是在替換表的介面，此時的確認是驗證是否有 1 對 1 對應到每個英文字母
                    if (counter != 0)
                    {
                        textBox3.Text += Environment.NewLine;                 //換行
                    }
                    if (table_create.IsValid(textBox1.Text))                  //合法時
                    {
                        Alphabet_new = textBox1.Text;                         //如果合法，就儲存該字串，更新新的字母對應表
                        label3.Text = "合法替換表";                           //顯示是合法的替換表
                        counter++;                                            //第幾次產生合法替換表
                        textBox3.Text += "新的替換表" + Environment.NewLine + textBox1.Text + Environment.NewLine; //歷史紀錄會更新 (※ 初始的替換表也須加到歷史紀錄中)
                    }
                    else
                    {
                        label3.Text = "替換表不合法，請重新輸入";
                    }
                    break;
                /**********************************加密*************************************************************************************/
                case 2:                                                       //當是state = 2是在加密的介面，此時的確認是確認是否要加密輸入的字串
                    textBox1.Text = table_create.Encrypt(textBox2.Text);      //先加密輸入的字串，再將他放入textBox1裡面。
                    //歷史紀錄會更新將明文和密文記錄到歷史紀錄中
                    textBox3.Text += "\r\n加密\r\n";               
                    textBox3.Text += "明文:" + textBox2.Text + "\r\n";
                    textBox3.Text += "密文:" + textBox1.Text + "\r\n";
                    break;
                /**********************************解密*************************************************************************************/
                case 3:                                                       //當是state = 3是在加密的介面，此時的確認是確認是否要解密輸入的字串
                    textBox1.Text = table_create.Decrypt(textBox2.Text);      //先解密輸入的字串，再將他放入textBox1裡面。
                    //歷史紀錄會更新將明文和密文記錄到歷史紀錄中
                    textBox3.Text += "\r\n解密\r\n";
                    textBox3.Text += "密文:" + textBox2.Text + "\r\n";
                    textBox3.Text += "明文:" + textBox1.Text + "\r\n";
                    break;
            }
            
        }
        
        /**********************按下加密button******************************************************/
        private void button2_Click(object sender, EventArgs e)               //按下加密的button
        {
            label1.Text = "加密";                                            //加密
            label1.Visible = true;                                           //顯示加密
            label2.Visible = false;                                          //將原始字母對應表隱藏
            label4.Visible = true;                                           //輸入字串不隱藏
            //加密結果不隱藏
            label5.Text = "加密結果";
            label5.Visible = true;

            //輸入字串的文字框是沒有東西先不隱藏
            textBox1.Text = "";                                              
            textBox1.Visible = true;

            //輸出字串的文字框是沒有東西先不隱藏
            textBox2.Text = "";
            textBox2.Visible = true;                                         
                                          
            textBox3.Visible = false;                                        //歷史紀錄隱藏
            button6.Visible = false;                                         //隨機生成隱藏
            button7.Visible = true;                                          //確認顯示
            label3.Visible = false;                                          //合不合法的lable隱藏
            state = 2;                                                       //狀態改為2 加密
        }

        private void label2_VisibleChanged(object sender, EventArgs e)
        {

        }
        /**********************按下解密button******************************************************/
        private void button3_Click(object sender, EventArgs e)               //按下解密的button
        {
            label1.Text = "解密";                                            //解密
            label1.Visible = true;                                           //顯示解密
            label2.Visible = false;                                          //將原始字母對應表隱藏
            label4.Visible = true;                                           //輸入字串不隱藏
            //解密結果不隱藏
            label5.Text = "解密結果";
            label5.Visible = true;

            //輸入字串的文字框是沒有東西先不隱藏
            textBox1.Text = "";
            textBox1.Visible = true;

            //輸出字串的文字框是沒有東西先不隱藏
            textBox2.Text = "";
            textBox2.Visible = true;

            textBox3.Visible = false;                                        //歷史紀錄隱藏
            button6.Visible = false;                                         //隨機生成隱藏
            button7.Visible = true;                                          //確認顯示
            label3.Visible = false;                                          //合不合法的lable隱藏
            state = 3;                                                       //狀態改為3 解密
        }
        /**********************************歷史紀錄*************************************************************************************/
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = "歷史紀錄";                                        //歷史紀錄
            label1.Visible = true;                                           //顯示歷史紀錄
            label2.Visible = false;                                          //將原始字母對應表隱藏 
            label4.Visible = false;                                          //輸入字串隱藏
            label5.Visible = false;                                          //結果隱藏
            textBox1.Visible = false;                                        //輸入字串的文字框先隱藏
            textBox2.Visible = false;                                        //輸出字串的文字框先隱藏

            textBox3.Visible = true;                                         //歷史紀錄顯示剛剛每次的行動

            button6.Visible = false;                                         //隨機生成隱藏
            button7.Visible = false;                                         //確認隱藏
            label3.Visible = false;                                          //合不合法的lable隱藏
        }
        private void button1_Click(object sender, EventArgs e)
        {                                                                
            label1.Text = "替換表";                                          //替換表
            label1.Visible = true;                                           //顯示替換表
            label2.Visible = true;                                           //將原始字母對應表顯示                                           
            label3.Visible = true;                                           //替換表合不合法的顯示 
            label4.Visible = false;                                          //輸入字串隱藏
            label5.Visible = false;                                          //結果隱藏
            //顯示原始的字串框
            textBox1.Text = Alphabet_new;
            textBox1.Visible = true;  
            
            textBox2.Visible = false;                                        //輸出字串的文字框先隱藏
            textBox3.Visible = false;                                        //歷史紀錄顯示
            button6.Visible = true;                                          //隨機生成隱藏
            button7.Visible = true;                                          //確認顯示
            state = 1;                                                       //狀態為1是替換表
        }
    }
}
