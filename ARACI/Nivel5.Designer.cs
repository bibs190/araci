namespace ARACI
{
    partial class Nivel5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nivel5));
            this.lblTimeElapse = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnEmbaralhar = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.gbOriginal = new System.Windows.Forms.GroupBox();
            this.gbPuzzleBox = new System.Windows.Forms.GroupBox();
            this.pbx8 = new System.Windows.Forms.PictureBox();
            this.pbx9 = new System.Windows.Forms.PictureBox();
            this.pbx7 = new System.Windows.Forms.PictureBox();
            this.pbx6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pbx4 = new System.Windows.Forms.PictureBox();
            this.pbx3 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.lblMovimentosFeitos = new System.Windows.Forms.Label();
            this.tmrTimeElapse = new System.Windows.Forms.Timer(this.components);
            this.gbPuzzleBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTimeElapse
            // 
            this.lblTimeElapse.AutoSize = true;
            this.lblTimeElapse.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapse.Location = new System.Drawing.Point(717, 368);
            this.lblTimeElapse.Name = "lblTimeElapse";
            this.lblTimeElapse.Size = new System.Drawing.Size(325, 77);
            this.lblTimeElapse.TabIndex = 0;
            this.lblTimeElapse.Text = "00:00:00";
            this.lblTimeElapse.Click += new System.EventHandler(this.lblTimeElapse_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnSair.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(940, 473);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(119, 103);
            this.BtnSair.TabIndex = 11;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.btnQuit_Click_1);
            // 
            // BtnEmbaralhar
            // 
            this.BtnEmbaralhar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnEmbaralhar.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmbaralhar.Location = new System.Drawing.Point(679, 473);
            this.BtnEmbaralhar.Name = "BtnEmbaralhar";
            this.BtnEmbaralhar.Size = new System.Drawing.Size(130, 103);
            this.BtnEmbaralhar.TabIndex = 10;
            this.BtnEmbaralhar.Text = "Embaralhar";
            this.BtnEmbaralhar.UseVisualStyleBackColor = false;
            this.BtnEmbaralhar.Click += new System.EventHandler(this.btnSuffle_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPause.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPause.Location = new System.Drawing.Point(815, 473);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(119, 103);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pausar";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // gbOriginal
            // 
            this.gbOriginal.BackgroundImage = global::ARACI.Properties.Resources.numerosNivel4;
            this.gbOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbOriginal.Location = new System.Drawing.Point(730, 30);
            this.gbOriginal.Name = "gbOriginal";
            this.gbOriginal.Size = new System.Drawing.Size(312, 303);
            this.gbOriginal.TabIndex = 8;
            this.gbOriginal.TabStop = false;
            // 
            // gbPuzzleBox
            // 
            this.gbPuzzleBox.Controls.Add(this.pbx8);
            this.gbPuzzleBox.Controls.Add(this.pbx9);
            this.gbPuzzleBox.Controls.Add(this.pbx7);
            this.gbPuzzleBox.Controls.Add(this.pbx6);
            this.gbPuzzleBox.Controls.Add(this.pb5);
            this.gbPuzzleBox.Controls.Add(this.pbx4);
            this.gbPuzzleBox.Controls.Add(this.pbx3);
            this.gbPuzzleBox.Controls.Add(this.pbx2);
            this.gbPuzzleBox.Controls.Add(this.pbx1);
            this.gbPuzzleBox.Location = new System.Drawing.Point(16, 22);
            this.gbPuzzleBox.Name = "gbPuzzleBox";
            this.gbPuzzleBox.Size = new System.Drawing.Size(616, 631);
            this.gbPuzzleBox.TabIndex = 0;
            this.gbPuzzleBox.TabStop = false;
            this.gbPuzzleBox.Text = "Quebra-Cabeça";
            // 
            // pbx8
            // 
            this.pbx8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx8.Location = new System.Drawing.Point(399, 417);
            this.pbx8.Name = "pbx8";
            this.pbx8.Size = new System.Drawing.Size(200, 200);
            this.pbx8.TabIndex = 7;
            this.pbx8.TabStop = false;
            this.pbx8.Click += new System.EventHandler(this.SwitcPictureBox);
            // 
            // pbx9
            // 
            this.pbx9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx9.Location = new System.Drawing.Point(203, 417);
            this.pbx9.Name = "pbx9";
            this.pbx9.Size = new System.Drawing.Size(200, 200);
            this.pbx9.TabIndex = 8;
            this.pbx9.TabStop = false;
            this.pbx9.Click += new System.EventHandler(this.SwitcPictureBox);
            // 
            // pbx7
            // 
            this.pbx7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx7.Location = new System.Drawing.Point(15, 417);
            this.pbx7.Name = "pbx7";
            this.pbx7.Size = new System.Drawing.Size(191, 200);
            this.pbx7.TabIndex = 6;
            this.pbx7.TabStop = false;
            this.pbx7.Click += new System.EventHandler(this.SwitcPictureBox);
            // 
            // pbx6
            // 
            this.pbx6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx6.Location = new System.Drawing.Point(399, 223);
            this.pbx6.Name = "pbx6";
            this.pbx6.Size = new System.Drawing.Size(200, 200);
            this.pbx6.TabIndex = 5;
            this.pbx6.TabStop = false;
            this.pbx6.Click += new System.EventHandler(this.SwitcPictureBox);
            // 
            // pb5
            // 
            this.pb5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb5.Location = new System.Drawing.Point(203, 223);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(200, 200);
            this.pb5.TabIndex = 4;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.SwitcPictureBox);
            // 
            // pbx4
            // 
            this.pbx4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx4.Location = new System.Drawing.Point(15, 223);
            this.pbx4.Name = "pbx4";
            this.pbx4.Size = new System.Drawing.Size(191, 200);
            this.pbx4.TabIndex = 3;
            this.pbx4.TabStop = false;
            this.pbx4.Click += new System.EventHandler(this.SwitcPictureBox);
            // 
            // pbx3
            // 
            this.pbx3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx3.Location = new System.Drawing.Point(399, 31);
            this.pbx3.Name = "pbx3";
            this.pbx3.Size = new System.Drawing.Size(200, 200);
            this.pbx3.TabIndex = 2;
            this.pbx3.TabStop = false;
            this.pbx3.Click += new System.EventHandler(this.SwitcPictureBox);
            // 
            // pbx2
            // 
            this.pbx2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx2.Location = new System.Drawing.Point(203, 31);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(200, 200);
            this.pbx2.TabIndex = 1;
            this.pbx2.TabStop = false;
            this.pbx2.Click += new System.EventHandler(this.SwitcPictureBox);
            // 
            // pbx1
            // 
            this.pbx1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbx1.Location = new System.Drawing.Point(15, 31);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(191, 200);
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Click += new System.EventHandler(this.SwitcPictureBox);
            // 
            // lblMovimentosFeitos
            // 
            this.lblMovimentosFeitos.AutoSize = true;
            this.lblMovimentosFeitos.BackColor = System.Drawing.Color.Transparent;
            this.lblMovimentosFeitos.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovimentosFeitos.ForeColor = System.Drawing.Color.Black;
            this.lblMovimentosFeitos.Location = new System.Drawing.Point(674, 614);
            this.lblMovimentosFeitos.Name = "lblMovimentosFeitos";
            this.lblMovimentosFeitos.Size = new System.Drawing.Size(213, 25);
            this.lblMovimentosFeitos.TabIndex = 12;
            this.lblMovimentosFeitos.Text = "Movimentos feitos:";
            this.lblMovimentosFeitos.Click += new System.EventHandler(this.lblMovimentosFeitos_Click);
            // 
            // tmrTimeElapse
            // 
            this.tmrTimeElapse.Enabled = true;
            this.tmrTimeElapse.Interval = 900;
            this.tmrTimeElapse.Tick += new System.EventHandler(this.UpdateTimeElapse);
            // 
            // Nivel5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1095, 664);
            this.Controls.Add(this.lblMovimentosFeitos);
            this.Controls.Add(this.lblTimeElapse);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnEmbaralhar);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.gbOriginal);
            this.Controls.Add(this.gbPuzzleBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Nivel5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo de Quebra-Cabeças";
            this.Load += new System.EventHandler(this.Nivel5_Load);
            this.gbPuzzleBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeElapse;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnEmbaralhar;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox gbOriginal;
        private System.Windows.Forms.GroupBox gbPuzzleBox;
        private System.Windows.Forms.PictureBox pbx8;
        private System.Windows.Forms.PictureBox pbx9;
        private System.Windows.Forms.PictureBox pbx7;
        private System.Windows.Forms.PictureBox pbx6;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pbx4;
        private System.Windows.Forms.PictureBox pbx3;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.Label lblMovimentosFeitos;
        private System.Windows.Forms.Timer tmrTimeElapse;
    }
}