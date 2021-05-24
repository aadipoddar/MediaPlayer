using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        //create global variables of string type array to save the titles or name of the tracks and path of th track
        String[] paths, files;

        private void btnSelectSongs_Click(object sender, EventArgs e)
        {
            //code to select songs
            OpenFileDialog ofd = new OpenFileDialog();

            //code to select multiple file
            ofd.Multiselect = true; 

            if(ofd.ShowDialog()== System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;//save the names of track in files array
                paths = ofd.FileNames;//save the paths of the tracks in path array

                //display the music title in list box
                for(int i = 0; i<files.Length;i++)
                {
                    listBoxSongs.Items.Add(files[i]);//display songs in listbox
                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //write a code to play music
            axWindowsMediaPlayerMusic.URL = paths[listBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //code to close the app
            this.Close();
        }
    }
}
