using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApp1
{
    class Chess : System.Windows.Forms.Button
    {
        public int player, role,row,col;
        public Chess()
        {
        }
        public void set_player(int player)
        {
            this.player = player;
        }
        public int get_player()
        {
            return player;
        }
        public void set_role(int role)
        {
            this.role = role;
        }
        public void set_row(int row)
        {
            this.row = row;
        }
        public void set_col(int col)
        {
            this.col = col;
        }
        public int get_row()
        {
            return this.row;
        }
        public int get_col()
        {
            return this.col;
        }
        public void set() {
                if (role == 1)
                {
                    if (player == 1)
                    {
                        this.BackColor = System.Drawing.Color.DeepSkyBlue;
                    }
                    else
                    {
                        this.BackColor = System.Drawing.Color.Orange;
                    }
                }
                else if (role == 2)
                {
                    if (player == 1)
                    {
                        this.BackColor = System.Drawing.Color.DarkBlue;
                    }
                    else
                    {
                        this.BackColor = System.Drawing.Color.DarkOrange;
                    }
                }
                else
                {
                    if (player == 1)
                    {
                        this.BackColor = System.Drawing.Color.BlueViolet;
                    }
                    else
                    {
                        this.BackColor = System.Drawing.Color.OrangeRed;
                    }
                }
        }
    }
}
