//F74109016 葉惟欣 week8 practice 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public class Card : System.Windows.Forms.Button
    {
        private int number;
        private bool exist = true;
        public void set_number(int number)
        {
            this.number = number;
        }
        public int get_number()
        {
            return number;
        }
        public void set_exist(bool exist)
        {
            this.exist = exist;
        }
        public bool get_exist()
        {
            return exist;
        }
        public void hideNumber()
        {
            this.Text = "";
        }
        public void showNumber()
        {
            this.Text = number.ToString();
        }
        
    }

}
