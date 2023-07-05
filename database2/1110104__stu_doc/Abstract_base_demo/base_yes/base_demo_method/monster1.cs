using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_demo
{
    class Monster1 : Monster
    {

       
        public override string introduceSelf()
        {
            return base.introduceSelf() + "+ I am monster1"; // 利用 base 取得 Monster 的 method
        }
    }
}
