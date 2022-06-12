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
    public partial class Animale : Form
    {
        private Acasa frm2;
        public static int ascultari;
        public Animale()
        {
            InitializeComponent();
        }
        public Animale(string nume, Acasa f)
        {
            frm2 = f;
            InitializeComponent();
        }

        private void Animale_Load(object sender, EventArgs e)
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

        private void Caine(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioCaine);
            audio.Play();
            ascultari++;
        }

        private void Pisica(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioPisica);
            audio.Play();
            ascultari++;
        }

        private void Vaca(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioVaca);
            audio.Play();
            ascultari++;
        }

        private void Leu(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioLeu);
            audio.Play();
            ascultari++;
        }

        private void Girafa(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioGirafa);
            audio.Play();
            ascultari++;
        }

        private void Elefant(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioElefant);
            audio.Play();
            ascultari++;
        }
    }
}
