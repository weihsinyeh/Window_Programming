using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Player : Creature, Iattack
    {

        public override string getName()
        {
            return "player" ;
        }
        public void Iattack(Creature target) // 一定要是 public 
        {
            target.injured(20);
        }
    }
}
