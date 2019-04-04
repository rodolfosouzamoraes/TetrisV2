namespace United_Blocks
{
    partial class FrmJogador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJogador));
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.lbModo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDificil = new System.Windows.Forms.Button();
            this.btnMedio = new System.Windows.Forms.Button();
            this.btnFacil = new System.Windows.Forms.Button();
            this.btnJEDI = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNome.Location = new System.Drawing.Point(56, 100);
            this.txtBoxNome.MaxLength = 15;
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(113, 23);
            this.txtBoxNome.TabIndex = 0;
            // 
            // lbModo
            // 
            this.lbModo.AutoSize = true;
            this.lbModo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModo.Location = new System.Drawing.Point(91, 82);
            this.lbModo.Name = "lbModo";
            this.lbModo.Size = new System.Drawing.Size(47, 13);
            this.lbModo.TabIndex = 10;
            this.lbModo.Text = "Arcade";
            this.lbModo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(149, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(69, 31);
            this.btnSair.TabIndex = 11;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            this.btnSair.MouseEnter += new System.EventHandler(this.btnSair_MouseEnter);
            this.btnSair.MouseLeave += new System.EventHandler(this.btnSair_MouseLeave);
            // 
            // btnDificil
            // 
            this.btnDificil.BackColor = System.Drawing.Color.Transparent;
            this.btnDificil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDificil.BackgroundImage")));
            this.btnDificil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDificil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDificil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDificil.Location = new System.Drawing.Point(12, 235);
            this.btnDificil.Name = "btnDificil";
            this.btnDificil.Size = new System.Drawing.Size(100, 100);
            this.btnDificil.TabIndex = 4;
            this.btnDificil.UseVisualStyleBackColor = false;
            this.btnDificil.Click += new System.EventHandler(this.btnDificil_Click);
            this.btnDificil.MouseEnter += new System.EventHandler(this.btnDificil_MouseEnter);
            this.btnDificil.MouseLeave += new System.EventHandler(this.btnDificil_MouseLeave);
            // 
            // btnMedio
            // 
            this.btnMedio.BackColor = System.Drawing.Color.Transparent;
            this.btnMedio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMedio.BackgroundImage")));
            this.btnMedio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMedio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedio.Location = new System.Drawing.Point(118, 129);
            this.btnMedio.Name = "btnMedio";
            this.btnMedio.Size = new System.Drawing.Size(100, 100);
            this.btnMedio.TabIndex = 3;
            this.btnMedio.UseVisualStyleBackColor = false;
            this.btnMedio.Click += new System.EventHandler(this.button3_Click);
            this.btnMedio.MouseEnter += new System.EventHandler(this.btnMedio_MouseEnter);
            this.btnMedio.MouseLeave += new System.EventHandler(this.btnMedio_MouseLeave);
            // 
            // btnFacil
            // 
            this.btnFacil.BackColor = System.Drawing.Color.Transparent;
            this.btnFacil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFacil.BackgroundImage")));
            this.btnFacil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFacil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacil.Location = new System.Drawing.Point(12, 129);
            this.btnFacil.Name = "btnFacil";
            this.btnFacil.Size = new System.Drawing.Size(100, 100);
            this.btnFacil.TabIndex = 2;
            this.btnFacil.UseVisualStyleBackColor = false;
            this.btnFacil.Click += new System.EventHandler(this.btnFacil_Click);
            this.btnFacil.MouseEnter += new System.EventHandler(this.btnFacil_MouseEnter);
            this.btnFacil.MouseLeave += new System.EventHandler(this.btnFacil_MouseLeave);
            // 
            // btnJEDI
            // 
            this.btnJEDI.BackColor = System.Drawing.Color.Transparent;
            this.btnJEDI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnJEDI.BackgroundImage")));
            this.btnJEDI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnJEDI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJEDI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJEDI.ForeColor = System.Drawing.Color.White;
            this.btnJEDI.Location = new System.Drawing.Point(118, 235);
            this.btnJEDI.Name = "btnJEDI";
            this.btnJEDI.Size = new System.Drawing.Size(100, 100);
            this.btnJEDI.TabIndex = 5;
            this.btnJEDI.UseVisualStyleBackColor = false;
            this.btnJEDI.Click += new System.EventHandler(this.button1_Click);
            this.btnJEDI.MouseEnter += new System.EventHandler(this.btnJEDI_MouseEnter);
            this.btnJEDI.MouseLeave += new System.EventHandler(this.btnJEDI_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(84, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 63);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(64, 341);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 100);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            this.btnSalvar.MouseEnter += new System.EventHandler(this.btnSalvar_MouseEnter);
            this.btnSalvar.MouseLeave += new System.EventHandler(this.btnSalvar_MouseLeave);
            // 
            // FrmJogador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(229, 450);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lbModo);
            this.Controls.Add(this.btnDificil);
            this.Controls.Add(this.btnMedio);
            this.Controls.Add(this.btnFacil);
            this.Controls.Add(this.btnJEDI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxNome);
            this.Controls.Add(this.btnSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmJogador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nome jogador";
            this.Load += new System.EventHandler(this.FrmJogador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtBoxNome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnJEDI;
        private System.Windows.Forms.Button btnFacil;
        private System.Windows.Forms.Button btnMedio;
        private System.Windows.Forms.Button btnDificil;
        private System.Windows.Forms.Label lbModo;
        private System.Windows.Forms.Button btnSair;
    }
}