using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_demo
{
    class Monster1 : Monster
    {
       public Monster1(string name ) : base("name")  //建立一個建構值 需要參數值
     //public Monster1() : base("test")  // Moster1 也可以不用傳任何參數, 給他一個固定值即可
        {
            //       hp = 200;
            base.hp = 300;  // base 使用來自 Monster 的變數
       
        }
       

    }
}
