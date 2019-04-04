namespace United_Blocks.VIEW
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lkCadastrar = new System.Windows.Forms.LinkLabel();
            this.lkEsqueceuSenha = new System.Windows.Forms.LinkLabel();
            this.lkMudarSenha = new System.Windows.Forms.LinkLabel();
            this.lkOffline = new System.Windows.Forms.LinkLabel();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.rbPortugues = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(12, 88);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(173, 26);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(12, 190);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(173, 26);
            this.txtSenha.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEntrar.BackgroundImage")));
            this.btnEntrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEntrar.Location = new System.Drawing.Point(12, 257);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(173, 45);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lkCadastrar
            // 
            this.lkCadastrar.AutoSize = true;
            this.lkCadastrar.Location = new System.Drawing.Point(12, 219);
            this.lkCadastrar.Name = "lkCadastrar";
            this.lkCadastrar.Size = new System.Drawing.Size(63, 13);
            this.lkCadastrar.TabIndex = 6;
            this.lkCadastrar.TabStop = true;
            this.lkCadastrar.Text = "Cadastre-se";
            this.lkCadastrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lkEsqueceuSenha
            // 
            this.lkEsqueceuSenha.AutoSize = true;
            this.lkEsqueceuSenha.Location = new System.Drawing.Point(83, 219);
            this.lkEsqueceuSenha.Name = "lkEsqueceuSenha";
            this.lkEsqueceuSenha.Size = new System.Drawing.Size(102, 13);
            this.lkEsqueceuSenha.TabIndex = 8;
            this.lkEsqueceuSenha.TabStop = true;
            this.lkEsqueceuSenha.Text = "Esqueceu a senha?";
            this.lkEsqueceuSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lkMudarSenha
            // 
            this.lkMudarSenha.AutoSize = true;
            this.lkMudarSenha.Location = new System.Drawing.Point(83, 235);
            this.lkMudarSenha.Name = "lkMudarSenha";
            this.lkMudarSenha.Size = new System.Drawing.Size(84, 13);
            this.lkMudarSenha.TabIndex = 7;
            this.lkMudarSenha.TabStop = true;
            this.lkMudarSenha.Text = "Mudar a senha?";
            this.lkMudarSenha.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkMudarSenha_LinkClicked);
            // 
            // lkOffline
            // 
            this.lkOffline.AutoSize = true;
            this.lkOffline.Location = new System.Drawing.Point(11, 235);
            this.lkOffline.Name = "lkOffline";
            this.lkOffline.Size = new System.Drawing.Size(66, 13);
            this.lkOffline.TabIndex = 9;
            this.lkOffline.TabStop = true;
            this.lkOffline.Text = "Jogar Offline";
            this.lkOffline.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkOffline_LinkClicked);
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.BackColor = System.Drawing.Color.Transparent;
            this.rbEnglish.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbEnglish.Location = new System.Drawing.Point(126, 308);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(59, 17);
            this.rbEnglish.TabIndex = 5;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = false;
            this.rbEnglish.CheckedChanged += new System.EventHandler(this.rbEnglish_CheckedChanged);
            // 
            // rbPortugues
            // 
            this.rbPortugues.AutoSize = true;
            this.rbPortugues.BackColor = System.Drawing.Color.Transparent;
            this.rbPortugues.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rbPortugues.Location = new System.Drawing.Point(15, 308);
            this.rbPortugues.Name = "rbPortugues";
            this.rbPortugues.Size = new System.Drawing.Size(73, 17);
            this.rbPortugues.TabIndex = 4;
            this.rbPortugues.TabStop = true;
            this.rbPortugues.Text = "Português";
            this.rbPortugues.UseVisualStyleBackColor = false;
            this.rbPortugues.CheckedChanged += new System.EventHandler(this.rbPortugues_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(66, 120);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 330);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rbEnglish);
            this.Controls.Add(this.rbPortugues);
            this.Controls.Add(this.lkOffline);
            this.Controls.Add(this.lkMudarSenha);
            this.Controls.Add(this.lkEsqueceuSenha);
            this.Controls.Add(this.lkCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuário | Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.LinkLabel lkCadastrar;
        private System.Windows.Forms.LinkLabel lkEsqueceuSenha;
        private System.Windows.Forms.LinkLabel lkMudarSenha;
        private System.Windows.Forms.LinkLabel lkOffline;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbPortugues;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}