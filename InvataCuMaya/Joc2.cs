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
    public partial class Joc2 : Form
    {
        private Acasa frm2;
        bool click = false;
        PictureBox poza1;
        Random rnd = new Random();
        Timer timerClick=new Timer();
        int time = 60;
        Timer tmr = new Timer { Interval = 1000 };
        public static int scor = 0;
        public Joc2(string nume, Acasa f)
        {
            frm2 = f;
            InitializeComponent();
        }

        public Joc2()
        {
            InitializeComponent();
        }

        private void Joc2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.cirese,
                    Properties.Resources.pepene,
                    Properties.Resources.caine,
                    Properties.Resources.pisica,
                    Properties.Resources.morcov,
                    Properties.Resources.rosie,
                    Properties.Resources.mov,
                    Properties.Resources.albastru_,
                };
            }
        }

        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }

        private void clickTimer(object sender, EventArgs e)
        {
            AscundeImagini();
            click = true;
            timerClick.Stop();
        }

        private void AscundeImagini()
        {
            foreach(var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.semn_intrebare;
            }
        }

        private PictureBox Imag()
        {
            int num;
            do
            {
                num = rnd.Next(0, pictureBoxes.Count());
            }while(pictureBoxes[num].Tag != null);

            return pictureBoxes[num];
        }

        private void ImaginiRandom()
        {
            foreach(var image in images)
            {
                Imag().Tag = image;
                Imag().Tag = image;
            }
        }

        private void ResetImagini()
        {
            foreach(var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }

            AscundeImagini();
            ImaginiRandom();
            time = 60;
            tmr.Start();
        }

        private void startTimer()
        {
            tmr.Start();
            tmr.Tick += delegate
            {
                time--;
                if (time < 0)
                {
                    tmr.Stop();
                    System.Media.SoundPlayer audio2 = new System.Media.SoundPlayer(Properties.Resources.audio_gresit1);
                    audio2.Play();
                    MessageBox.Show("Timpul s-a scurs!", "AI PIERDUT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ResetImagini();
                }
                var ssTimp = TimeSpan.FromSeconds(time);
                label2.Text = "00: " + time.ToString();
            };
        }

        private void clickImagine(object sender, EventArgs e)
        {
            if (!click)
                return;
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            var img = (PictureBox)sender;

            if(poza1 == null)
            {
                poza1 = img;
                img.Image = (Image)img.Tag;
                return;
            }

            img.Image= (Image)img.Tag;

            if(img.Image==poza1.Image && img!=poza1)
            {
                img.Visible = poza1.Visible = false;
                poza1 = img;
                AscundeImagini();
            }

            else
            {
                click = false;
                timerClick.Start();
            }

            poza1 = null;
            if (pictureBoxes.Any(p => p.Visible))
                return;
            System.Media.SoundPlayer audio1 = new System.Media.SoundPlayer(Properties.Resources.audio_corect);
            audio1.Play();
            MessageBox.Show("Ai castigat!", "FELICITARI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tmr.Stop();
            scor = 100;
        }

        private void startJoc(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_start);
            audio.Play();
            click = true;
            ImaginiRandom();
            AscundeImagini();
            startTimer();
            timerClick.Interval = 1000;
            timerClick.Tick += clickTimer;
            button2.Enabled = false;
        }

        private void Inapoi(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_inapoi);
            audio.Play();
            tmr.Stop();
            this.Hide();
            frm2.Show();
        }

    }
}
