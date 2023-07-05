using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Monster
    {
        protected int hp = 100;
        private string name;
        public Monster(string name)
        {
            this.name = name;
        }

        //   public string attack()   // method  
        //    {
        //       return name + "attack!!";  //含內容
        //    }

        public abstract string attack();  // abstract method  不含內容 
   
    }

}
