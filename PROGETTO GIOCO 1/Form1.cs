using System;
using System.Windows.Forms;

namespace PROGETTO_GIOCO_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int velocitàPersonaggio = 10;
        int velocitàColpo = 5;
        int munizioni = 30;
        bool staSparando = false;
        bool staRicaricando = false;

        int tickCount = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            tmrColpo.Start();
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                tmrAlto.Start();
            }
            else if (e.KeyCode == Keys.S)
            {
                tmrGiù.Start();
            }
            else if (e.KeyCode == Keys.R)
            {
                ricarica(); 

            }
            else if (e.KeyCode == Keys.Space && !staSparando && !staRicaricando)
            {
                PictureBox colpo = new PictureBox();               
                colpo.Size = new System.Drawing.Size(35, 10);
                colpo.BackColor = System.Drawing.Color.Red;
                colpo.Tag = "colpo";
                colpo.Left = ptbPersonaggio.Left + ptbPersonaggio.Width/2-colpo.Width/2;
                colpo.Top = ptbPersonaggio.Top + ptbPersonaggio.Height/2-colpo.Height/2;  

                if (munizioni > 0)
                {
                    this.Controls.Add(colpo);
                colpo.BringToFront();
                munizioni--;
                lblMunizioni.Text = munizioni.ToString();
                    staSparando = true;
                }
            }
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W )
            {
                tmrAlto.Stop();
            }
            else if (e.KeyCode == Keys.S)
            {
                tmrGiù.Stop();
            }
            else if (e.KeyCode == Keys.Space)
            {
                staSparando = false;
            }
        }

        private void tmrAlto_Tick(object sender, EventArgs e)
        {
            ptbPersonaggio.Top = Math.Max(ptbPersonaggio.Top - velocitàPersonaggio, 50); // Limita il movimento verso l'alto
        }

        private void tmrGiù_Tick(object sender, EventArgs e)
        {
            ptbPersonaggio.Top = Math.Min(ptbPersonaggio.Top + velocitàPersonaggio, 520-ptbPersonaggio.Height);
        }

        private void tmrColpo_Tick(object sender, EventArgs e)
        {            
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox && c.Tag != null && c.Tag.ToString() == "colpo")
                {
                    c.Left += velocitàColpo;
                    if (c.Top < -c.Height)
                    {
                        this.Controls.Remove(c);
                        c.Dispose();
                    }
                }
            }
        }


        private void ricarica()
        {
            staRicaricando= true;
            tmrRicarica.Start();
            
        }

        private void tmrRicarica_Tick(object sender, EventArgs e)
        {
            tickCount++;    
            if (tickCount>5) {  
                if (munizioni < 30 )
                    {
                
                    munizioni = 30;
                    
                    staRicaricando = false;
                    lblMunizioni.Text = munizioni.ToString();
                    tmrRicarica.Stop();
                    }
            }



            if (tickCount == 1)
            {
                lblMunizioni.Text = "5s";
            }
            else if (tickCount == 2)
            {
                lblMunizioni.Text = "4s";
            }
            else if (tickCount == 3)
            {
                lblMunizioni.Text = "3s";
            }
            else if (tickCount == 4)
            {
                lblMunizioni.Text = "2s";
            }
            else if (tickCount == 5)
            {
                lblMunizioni.Text = "1s";
                
            }
                
            
        }
    }
}
