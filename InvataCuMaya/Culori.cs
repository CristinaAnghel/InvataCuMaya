using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectInfoEducatie
{
    public partial class Culori : Form
    {
        private Acasa frm2;
        public static int ascultari;
        public Culori()
        {
            InitializeComponent();
        }

        public Culori(string nume, Acasa f)
        {
            frm2 = f;
            InitializeComponent();
        }

        private void Culori_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void Inapoi(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_inapoi);
            audio.Play();
            this.Hide();
            frm2.Show();
        }

        private void Rosu(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioRosu);
            audio.Play();
            ascultari++;
        }

        private void Albastru(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioAlbastru);
            audio.Play();
            ascultari++;
        }

        private void Galben(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioGalben);
            audio.Play();
            ascultari++;
        }

        private void Verde(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioVerde);
            audio.Play();
            ascultari++;
        }

        private void Portocaliu(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioPortocaliu);
            audio.Play();
            ascultari++;
        }

        private void Mov(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioMov);
            audio.Play();
            ascultari++;
        }
    }
}
