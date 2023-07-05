using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Monster :Creature , Iattack
    {
        public  override string say()
        {
            return "hp -->" + hp;
        }

        public override string getName()
        {
            return "Monster" ;
        }

        public void Iattack(Creature target) // 一定要是 public 
        {
            target.injured(35);
        }
    }
}
