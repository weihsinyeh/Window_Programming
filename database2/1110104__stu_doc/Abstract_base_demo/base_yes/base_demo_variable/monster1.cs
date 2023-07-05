using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_demo
{
    class Monster1 : Monster
    {
        public Monster1() 
        {
     //       hp = 200;
            base.hp = 300;  // base 使用來自 Monster 的變數
       
        }
       

    }
}
