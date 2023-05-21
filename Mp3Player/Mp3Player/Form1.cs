using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
            {
                listBoxMusic.Items.Add(openFileDialog1.SafeFileNames[i].ToString());
                listBoxAdress.Items.Add(openFileDialog1.FileNames[i].ToString());
            }
        }

        private void listBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAdress.SelectedIndex = listBoxMusic.SelectedIndex;
            axWindowsMediaPlayer1.URL = listBoxAdress.SelectedItem.ToString();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            listBoxMusic.Items.Clear();
            listBoxAdress.Items.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
