using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public MusicPlayer music;
        public string[] musiclist;
        public RadioButton[] music_button = new RadioButton[4];
        public int number_music =0;
        public bool loop; //當還沒有音樂時就設定的且如果select的話還可以保留現在的狀況
        public Color fontcolor = System.Drawing.Color.Black;
        public Font fontfont = DefaultFont;
        bool isexist = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void select_button_Click(object sender, EventArgs e)
        {
            if (music != null)
            {
                music.stop();
            }
            else
            {
                music = new MusicPlayer();
            }
            music.set_loop(loop); //先設定之前的loop
            musiclist = music.SelectWavFiles();
            if (music.get_change_list() == true)
            {
                isexist = true;
                create();
            }
        }
        public void create()
        {
           for (int i = 0; i < number_music; i++)
           {
                    music_button[i].Dispose();
           }
           
            number_music = music.get_number_music();
            for(int i= 0 ; i < number_music ;i++)
            {
                try
                {
                    if (musiclist[i] != "")
                    {
                        music_button[i] = new RadioButton();
                        music_button[i].Text = musiclist[i];
                        music_button[i].Enabled = true;
                        music_button[i].Visible = true;
                        music_button[i].AutoSize = true;
                        if (i == 0)
                        {
                            music_button[i].Location = new System.Drawing.Point(30, 50 + music_button[i].Height * i);
                        }
                        else
                        {
                            music_button[i].Location = new System.Drawing.Point(30, music_button[i-1].Bottom);
                        }
                        music_button[i].CheckedChanged += new EventHandler(this.CheckedChangedHandle);
                        groupBox1.Controls.Add(music_button[i]);
                        change_color();
                        change_font();
                    }
                }
                catch
                {
                }
            }
        }
        private void CheckedChangedHandle(object sender, EventArgs e)
        {
            if (music != null)
            {
                music.stop();
                for (int i = 0; i < number_music; i++)
                {
                    if(music_button[i].Checked == true)
                    {
                        music.setMusicLocation(music_button[i].Text);
                    }
                }
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            if (music != null && isexist == true)
            {
                music.stop();
            }
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            if (music != null&& isexist == true)
            {
                music.play();
            }
        }

        private void loop_check_CheckedChanged(object sender, EventArgs e)
        {
            if (music != null&& isexist == true)
            {
                if (loop_check.Checked == true)
                {
                    music.set_loop(true);
                    loop = true; //因為如果select的話還可以保留現在的狀況
                }
                else
                {
                    music.set_loop(false);
                    loop = false; //因為如果select的話還可以保留現在的狀況
                }
            }
            else
            {
                if (loop_check.Checked == true)
                {
                    loop =true ;
                }
                else
                {
                    loop = false;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (music != null&& isexist==true)
            {
                music.save();
            }
            else
            {
                MessageBox.Show("請先建立撥放清單");
            }
            
        }
        private void load_Click(object sender, EventArgs e)
        {
            if (music != null)
            {
                music.load();
            }
            else
            {
                music = new MusicPlayer();
                music.set_loop(loop); //先設定之前的loop
                musiclist = music.load();
            }
            if (music.get_change_load() == true)
            {
                create();
            }
        }


        private void change_color()
        {
            for (int i = 0; i < number_music; i++)
            {
                music_button[i].ForeColor = fontcolor;
            }
        }
        private void change_font()
        {
            for (int i = 0; i < number_music; i++)
            {
                music_button[i].Font = fontfont;
                if (i == 0)
                {
                    music_button[i].Location = new System.Drawing.Point(30, 50 + music_button[i].Height * i);
                }
                else
                {
                    music_button[i].Location = new System.Drawing.Point(30, music_button[i - 1].Bottom);
                }
            }
        }

        private void color_Click(object sender, EventArgs e)
        {
            if (music != null&&isexist == true)
            {
                if (colorDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    fontcolor = colorDialog1.Color;
                    change_color();
                }
            }
        }

        private void font_Click(object sender, EventArgs e)
        {
            if (music != null && isexist == true)
            {
                if (fontDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    fontfont = fontDialog1.Font;
                    change_font();
                }
            }
        }

        
    }
}
