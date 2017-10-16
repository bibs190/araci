namespace ARACI
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.btn1nivel = new System.Windows.Forms.Button();
            this.btn2nivel = new System.Windows.Forms.Button();
            this.btn3nivel = new System.Windows.Forms.Button();
            this.btn4nivel = new System.Windows.Forms.Button();
            this.btn5nivel = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btn1nivel
            // 
            this.btn1nivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn1nivel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn1nivel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1nivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn1nivel.Location = new System.Drawing.Point(253, 38);
            this.btn1nivel.Name = "btn1nivel";
            this.btn1nivel.Size = new System.Drawing.Size(66, 44);
            this.btn1nivel.TabIndex = 0;
            this.btn1nivel.Text = "NÍVEL 1";
            this.btn1nivel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn1nivel.UseVisualStyleBackColor = false;
            this.btn1nivel.Click += new System.EventHandler(this.btn1nivel_Click);
            // 
            // btn2nivel
            // 
            this.btn2nivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn2nivel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2nivel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn2nivel.Location = new System.Drawing.Point(159, 12);
            this.btn2nivel.Name = "btn2nivel";
            this.btn2nivel.Size = new System.Drawing.Size(66, 44);
            this.btn2nivel.TabIndex = 1;
            this.btn2nivel.Text = "NÍVEL 2";
            this.btn2nivel.UseVisualStyleBackColor = false;
            this.btn2nivel.Click += new System.EventHandler(this.btn2_nivelCLICK);
            // 
            // btn3nivel
            // 
            this.btn3nivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn3nivel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3nivel.Location = new System.Drawing.Point(65, 27);
            this.btn3nivel.Name = "btn3nivel";
            this.btn3nivel.Size = new System.Drawing.Size(66, 44);
            this.btn3nivel.TabIndex = 2;
            this.btn3nivel.Text = "NÍVEL 3";
            this.btn3nivel.UseVisualStyleBackColor = false;
            this.btn3nivel.Click += new System.EventHandler(this.btn3nivel_Click);
            // 
            // btn4nivel
            // 
            this.btn4nivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn4nivel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4nivel.Location = new System.Drawing.Point(0, 98);
            this.btn4nivel.Name = "btn4nivel";
            this.btn4nivel.Size = new System.Drawing.Size(66, 44);
            this.btn4nivel.TabIndex = 3;
            this.btn4nivel.Text = "NÍVEL 4";
            this.btn4nivel.UseVisualStyleBackColor = false;
            this.btn4nivel.Click += new System.EventHandler(this.btn4nivel_Click);
            // 
            // btn5nivel
            // 
            this.btn5nivel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn5nivel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5nivel.Location = new System.Drawing.Point(400, 217);
            this.btn5nivel.Name = "btn5nivel";
            this.btn5nivel.Size = new System.Drawing.Size(66, 44);
            this.btn5nivel.TabIndex = 4;
            this.btn5nivel.Text = "NÍVEL 5";
            this.btn5nivel.UseVisualStyleBackColor = false;
            this.btn5nivel.Click += new System.EventHandler(this.btn5NivelCLICK);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Brown;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSair.Location = new System.Drawing.Point(0, 353);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(66, 40);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.MediumBlue;
            this.linkLabel1.Location = new System.Drawing.Point(320, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(133, 23);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Classificação";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnSair;
            this.ClientSize = new System.Drawing.Size(465, 405);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btn5nivel);
            this.Controls.Add(this.btn4nivel);
            this.Controls.Add(this.btn3nivel);
            this.Controls.Add(this.btn2nivel);
            this.Controls.Add(this.btn1nivel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1nivel;
        private System.Windows.Forms.Button btn2nivel;
        private System.Windows.Forms.Button btn3nivel;
        private System.Windows.Forms.Button btn4nivel;
        private System.Windows.Forms.Button btn5nivel;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}