using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ProiectInfoEducatie
{
    public partial class Legume : Form
    {
        //string nume = Acasa.numeUser;
        private Acasa frm2;
        public static int ascultari;
        public Legume()
        {
            InitializeComponent();
        }

        public Legume(string nume, Acasa f)
        {
            frm2 = f;
            InitializeComponent();
        }
        private void Legume_Load(object sender, EventArgs e)
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

        private void Rosii(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioRosii); 
            audio.Play();
            ascultari++;
        }

        private void Ardei(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioArdei);
            audio.Play();
            ascultari++;
        }

        private void Cartofi(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioCartof);
            audio.Play();
            ascultari++;
        }

        private void Castraveti(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioCastraveti);
            audio.Play();
            ascultari++;
        }

        private void Conopida(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioConopida);
            audio.Play();
            ascultari++;
        }

        private void Morcovi(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audioMorcovi);
            audio.Play();
            ascultari++;
        }
    }
}
