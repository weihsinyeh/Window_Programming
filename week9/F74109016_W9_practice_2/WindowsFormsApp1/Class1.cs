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
        private bool change_list = false,change_load = false;
        private Form2 Spectrum;
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
            if (Spectrum != null)
            {
                Spectrum.Close();
            }
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
        public void set_change_load(bool change_load)
        {
            this.change_load = change_load;
        }
        public bool get_change_load()
        {
            return change_load;
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
                for (int i = 0; i < number_music; i++)
                {
                    Playlist[number_music] = "";
                }
                set_change_list(true);
                number_music = 0;
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
                    Spectrum = new Form2();
                    Spectrum.Show();
                }
                else
                {
                    this.Play();
                }
            }
        }
        public void stop()
        {
            if (Spectrum != null)
            {
                Spectrum.Close();
            }
            if (getMusicLocation() != "")
            {
                this.Stop();                                  // 停止播放
            }
        }
        public void save()
        {
            System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.Filter = "TXT(*.txt)|*.txt";
            saveFileDialog.Title = "Save an Image File";
            saveFileDialog.FileName = "新文字文件.txt";
            if (saveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))   //小寫TXT     
                    {
                        for (int i = 0; i < number_music; i++)
                        {
                            sw.WriteLine(Playlist[i]);
                        }
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("未輸入欲儲存的檔案名稱");
                }
            }
        }
        public string[] load()
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            //設相對路徑
            string CombinedPath = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "..\\..\\..\\");
            openFileDialog.InitialDirectory = System.IO.Path.GetFullPath(CombinedPath);
            String stFilter = "TXT(*.txt)|*.txt";
            openFileDialog.Filter = stFilter;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                stop();
                for (int i = 0; i < number_music; i++)
                {
                    Playlist[i] = "";
                }
                number_music = 0;
                set_change_load(true);
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                    {
                        number_music = 0;
                        string line = sr.ReadLine().Trim();
                        while(line != null) { 
                            Playlist[number_music] = line;
                            number_music++;
                            line = sr.ReadLine().Trim();
                        }
                    }
                }
                catch
                {
                }
            }
            set_number_music(number_music);
            return Playlist;
        }
    }
}
