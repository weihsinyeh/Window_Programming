using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Monster :Creature , attack
    {
        public  override string say()
        {
            return "hp -->" + hp;
        }

        public override string getName()
        {
            return "Monster" ;
        }

        public void attack(Creature target) // 一定要是 public 
        {
            target.injured(35);
        }
    }
}
