using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Player : Creature, attack, Talk
    {

        public override string getName()
        {
            return "player" ;
        }
        public void attack(Creature target) // 一定要是 public 
        {
            target.injured(20);
        }

        public string talkTo(Creature target)
        {
            return "Player talk-->" + target.getName();
        }
    }
}
