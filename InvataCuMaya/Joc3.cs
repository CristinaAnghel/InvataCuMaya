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
    public partial class Joc3 : Form
    {
        private Acasa frm2;
        int raspunsCorect;
        string rasp;
        int nrIntrebari = 1;
        public static int scor;
        Random rnd = new Random();
        public Joc3()
        {
            InitializeComponent();
            Intrebare(nrIntrebari);
            nrIntrebari = rnd.Next(1, 24);
        }
        public Joc3(string nume, Acasa f)
        {
            frm2 = f;
            InitializeComponent();
            Intrebare(nrIntrebari);
            nrIntrebari = rnd.Next(1, 24);
        }

        private void Joc3_Load(object sender, EventArgs e)
        {
            scor = 0;
            this.ControlBox = false;
        }

        private void VerificaRaspuns(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            var senderObject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == raspunsCorect)
            {
                scor++;
                label2.Text = "Scor: " + scor;
            }
            else
            {
                MessageBox.Show("Raspunsul corect este "+ rasp, "GRESIT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            nrIntrebari = rnd.Next(1, 24);
            Intrebare(nrIntrebari);

        }

        private void Intrebare(int nr)
        {

            switch (nr)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.animale_pisica;

                    label1.Text = "Ce animal este in imagine?";

                    button1.Text = "Caine";
                    button2.Text = "Elefant";
                    button3.Text = "Pisica";
                    button4.Text = "Vaca";

                    raspunsCorect = 3;
                    rasp = "pisica";

                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources.culori_rosu;

                    label1.Text = "Ce culoare este in imagine?";

                    button1.Text = "Verde";
                    button2.Text = "Albastru";
                    button3.Text = "Mov";
                    button4.Text = "Rosu";

                    raspunsCorect= 4;
                    rasp = "rosu";

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources.legume_conopida;

                    label1.Text = "Ce leguma este in imagine?";

                    button1.Text = "Castravete";
                    button2.Text = "Ardei";
                    button3.Text = "Conopida";
                    button4.Text = "Morcov";

                    raspunsCorect = 3;
                    rasp = "conopida";

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources.fructe_cirese;

                    label1.Text = "ce fruct este in imagine";

                    button1.Text = "Cirese";
                    button2.Text = "Mere";
                    button3.Text = "Capsuni";
                    button4.Text = "Pepene";

                    raspunsCorect = 1;
                    rasp = "cirese";

                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.culori_verde;

                    label1.Text = "Ce culoare este in imagine?";

                    button1.Text = "Albastru";
                    button2.Text = "Rosu";
                    button3.Text = "Verde";
                    button4.Text = "Galben";

                    raspunsCorect = 3;
                    rasp = "verde";

                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.fructe_portocale;

                    label1.Text = "Ce fruct este in imagine?";

                    button1.Text = "Capsuni";
                    button2.Text = "Para";
                    button3.Text = "Mar";
                    button4.Text = "Portocala";

                    raspunsCorect = 4;
                    rasp = "portocala";

                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.animale_girafa;

                    label1.Text = "Ce animal este in imagine?";

                    button1.Text = "Girafa";
                    button2.Text = "Leu";
                    button3.Text = "Vaca";
                    button4.Text = "Pisica";

                    raspunsCorect = 1;
                    rasp = "girafa";

                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.legume_ardei;

                    label1.Text = "Ce leguma este in imagine?";

                    button1.Text = "Castravete";
                    button2.Text = "Ardei";
                    button3.Text = "Conopida";
                    button4.Text = "Cartof";

                    raspunsCorect = 2;
                    rasp = "ardei";

                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources.animale_leu;

                    label1.Text = "Ce animal este in imagine?";

                    button1.Text = "Leu";
                    button2.Text = "Elefant";
                    button3.Text = "Vaca";
                    button4.Text = "Pisica";

                    raspunsCorect = 1;
                    rasp = "leu";

                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources.animale_caine;

                    label1.Text = "Ce animal este in imagine?";

                    button1.Text = "Leu";
                    button2.Text = "Caine";
                    button3.Text = "Girafa";
                    button4.Text = "Vaca";

                    raspunsCorect = 2;
                    rasp = "caine";

                    break;
                case 11:
                    pictureBox1.Image = Properties.Resources.animale_vaca;

                    label1.Text = "Ce animal este in imagine?";

                    button1.Text = "Girafa";
                    button2.Text = "Pisica";
                    button3.Text = "Caine";
                    button4.Text = "Vaca";

                    raspunsCorect = 4;
                    rasp = "vaca";

                    break;
                case 12:
                    pictureBox1.Image = Properties.Resources.animale_elefant;

                    label1.Text = "Ce animal este in imagine?";

                    button1.Text = "Vaca";
                    button2.Text = "Elefant";
                    button3.Text = "Pisica";
                    button4.Text = "Girafa";

                    raspunsCorect = 2;
                    rasp = "elefant";

                    break;
                case 13:
                    pictureBox1.Image = Properties.Resources.culori_mov;

                    label1.Text = "Ce culoare este in imagine?";

                    button1.Text = "Rosu";
                    button2.Text = "Albastru";
                    button3.Text = "Mov";
                    button4.Text = "Galben";

                    raspunsCorect = 3;
                    rasp = "mov";

                    break;
                case 14:
                    pictureBox1.Image = Properties.Resources.culori_galben;

                    label1.Text = "Ce culoare este in imagine?";

                    button1.Text = "Galben";
                    button2.Text = "Verde";
                    button3.Text = "Portocaliu";
                    button4.Text = "Albastru";

                    raspunsCorect = 1;
                    rasp = "galben";

                    break;
                case 15:
                    pictureBox1.Image = Properties.Resources.culori_albastru;

                    label1.Text = "Ce culoare este in imagine?";

                    button1.Text = "Rosu";
                    button2.Text = "Mov";
                    button3.Text = "Portocaliu";
                    button4.Text = "Albastru";

                    raspunsCorect = 4;
                    rasp = "albastru";

                    break;
                case 16:
                    pictureBox1.Image = Properties.Resources.culori_portocaliu;

                    label1.Text = "Ce culoare este in imagine?";

                    button1.Text = "ALbastru";
                    button2.Text = "Verde";
                    button3.Text = "Portocaliu";
                    button4.Text = "Galben";

                    raspunsCorect = 3;
                    rasp = "portocaliu";

                    break;
                case 17:
                    pictureBox1.Image = Properties.Resources.legume_cartofi;

                    label1.Text = "Ce leguma este in imagine?";

                    button1.Text = "Castravete";
                    button2.Text = "Rosii";
                    button3.Text = "Conopida";
                    button4.Text = "Cartof";

                    raspunsCorect = 4;
                    rasp = "cartofi";

                    break;
                case 18:
                    pictureBox1.Image = Properties.Resources.legume_rosii;

                    label1.Text = "Ce leguma este in imagine?";

                    button1.Text = "Cartofi";
                    button2.Text = "Ardei";
                    button3.Text = "Castraveti";
                    button4.Text = "Rosii";

                    raspunsCorect = 4;
                    rasp = "rosii";

                    break;
                case 19:
                    pictureBox1.Image = Properties.Resources.legume_castraveti;

                    label1.Text = "Ce leguma este in imagine?";

                    button1.Text = "Conopida";
                    button2.Text = "Morcovi";
                    button3.Text = "Castraveti";
                    button4.Text = "Cartof";

                    raspunsCorect = 3;
                    rasp = "castraveti";

                    break;
                case 20:
                    pictureBox1.Image = Properties.Resources.legume_morcovi;

                    label1.Text = "Ce leguma este in imagine?";

                    button1.Text = "Morcovi";
                    button2.Text = "Rosii";
                    button3.Text = "Conopida";
                    button4.Text = "Ardei";

                    raspunsCorect = 1;
                    rasp = "morcovi";

                    break;
                case 21:
                    pictureBox1.Image = Properties.Resources.fructe_pepene;

                    label1.Text = "ce fruct este in imagine";

                    button1.Text = "Mar";
                    button2.Text = "Pepene";
                    button3.Text = "Para";
                    button4.Text = "Portocala";

                    raspunsCorect = 2;
                    rasp = "pepene";

                    break;
                case 22:
                    pictureBox1.Image = Properties.Resources.fructe_mere;

                    label1.Text = "ce fructe sunt in imagine";

                    button1.Text = "Pere";
                    button2.Text = "Cirese";
                    button3.Text = "Capsuni";
                    button4.Text = "Mere";

                    raspunsCorect = 4;
                    rasp = "mere";

                    break;
                case 23:
                    pictureBox1.Image = Properties.Resources.fructe_capsuni;

                    label1.Text = "ce fructe sunt in imagine";

                    button1.Text = "Portocale";
                    button2.Text = "Cirese";
                    button3.Text = "Capsuni";
                    button4.Text = "Mere";

                    raspunsCorect = 3;
                    rasp = "capsuni";

                    break;
                case 24:
                    pictureBox1.Image = Properties.Resources.fructe_pere;

                    label1.Text = "ce fructe sunt in imagine";

                    button1.Text = "Pepene";
                    button2.Text = "Pere";
                    button3.Text = "Portocale";
                    button4.Text = "Mere";

                    raspunsCorect = 2;
                    rasp = "pere";

                    break;
            }



        }

        private void Inapoi(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_inapoi);
            audio.Play();
            this.Hide();
            frm2.Show();
        }

    }
}
