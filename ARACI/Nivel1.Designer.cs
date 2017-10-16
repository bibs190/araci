namespace ARACI
{
    partial class Nivel1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nivel1));
            this.nivel1video = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nivel1video)).BeginInit();
            this.SuspendLayout();
            // 
            // nivel1video
            // 
            this.nivel1video.Enabled = true;
            this.nivel1video.Location = new System.Drawing.Point(73, 61);
            this.nivel1video.Name = "nivel1video";
            this.nivel1video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("nivel1video.OcxState")));
            this.nivel1video.Size = new System.Drawing.Size(637, 400);
            this.nivel1video.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Black;
            this.lbl1.Location = new System.Drawing.Point(115, 19);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(531, 39);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "APRESENTAÇÃO DOS NÚMEROS";
            // 
            // Nivel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(751, 473);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.nivel1video);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nivel1";
            this.Text = "Apresentação dos Números";
            this.Load += new System.EventHandler(this.Nivel1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nivel1video)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer nivel1video;
        private System.Windows.Forms.Label lbl1;
    }
}