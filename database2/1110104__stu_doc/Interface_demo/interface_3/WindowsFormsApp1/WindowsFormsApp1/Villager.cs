using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Villager : Creature
    {
        public override string getName()
        {
            return "Villager";
        }
        public string talkTo(Creature target)
        {
            return "Villager name-->" + target.getName();
        }
    }
}
