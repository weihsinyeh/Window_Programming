using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    abstract class Creature
    {
        protected int hp = 100;
        public virtual string say()
        {
            return "I am " + getName() + " I have " + hp;
        }
        public void injured(int damage)
        {
                    hp -= damage;
        }
        public abstract string getName();

    }
}
