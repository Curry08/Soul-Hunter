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
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonaggio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbElimina)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbPersonaggio
            // 
            this.ptbPersonaggio.BackColor = System.Drawing.Color.Transparent;
            this.ptbPersonaggio.Image = global::PROGETTO_GIOCO_1.Properties.Resources.ProtagonistaFermo;
            this.ptbPersonaggio.Location = new System.Drawing.Point(10, 160);
            this.ptbPersonaggio.Name = "ptbPersonaggio";
            this.ptbPersonaggio.Size = new System.Drawing.Size(90, 100);
            this.ptbPersonaggio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPersonaggio.TabIndex = 1;
            this.ptbPersonaggio.TabStop = false;
            // 
            // lblMunizioni
            // 
            this.lblMunizioni.AutoEllipsis = true;
            this.lblMunizioni.AutoSize = true;
            this.lblMunizioni.BackColor = System.Drawing.Color.Red;
            this.lblMunizioni.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunizioni.ForeColor = System.Drawing.Color.Black;
            this.lblMunizioni.Location = new System.Drawing.Point(498, 34);
            this.lblMunizioni.Name = "lblMunizioni";
            this.lblMunizioni.Size = new System.Drawing.Size(55, 38);
            this.lblMunizioni.TabIndex = 3;
            this.lblMunizioni.Text = "30";
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
            this.lblAttesa.Location = new System.Drawing.Point(489, 9);
            this.lblAttesa.Name = "lblAttesa";
            this.lblAttesa.Size = new System.Drawing.Size(0, 16);
            this.lblAttesa.TabIndex = 5;
            // 
            // ptbLimite
            // 
            this.ptbLimite.BackColor = System.Drawing.Color.Transparent;
            this.ptbLimite.Location = new System.Drawing.Point(0, -2);
            this.ptbLimite.Name = "ptbLimite";
            this.ptbLimite.Size = new System.Drawing.Size(100, 74);
            this.ptbLimite.TabIndex = 4;
            this.ptbLimite.TabStop = false;
            // 
            // ptbElimina
            // 
            this.ptbElimina.BackColor = System.Drawing.Color.Transparent;
            this.ptbElimina.Location = new System.Drawing.Point(0, 65);
            this.ptbElimina.Name = "ptbElimina";
            this.ptbElimina.Size = new System.Drawing.Size(100, 399);
            this.ptbElimina.TabIndex = 6;
            this.ptbElimina.TabStop = false;
            // 
            // tmrMovimentoNemico
            // 
            this.tmrMovimentoNemico.Enabled = true;
            this.tmrMovimentoNemico.Tick += new System.EventHandler(this.tmrMovimentoNemico_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImage = global::PROGETTO_GIOCO_1.Properties.Resources.Sfondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.lblAttesa);
            this.Controls.Add(this.lblMunizioni);
            this.Controls.Add(this.ptbPersonaggio);
            this.Controls.Add(this.ptbLimite);
            this.Controls.Add(this.ptbElimina);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonaggio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLimite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbElimina)).EndInit();
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
    }
}

