using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;   //引用System.IO命名空間
using System.Media;
namespace WindowsFormsApp1
{
    public class MusicPlayer : SoundPlayer
    {
        public bool loop = false;
        public string[] Playlist = new string[4];
        private int number_music=0;
        private bool change_list = false;
        public void set_loop(bool loop)
        {
            this.loop = loop;
        }
        public bool get_loop()
        {
            return loop;
        }
        public void setMusicLocation(string path)
        {
            this.SoundLocation = path;
        }
        public string getMusicLocation()
        {
            return this.SoundLocation;
        }
        public void set_change_list(bool change_list)
        {
            this.change_list = change_list;
        }
        public bool get_change_list()
        {
            return this.change_list;
        }
        public string[] SelectWavFiles()
        {
            
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            //設相對路徑
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\Wavs");
            openFileDialog.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);
            String stFilter = "WAV(*.wav)|*.wav";
            openFileDialog.Filter = stFilter;
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                number_music = 0;
                set_change_list(true);
                foreach (String file in openFileDialog.FileNames)
                {
                    try
                    {
                        Playlist[number_music] = file;
                        number_music++;
                    }
                    catch
                    {
                    }
                }
            }
            set_number_music(number_music);
            return Playlist;
        }
        public void set_number_music(int number_music)
        {
            this.number_music = number_music;
        }
        public int get_number_music()
        {
            return this.number_music;
        }
        public void play()
        {
            if (getMusicLocation() != "")
            {
                this.Load();
                if (get_loop() == true)
                {
                    this.PlayLooping();
                }
                else
                {
                    this.Play();
                }
            }
        }
        public void stop()
        {
            if (getMusicLocation() != "")
            {
                this.Stop();                                  // 停止播放
            }
        }
    }
}
