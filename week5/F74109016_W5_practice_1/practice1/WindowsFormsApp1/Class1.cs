//F74109016_week5_practice_1 葉惟欣 資訊113
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace WindowsFormsApp1
{
    class cipher
    {
        public string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        char[] origintable = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        public string Substitution = "";
        char[] randon_table = new char[52];
        public cipher(){
        }
        /*******************************產生隨機字母對應表******************************************/
        public String Generate()
        {
            Substitution = "";                                        //新的字母對應表
            Random myObject = new Random();                           //隨機的物件
            for (int i = 0; i < 52; i++)
            {
                int test;                                             //測試值
                do
                {
                    test = myObject.Next(0, 52);                      //測試值為隨機數
                } while (Substitution.Contains(origintable[test]));   //如果新的字母對應表目前含有原本字母對應表index為test的字元則再重新產生隨機數
                Substitution += origintable[test];                    //將字母對應表index為test的字元放入新的字母對應表(字串)
                randon_table[i] = origintable[test];                  //將字母對應表index為test的字元放入新的字母對應表(陣列)
            }
            return Substitution;                                      //回傳新的字母對應表
        }
        /**********************************看生成的字母對應表是否合法****************************/
        public bool IsValid(String crypto)
        {
            if (crypto.Length != 52)             //當字母對應表不是52個直接不合法
            {
                return false;                    //回傳不合法
            }
            randon_table = new char[52];         //想自行產生字母對應表
            //如果有人想自行修改或產生字母對應表，需要將文字框裡的字串放入陣列裡
            for (int i = 0; i < 52; i++)         
            {
                try
                {
                    randon_table[i] = char.Parse(crypto.Substring(i, 1));      
                }
                catch (ArgumentOutOfRangeException)
                {
                    return false;
                }
            }
            bool[] reasonable = Enumerable.Repeat(false, 52).ToArray();       //存放每個字母是否存在原本的陣列的布林值，先預設為false
            for (int i = 0; i < 52; i++)
            {
                for (int j = 0; j < 52; j++)
                {
                    if (randon_table[i] == origintable[j])                    //如果字串有出限在52個英文字母裡面，就將英文字母的陣列設為true，意思為存在。
                    {
                        reasonable[j] = true;                                 //如果有對應到字母就設為true
                        break;                                                //直接break不用再比對下去了
                    }
                }
            }
            for (int i = 0; i < 52; i++)
            {
                if ((reasonable[i] == false))                                 //如果有英文字母還沒被改為true，代表字母對應表並未產生全部的字母，且因為只產生52個字元陣列
                {                                                             //且因為只產生52個字元陣列，所以如果有多出去也沒差，只看前52個的。
                    return false;                                             //如果有字母沒有被對應到就傳回不合法
                }
            }
            return true;                                                      //傳回合法
        }
        /**********************************加密****************************/
        public String Encrypt(String text)
        {
            char[] inputtext2 = new char[text.Length];                        //輸入原文的欲加密字元陣列
            char[] outputtext2 = new char[text.Length];                       //輸出加密後的密文字元陣列
            //將傳入的原文字串放入原文的欲加密字元陣列
            for (int i = 0; i < text.Length; i++)
            {
                try
                {
                    inputtext2[i] = char.Parse(text.Substring(i, 1));
                }
                catch (ArgumentOutOfRangeException)
                {
                    return "超出界線";
                }
            }
            string output2 = "";                                              //輸出加密後的密文字串
            //產生密文的字元陣列與密文字串
            for (int i = 0; i < inputtext2.Length; i++)
            {
                //如果不是空白鍵
                if (inputtext2[i] != ' ')                                     
                {
                    for (int j = 0; j < 52; j++)
                    {
                        try
                        {
                            if (inputtext2[i] == origintable[j])             //如果加密字元陣列的某個index元素有對應到原始的字母對應表的另某個index
                            {
                                output2 += randon_table[j];                  //將新的字母對應表的另某個index加入密文字串
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            return "超出界線";
                        }
                    }
                }
                //如果是空白鍵，密文也直接是空白鍵
                else
                {
                    output2 += ' ';
                }
            }
            return output2;                                                  //傳回加密字串
        }
        /**********************************解密****************************/
        public String Decrypt(String text)                                 
        {
            char[] inputtext3 = new char[text.Length];                       //輸入解文的欲解密字元陣列
            char[] outputtext3 = new char[text.Length];                      //輸出解密後的原文字元陣列
            //將傳入的密文字串放入密文的欲解密字元陣列
            for (int i = 0; i < text.Length; i++)
            {
                try
                {
                    inputtext3[i] = char.Parse(text.Substring(i, 1));
                }
                catch (ArgumentOutOfRangeException)
                {
                    return "超出界線";
                }
            }
            string output3 = "";                                             //輸出解密後的文文字串
            //產生原文的字元陣列與密文字串
            for (int i = 0; i < inputtext3.Length; i++)
            {
                //如果不是空白鍵
                if (inputtext3[i] != ' ')
                {
                    for (int j = 0; j < randon_table.Length; j++)
                    {
                        try
                        {
                            if (inputtext3[i] == randon_table[j])            //如果解密字元陣列的某個index元素有對應到新產生的字母對應表的另某個index
                            {
                                output3 += origintable[j];                   //將原始的字母對應表的另某個index加入原文字串
                            }
                        }
                        catch (IndexOutOfRangeException)
                        {
                            return "超出界線";
                        }
                    }
                }
                //如果是空白鍵，密文也直接是空白鍵
                else
                {
                    output3 += ' ';
                }
            }
            return output3;                                              //傳回解密字串
        }
    }
}
