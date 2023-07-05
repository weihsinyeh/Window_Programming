using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Monster1 : Monster
    {
        public Monster1(): base("test")
        {
            hp = 200;
        }
      public override string attack()
        {
            return "monster1 attack";
        }

    }
}
