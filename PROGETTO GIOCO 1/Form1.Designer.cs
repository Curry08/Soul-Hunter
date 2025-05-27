namespace PROGETTO_GIOCO_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ptbPersonaggio = new System.Windows.Forms.PictureBox();
            this.lblMunizioni = new System.Windows.Forms.Label();
            this.tmrMainGameEvents = new System.Windows.Forms.Timer(this.components);
            this.tmrAttesaSparo = new System.Windows.Forms.Timer(this.components);
            this.tmrAttesaRicarica = new System.Windows.Forms.Timer(this.components);
            this.lblAttesa = new System.Windows.Forms.Label();
            this.ptbLimite = new System.Windows.Forms.PictureBox();
            this.ptbElimina = new System.Windows.Forms.PictureBox();
            this.tmrMovimentoNemico = new System.Windows.Forms.Timer(this.components);
            this.ptbStart = new System.Windows.Forms.PictureBox();
            this.ptbTitolo = new System.Windows.Forms.PictureBox();
            this.ptbExit = new System.Windows.Forms.PictureBox();
            this.ptbRetry = new System.Windows.Forms.PictureBox();
            this.ptbMainMenu = new System.Windows.Forms.PictureBox();
            this.lblNomeGruppo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonaggio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbElimina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTitolo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRetry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMainMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbPersonaggio
            // 
            this.ptbPersonaggio.BackColor = System.Drawing.Color.Transparent;
            this.ptbPersonaggio.Image = global::PROGETTO_GIOCO_1.Properties.Resources.ProtagonistaFermo;
            this.ptbPersonaggio.Location = new System.Drawing.Point(10, 199);
            this.ptbPersonaggio.Name = "ptbPersonaggio";
            this.ptbPersonaggio.Size = new System.Drawing.Size(90, 100);
            this.ptbPersonaggio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPersonaggio.TabIndex = 1;
            this.ptbPersonaggio.TabStop = false;
            this.ptbPersonaggio.Visible = false;
            // 
            // lblMunizioni
            // 
            this.lblMunizioni.AutoEllipsis = true;
            this.lblMunizioni.AutoSize = true;
            this.lblMunizioni.BackColor = System.Drawing.Color.Transparent;
            this.lblMunizioni.Font = new System.Drawing.Font("Impact", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunizioni.ForeColor = System.Drawing.Color.White;
            this.lblMunizioni.Image = global::PROGETTO_GIOCO_1.Properties.Resources.SfondoMunizioni;
            this.lblMunizioni.Location = new System.Drawing.Point(506, 31);
            this.lblMunizioni.Name = "lblMunizioni";
            this.lblMunizioni.Size = new System.Drawing.Size(51, 41);
            this.lblMunizioni.TabIndex = 3;
            this.lblMunizioni.Text = "15";
            this.lblMunizioni.Visible = false;
            // 
            // tmrMainGameEvents
            // 
            this.tmrMainGameEvents.Enabled = true;
            this.tmrMainGameEvents.Interval = 20;
            this.tmrMainGameEvents.Tick += new System.EventHandler(this.tmrMainGameEvents_Tick);
            // 
            // tmrAttesaSparo
            // 
            this.tmrAttesaSparo.Interval = 250;
            this.tmrAttesaSparo.Tick += new System.EventHandler(this.tmrAttesaSparo_Tick);
            // 
            // tmrAttesaRicarica
            // 
            this.tmrAttesaRicarica.Interval = 1000;
            this.tmrAttesaRicarica.Tick += new System.EventHandler(this.tmrAttesaRicarica_Tick);
            // 
            // lblAttesa
            // 
            this.lblAttesa.AutoSize = true;
            this.lblAttesa.BackColor = System.Drawing.Color.Transparent;
            this.lblAttesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttesa.Location = new System.Drawing.Point(498, 9);
            this.lblAttesa.Name = "lblAttesa";
            this.lblAttesa.Size = new System.Drawing.Size(0, 16);
            this.lblAttesa.TabIndex = 5;
            // 
            // ptbLimite
            // 
            this.ptbLimite.BackColor = System.Drawing.Color.Transparent;
            this.ptbLimite.Location = new System.Drawing.Point(0, -2);
            this.ptbLimite.Name = "ptbLimite";
            this.ptbLimite.Size = new System.Drawing.Size(1112, 74);
            this.ptbLimite.TabIndex = 4;
            this.ptbLimite.TabStop = false;
            // 
            // ptbElimina
            // 
            this.ptbElimina.BackColor = System.Drawing.Color.Transparent;
            this.ptbElimina.Location = new System.Drawing.Point(0, 9);
            this.ptbElimina.Name = "ptbElimina";
            this.ptbElimina.Size = new System.Drawing.Size(116, 455);
            this.ptbElimina.TabIndex = 6;
            this.ptbElimina.TabStop = false;
            // 
            // tmrMovimentoNemico
            // 
            this.tmrMovimentoNemico.Enabled = true;
            this.tmrMovimentoNemico.Tick += new System.EventHandler(this.tmrMovimentoNemico_Tick);
            // 
            // ptbStart
            // 
            this.ptbStart.BackColor = System.Drawing.Color.Black;
            this.ptbStart.Image = global::PROGETTO_GIOCO_1.Properties.Resources.BottoneStart;
            this.ptbStart.Location = new System.Drawing.Point(492, 287);
            this.ptbStart.Name = "ptbStart";
            this.ptbStart.Size = new System.Drawing.Size(102, 50);
            this.ptbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbStart.TabIndex = 7;
            this.ptbStart.TabStop = false;
            this.ptbStart.Click += new System.EventHandler(this.ptbStart_Click);
            // 
            // ptbTitolo
            // 
            this.ptbTitolo.BackColor = System.Drawing.Color.Transparent;
            this.ptbTitolo.Image = global::PROGETTO_GIOCO_1.Properties.Resources.TitoloGioco;
            this.ptbTitolo.Location = new System.Drawing.Point(299, 28);
            this.ptbTitolo.Name = "ptbTitolo";
            this.ptbTitolo.Size = new System.Drawing.Size(514, 253);
            this.ptbTitolo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbTitolo.TabIndex = 8;
            this.ptbTitolo.TabStop = false;
            // 
            // ptbExit
            // 
            this.ptbExit.BackColor = System.Drawing.Color.Black;
            this.ptbExit.Image = global::PROGETTO_GIOCO_1.Properties.Resources.BottoneExit;
            this.ptbExit.Location = new System.Drawing.Point(492, 343);
            this.ptbExit.Name = "ptbExit";
            this.ptbExit.Size = new System.Drawing.Size(102, 50);
            this.ptbExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbExit.TabIndex = 9;
            this.ptbExit.TabStop = false;
            this.ptbExit.Click += new System.EventHandler(this.ptbExit_Click);
            // 
            // ptbRetry
            // 
            this.ptbRetry.BackColor = System.Drawing.Color.Black;
            this.ptbRetry.Image = global::PROGETTO_GIOCO_1.Properties.Resources.BottoneRetry;
            this.ptbRetry.Location = new System.Drawing.Point(492, 270);
            this.ptbRetry.Name = "ptbRetry";
            this.ptbRetry.Size = new System.Drawing.Size(102, 67);
            this.ptbRetry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRetry.TabIndex = 10;
            this.ptbRetry.TabStop = false;
            this.ptbRetry.Visible = false;
            this.ptbRetry.Click += new System.EventHandler(this.ptbRetry_Click);
            // 
            // ptbMainMenu
            // 
            this.ptbMainMenu.BackColor = System.Drawing.Color.Black;
            this.ptbMainMenu.Image = global::PROGETTO_GIOCO_1.Properties.Resources.BottoneMainMenu;
            this.ptbMainMenu.Location = new System.Drawing.Point(492, 343);
            this.ptbMainMenu.Name = "ptbMainMenu";
            this.ptbMainMenu.Size = new System.Drawing.Size(102, 71);
            this.ptbMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMainMenu.TabIndex = 11;
            this.ptbMainMenu.TabStop = false;
            this.ptbMainMenu.Visible = false;
            this.ptbMainMenu.Click += new System.EventHandler(this.ptbMainMenu_Click);
            // 
            // lblNomeGruppo
            // 
            this.lblNomeGruppo.AutoSize = true;
            this.lblNomeGruppo.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeGruppo.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeGruppo.Location = new System.Drawing.Point(8, 441);
            this.lblNomeGruppo.Name = "lblNomeGruppo";
            this.lblNomeGruppo.Size = new System.Drawing.Size(65, 11);
            this.lblNomeGruppo.TabIndex = 12;
            this.lblNomeGruppo.Text = "©StarPixel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::PROGETTO_GIOCO_1.Properties.Resources.SfondoImmagine;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1112, 461);
            this.Controls.Add(this.lblNomeGruppo);
            this.Controls.Add(this.ptbMainMenu);
            this.Controls.Add(this.ptbRetry);
            this.Controls.Add(this.ptbExit);
            this.Controls.Add(this.ptbTitolo);
            this.Controls.Add(this.ptbStart);
            this.Controls.Add(this.lblAttesa);
            this.Controls.Add(this.lblMunizioni);
            this.Controls.Add(this.ptbPersonaggio);
            this.Controls.Add(this.ptbElimina);
            this.Controls.Add(this.ptbLimite);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Soul Hunter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.Resize += new System.EventHandler(this.Form1_Resize_1);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonaggio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbElimina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTitolo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRetry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMainMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbPersonaggio;
        private System.Windows.Forms.Label lblMunizioni;
        private System.Windows.Forms.Timer tmrMainGameEvents;
        private System.Windows.Forms.Timer tmrAttesaSparo;
        private System.Windows.Forms.Timer tmrAttesaRicarica;
        private System.Windows.Forms.Label lblAttesa;
        private System.Windows.Forms.PictureBox ptbLimite;
        private System.Windows.Forms.PictureBox ptbElimina;
        private System.Windows.Forms.Timer tmrMovimentoNemico;
        private System.Windows.Forms.PictureBox ptbStart;
        private System.Windows.Forms.PictureBox ptbTitolo;
        private System.Windows.Forms.PictureBox ptbExit;
        private System.Windows.Forms.PictureBox ptbRetry;
        private System.Windows.Forms.PictureBox ptbMainMenu;
        private System.Windows.Forms.Label lblNomeGruppo;
    }
}

