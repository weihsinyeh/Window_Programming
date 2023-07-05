using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Simple
    {
        private int score;
        private int current_num;
        public int [] number_array = new int[3];
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
}
