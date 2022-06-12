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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nume.Text = "";
            parola.Text = "";
            nume.Focus();
        }
        private void buton_ajutor(object sender, EventArgs e)
        {
            MessageBox.Show("Dacă ai întâmpinat dificultăți cere ajutorul unui părinte!","", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        SqlConnection ct = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\InvataCuMaya\InvataCuMaya\Conturi.mdf;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        private void cont_nou(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();

            if (nume.Text == "" || parola.Text == "")
            {
                MessageBox.Show("Va rugam sa introduceti numele si parola!","EROARE",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nume.Text = "";
                parola.Text = "";
                nume.Focus();
            }
            else
                if(nume.Text.Trim() == "admin" || parola.Text.Trim() == "admin")
                {
                    MessageBox.Show("Alege-ti alt nume/parola!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nume.Text = "";
                    parola.Text = "";
                    nume.Focus();
                }
                else
                {

                    ConturiDataSetTableAdapters.AccountsTableAdapter aTa = new ConturiDataSetTableAdapters.AccountsTableAdapter();
                    DataTable dt = aTa.GetDataByName(nume.Text.Trim());
                    if (dt.Rows.Count == 1)
                    {
                        MessageBox.Show("Numele de utilizator este deja folosit! Alege alt nume", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        nume.Text = "";
                        parola.Text = "";
                        nume.Focus();
                    }
                    else
                    {
                        ct.Open();
                        string register = "INSERT INTO Accounts VALUES ('" + nume.Text + "', '" + parola.Text + "', '" + 0 + "', '" + 1 + "', '" + 1 + "', '" + 1 + "', '" + 1 + "', '" + 1 + "', '" + 1 + "', '" + 1 + "', '" + null + "', '"+0+ "', '" + 0 + "', '" + 0 + "', '" + 0 + "')";
                        command = new SqlCommand(register, ct);
                        command.Parameters.AddWithValue("Nume", nume.Text.Trim());
                        command.Parameters.AddWithValue("Parola", parola.Text.Trim());
                        command.ExecuteNonQuery();               
                        ct.Close();
                    
                        using (StreamWriter writeText = new StreamWriter(nume.Text.Trim() + "_total.txt"))
                        {
                            writeText.WriteLine(0.ToString());
                        }
                        using (StreamWriter writeText = new StreamWriter(nume.Text.Trim() + "_areMaro.txt"))
                        {
                            writeText.WriteLine(1.ToString());
                        }
                        using (StreamWriter writeText = new StreamWriter(nume.Text.Trim() + "_areSalopeta.txt"))
                        {
                            writeText.WriteLine(1.ToString());
                        }
                        using (StreamWriter writeText = new StreamWriter(nume.Text.Trim() + "_areGalben.txt"))
                        {
                            writeText.WriteLine(1.ToString());
                        }
                        using (StreamWriter writeText = new StreamWriter(nume.Text.Trim() + "_areRosu.txt"))
                        {
                            writeText.WriteLine(1.ToString());
                        }
                        using (StreamWriter writeText = new StreamWriter(nume.Text.Trim() + "_areAlbastru.txt"))
                        {
                            writeText.WriteLine(1.ToString());
                        }
                        using (StreamWriter writeText = new StreamWriter(nume.Text.Trim() + "_par.txt"))
                        {
                            writeText.WriteLine(1.ToString());
                        }
                        using (StreamWriter writeText = new StreamWriter(nume.Text.Trim() + "_haina.txt"))
                        {
                            writeText.WriteLine(1.ToString());
                        }
                        using (StreamWriter writeText = new StreamWriter(nume.Text.Trim() + "_nrAscultari.txt"))
                        {
                            writeText.WriteLine(1.ToString());
                        }
                        using (StreamWriter writeText = new StreamWriter(nume.Text.Trim() + "_scorJoc1.txt"))
                        {
                            writeText.WriteLine(1.ToString());
                        }
                        using (StreamWriter writeText = new StreamWriter(nume.Text.Trim() + "_scorJoc2.txt"))
                        {
                            writeText.WriteLine(1.ToString());
                        }
                        using (StreamWriter writeText = new StreamWriter(nume.Text.Trim() + "_scorJoc3.txt"))
                        {
                            writeText.WriteLine(1.ToString());
                        }

                        MessageBox.Show("Ti-ai facut un cont!", "Cont nou", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Acasa frm = new Acasa(nume.Text.Trim(), this);
                        this.Hide();
                        frm.ShowDialog();
                    }
                 }
        }

        private void autentificareCont(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_click);
            audio.Play();
            ConturiDataSetTableAdapters.ConturiTableAdapter aTa = new ConturiDataSetTableAdapters.ConturiTableAdapter();
            DataTable dt = aTa.GetDataByCredentials(nume.Text.Trim(), parola.Text.Trim());
            if (parola.Text.Trim() == "admin" && nume.Text.Trim() == "admin")
            {
                Admin fr = new Admin(nume.Text.Trim(), this);
                this.Hide();
                fr.ShowDialog();

            }
            else
            {
                if (dt.Rows.Count == 1)
                {

                    Acasa frm = new Acasa(nume.Text.Trim(), this);
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Numele/parola gresita!", "EROARE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nume.Text = "";
                    parola.Text = "";
                    nume.Focus();
                }
            }
        }
    }
}
