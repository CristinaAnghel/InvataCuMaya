using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProiectInfoEducatie
{
    public partial class Magazin : Form
    {
        private Acasa frm2;
        public static int bani;
        public static int par =1;
        public static int haina =1;
        public static int maro = 1;
        public static int albastru = 1;
        public static int galben = 1;
        public static int salopeta = 1;
        public static int rosu = 1;
        public static int baniDati;
        string Nume;

        public Magazin()
        {
            InitializeComponent();
        }

        public Magazin(string nume, Acasa f)
        {
            frm2 = f;
            Nume = nume;
            InitializeComponent();
        }

        private void Inapoi(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_inapoi);
            audio.Play();
            this.Hide();
            frm2.Show();
        }

        private void Magazin_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            baniDati = 0;
            maro = Convert.ToInt32(File.ReadAllText(Nume + "_areMaro.txt"));
            salopeta= Convert.ToInt32(File.ReadAllText(Nume + "_areSalopeta.txt"));
            galben = Convert.ToInt32(File.ReadAllText(Nume + "_areGalben.txt"));
            rosu= Convert.ToInt32(File.ReadAllText(Nume + "_areRosu.txt"));
            albastru= Convert.ToInt32(File.ReadAllText(Nume + "_areAlbastru.txt"));
            bani = Convert.ToInt32(File.ReadAllText(Nume + "_total.txt"));
            label_total.Text=Convert.ToString(bani);
            if (maro == 0)
            {
                cump_maro.Hide();
                util_maro.Show();
                pret_maro.Hide();
                b_maro.Hide();
            }
            else
            {
                cump_maro.Show();
                util_maro.Hide();
            }

            if (albastru == 0)
            {
                cump_albastru.Hide();
                util_albastru.Show();
                pret_albastru.Hide();
                b_albastru.Hide();
            }
            else
            {
                cump_albastru.Show();
                util_albastru.Hide();
            }

            if (galben == 0)
            {
                cump_galben.Hide();
                util_galben.Show();
                pret_galben.Hide();
                b_galben.Hide();
            }
            else
            {
                cump_galben.Show();
                util_galben.Hide();
            }

            if (salopeta == 0)
            {
                cump_salopeta.Hide();
                util_salopeta.Show();
                pret_salopeta.Hide();
                b_salopeta.Hide();
            }
            else
            {
                cump_salopeta.Show();
                util_salopeta.Hide();
            }

            if (rosu == 0)
            {
                cump_rosu.Hide();
                util_rosu.Show();
                pret_rosu.Hide();
                b_rosu.Hide();
            }
            else
            {
                cump_rosu.Show();
                util_rosu.Hide();
            }
        }

        private void Cumpara_maro(object sender, EventArgs e)
        {
            if (bani >= 1000)
            {
                System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_cumpara);
                audio.Play();
                bani -= 1000;
                cump_maro.Hide();
                util_maro.Show();
                pret_maro.Hide();
                b_maro.Hide();
                label_total.Text = Convert.ToString(bani);
                maro = 0;
                baniDati += 1000;
                using (StreamWriter writeText = new StreamWriter(Nume + "_areMaro.txt"))
                {
                    writeText.WriteLine(maro.ToString());
                }

            }
            else
                MessageBox.Show("Nu ai bani suficienti!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Cumpara_rosu(object sender, EventArgs e)
        {
            if (bani >= 1600)
            {
                System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_cumpara);
                audio.Play();
                bani -= 1600;
                cump_rosu.Hide();
                util_rosu.Show();
                pret_rosu.Hide();
                b_rosu.Hide();
                label_total.Text = Convert.ToString(bani);
                rosu = 0;
                baniDati += 1600;
                using (StreamWriter writeText = new StreamWriter(Nume + "_areRosu.txt"))
                {
                    writeText.WriteLine(rosu.ToString());
                }
            }
            else
                MessageBox.Show("Nu ai bani suficienti!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Cumpara_salopeta(object sender, EventArgs e)
        {
            if (bani >= 1200)
            {
                System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_cumpara);
                audio.Play();
                bani -= 1200;
                cump_salopeta.Hide();
                util_salopeta.Show();
                pret_salopeta.Hide();
                b_salopeta.Hide();
                label_total.Text = Convert.ToString(bani);
                salopeta = 0;
                baniDati += 1200;
                using (StreamWriter writeText = new StreamWriter(Nume + "_areSalopeta.txt"))
                {
                    writeText.WriteLine(salopeta.ToString());
                }
            }
            else
                MessageBox.Show("Nu ai bani suficienti!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void Cumpara_galben(object sender, EventArgs e)
        {
            if (bani >= 1100)
            {
                System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_cumpara);
                audio.Play();
                bani -= 1100;
                cump_galben.Hide();
                util_galben.Show();
                pret_galben.Hide();
                b_galben.Hide();
                label_total.Text = Convert.ToString(bani);
                galben = 0;
                baniDati += 1100;
                using (StreamWriter writeText = new StreamWriter(Nume + "_areGalben.txt"))
                {
                    writeText.WriteLine(salopeta.ToString());
                }
            }
            else
                MessageBox.Show("Nu ai bani suficienti!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Cumpara_albastru(object sender, EventArgs e)
        {
            if (bani >= 700)
            {
                System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_cumpara);
                audio.Play();
                bani -= 700;
                cump_albastru.Hide();
                util_albastru.Show();
                pret_albastru.Hide();
                b_albastru.Hide();
                label_total.Text = Convert.ToString(bani);
                albastru = 0;
                baniDati += 700;
                using (StreamWriter writeText = new StreamWriter(Nume + "_areAlbastru.txt"))
                {
                    writeText.WriteLine(albastru.ToString());
                }

            }
            else
                MessageBox.Show("Nu ai bani suficienti!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Utilizeaza_roz(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            haina = 1;
            using (StreamWriter writeText = new StreamWriter(Nume + "_haina.txt"))
            {
                writeText.WriteLine(haina.ToString());
            }
        }

        private void Utilizeaza_albastru(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            haina = 2;
            using (StreamWriter writeText = new StreamWriter(Nume + "_haina.txt"))
            {
                writeText.WriteLine(haina.ToString());
            }
        }

        private void Utilizeaza_galben(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            haina = 3;
            using (StreamWriter writeText = new StreamWriter(Nume + "_haina.txt"))
            {
                writeText.WriteLine(haina.ToString());
            }
        }

        private void Utilizeaza_salopeta(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            haina = 4;
            using (StreamWriter writeText = new StreamWriter(Nume + "_haina.txt"))
            {
                writeText.WriteLine(haina.ToString());
            }
        }

        private void Utilizeaza_rosu(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            haina = 5;
            using (StreamWriter writeText = new StreamWriter(Nume + "_haina.txt"))
            {
                writeText.WriteLine(haina.ToString());
            }
        }

        private void Utilizeaza_maro(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            par = 2;
            using (StreamWriter writeText = new StreamWriter(Nume + "_par.txt"))
            {
                writeText.WriteLine(par.ToString());
            }
        }

        private void Utilizeaza_blond(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            par = 1;
            using (StreamWriter writeText = new StreamWriter(Nume + "_par.txt"))
            {
                writeText.WriteLine(par.ToString());
            }
        }
    }
}
