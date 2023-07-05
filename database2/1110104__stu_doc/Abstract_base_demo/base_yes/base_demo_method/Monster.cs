using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_demo
{
    abstract class Monster
    {

        private string name;


        public virtual string introduceSelf()  // virtual 這個 method 可以被改寫 (使用 override)
        {
            return "I am Monster";
        }
    }

}
