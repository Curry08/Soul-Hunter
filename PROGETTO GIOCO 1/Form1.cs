using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace PROGETTO_GIOCO_1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool staSaltando = false;
        int forzaDiGravità = 10;
        int salto = 10;
        int velocità = 10;
        bool staCadendo = false;

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ptbPersonaggio_Click(object sender, EventArgs e)
        {

        }

        

        private void gravità(object sender, EventArgs e)
        {
            if (!ptbPersonaggio.Bounds.IntersectsWith(ptbTerreno.Bounds) && staSaltando == false)
            {
                ptbPersonaggio.Top += forzaDiGravità;
                staCadendo = true;

            }
            else
            {
                staCadendo = false;
            }
        }
       
        private void tmrSalto_Tick(object sender, EventArgs e)
        {
            ptbPersonaggio.Top -= forzaDiGravità;
            staSaltando = true;
            
        }

        private void tmrDestra_Tick(object sender, EventArgs e)
        {
            ptbPersonaggio.Left += velocità;

        }

        private void tmrSinistra_Tick(object sender, EventArgs e)
        {
            ptbPersonaggio.Left -= velocità;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode== Keys.W && staSaltando==false && staCadendo==false)
            {
                
                tmrSalto.Start();
            }
            else if (e.KeyCode == Keys.D)
            {
                tmrDestra.Start();
            }
            else if (e.KeyCode == Keys.A)
            {
                tmrSinistra.Start();
            }
            
        }

private void Form1_KeyUp(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.W)
            {
                tmrSalto.Stop();
                staSaltando = false;
                
            }
            else if (e.KeyCode == Keys.D)
            {
                tmrDestra.Stop();
            }
            else if (e.KeyCode == Keys.A)
            {
                tmrSinistra.Stop();
            }
        }

    }
}
