namespace United_Blocks.VIEW
{
    partial class FrmCadastrarUsuario
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
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbConfSenha = new System.Windows.Forms.Label();
            this.txtConfSenha = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnQuestSenha = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnQuestUsu = new System.Windows.Forms.Button();
            this.btnQuestEmail = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbContEmail = new System.Windows.Forms.Label();
            this.lbContagem = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(12, 61);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(19, 20);
            this.lbSenha.TabIndex = 7;
            this.lbSenha.Text = "*:";
            this.lbSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(16, 84);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(70, 26);
            this.txtSenha.TabIndex = 1;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.Location = new System.Drawing.Point(12, 9);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(19, 20);
            this.lbUsuario.TabIndex = 5;
            this.lbUsuario.Text = "*:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(16, 32);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(221, 26);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // lbConfSenha
            // 
            this.lbConfSenha.AutoSize = true;
            this.lbConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfSenha.Location = new System.Drawing.Point(12, 113);
            this.lbConfSenha.Name = "lbConfSenha";
            this.lbConfSenha.Size = new System.Drawing.Size(19, 20);
            this.lbConfSenha.TabIndex = 9;
            this.lbConfSenha.Text = "*:";
            this.lbConfSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtConfSenha
            // 
            this.txtConfSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfSenha.Location = new System.Drawing.Point(16, 136);
            this.txtConfSenha.MaxLength = 8;
            this.txtConfSenha.Name = "txtConfSenha";
            this.txtConfSenha.PasswordChar = '*';
            this.txtConfSenha.Size = new System.Drawing.Size(70, 26);
            this.txtConfSenha.TabIndex = 2;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(12, 165);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(19, 20);
            this.lbEmail.TabIndex = 11;
            this.lbEmail.Text = "*:";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(16, 188);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(221, 26);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnQuestSenha
            // 
            this.btnQuestSenha.Location = new System.Drawing.Point(92, 85);
            this.btnQuestSenha.Name = "btnQuestSenha";
            this.btnQuestSenha.Size = new System.Drawing.Size(26, 26);
            this.btnQuestSenha.TabIndex = 17;
            this.btnQuestSenha.UseVisualStyleBackColor = true;
            this.btnQuestSenha.Click += new System.EventHandler(this.btnQuestSenha_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(145, 220);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(16, 220);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(123, 23);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnQuestUsu
            // 
            this.btnQuestUsu.Location = new System.Drawing.Point(243, 32);
            this.btnQuestUsu.Name = "btnQuestUsu";
            this.btnQuestUsu.Size = new System.Drawing.Size(26, 26);
            this.btnQuestUsu.TabIndex = 6;
            this.btnQuestUsu.UseVisualStyleBackColor = true;
            this.btnQuestUsu.Click += new System.EventHandler(this.btnQuestUsu_Click);
            // 
            // btnQuestEmail
            // 
            this.btnQuestEmail.Location = new System.Drawing.Point(243, 188);
            this.btnQuestEmail.Name = "btnQuestEmail";
            this.btnQuestEmail.Size = new System.Drawing.Size(26, 26);
            this.btnQuestEmail.TabIndex = 7;
            this.btnQuestEmail.UseVisualStyleBackColor = true;
            this.btnQuestEmail.Click += new System.EventHandler(this.btnQuestEmail_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "- 30";
            // 
            // lbContEmail
            // 
            this.lbContEmail.AutoSize = true;
            this.lbContEmail.Location = new System.Drawing.Point(197, 172);
            this.lbContEmail.Name = "lbContEmail";
            this.lbContEmail.Size = new System.Drawing.Size(13, 13);
            this.lbContEmail.TabIndex = 21;
            this.lbContEmail.Text = "0";
            this.lbContEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbContagem
            // 
            this.lbContagem.AutoSize = true;
            this.lbContagem.Location = new System.Drawing.Point(197, 16);
            this.lbContagem.Name = "lbContagem";
            this.lbContagem.Size = new System.Drawing.Size(13, 13);
            this.lbContagem.TabIndex = 23;
            this.lbContagem.Text = "0";
            this.lbContagem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(212, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "- 15";
            // 
            // FrmCadastrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.lbContagem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbContEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnQuestEmail);
            this.Controls.Add(this.btnQuestUsu);
            this.Controls.Add(this.btnQuestSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbConfSenha);
            this.Controls.Add(this.txtConfSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.txtUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCadastrarUsuario";
            this.Load += new System.EventHandler(this.FrmCadastrarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbConfSenha;
        private System.Windows.Forms.TextBox txtConfSenha;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnQuestSenha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnQuestUsu;
        private System.Windows.Forms.Button btnQuestEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbContEmail;
        private System.Windows.Forms.Label lbContagem;
        private System.Windows.Forms.Label label8;
    }
}