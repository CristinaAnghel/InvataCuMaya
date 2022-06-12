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
    public partial class Admin : Form
    {
        private MainForm frm1;
        int scor_joc1;
        int scor_joc2;
        int scor_joc3;
        int ascultari;
        public Admin()
        {
            InitializeComponent();
        }

        public Admin(string nume, MainForm f)
        {
            frm1 = f;
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'conturiDataSet.Accounts' table. You can move, or remove it, as needed.
            this.accountsTableAdapter.Fill(this.conturiDataSet.Accounts);
            this.ControlBox = false;
            comboBox1.SelectedIndex = -1;
            /*if (comboBox1.SelectedIndex != -1)
            {
                scor_joc1 = Convert.ToInt32(File.ReadAllText(comboBox1.SelectedItem + "_scorJoc1.txt"));
                scor_joc2 = Convert.ToInt32(File.ReadAllText(comboBox1.SelectedItem + "_scorJoc2.txt"));
                scor_joc3 = Convert.ToInt32(File.ReadAllText(comboBox1.SelectedItem + "_scorJoc3.txt"));
                //label1.Text = comboBox1.Text;
                label9.Text=Convert.ToString(scor_joc1);
                label8.Text=Convert.ToString(scor_joc2);
                label7.Text=Convert.ToString(scor_joc3);
               // MessageBox.Show(Convert.ToString(scor_joc1 + " " + scor_joc2 + " " + scor_joc3));
            }*/
        }

        private void back(object sender, EventArgs e)
        {
            System.Media.SoundPlayer audio = new System.Media.SoundPlayer(Properties.Resources.audio_inapoi);
            audio.Play();
            this.Hide();
            frm1.Show();
        }

        private void change(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                scor_joc1 = Convert.ToInt32(File.ReadAllText(comboBox1.Text + "_scorJoc1.txt"));
                scor_joc2 = Convert.ToInt32(File.ReadAllText(comboBox1.Text + "_scorJoc2.txt"));
                scor_joc3 = Convert.ToInt32(File.ReadAllText(comboBox1.Text + "_scorJoc3.txt"));
                ascultari = Convert.ToInt32(File.ReadAllText(comboBox1.Text + "_nrAscultari.txt"));
                label9.Text = Convert.ToString(scor_joc1);
                label8.Text = Convert.ToString(scor_joc2);
                label7.Text = Convert.ToString(scor_joc3);
                label14.Text = Convert.ToString(ascultari/10);
                if (scor_joc2 == 0 && scor_joc1 == 0 && scor_joc3 == 0 && ascultari == 0)
                {
                    g_mat.Image = Properties.Resources.gresit;
                    inv_vizuala.Image = Properties.Resources.gresit;
                    m_viz.Image = Properties.Resources.gresit;
                    inv_aud.Image = Properties.Resources.gresit;
                }
                else
                {

                    if (scor_joc1 > scor_joc2 && scor_joc1 > scor_joc3 && scor_joc1 > ascultari)
                    {
                        g_mat.Image = Properties.Resources.corect;
                        inv_vizuala.Image = Properties.Resources.gresit;
                        m_viz.Image = Properties.Resources.gresit;
                        inv_aud.Image = Properties.Resources.gresit;
                    }
                    else
                    {
                        if (scor_joc2 > scor_joc1 && scor_joc2 > scor_joc3 && scor_joc2 > ascultari)
                        {
                            g_mat.Image = Properties.Resources.gresit;
                            inv_vizuala.Image = Properties.Resources.gresit;
                            m_viz.Image = Properties.Resources.corect;
                            inv_aud.Image = Properties.Resources.gresit;
                        }
                        else
                        {
                            if (scor_joc3 > scor_joc1 && scor_joc3 > scor_joc2 && scor_joc3 > ascultari)
                            {
                                g_mat.Image = Properties.Resources.gresit;
                                inv_vizuala.Image = Properties.Resources.corect;
                                m_viz.Image = Properties.Resources.gresit;
                                inv_aud.Image = Properties.Resources.gresit;
                            }
                            else
                            {
                                if (scor_joc3 == scor_joc1 && scor_joc3 == scor_joc2 && scor_joc3 > ascultari)
                                {
                                    g_mat.Image = Properties.Resources.corect;
                                    inv_vizuala.Image = Properties.Resources.corect;
                                    m_viz.Image = Properties.Resources.corect;
                                    inv_aud.Image = Properties.Resources.gresit;
                                }
                                else
                                {
                                    if (scor_joc3 == scor_joc1 && scor_joc3 > scor_joc2 && scor_joc3 > ascultari)
                                    {
                                        g_mat.Image = Properties.Resources.corect;
                                        inv_vizuala.Image = Properties.Resources.corect;
                                        m_viz.Image = Properties.Resources.gresit;
                                        inv_aud.Image = Properties.Resources.gresit;
                                    }
                                    else
                                    {
                                        if (scor_joc3 == scor_joc2 && scor_joc3 > scor_joc1 && scor_joc3 > ascultari)
                                        {
                                            g_mat.Image = Properties.Resources.gresit;
                                            inv_vizuala.Image = Properties.Resources.corect;
                                            m_viz.Image = Properties.Resources.corect;
                                            inv_aud.Image = Properties.Resources.gresit;
                                        }
                                        else
                                        {
                                            if (scor_joc2 == scor_joc1 && scor_joc1 > scor_joc3 && scor_joc2 > ascultari)
                                            {
                                                g_mat.Image = Properties.Resources.corect;
                                                inv_vizuala.Image = Properties.Resources.gresit;
                                                m_viz.Image = Properties.Resources.corect;
                                                inv_aud.Image = Properties.Resources.gresit;
                                            }
                                            else
                                            {
                                                if(scor_joc3 == scor_joc1 && scor_joc3 == scor_joc2 && scor_joc3 == ascultari)
                                                {
                                                    g_mat.Image = Properties.Resources.corect;
                                                    inv_vizuala.Image = Properties.Resources.corect;
                                                    m_viz.Image = Properties.Resources.corect;
                                                    inv_aud.Image = Properties.Resources.corect;
                                                }
                                                else
                                                {
                                                    if(ascultari > scor_joc1 && ascultari > scor_joc2 && ascultari > scor_joc3)
                                                    {
                                                        g_mat.Image = Properties.Resources.gresit;
                                                        inv_vizuala.Image = Properties.Resources.gresit;
                                                        m_viz.Image = Properties.Resources.gresit;
                                                        inv_aud.Image = Properties.Resources.corect;
                                                    }
                                                    else
                                                    {
                                                        if(scor_joc3 == ascultari && scor_joc3 > scor_joc1 && scor_joc3 > scor_joc2)
                                                        {
                                                            g_mat.Image = Properties.Resources.gresit;
                                                            inv_vizuala.Image = Properties.Resources.corect;
                                                            m_viz.Image = Properties.Resources.gresit;
                                                            inv_aud.Image = Properties.Resources.corect;
                                                        }
                                                        else
                                                        {
                                                            if(scor_joc2 == ascultari && scor_joc2 > scor_joc3 && scor_joc2 > scor_joc1)
                                                            {
                                                                g_mat.Image = Properties.Resources.gresit;
                                                                inv_vizuala.Image = Properties.Resources.gresit;
                                                                m_viz.Image = Properties.Resources.corect;
                                                                inv_aud.Image = Properties.Resources.corect;
                                                            }
                                                            else
                                                            {
                                                                if(scor_joc1 == ascultari && scor_joc1 > scor_joc3 && scor_joc1 > scor_joc2)
                                                                {
                                                                    g_mat.Image = Properties.Resources.corect;
                                                                    inv_vizuala.Image = Properties.Resources.gresit;
                                                                    m_viz.Image = Properties.Resources.gresit;
                                                                    inv_aud.Image = Properties.Resources.corect;
                                                                }
                                                                else
                                                                {
                                                                    if(scor_joc1 == ascultari && scor_joc1 == scor_joc2 && scor_joc1 > scor_joc3)
                                                                    {
                                                                        g_mat.Image = Properties.Resources.corect;
                                                                        inv_vizuala.Image = Properties.Resources.gresit;
                                                                        m_viz.Image = Properties.Resources.corect;
                                                                        inv_aud.Image = Properties.Resources.corect;
                                                                    }
                                                                    else
                                                                    {
                                                                        if(scor_joc1 == ascultari && scor_joc1 == scor_joc3 && scor_joc1 > scor_joc2)
                                                                        {
                                                                            g_mat.Image = Properties.Resources.corect;
                                                                            inv_vizuala.Image = Properties.Resources.corect;
                                                                            m_viz.Image = Properties.Resources.gresit;
                                                                            inv_aud.Image = Properties.Resources.corect;
                                                                        }
                                                                        else
                                                                        {
                                                                            if(scor_joc2 == ascultari && scor_joc2 == scor_joc3 && scor_joc2 > scor_joc1)
                                                                            {
                                                                                g_mat.Image = Properties.Resources.gresit;
                                                                                inv_vizuala.Image = Properties.Resources.corect;
                                                                                m_viz.Image = Properties.Resources.corect;
                                                                                inv_aud.Image = Properties.Resources.corect;
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inv_vizuala_Click(object sender, EventArgs e)
        {

        }
    }
}
