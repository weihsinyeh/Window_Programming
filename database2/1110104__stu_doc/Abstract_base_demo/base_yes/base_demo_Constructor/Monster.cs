using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_demo
{
    abstract class Monster
    {
        protected int hp = 100;
        private string name;
        public Monster(string name)
        {
            this.name = name; // 指向 Monster 定義 name
        }

   
        public int getHp()
        {
            return hp;
        }


    }

}
