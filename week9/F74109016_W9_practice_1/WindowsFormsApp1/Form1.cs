using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public MusicPlayer music;
        public string[] musiclist;
        public RadioButton[] music_button = new RadioButton[4];
        public int number_music =0;
        public bool loop; //當還沒有音樂時就設定的且如果select的話還可以保留現在的狀況
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
            music = new MusicPlayer();
            music.set_loop(loop); //先設定之前的loop
            musiclist = music.SelectWavFiles();
            if (music.get_change_list() == true)
            {
                create();
            }
        }
        public void create()
        {
            if (music != null)
            {
                for (int i = 0; i < number_music; i++)
                {
                    music_button[i].Dispose();
                }
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
                        music_button[i].Location = new System.Drawing.Point(30, 50 + 30 * i);
                        music_button[i].CheckedChanged += new EventHandler(this.CheckedChangedHandle);
                        groupBox1.Controls.Add(music_button[i]);
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
                    if (music_button[i].Checked == true)
                    {
                        music.setMusicLocation(music_button[i].Text);
                    }
                }
            }
        }

        private void stop_button_Click(object sender, EventArgs e)
        {
            if (music != null)
            {
                music.stop();
            }
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            if (music != null)
            {
                music.play();
            }
        }

        private void loop_check_CheckedChanged(object sender, EventArgs e)
        {
            if (music != null)
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
    }
}
