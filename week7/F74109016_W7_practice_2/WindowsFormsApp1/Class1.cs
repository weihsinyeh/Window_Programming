using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp1
{
    public class Role
    {
        protected int property, fole_strong, fole_weak, speed;
        protected string text = "";
        protected System.Drawing.Color color;
        public void set_property(int property)
        {
            this.property = property;
        }
        public int get_property()
        {
            return this.property;
        }
        public void set_fole_strong(int fole_strong)
        {
            this.fole_strong = fole_strong;
        }
        public int get_fole_strong()
        {
            return this.fole_strong;
        }
        public void set_fole_weak(int fole_weak)
        {
            this.fole_weak = fole_weak;
        }
        public int get_fole_weak()
        {
            return this.fole_weak;
        }
        public void set_text(string text)
        {
            this.text = text;
        }
        public string get_text()
        {
            return text;
        }
        public void set_speed(int speed)
        {
            this.speed = speed;
        }
        public int get_speed()
        {
            return this.speed;
        }
        public void set_color(int property)
        {
            switch (property)
            {
                case 1:
                    color = System.Drawing.Color.Blue;
                    break;
                case 2:
                    color = System.Drawing.Color.Red;
                    break;
                case 3:
                    color = System.Drawing.Color.Green;
                    break;
            }
        }
        public System.Drawing.Color get_color()
        {
            return color;
        }
    }
    public class Role_water : Role
    {
        public Role_water()
        {
            set_fole_strong(3); //木
            set_fole_weak(2); //火
            set_property(1);
            set_text("水");
            set_speed(10);
            set_color(1);
        }
    }
    public class Role_fire : Role
    {
        public Role_fire()
        {
            set_fole_strong(1); //水
            set_fole_weak(3);   //木
            set_property(2);
            set_text("火");
            set_speed(20);
            set_color(2);
        }
    }
    public class Role_tree : Role
    {
        public Role_tree()
        {
            set_fole_strong(2); //火
            set_fole_weak(1);   //水
            set_property(3);
            set_text("木");
            set_speed(30);
            set_color(3);
        }
    }
}
