namespace United_Blocks
{
    partial class FrmPlacarOnline
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
            this.lbPrimeiro = new System.Windows.Forms.Label();
            this.lbSegundo = new System.Windows.Forms.Label();
            this.lbTerceiro = new System.Windows.Forms.Label();
            this.tabEasy = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvEasy = new System.Windows.Forms.DataGridView();
            this.sCRNicknameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCRScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCRDateGameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbScoreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvNormal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvHard = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvJedi = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvArcade = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabEasy.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormal)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHard)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedi)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArcade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPrimeiro
            // 
            this.lbPrimeiro.AutoSize = true;
            this.lbPrimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrimeiro.Location = new System.Drawing.Point(95, 12);
            this.lbPrimeiro.Name = "lbPrimeiro";
            this.lbPrimeiro.Size = new System.Drawing.Size(217, 32);
            this.lbPrimeiro.TabIndex = 1;
            this.lbPrimeiro.Text = "Primeiro Coloca";
            // 
            // lbSegundo
            // 
            this.lbSegundo.AutoSize = true;
            this.lbSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegundo.Location = new System.Drawing.Point(95, 112);
            this.lbSegundo.Name = "lbSegundo";
            this.lbSegundo.Size = new System.Drawing.Size(217, 32);
            this.lbSegundo.TabIndex = 3;
            this.lbSegundo.Text = "Primeiro Coloca";
            // 
            // lbTerceiro
            // 
            this.lbTerceiro.AutoSize = true;
            this.lbTerceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTerceiro.Location = new System.Drawing.Point(95, 214);
            this.lbTerceiro.Name = "lbTerceiro";
            this.lbTerceiro.Size = new System.Drawing.Size(217, 32);
            this.lbTerceiro.TabIndex = 5;
            this.lbTerceiro.Text = "Primeiro Coloca";
            // 
            // tabEasy
            // 
            this.tabEasy.Controls.Add(this.tabPage1);
            this.tabEasy.Controls.Add(this.tabPage2);
            this.tabEasy.Controls.Add(this.tabPage3);
            this.tabEasy.Controls.Add(this.tabPage4);
            this.tabEasy.Controls.Add(this.tabPage5);
            this.tabEasy.Location = new System.Drawing.Point(335, 12);
            this.tabEasy.Name = "tabEasy";
            this.tabEasy.SelectedIndex = 0;
            this.tabEasy.Size = new System.Drawing.Size(342, 276);
            this.tabEasy.TabIndex = 6;
            this.tabEasy.SelectedIndexChanged += new System.EventHandler(this.tabEasy_SelectedIndexChanged);
            this.tabEasy.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabEasy_Selecting);
            this.tabEasy.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabEasy_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvEasy);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(334, 250);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Easy";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvEasy
            // 
            this.dgvEasy.AllowUserToAddRows = false;
            this.dgvEasy.AllowUserToDeleteRows = false;
            this.dgvEasy.AutoGenerateColumns = false;
            this.dgvEasy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEasy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sCRNicknameDataGridViewTextBoxColumn,
            this.sCRScoreDataGridViewTextBoxColumn,
            this.sCRDateGameDataGridViewTextBoxColumn});
            this.dgvEasy.DataSource = this.tbScoreBindingSource;
            this.dgvEasy.Location = new System.Drawing.Point(6, 6);
            this.dgvEasy.Name = "dgvEasy";
            this.dgvEasy.ReadOnly = true;
            this.dgvEasy.RowHeadersVisible = false;
            this.dgvEasy.Size = new System.Drawing.Size(322, 238);
            this.dgvEasy.TabIndex = 0;
            // 
            // sCRNicknameDataGridViewTextBoxColumn
            // 
            this.sCRNicknameDataGridViewTextBoxColumn.DataPropertyName = "SCR_Nickname";
            this.sCRNicknameDataGridViewTextBoxColumn.HeaderText = "Usuario / Nick";
            this.sCRNicknameDataGridViewTextBoxColumn.Name = "sCRNicknameDataGridViewTextBoxColumn";
            this.sCRNicknameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sCRScoreDataGridViewTextBoxColumn
            // 
            this.sCRScoreDataGridViewTextBoxColumn.DataPropertyName = "SCR_Score";
            this.sCRScoreDataGridViewTextBoxColumn.HeaderText = "Pontuação / Score";
            this.sCRScoreDataGridViewTextBoxColumn.Name = "sCRScoreDataGridViewTextBoxColumn";
            this.sCRScoreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sCRDateGameDataGridViewTextBoxColumn
            // 
            this.sCRDateGameDataGridViewTextBoxColumn.DataPropertyName = "SCR_DateGame";
            this.sCRDateGameDataGridViewTextBoxColumn.HeaderText = "Data Jogo / Game Date";
            this.sCRDateGameDataGridViewTextBoxColumn.Name = "sCRDateGameDataGridViewTextBoxColumn";
            this.sCRDateGameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbScoreBindingSource
            // 
            this.tbScoreBindingSource.DataSource = typeof(United_Blocks.MODEL.tb_Score);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvNormal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(334, 250);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Normal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvNormal
            // 
            this.dgvNormal.AllowUserToAddRows = false;
            this.dgvNormal.AllowUserToDeleteRows = false;
            this.dgvNormal.AutoGenerateColumns = false;
            this.dgvNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNormal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvNormal.DataSource = this.tbScoreBindingSource;
            this.dgvNormal.Location = new System.Drawing.Point(6, 6);
            this.dgvNormal.Name = "dgvNormal";
            this.dgvNormal.ReadOnly = true;
            this.dgvNormal.RowHeadersVisible = false;
            this.dgvNormal.Size = new System.Drawing.Size(322, 238);
            this.dgvNormal.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SCR_Nickname";
            this.dataGridViewTextBoxColumn1.HeaderText = "Usuario / Nick";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SCR_Score";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pontuação / Score";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SCR_DateGame";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data Jogo / Game Date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvHard);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(334, 250);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hard";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvHard
            // 
            this.dgvHard.AllowUserToAddRows = false;
            this.dgvHard.AllowUserToDeleteRows = false;
            this.dgvHard.AutoGenerateColumns = false;
            this.dgvHard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvHard.DataSource = this.tbScoreBindingSource;
            this.dgvHard.Location = new System.Drawing.Point(6, 6);
            this.dgvHard.Name = "dgvHard";
            this.dgvHard.ReadOnly = true;
            this.dgvHard.RowHeadersVisible = false;
            this.dgvHard.Size = new System.Drawing.Size(322, 238);
            this.dgvHard.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SCR_Nickname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Usuario / Nick";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SCR_Score";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pontuação / Score";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "SCR_DateGame";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data Jogo / Game Date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvJedi);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(334, 250);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Jedi";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvJedi
            // 
            this.dgvJedi.AllowUserToAddRows = false;
            this.dgvJedi.AllowUserToDeleteRows = false;
            this.dgvJedi.AutoGenerateColumns = false;
            this.dgvJedi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJedi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvJedi.DataSource = this.tbScoreBindingSource;
            this.dgvJedi.Location = new System.Drawing.Point(6, 6);
            this.dgvJedi.Name = "dgvJedi";
            this.dgvJedi.ReadOnly = true;
            this.dgvJedi.RowHeadersVisible = false;
            this.dgvJedi.Size = new System.Drawing.Size(322, 238);
            this.dgvJedi.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SCR_Nickname";
            this.dataGridViewTextBoxColumn7.HeaderText = "Usuario / Nick";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SCR_Score";
            this.dataGridViewTextBoxColumn8.HeaderText = "Pontuação / Score";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SCR_DateGame";
            this.dataGridViewTextBoxColumn9.HeaderText = "Data Jogo / Game Date";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvArcade);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(334, 250);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Arcade";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvArcade
            // 
            this.dgvArcade.AllowUserToAddRows = false;
            this.dgvArcade.AllowUserToDeleteRows = false;
            this.dgvArcade.AutoGenerateColumns = false;
            this.dgvArcade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArcade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvArcade.DataSource = this.tbScoreBindingSource;
            this.dgvArcade.Location = new System.Drawing.Point(6, 6);
            this.dgvArcade.Name = "dgvArcade";
            this.dgvArcade.ReadOnly = true;
            this.dgvArcade.RowHeadersVisible = false;
            this.dgvArcade.Size = new System.Drawing.Size(322, 238);
            this.dgvArcade.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "SCR_Nickname";
            this.dataGridViewTextBoxColumn10.HeaderText = "Usuario / Nick";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SCR_Score";
            this.dataGridViewTextBoxColumn11.HeaderText = "Pontuação / Score";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "SCR_DateGame";
            this.dataGridViewTextBoxColumn12.HeaderText = "Data Jogo / Game Date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::United_Blocks.Properties.Resources.bronze;
            this.pictureBox3.Location = new System.Drawing.Point(25, 214);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::United_Blocks.Properties.Resources.silver;
            this.pictureBox2.Location = new System.Drawing.Point(25, 112);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::United_Blocks.Properties.Resources.gold;
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPlacarOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 297);
            this.Controls.Add(this.tabEasy);
            this.Controls.Add(this.lbTerceiro);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbSegundo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbPrimeiro);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlacarOnline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pontuação | Score";
            this.Load += new System.EventHandler(this.FrmPlacarOnline_Load);
            this.tabEasy.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbScoreBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormal)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHard)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedi)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArcade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbPrimeiro;
        private System.Windows.Forms.Label lbSegundo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbTerceiro;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabControl tabEasy;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvEasy;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCRNicknameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCRScoreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCRDateGameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tbScoreBindingSource;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvNormal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvHard;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvJedi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dgvArcade;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}