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
    public partial class Joc1 : Form
    {
        private Acasa frm2;
        Random rnd = new Random();
        string[] Operatii = {"adaugare", "scadere"};
        int total;
        public static int scor;

        public Joc1()
        {
            InitializeComponent();
            Game_start();
        }

        public Joc1(string nume, Acasa f)
        {
            frm2 = f;
            InitializeComponent();
            Game_start();
        }

        private void Joc1_Load(object sender, EventArgs e)
        {
            scor = 0;
            this.ControlBox = false;
        }

        private void Inapoi(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_inapoi);
            audio.Play();
            this.Hide();
            frm2.Show();
        }

        private void Verifica_raspuns(object sender, EventArgs e)
        {

        }

        private void Verificare(object sender, EventArgs e)
        {
            int userEntered = Convert.ToInt32(textBox1.Text);

            if (userEntered == total)
            {
                System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_corect);
                audio.Play();
                label1.Text = "Corect";
                label1.ForeColor = Color.Green;
                scor += 1;
                label3.Text = "Scor: " + scor;
                textBox1.Focus();
                Game_start();

            }
            else
            {
                System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_gresit1);
                audio.Play();
                MessageBox.Show("Raspunsul corect este " + Convert.ToString(total), "GRESIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label1.Text = "Incorect";
                label1.ForeColor = Color.Red;
            }
        }
        
        private void Game_start()
        {
            int numar1 = rnd.Next(10, 20);
            int numar2 = rnd.Next(0, 9);

            textBox1.Text = null;
            textBox1.Focus();

            switch(Operatii[rnd.Next(0, Operatii.Length)])
            {
                case "adaugare":
                    total = numar1 + numar2;
                    semn.Text = "+";
                    break;

                case "scadere":
                    total = numar1 - numar2;
                    semn.Text = "-";
                    break;

            }

            label_numar1.Text = numar1.ToString();
            label_numar2.Text = numar2.ToString();
        }
    }
}
