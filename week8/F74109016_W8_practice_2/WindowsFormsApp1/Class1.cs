using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Role
    {
        public int A, B, C, D,role;
        public void set_role(int role)
        {
            this.role = role;
        }
        public int get_role()
        {
            return role;
        }
        /****棋子數量********************/
        public void setA(int A)
        {
            this.A = A;
        }
        public void setB(int B)
        {
            this.B = B;
        }
        public void setC(int C)
        {
            this.C = C;
        }
        public void setD(int D)
        {
            this.D = D;
        }
        public int getA()
        {
            return this.A;
        }
        public int getB()
        {
            return this.B;
        }
        public int getC()
        {
            return this.C;
        }
        public int getD()
        {
            return this.D;
        }
        /****棋子數量********************/
        public void changeA()
        {
            if (this.A - 1 != -1)
            {
                this.A--;
            }
        }
        public bool changeB()
        {
            this.B --;
            if (this.B == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool changeC()
        {
            this.C --;
            if (this.C == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool changeD()
        {
            this.D --;
            if (this.D == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

    public class Warrier : Role
    {
        public Warrier(int A, int B, int C, int D,int role)
        {
            setA(A);
            setB(B);
            setC(C);
            setD(D);
            set_role(role);
        }
    }
    public class Mage : Role
    {
        public Mage(int A, int B, int C, int D, int role)
        {
            setA(A);
            setB(B);
            setC(C);
            setD(D);
            set_role(role);
        }
    }
    public class Archer : Role
    {
        public Archer(int A, int B, int C, int D, int role)
        {
            setA(A);
            setB(B);
            setC(C);
            setD(D);
            set_role(role);
        }
    }
}
