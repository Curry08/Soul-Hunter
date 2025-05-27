using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace PROGETTO_GIOCO_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.DoubleBuffer |
                  ControlStyles.UserPaint |
                  ControlStyles.AllPaintingInWmPaint, true);

            this.UpdateStyles();
        }

        bool GiocoIniziato = false;
        bool GiocoInPausa = false;
        bool vaSu = false;
        bool vaGiù = false;
        bool staSparando = false;
        bool staRicaricando = false;
        bool haSparato = false;
        bool GameOver = false;

        bool suonoPassiInRiproduzione = false;

        int VitaPersonaggio = 10;
        int VelocitàPersonaggio = 5;
        int VelocitàNemico = 6;
        int Munizioni = 15;
        int VelocitàColpo = 10;
        int ContaRicarica = 3;
        int ContaNemiciRimasti = 5;
        int LabelAttesaLocation = 0;

        int PosizioneNemicoX = 0;
        int PosizioneNemicoY = 0;

        List<Label> Colpi = new List<Label>();
        List<PictureBox> Nemici = new List<PictureBox>();

        SoundPlayer MovPersonaggio = new SoundPlayer(Properties.Resources.MovimentoPersonaggio);
        SoundPlayer SuonoSparo = new SoundPlayer(Properties.Resources.Sparo);
        SoundPlayer SuonoDanno = new SoundPlayer(Properties.Resources.Danno);
        SoundPlayer PremiBottone = new SoundPlayer(Properties.Resources.PressioneBottone);
        SoundPlayer SuonoGameOver = new SoundPlayer(Properties.Resources.GameOver);


        private void Form1_Resize_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                tmrMainGameEvents.Enabled = false;
                tmrMovimentoNemico.Enabled = false;
            }
            else
            {
                tmrMainGameEvents.Enabled = true;
                tmrMovimentoNemico.Enabled = true;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.IconaSoulHunter;

            LabelAttesaLocation = lblMunizioni.Left;
            PosizioneNemicoX = this.ClientSize.Width + 60;
            PosizioneNemicoY = this.ClientSize.Height - 60;
        }
        
        
        private void ptbStart_Click(object sender, EventArgs e)
        {

            PremiBottone.Play();

            for (int i = 0; i < 5; i++)
            {
                PictureBox nemico = new PictureBox();
                nemico.Size = new Size(55, 55);

                nemico.BackColor = Color.Transparent;
                nemico.Image = Properties.Resources.Fantasma;
                nemico.SizeMode = PictureBoxSizeMode.Zoom;

                nemico.Location = new Point(PosizioneNemicoX, PosizioneNemicoY);

                PosizioneNemicoY -= 60;

                this.Controls.Add(nemico);
                Nemici.Add(nemico);
            }

            GiocoIniziato = true;
            ptbTitolo.Visible = false;
            ptbStart.Visible = false;
            ptbExit.Visible = false;

            this.BackgroundImage = Properties.Resources.Sfondo;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Invalidate();

            ptbPersonaggio.Visible = true;
            lblMunizioni.Visible = true;
        }


        private void ptbExit_Click(object sender, EventArgs e)
        {
            PremiBottone.Play();

            Application.Exit();
        }


        private void ptbRetry_Click(object sender, EventArgs e)
        {

            if (GameOver)
                SuonoGameOver.Stop();

            PremiBottone.Play();

            ptbPersonaggio.Visible = true;
            lblMunizioni.Visible = true;

            ptbRetry.Visible = false;
            ptbMainMenu.Visible = false;

            try
            {
                for (int i = 0; i < Colpi.Count; i++)
                {
                    this.Controls.Remove(Colpi[i]);
                    Colpi[i].Dispose();
                    Colpi.RemoveAt(i);
                    i--;
                }

                if (Nemici.Count > 5)
                {
                    for (int i = 5; i < Nemici.Count; i++)
                    {
                        this.Controls.Remove(Nemici[i]);
                        Nemici[i].Dispose();
                        Nemici.RemoveAt(i);
                        i--;
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    Nemici[i].Visible = true;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                // NON FA NULLA
            }

            ContaNemiciRimasti = 5;
            GeneraNemici();

            Munizioni = 15;
            lblMunizioni.Text = Munizioni.ToString();

            VitaPersonaggio = 10;

            this.BackgroundImage = Properties.Resources.Sfondo;
            this.Invalidate();


            GiocoIniziato = true;
            GiocoInPausa = false;
            GameOver = false;
        }
        
        
        private void ptbMainMenu_Click(object sender, EventArgs e)
        {

            if (GameOver)
                SuonoGameOver.Stop();

            PremiBottone.Play();

            ptbPersonaggio.Visible = false;
            ptbRetry.Visible = false;
            ptbMainMenu.Visible = false;

            Munizioni = 15;
            lblMunizioni.Text = Munizioni.ToString();
            lblMunizioni.Visible = false;

            try
            {
                for (int i = 0; i < Colpi.Count; i++)
                {
                    this.Controls.Remove(Colpi[i]);
                    Colpi[i].Dispose();
                    Colpi.RemoveAt(i);
                    i--;
                }

                if (Nemici.Count > 5)
                {
                    for (int i = 5; i < Nemici.Count; i++)
                    {
                        this.Controls.Remove(Nemici[i]);
                        Nemici[i].Dispose();
                        Nemici.RemoveAt(i);
                        i--;
                    }
                }

                for (int i = 0; i < 5; i++)
                {
                    Nemici[i].Visible = false;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                // NON FA NULLA
            }

            this.BackgroundImage = Properties.Resources.SfondoImmagine;
            this.BackgroundImageLayout = ImageLayout.Center;
            this.Invalidate();

            ptbTitolo.Visible = true;
            ptbStart.Visible = true;
            ptbExit.Visible = true;

            GameOver = false;
            GiocoInPausa = false;
            GiocoIniziato = false;
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (GameOver || !GiocoIniziato || GiocoInPausa)
                return;

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                vaSu = true;

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                vaGiù = true;
        }
        

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (GameOver || !GiocoIniziato || GiocoInPausa)
                return;

            if (e.Button == MouseButtons.Left && !staRicaricando && !staSparando)
            {
                if (Munizioni > 0)
                {
                    staSparando = true;
                    if (!haSparato)
                        haSparato = true;

                    SuonoSparo.Play();
                    CreazioneColpoEAvvioSparo();
                }
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (GameOver || !GiocoIniziato)
                return;

            if (e.KeyCode == Keys.Escape)
            {
                if (!GiocoInPausa)
                {
                    foreach (Label colpo in Colpi)
                    {
                        colpo.Visible = false;
                    }

                    foreach (PictureBox nemico in Nemici)
                    {
                        nemico.Visible = false;
                    }

                    ptbPersonaggio.Visible = false;
                    lblMunizioni.Visible = false;
                    lblAttesa.Visible = false;

                    ptbRetry.Visible = true;
                    ptbMainMenu.Visible = true;

                    this.BackgroundImage = Properties.Resources.SfondoPausa;
                    this.Invalidate();

                    GiocoInPausa = true;
                }
                else
                {
                    ptbRetry.Visible = false;
                    ptbMainMenu.Visible = false;

                    this.BackgroundImage = Properties.Resources.Sfondo;
                    this.Invalidate();

                    foreach (Label colpo in Colpi)
                    {
                        colpo.Visible = true;
                    }

                    foreach (PictureBox nemico in Nemici)
                    {
                        nemico.Visible = true;
                    }

                    ptbPersonaggio.Visible = true;
                    lblMunizioni.Visible = true;
                    lblAttesa.Visible = true;

                    GiocoInPausa = false;
                }
            }

            if (GiocoInPausa)
                return;

            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                vaSu = false;

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                vaGiù = false;

            if (e.KeyCode == Keys.R && !staRicaricando && !staSparando)
            {
                if (Munizioni != 15)
                {
                    staRicaricando = true;

                    lblAttesa.Text = ContaRicarica + " Secondi";
                    lblAttesa.Left = (lblMunizioni.Left + lblMunizioni.Width / 2) - lblAttesa.Width / 2;

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

                        SuonoSparo.Play();
                        CreazioneColpoEAvvioSparo();
                    }
                }
            }
        }


        private void tmrMainGameEvents_Tick(object sender, EventArgs e)
        {
            if (GameOver || !GiocoIniziato || GiocoInPausa)
                return;

            if (vaSu)
                ptbPersonaggio.Top = Math.Max(ptbLimite.Height, ptbPersonaggio.Top - VelocitàPersonaggio);
           
           if (vaGiù)
                ptbPersonaggio.Top = Math.Min(this.ClientSize.Height - ptbPersonaggio.Height, ptbPersonaggio.Top + VelocitàPersonaggio);

            if (vaSu || vaGiù)
            {
                if (!suonoPassiInRiproduzione)
                {
                    MovPersonaggio.PlayLooping();
                    suonoPassiInRiproduzione = true;
                }
            }
            else
            {
                if (suonoPassiInRiproduzione)
                {
                    MovPersonaggio.Stop();
                    suonoPassiInRiproduzione = false;
                }
            }

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
                            Nemici[i].Visible = false;

                            this.Controls.Remove(Colpi[j]);
                            Colpi[j].Dispose();
                            Colpi.RemoveAt(j);
                            j--;

                            SuonoDanno.Play();

                            ContaNemiciRimasti--;

                            break;
                        }
                    }
                }
            }
        }


        private void tmrMovimentoNemico_Tick(object sender, EventArgs e)
        {
            if (GameOver || !GiocoIniziato || GiocoInPausa)
                return;

            for (int i = 0; i < Nemici.Count; i++)
            {
                if (Nemici[i].Visible)
                {

                    Nemici[i].Left -= VelocitàNemico;


                    if (Nemici[i].Bounds.IntersectsWith(ptbElimina.Bounds))
                    {
                        Nemici[i].Visible = false;
                        VitaPersonaggio--;
                        ContaNemiciRimasti--;
                        SuonoDanno.Play();
                    }
                    else Nemici[i].Refresh();

                    if (VitaPersonaggio == 0 && !GameOver)
                    {
                        ptbPersonaggio.Visible = false;

                        Munizioni = 15;
                        lblMunizioni.Text = Munizioni.ToString();
                        lblMunizioni.Visible = false;

                        try
                        {
                            for (int j = 0; j < Nemici.Count; j++)
                            {
                                Nemici[j].Visible = false;
                            }

                            for (int j = 0; j < Colpi.Count; j++)
                            {
                                this.Controls.Remove(Colpi[j]);
                                Colpi[j].Dispose();
                                Colpi.RemoveAt(j);
                                j--;
                            }
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            // NON FA NULLA
                        }

                        SuonoGameOver.Play();

                        this.BackgroundImage = Properties.Resources.SfondoGameOver;
                        this.Invalidate();

                        ptbRetry.Visible = true;
                        ptbRetry.Left = this.ClientSize.Width / 2 - ptbRetry.Width / 2 + 5;
                        ptbMainMenu.Visible = true;
                        ptbMainMenu.Left = this.ClientSize.Width / 2 - ptbMainMenu.Width / 2 + 5;

                        GiocoInPausa = false;
                        GiocoIniziato = false;

                        GameOver = true;
                        break;
                    }
                }
            }

            if (ContaNemiciRimasti == 0 && Nemici.Count < 15)
            {
                GeneraNemici();
                tmrMovimentoNemico.Interval = Math.Max(20, tmrMovimentoNemico.Interval - 20);
            }
        }

        
        private void tmrAttesaRicarica_Tick(object sender, EventArgs e)
        {
            if (GameOver || !GiocoIniziato || GiocoInPausa)
                return;

            ContaRicarica--;
            if (ContaRicarica == 1)
                lblAttesa.Text = ContaRicarica + " Secondo";
            else
                lblAttesa.Text = ContaRicarica + " Secondi";
            lblAttesa.Refresh();


            if (ContaRicarica == 0)
            {
                staRicaricando = false;

                Munizioni = 15;
                lblAttesa.Text = "";
                ContaRicarica = 3;
                lblAttesa.Left = LabelAttesaLocation;
                lblMunizioni.Text = Munizioni.ToString();
                lblMunizioni.Refresh();

                tmrAttesaRicarica.Stop();
            }
        }


        private void tmrAttesaSparo_Tick(object sender, EventArgs e)
        {
            lblAttesa.Text = "";
            lblMunizioni.Text = Munizioni.ToString();
            staSparando = false;

            tmrAttesaSparo.Stop();
        }


        private void CreazioneColpoEAvvioSparo()
        {
            Label colpo = new Label();
            colpo.Size = new Size(22, 8);
            colpo.BackColor = Color.Transparent;
            colpo.Image = Properties.Resources.Proiettili;
            colpo.ImageAlign = ContentAlignment.MiddleRight;
            colpo.Left = ptbPersonaggio.Left + ptbPersonaggio.Width;
            colpo.Top = ptbPersonaggio.Top + ptbPersonaggio.Height / 2;

            Colpi.Add(colpo);

            Munizioni--;

            lblAttesa.Text = "Attendi...";
            this.Controls.Add(colpo);
            colpo.BringToFront();
            tmrAttesaSparo.Start();
        }


        private void GeneraNemici()
        {
            PosizioneNemicoX = this.ClientSize.Width + 60;
            PosizioneNemicoY = this.ClientSize.Height - 60;

            foreach (PictureBox nemico in Nemici)
            {
                if (!nemico.Visible)
                    nemico.Visible = true;

                nemico.Location = new Point(PosizioneNemicoX, PosizioneNemicoY);
                PosizioneNemicoY -= 60;

                if (PosizioneNemicoY < ptbLimite.Bottom)
                {
                    PosizioneNemicoX += 60;
                    PosizioneNemicoY = this.ClientSize.Height - 60;
                }
            }

            if (ContaNemiciRimasti == 0)
            {
                ContaNemiciRimasti = Nemici.Count + 2;
                for (int i = 0; i < 2; i++)
                {
                    PictureBox nemico = new PictureBox();
                    nemico.Size = new Size(55, 55);
                    nemico.BackColor = Color.Transparent;
                    nemico.Image = Properties.Resources.Fantasma;
                    nemico.SizeMode = PictureBoxSizeMode.Zoom;
                    nemico.Location = new Point(PosizioneNemicoX, PosizioneNemicoY);
                    PosizioneNemicoY -= 60;

                    if (PosizioneNemicoY < ptbLimite.Bottom)
                    {
                        PosizioneNemicoX += 60;
                        PosizioneNemicoY = this.ClientSize.Height - 60;
                    }

                    this.Controls.Add(nemico);
                    Nemici.Add(nemico);
                }
            }
        }
    }
}