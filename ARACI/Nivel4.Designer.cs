namespace ARACI
{
    partial class Nivel4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nivel4));
            this.PainelJogo = new System.Windows.Forms.Panel();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblRecordNumero = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // PainelJogo
            // 
            this.PainelJogo.Location = new System.Drawing.Point(12, 12);
            this.PainelJogo.Name = "PainelJogo";
            this.PainelJogo.Size = new System.Drawing.Size(371, 346);
            this.PainelJogo.TabIndex = 0;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.BackColor = System.Drawing.Color.Ivory;
            this.btnReiniciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReiniciar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReiniciar.Location = new System.Drawing.Point(429, 307);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(178, 51);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "Reiniciar Jogo";
            this.btnReiniciar.UseVisualStyleBackColor = false;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.BackColor = System.Drawing.Color.Transparent;
            this.lblRecord.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.Location = new System.Drawing.Point(535, 22);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(106, 29);
            this.lblRecord.TabIndex = 2;
            this.lblRecord.Text = "Record:";
            this.lblRecord.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRecordNumero
            // 
            this.lblRecordNumero.AccessibleName = "";
            this.lblRecordNumero.AutoSize = true;
            this.lblRecordNumero.BackColor = System.Drawing.Color.Transparent;
            this.lblRecordNumero.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordNumero.Location = new System.Drawing.Point(638, 22);
            this.lblRecordNumero.Name = "lblRecordNumero";
            this.lblRecordNumero.Size = new System.Drawing.Size(28, 29);
            this.lblRecordNumero.TabIndex = 3;
            this.lblRecordNumero.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 900;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Nivel4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(677, 386);
            this.Controls.Add(this.lblRecordNumero);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.PainelJogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Nivel4";
            this.Text = "Jogo da Memória";
            this.Load += new System.EventHandler(this.Nivel5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PainelJogo;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblRecordNumero;
        private System.Windows.Forms.Timer timer1;
    }
}