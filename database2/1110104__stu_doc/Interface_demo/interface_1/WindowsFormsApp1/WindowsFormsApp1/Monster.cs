using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Monster :Creature
    {
        public  override string say()
        {
            return "hp -->" + hp;
        }

        public override string getName()
        {
            return "Monster" ;
        }
    }
}
