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
            this.tmrGravità = new System.Windows.Forms.Timer(this.components);
            this.ptbTerreno = new System.Windows.Forms.PictureBox();
            this.tmrSalto = new System.Windows.Forms.Timer(this.components);
            this.tmrDestra = new System.Windows.Forms.Timer(this.components);
            this.tmrSinistra = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonaggio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTerreno)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbPersonaggio
            // 
            this.ptbPersonaggio.BackColor = System.Drawing.Color.Transparent;
            this.ptbPersonaggio.Image = global::PROGETTO_GIOCO_1.Properties.Resources.personaggio_1_png;
            this.ptbPersonaggio.Location = new System.Drawing.Point(375, 103);
            this.ptbPersonaggio.Name = "ptbPersonaggio";
            this.ptbPersonaggio.Size = new System.Drawing.Size(92, 97);
            this.ptbPersonaggio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPersonaggio.TabIndex = 1;
            this.ptbPersonaggio.TabStop = false;
            this.ptbPersonaggio.Click += new System.EventHandler(this.ptbPersonaggio_Click);
            // 
            // tmrGravità
            // 
            this.tmrGravità.Enabled = true;
            this.tmrGravità.Interval = 10;
            this.tmrGravità.Tick += new System.EventHandler(this.gravità);
            // 
            // ptbTerreno
            // 
            this.ptbTerreno.BackColor = System.Drawing.Color.Lime;
            this.ptbTerreno.Location = new System.Drawing.Point(-50, 312);
            this.ptbTerreno.Name = "ptbTerreno";
            this.ptbTerreno.Size = new System.Drawing.Size(1077, 77);
            this.ptbTerreno.TabIndex = 2;
            this.ptbTerreno.TabStop = false;
            // 
            // tmrSalto
            // 
            this.tmrSalto.Interval = 10;
            this.tmrSalto.Tick += new System.EventHandler(this.tmrSalto_Tick);
            // 
            // tmrDestra
            // 
            this.tmrDestra.Interval = 10;
            this.tmrDestra.Tick += new System.EventHandler(this.tmrDestra_Tick);
            // 
            // tmrSinistra
            // 
            this.tmrSinistra.Interval = 10;
            this.tmrSinistra.Tick += new System.EventHandler(this.tmrSinistra_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(854, 348);
            this.Controls.Add(this.ptbTerreno);
            this.Controls.Add(this.ptbPersonaggio);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonaggio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTerreno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbPersonaggio;
        private System.Windows.Forms.Timer tmrGravità;
        private System.Windows.Forms.PictureBox ptbTerreno;
        private System.Windows.Forms.Timer tmrSalto;
        private System.Windows.Forms.Timer tmrDestra;
        private System.Windows.Forms.Timer tmrSinistra;
    }
}

