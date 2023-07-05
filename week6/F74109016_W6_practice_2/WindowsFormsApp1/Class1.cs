//F74109016 葉惟欣 Homework#2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp1
{
    class Class1
    {
        public int Size = 12; // 字體大小
        public FontFamily Family; // 字型
        public FontStyle Style; // 風格(粗體、斜體)
        public ContentAlignment Alignment = ContentAlignment.TopLeft; // 字的位置(左中右)
        public int Y_Location = 9; //字的位置(上下)
        public System.Windows.Forms.Label ChangeLabel(System.Windows.Forms.Label label)  // 將label改變字體與位置
        {
            try
            {
                label.Font = new Font(Family, Size, Style);
                label.TextAlign = Alignment;
            }
            catch
            {

            }
            return label;
        }
        public void ChangeAlignment(int type)  // 改變 ContentAlignment
        {
            switch (type)
            {
                case 0: 
                    Alignment = ContentAlignment.TopLeft;
                    break;
                case 1:
                    Alignment = ContentAlignment.TopCenter;
                    break;
                case 2:
                    Alignment = ContentAlignment.TopRight;
                    break;
                case 3:
                    Alignment = ContentAlignment.BottomLeft;
                    break;
                case 4:
                    Alignment = ContentAlignment.BottomCenter;
                    break;
                case 5:
                    Alignment = ContentAlignment.BottomLeft;
                    break;
            }
        }
        public void ChangeFamily(string newFamily)  // 改變 FontFamily
        {
            if (string.IsNullOrEmpty(newFamily))
            {
                Family = new FontFamily("標楷體");
            }
            else
            {
                Family = new FontFamily(newFamily);
            }
        }
        public void ChangeStyle(bool bold, bool italic)// 改變 FontStyle
        {
            Style = FontStyle.Regular;
            if(bold == true)
            {
                Style = FontStyle.Bold;
            }
            if(italic == true)
            {
                Style = FontStyle.Italic;
            }
            if(italic == true&&bold == true)
            {
                Style = FontStyle.Bold | FontStyle.Italic;
            }
        }
        public void ChangeSize(int size)
        {
            this.Size = size;
        }
    }

}
