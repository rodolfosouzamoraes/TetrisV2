namespace United_Blocks
{
    partial class FrmPrincipalTetris
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipalTetris));
            this.dgvTetris = new System.Windows.Forms.DataGridView();
            this.timerPecas = new System.Windows.Forms.Timer(this.components);
            this.TimerCaindo = new System.Windows.Forms.Timer(this.components);
            this.lbLinhas = new System.Windows.Forms.Label();
            this.txtBoxPontuacao = new System.Windows.Forms.TextBox();
            this.txtBoxLinhas = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnPausa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pbRanking = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTetris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTetris
            // 
            this.dgvTetris.AllowUserToAddRows = false;
            this.dgvTetris.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTetris.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTetris.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTetris.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvTetris.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTetris.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTetris.Cursor = System.Windows.Forms.Cursors.No;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTetris.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTetris.GridColor = System.Drawing.Color.Black;
            this.dgvTetris.Location = new System.Drawing.Point(-42, -110);
            this.dgvTetris.MultiSelect = false;
            this.dgvTetris.Name = "dgvTetris";
            this.dgvTetris.ReadOnly = true;
            this.dgvTetris.Size = new System.Drawing.Size(338, 652);
            this.dgvTetris.TabIndex = 0;
            this.dgvTetris.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTetris_CellClick);
            this.dgvTetris.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTetris_CellContentClick);
            this.dgvTetris.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTetris_CellFormatting);
            // 
            // timerPecas
            // 
            this.timerPecas.Interval = 1000;
            this.timerPecas.Tick += new System.EventHandler(this.timerPecas_Tick);
            // 
            // TimerCaindo
            // 
            this.TimerCaindo.Interval = 250;
            this.TimerCaindo.Tick += new System.EventHandler(this.TimerCaindo_Tick);
            // 
            // lbLinhas
            // 
            this.lbLinhas.AutoSize = true;
            this.lbLinhas.Font = new System.Drawing.Font("MV Boli", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLinhas.Location = new System.Drawing.Point(303, 333);
            this.lbLinhas.Name = "lbLinhas";
            this.lbLinhas.Size = new System.Drawing.Size(149, 44);
            this.lbLinhas.TabIndex = 2;
            this.lbLinhas.Text = "LINHAS";
            // 
            // txtBoxPontuacao
            // 
            this.txtBoxPontuacao.BackColor = System.Drawing.Color.Black;
            this.txtBoxPontuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPontuacao.ForeColor = System.Drawing.Color.LightGreen;
            this.txtBoxPontuacao.Location = new System.Drawing.Point(309, 267);
            this.txtBoxPontuacao.MaxLength = 12;
            this.txtBoxPontuacao.Name = "txtBoxPontuacao";
            this.txtBoxPontuacao.Size = new System.Drawing.Size(225, 45);
            this.txtBoxPontuacao.TabIndex = 1;
            this.txtBoxPontuacao.Text = "0";
            this.txtBoxPontuacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxPontuacao.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxPontuacao_MouseClick);
            // 
            // txtBoxLinhas
            // 
            this.txtBoxLinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLinhas.Location = new System.Drawing.Point(310, 375);
            this.txtBoxLinhas.MaxLength = 12;
            this.txtBoxLinhas.Name = "txtBoxLinhas";
            this.txtBoxLinhas.Size = new System.Drawing.Size(225, 45);
            this.txtBoxLinhas.TabIndex = 2;
            this.txtBoxLinhas.Text = "0";
            this.txtBoxLinhas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBoxLinhas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxLinhas_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(296, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 95);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(309, 483);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(226, 34);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnPausa
            // 
            this.btnPausa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPausa.Location = new System.Drawing.Point(309, 443);
            this.btnPausa.Name = "btnPausa";
            this.btnPausa.Size = new System.Drawing.Size(226, 34);
            this.btnPausa.TabIndex = 4;
            this.btnPausa.Text = "Pause";
            this.btnPausa.UseVisualStyleBackColor = true;
            this.btnPausa.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(406, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "United Blocks";
            // 
            // pbRanking
            // 
            this.pbRanking.BackgroundImage = global::United_Blocks.Properties.Resources.rating4;
            this.pbRanking.InitialImage = global::United_Blocks.Properties.Resources.rating4;
            this.pbRanking.Location = new System.Drawing.Point(360, 121);
            this.pbRanking.Name = "pbRanking";
            this.pbRanking.Size = new System.Drawing.Size(128, 128);
            this.pbRanking.TabIndex = 11;
            this.pbRanking.TabStop = false;
            // 
            // FrmPrincipalTetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 529);
            this.Controls.Add(this.pbRanking);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPausa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBoxLinhas);
            this.Controls.Add(this.txtBoxPontuacao);
            this.Controls.Add(this.lbLinhas);
            this.Controls.Add(this.dgvTetris);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipalTetris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "United Blocks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipalTetris_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipalTetris_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPrincipalTetris_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTetris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRanking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTetris;
        private System.Windows.Forms.Timer timerPecas;
        private System.Windows.Forms.Timer TimerCaindo;
        private System.Windows.Forms.Label lbLinhas;
        private System.Windows.Forms.TextBox txtBoxPontuacao;
        private System.Windows.Forms.TextBox txtBoxLinhas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnPausa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbRanking;
    }
}

