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
            this.tmrAlto = new System.Windows.Forms.Timer(this.components);
            this.tmrGiù = new System.Windows.Forms.Timer(this.components);
            this.tmrColpo = new System.Windows.Forms.Timer(this.components);
            this.lblMunizioni = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmrNemici = new System.Windows.Forms.Timer(this.components);
            this.tmrRicarica = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonaggio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbPersonaggio
            // 
            this.ptbPersonaggio.BackColor = System.Drawing.Color.Transparent;
            this.ptbPersonaggio.Image = global::PROGETTO_GIOCO_1.Properties.Resources.personaggio_1_png;
            this.ptbPersonaggio.Location = new System.Drawing.Point(12, 160);
            this.ptbPersonaggio.Name = "ptbPersonaggio";
            this.ptbPersonaggio.Size = new System.Drawing.Size(92, 97);
            this.ptbPersonaggio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPersonaggio.TabIndex = 1;
            this.ptbPersonaggio.TabStop = false;
            // 
            // tmrAlto
            // 
            this.tmrAlto.Interval = 1;
            this.tmrAlto.Tick += new System.EventHandler(this.tmrAlto_Tick);
            // 
            // tmrGiù
            // 
            this.tmrGiù.Interval = 10;
            this.tmrGiù.Tick += new System.EventHandler(this.tmrGiù_Tick);
            // 
            // tmrColpo
            // 
            this.tmrColpo.Interval = 10;
            this.tmrColpo.Tick += new System.EventHandler(this.tmrColpo_Tick);
            // 
            // lblMunizioni
            // 
            this.lblMunizioni.AutoEllipsis = true;
            this.lblMunizioni.AutoSize = true;
            this.lblMunizioni.BackColor = System.Drawing.Color.Red;
            this.lblMunizioni.Font = new System.Drawing.Font("Noto Sans JP Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunizioni.ForeColor = System.Drawing.Color.Black;
            this.lblMunizioni.Location = new System.Drawing.Point(812, -2);
            this.lblMunizioni.Name = "lblMunizioni";
            this.lblMunizioni.Size = new System.Drawing.Size(60, 48);
            this.lblMunizioni.TabIndex = 3;
            this.lblMunizioni.Text = "30";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(915, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tmrRicarica
            // 
            this.tmrRicarica.Interval = 1000;
            this.tmrRicarica.Tick += new System.EventHandler(this.tmrRicarica_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.lblMunizioni);
            this.Controls.Add(this.ptbPersonaggio);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ptbPersonaggio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbPersonaggio;
        private System.Windows.Forms.Timer tmrAlto;
        private System.Windows.Forms.Timer tmrGiù;
        private System.Windows.Forms.Timer tmrColpo;
        private System.Windows.Forms.Label lblMunizioni;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrNemici;
        private System.Windows.Forms.Timer tmrRicarica;
    }
}

