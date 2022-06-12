using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProiectInfoEducatie
{
    public partial class Acasa : Form
    {
        int maro = Magazin.maro;
        int albastru = Magazin.albastru;
        int galben = Magazin.galben;
        int salopeta = Magazin.salopeta;
        int rosu = Magazin.rosu;
        int total, bani1, bani2, bani3, par, haina, scor_joc1, scor_joc2, scor_joc3, ascultari;
        public static string numeUser;
       
        private MainForm frm1;

        public Acasa()
        {
            InitializeComponent();
        }

        public Acasa(string nume)
        {
            numeUser = nume; 
            InitializeComponent();
        }

        public Acasa(string nume, MainForm f)
        {
            numeUser = nume;
            frm1 = f;
            InitializeComponent();
        }

        private void Legume_click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            Legume frm = new Legume(numeUser, this);
            this.Hide();
            frm.ShowDialog();
        }

        private void Culori_click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            Culori frm = new Culori(numeUser, this);
            this.Hide();
            frm.ShowDialog();
        }

        private void Fructe_click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            Fructe frm = new Fructe(numeUser, this);
            this.Hide();
            frm.ShowDialog();
        }

        private void Animale_click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            Animale frm = new Animale(numeUser, this);
            this.Hide();
            frm.ShowDialog();
        }

        private void Joc1_click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            Joc1 forma = new Joc1(numeUser, this);
            this.Hide();
            _ = forma.ShowDialog();
        }

        private void Joc2_click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            Joc2 frm = new Joc2(numeUser, this);
            this.Hide();
            frm.ShowDialog();
        }
        private void Joc3_click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            Joc3 frm = new Joc3(numeUser, this);
            this.Hide();
            frm.ShowDialog();
        }

        private void Magazin_click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            Magazin frm = new Magazin(numeUser, this); 
            this.Hide();
            frm.ShowDialog();
        }

        private void Inapoi(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_inapoi);
            audio.Play();
            this.Hide();
            frm1.Show();
        }

        SqlConnection ct = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\InvataCuMaya\InvataCuMaya\Conturi.mdf;Integrated Security=True");
        SqlCommand command = new SqlCommand();

        private void Form2_Load(object sender, EventArgs e)
        {
            bani1 = Joc1.scor*10;
            bani2= Joc2.scor;
            bani3 = Joc3.scor*10;
            Joc1.scor = Joc2.scor = Joc3.scor = 0;
            total= Convert.ToInt32(File.ReadAllText(numeUser + "_total.txt"));
            total -= Magazin.baniDati;
            Magazin.baniDati = 0;
            total += bani1 + bani2 + bani3;
            
            using (StreamWriter writeText = new StreamWriter(numeUser + "_total.txt"))
            {
                writeText.WriteLine(total.ToString());
            }

            scor_joc1 = Convert.ToInt32(File.ReadAllText(numeUser + "_scorJoc1.txt"));
            scor_joc1 += bani1;
            scor_joc2 = Convert.ToInt32(File.ReadAllText(numeUser + "_scorJoc2.txt"));
            scor_joc2 += bani2;
            scor_joc3 = Convert.ToInt32(File.ReadAllText(numeUser + "_scorJoc3.txt"));
            scor_joc3 += bani3;

            using (StreamWriter writeText = new StreamWriter(numeUser + "_scorJoc1.txt"))
            {
                writeText.WriteLine(scor_joc1.ToString());
            }
            using (StreamWriter writeText = new StreamWriter(numeUser + "_scorJoc2.txt"))
            {
                writeText.WriteLine(scor_joc2.ToString());
            }
            using (StreamWriter writeText = new StreamWriter(numeUser + "_scorJoc3.txt"))
            {
                writeText.WriteLine(scor_joc3.ToString());
            }

            ascultari = Convert.ToInt32(File.ReadAllText(numeUser + "_nrAscultari.txt"));
            ascultari += (Animale.ascultari + Culori.ascultari + Fructe.ascultari + Legume.ascultari)*10;
            Animale.ascultari = Culori.ascultari = Fructe.ascultari = Legume.ascultari = 0;

            using (StreamWriter writeText = new StreamWriter(numeUser + "_nrAscultari.txt"))
            {
                writeText.WriteLine(ascultari.ToString());
            }

            maro = Magazin.maro;
            albastru = Magazin.albastru;
            galben = Magazin.galben;
            salopeta = Magazin.salopeta;
            rosu = Magazin.rosu;

            ct.Open();
            string register = "UPDATE Accounts SET Total = '" + total + "', areMaro = '" + maro + "', areSalopeta = '" + salopeta + "', areGalben = '" + galben + "', areAlbastru = '" + albastru + "', areRosu = '" + rosu + "', Par = '" + par + "', Haina = '" + haina + "', scorJoc1 = '" + scor_joc1 + "', scorJoc2 = '" + scor_joc2 + "', scorJoc3 = '" + scor_joc3 + "', nrAscultari = '" + ascultari + "'  WHERE Nume = '" + numeUser + "'";//, WHERE scorJoc1 = '"+scor_joc1+"'";
            command = new SqlCommand(register, ct);
            command.ExecuteNonQuery();
            
            ct.Close();

            label_total.Text = File.ReadAllText(numeUser + "_total.txt");
            par= Convert.ToInt32(File.ReadAllText(numeUser + "_par.txt"));
            haina= Convert.ToInt32(File.ReadAllText(numeUser + "_haina.txt"));

            if (par == 1 && haina == 1)
                imagine_Maya.Image = Properties.Resources.mayab_roz;
            if (par == 1 && haina == 2)
                imagine_Maya.Image = Properties.Resources.mayab_albastru;
            if (par == 1 && haina == 3)
                imagine_Maya.Image = Properties.Resources.mayab_galben;
            if (par == 1 && haina == 4)
                imagine_Maya.Image = Properties.Resources.mayab_salopeta;
            if (par == 1 && haina == 5)
                imagine_Maya.Image = Properties.Resources.mayab_rosu;
            if (par == 2 && haina == 1)
                imagine_Maya.Image = Properties.Resources.mayam_roz;
            if (par == 2 && haina == 2)
                imagine_Maya.Image = Properties.Resources.mayam_albastru;
            if (par == 2 && haina == 3)
                imagine_Maya.Image = Properties.Resources.mayam_galben;
            if (par == 2 && haina == 4)
                imagine_Maya.Image = Properties.Resources.mayam_salopeta;
            if (par == 2 && haina == 5)
                imagine_Maya.Image = Properties.Resources.mayam_rosu;
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm1.Show();            
        }
    }
}
