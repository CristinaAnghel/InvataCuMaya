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
    public partial class Fructe : Form
    {
        private Acasa frm2;
        public static int ascultari;
        public Fructe()
        {
            InitializeComponent();
        }

        private void Fructe_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        public Fructe(string nume, Acasa f)
        {
            frm2 = f;
            InitializeComponent();
        }

        private void Inapoi(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_inapoi);
            audio.Play();
            this.Hide();
            frm2.Show();
        }

        private void Mere(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioMere);
            audio.Play();
            ascultari++;
        }

        private void Pere(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioPere);
            audio.Play();
            ascultari++;
        }

        private void Cirese(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioCirese);
            audio.Play();
            ascultari++;
        }

        private void Capsuni(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioCapsuni);
            audio.Play();
            ascultari++;
        }

        private void Portocale(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioPortocale);
            audio.Play();
            ascultari++;
        }

        private void Pepene(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioPepene);
            audio.Play();
            ascultari++;
        }
    }
}
