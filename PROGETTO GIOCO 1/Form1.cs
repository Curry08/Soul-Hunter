using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PROGETTO_GIOCO_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        bool vaSu = false;
        bool vaGiù = false;
        bool staSparando = false;
        bool staRicaricando = false;
        bool haSparato = false;
        bool GameOver = false;

        int VelocitàPersonaggio = 5;
        int VelocitàNemico = 5;
        int VelocitàColpo = 10;
        int Munizioni = 15;
        int RicaricaConta = 5;
        int ColpiRimastiLocation = 0;
        int ContaNemiciRimasti = 5;
        int VitaPersonaggio = 10;

        Random GenNemici = new Random();

        List<Control> Colpi = new List<Control>();
        List<PictureBox> Nemici = new List<PictureBox>();


        private void Form1_Load(object sender, EventArgs e)
        {
            ColpiRimastiLocation = lblMunizioni.Left;

            for (int i = 0; i < 5; i++)
            {
                PictureBox nemico = new PictureBox();
                nemico.Size = new Size(60, 60);
                nemico.BackColor = Color.Transparent;
                nemico.Image = Properties.Resources.Fantasma_1_png;
                
                nemico.SizeMode = PictureBoxSizeMode.Zoom;
                nemico.Location = new Point(GenNemici.Next(this.ClientSize.Width + nemico.Width, this.ClientSize.Width + 80), GenNemici.Next(ptbLimite.Height, this.ClientSize.Height - nemico.Height));

                this.Controls.Add(nemico);
                Nemici.Add(nemico);
            }

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                vaSu = true;

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                vaGiù = true;
        }


        private void tmrMainGameEvents_Tick(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                
                return;
            }
            
            if (GameOver)
            {
                tmrAttesaRicarica.Stop();
                return;
            }
            if (vaSu)
                ptbPersonaggio.Top = Math.Max(ptbLimite.Height, ptbPersonaggio.Top - VelocitàPersonaggio);

            if (vaGiù)
                ptbPersonaggio.Top = Math.Min(this.ClientSize.Height - ptbPersonaggio.Height, ptbPersonaggio.Top + VelocitàPersonaggio);

            if (haSparato)
            {
                for (int i = 0; i < Colpi.Count; i++)
                {
                    Colpi[i].Left += VelocitàColpo;
                    if (Colpi[i].Left > this.ClientSize.Width)
                    {
                        this.Controls.Remove(Colpi[i]);
                        Colpi[i].Dispose();
                        Colpi.RemoveAt(i);
                        i--;
                    }

                }

                for (int i = 0; i < Nemici.Count; i++)
                {
                    for (int j = 0; j < Colpi.Count; j++)
                    {
                        if (Nemici[i].Bounds.IntersectsWith(Colpi[j].Bounds) && Nemici[i].Visible)
                        {
                            Nemici[i].Enabled = false;
                            Nemici[i].Visible = false;

                            this.Controls.Remove(Colpi[j]);
                            Colpi[j].Dispose();
                            Colpi.RemoveAt(j);
                            j--;

                            ContaNemiciRimasti--;

                            break;
                        }
                    }
                }

                /*foreach (Control c in this.Controls)
                {
                    if (c is PictureBox && c.Tag != null && c.Tag.ToString() == "colpo")
                    {

                        c.Left += VelocitàColpo;
                        c.Invalidate(false);
                        if (c.Top < -c.Height)
                        {
                            this.Controls.Remove(c);
                            c.Dispose();
                        }
                    }

                    if (c.Left > this.ClientSize.Width)
                    {
                        colpiDaCancellare.Add(c);
                    }
                    foreach (Control colpo in colpiDaCancellare)
                    {
                        this.Controls.Remove(colpo);
                        colpo.Dispose();
                    }
                }


                foreach (Control colpo in colpiDaCancellare)
                {
                    colpo.Dispose();
                    this.Controls.Remove(colpo);
                }*/
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                vaSu = false;

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                vaGiù = false;

            if (e.KeyCode == Keys.R && !staRicaricando && !staSparando)
            {
                if (Munizioni != 15)
                {
                    staRicaricando = true;

                    
                    lblAttesa.Text = RicaricaConta + " Secondi";
                    lblMunizioni.Left = (lblAttesa.Left + lblAttesa.Width / 2) - lblMunizioni.Width / 2;

                    tmrAttesaRicarica.Start();
                }
            }

            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.E)
            {
                if (!staRicaricando && !staSparando)
                {
                    if (Munizioni > 0)
                    {
                        staSparando = true;
                        if (!haSparato)
                            haSparato = true;
                        CreazioneColpoEAvvioSparo();
                    }
                }
            }
        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !staRicaricando && !staSparando)
            {
                if (Munizioni > 0)
                {
                    staSparando = true;
                    if (!haSparato)
                        haSparato = true;
                    CreazioneColpoEAvvioSparo();
                }
            }
        }


        private void tmrAttesaRicarica_Tick(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {

                return;
            }

            if (GameOver)
            {
                tmrAttesaRicarica.Stop();
                return;
            }

            RicaricaConta--;
            if (RicaricaConta == 1)
                lblAttesa.Text = RicaricaConta + " Secondo";
            else
                lblAttesa.Text = RicaricaConta + " Secondi";
            lblAttesa.Refresh();


            if (RicaricaConta == 0)
            {
                staRicaricando = false;

                Munizioni = 15;
                lblAttesa.Text = "";
                RicaricaConta = 5;
                lblMunizioni.Left = ColpiRimastiLocation;
                lblMunizioni.Text = Munizioni.ToString();
                lblMunizioni.Refresh();

                tmrAttesaRicarica.Stop();
            }
        }


        private void tmrAttesaSparo_Tick(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {

                return;
            }
            if (GameOver)
            {
                tmrAttesaSparo.Stop();
                return;
            }
            lblAttesa.Text = "";
            lblMunizioni.Left = ColpiRimastiLocation;
            lblMunizioni.Text = Munizioni.ToString();
            staSparando = false;

            tmrAttesaSparo.Stop();
        }


        private void GeneraNemici()
        {
            foreach (var nemico in Nemici)
            {
                nemico.Visible = true;
                nemico.Location = new Point(GenNemici.Next(this.ClientSize.Width + nemico.Width, this.ClientSize.Width + 80), GenNemici.Next(ptbLimite.Height, this.ClientSize.Height - nemico.Height));
            }

            if (ContaNemiciRimasti == 0)
            {
                ContaNemiciRimasti = Nemici.Count + 2;
                for (int i = 0; i < 2; i++)
                {
                    PictureBox nemico = new PictureBox();
                    nemico.Size = new Size(60, 60);
                    nemico.BackColor = Color.Transparent;
                    nemico.Image = Properties.Resources.Fantasma_1_png;
                    nemico.SizeMode = PictureBoxSizeMode.Zoom;// Assicurati di avere un'immagine chiamata "nemico" nelle risorse del progetto
                    nemico.Location = new Point(GenNemici.Next(this.ClientSize.Width + nemico.Width, this.ClientSize.Width + 80), GenNemici.Next(ptbLimite.Height, this.ClientSize.Height - nemico.Height));

                    this.Controls.Add(nemico);
                    Nemici.Add(nemico);
                }
            }
        }


        private void CreazioneColpoEAvvioSparo()
        {
            PictureBox colpo = new PictureBox();
            colpo.Size = new Size(25, 15);
            colpo.BackColor = Color.Transparent;
            colpo.Image = Properties.Resources.proiettile; // Assicurati di avere un'immagine chiamata "colpo" nelle risorse del progetto
            colpo.SizeMode = PictureBoxSizeMode.Zoom;
            colpo.Left = ptbPersonaggio.Left + ptbPersonaggio.Width;
            colpo.Top = ptbPersonaggio.Top + ptbPersonaggio.Height / 2;

            Colpi.Add(colpo);

            Munizioni--;
            lblAttesa.Text = "Attendi...";
            this.Controls.Add(colpo);
            colpo.BringToFront();
            tmrAttesaSparo.Start();
        }

        private void tmrMovimentoNemico_Tick(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {

                return;
            }
            if (GameOver)
            {
                tmrMovimentoNemico.Stop();
                return;
            }
            for (int i = 0; i < Nemici.Count; i++)
            {
                if (Nemici[i].Visible)
                {

                    Nemici[i].Left -= VelocitàNemico;
                    Nemici[i].Refresh();
                    if (Nemici[i].Bounds.IntersectsWith(ptbElimina.Bounds))
                    {
                        Nemici[i].Visible = false;
                        VitaPersonaggio--;
                        ContaNemiciRimasti--;
                    }

                    if (VitaPersonaggio == 0 && !GameOver)
                    {
                        GameOver = true;
                        Application.Exit();
                        break;
                    }
                }
            }

            if (ContaNemiciRimasti <= 0 && Nemici.Count < 20)
            {
                GeneraNemici();
                tmrMovimentoNemico.Interval = Math.Max(20, tmrMovimentoNemico.Interval - 20);
            }
        }

        private void Form1_Resize_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                // sospendi il gioco
                tmrMainGameEvents.Enabled = false;
                tmrMovimentoNemico.Enabled = false;
            }
            else
            {
                // riprendi il gioco
                tmrMainGameEvents.Enabled = true;
                tmrMovimentoNemico.Enabled = true;
            }
        }

        private void ptbStart_MouseHover(object sender, EventArgs e)
        {
            ptbStart.Image = Properties.Resources.StartButtonHover; // Assicurati di avere un'immagine chiamata "start_hover" nelle risorse del progetto
            ptbStart.Refresh();
        }

        private void ptbStart_MouseLeave(object sender, EventArgs e)
        {
            ptbStart.Image = Properties.Resources.StartButtonNormal;
            ptbStart.Refresh(); 
        }

        private void ptbStart_MouseEnter(object sender, EventArgs e)
        {
            ptbStart.Image = Properties.Resources.StartButtonHover; // Assicurati di avere un'immagine chiamata "start_hover" nelle risorse del progetto
            ptbStart.Refresh();
        }

        private void ptbStart_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }
    }
}