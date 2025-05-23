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

        int Velocità = 5;
        int VelocitàColpo = 3;
        int Munizioni = 30;
        int RicaricaConta = 5;
        int ContaNemici = 0;
        int ColpiRimastiLocation = 0;

        List<Control> colpiDaCancellare = new List<Control>();


        private void Form1_Load(object sender, EventArgs e)
        {
            ColpiRimastiLocation = lblMunizioni.Left;
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
            if (vaSu)
                ptbPersonaggio.Top = Math.Max(0, ptbPersonaggio.Top - Velocità);

            if (vaGiù)
                ptbPersonaggio.Top = Math.Min(this.ClientSize.Height - ptbPersonaggio.Height, ptbPersonaggio.Top + Velocità);

            if (haSparato)
            {
                foreach (Control c in this.Controls)
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
            }
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                vaSu = false;

            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                vaGiù = false;

            if (e.KeyCode == Keys.R && !staRicaricando)
            {
                if (Munizioni != 30)
                {
                    staRicaricando = true;

                    lblAttesa.Text = "Attesa:";
                    lblMunizioni.Text = RicaricaConta + " Secondi";
                    lblMunizioni.Left = (lblAttesa.Left + lblAttesa.Width) - lblMunizioni.Width / 2;

                    tmrAttesa.Start();
                }
            }

            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.E)
            {
                if (!staRicaricando && !staSparando)
                {
                    haSparato = true;
                    staSparando = true;

                    PictureBox colpo = new PictureBox();
                    colpo.Size = new Size(10, 5);
                    colpo.BackColor = Color.Red;
                    colpo.Tag = "colpo";

                    colpo.Left = ptbPersonaggio.Left + ptbPersonaggio.Width;
                    colpo.Top = ptbPersonaggio.Top + ptbPersonaggio.Height / 2;

                    if (Munizioni > 0)
                    {

                        Munizioni--;

                        this.Controls.Add(colpo);
                        colpo.BringToFront();

                        tmrSparo.Start();
                    }
                }
            }
        }

        private void tmrAttesa_Tick(object sender, EventArgs e)
        {
            if (staRicaricando)
            {
                RicaricaConta--;
                if (RicaricaConta == 1)
                    lblMunizioni.Text = RicaricaConta + " Secondo";
                else
                    lblMunizioni.Text = RicaricaConta + " Secondi";
                lblMunizioni.Refresh();


                if (RicaricaConta == 0)
                {
                    staRicaricando = false;

                    Munizioni = 30;
                    lblAttesa.Text = "";
                    RicaricaConta = 5;
                    lblMunizioni.Left = ColpiRimastiLocation;
                    lblMunizioni.Text = Munizioni.ToString();

                    tmrAttesa.Stop();
                }
            }
        }

        private void tmrSparo_Tick(object sender, EventArgs e)
        {
            if (staSparando)
            {

                lblAttesa.Text = "";
                lblMunizioni.Left = ColpiRimastiLocation;
                lblMunizioni.Text = Munizioni.ToString();
                staSparando = false;

                tmrAttesa.Stop();
            }
        }
    }
}

