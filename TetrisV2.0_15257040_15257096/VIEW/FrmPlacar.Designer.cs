namespace United_Blocks
{
    partial class FrmPlacar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPlacar));
            this.dgvPlacar = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pontuacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jogadorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lbPlacar = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvNormal = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jogadorBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
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
            this.jogadorBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvArcade = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jogadorBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.jogadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jogadorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.jogadorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lbTerceiro = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbSegundo = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbPrimeiro = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource2)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource4)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHard)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource5)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArcade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPlacar
            // 
            this.dgvPlacar.AllowUserToAddRows = false;
            this.dgvPlacar.AllowUserToDeleteRows = false;
            this.dgvPlacar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPlacar.AutoGenerateColumns = false;
            this.dgvPlacar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlacar.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvPlacar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlacar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.pontuacaoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dgvPlacar.DataSource = this.jogadorBindingSource2;
            this.dgvPlacar.Location = new System.Drawing.Point(6, 6);
            this.dgvPlacar.Name = "dgvPlacar";
            this.dgvPlacar.ReadOnly = true;
            this.dgvPlacar.Size = new System.Drawing.Size(345, 230);
            this.dgvPlacar.TabIndex = 0;
            this.dgvPlacar.Click += new System.EventHandler(this.dgvPlacar_Click);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome / Name";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pontuacaoDataGridViewTextBoxColumn
            // 
            this.pontuacaoDataGridViewTextBoxColumn.DataPropertyName = "Pontuacao";
            this.pontuacaoDataGridViewTextBoxColumn.HeaderText = "Pontuação / Score";
            this.pontuacaoDataGridViewTextBoxColumn.Name = "pontuacaoDataGridViewTextBoxColumn";
            this.pontuacaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data do jogo / Game date";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jogadorBindingSource2
            // 
            this.jogadorBindingSource2.DataSource = typeof(United_Blocks.Jogador);
            // 
            // lbPlacar
            // 
            this.lbPlacar.AutoSize = true;
            this.lbPlacar.Font = new System.Drawing.Font("Forte", 30F);
            this.lbPlacar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbPlacar.Location = new System.Drawing.Point(12, 9);
            this.lbPlacar.Name = "lbPlacar";
            this.lbPlacar.Size = new System.Drawing.Size(376, 44);
            this.lbPlacar.TabIndex = 1;
            this.lbPlacar.Text = "Placar de Jogadores";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(313, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(365, 268);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.dgvPlacar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(357, 242);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fácil | Easy";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvNormal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(612, 242);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Normal";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // dgvNormal
            // 
            this.dgvNormal.AllowUserToAddRows = false;
            this.dgvNormal.AllowUserToDeleteRows = false;
            this.dgvNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNormal.AutoGenerateColumns = false;
            this.dgvNormal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNormal.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvNormal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNormal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvNormal.DataSource = this.jogadorBindingSource4;
            this.dgvNormal.Location = new System.Drawing.Point(6, 6);
            this.dgvNormal.Name = "dgvNormal";
            this.dgvNormal.ReadOnly = true;
            this.dgvNormal.Size = new System.Drawing.Size(600, 230);
            this.dgvNormal.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome / Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pontuacao";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pontuação / Score";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data do jogo / Game date";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // jogadorBindingSource4
            // 
            this.jogadorBindingSource4.DataSource = typeof(United_Blocks.Jogador);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvHard);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(612, 242);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Difícil | Hard";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dgvHard
            // 
            this.dgvHard.AllowUserToAddRows = false;
            this.dgvHard.AllowUserToDeleteRows = false;
            this.dgvHard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHard.AutoGenerateColumns = false;
            this.dgvHard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHard.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvHard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dgvHard.DataSource = this.jogadorBindingSource2;
            this.dgvHard.Location = new System.Drawing.Point(6, 6);
            this.dgvHard.Name = "dgvHard";
            this.dgvHard.ReadOnly = true;
            this.dgvHard.Size = new System.Drawing.Size(600, 230);
            this.dgvHard.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nome / Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Pontuacao";
            this.dataGridViewTextBoxColumn5.HeaderText = "Pontuação / Score";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data do jogo / Game date";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvJedi);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(612, 242);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Jedi";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // dgvJedi
            // 
            this.dgvJedi.AllowUserToAddRows = false;
            this.dgvJedi.AllowUserToDeleteRows = false;
            this.dgvJedi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvJedi.AutoGenerateColumns = false;
            this.dgvJedi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvJedi.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvJedi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJedi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvJedi.DataSource = this.jogadorBindingSource5;
            this.dgvJedi.Location = new System.Drawing.Point(6, 6);
            this.dgvJedi.Name = "dgvJedi";
            this.dgvJedi.ReadOnly = true;
            this.dgvJedi.Size = new System.Drawing.Size(600, 230);
            this.dgvJedi.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn7.HeaderText = "Nome / Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Pontuacao";
            this.dataGridViewTextBoxColumn8.HeaderText = "Pontuação / Score";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn9.HeaderText = "Data do jogo / Game date";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // jogadorBindingSource5
            // 
            this.jogadorBindingSource5.DataSource = typeof(United_Blocks.Jogador);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvArcade);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(612, 242);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Arcade";
            this.tabPage5.UseVisualStyleBackColor = true;
            this.tabPage5.Click += new System.EventHandler(this.tabPage5_Click);
            // 
            // dgvArcade
            // 
            this.dgvArcade.AllowUserToAddRows = false;
            this.dgvArcade.AllowUserToDeleteRows = false;
            this.dgvArcade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArcade.AutoGenerateColumns = false;
            this.dgvArcade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArcade.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvArcade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArcade.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dgvArcade.DataSource = this.jogadorBindingSource6;
            this.dgvArcade.Location = new System.Drawing.Point(6, 6);
            this.dgvArcade.Name = "dgvArcade";
            this.dgvArcade.ReadOnly = true;
            this.dgvArcade.Size = new System.Drawing.Size(600, 230);
            this.dgvArcade.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn10.HeaderText = "Nome / Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Pontuacao";
            this.dataGridViewTextBoxColumn11.HeaderText = "Pontuação / Score";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn12.HeaderText = "Data do jogo / Game date";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // jogadorBindingSource6
            // 
            this.jogadorBindingSource6.DataSource = typeof(United_Blocks.Jogador);
            // 
            // jogadorBindingSource
            // 
            this.jogadorBindingSource.DataSource = typeof(United_Blocks.Jogador);
            // 
            // jogadorBindingSource1
            // 
            this.jogadorBindingSource1.DataSource = typeof(United_Blocks.Jogador);
            // 
            // jogadorBindingSource3
            // 
            this.jogadorBindingSource3.DataSource = typeof(United_Blocks.Jogador);
            // 
            // lbTerceiro
            // 
            this.lbTerceiro.AutoSize = true;
            this.lbTerceiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTerceiro.Location = new System.Drawing.Point(90, 258);
            this.lbTerceiro.Name = "lbTerceiro";
            this.lbTerceiro.Size = new System.Drawing.Size(217, 32);
            this.lbTerceiro.TabIndex = 11;
            this.lbTerceiro.Text = "Primeiro Coloca";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::United_Blocks.Properties.Resources.bronze;
            this.pictureBox3.Location = new System.Drawing.Point(20, 258);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // lbSegundo
            // 
            this.lbSegundo.AutoSize = true;
            this.lbSegundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegundo.Location = new System.Drawing.Point(90, 156);
            this.lbSegundo.Name = "lbSegundo";
            this.lbSegundo.Size = new System.Drawing.Size(217, 32);
            this.lbSegundo.TabIndex = 9;
            this.lbSegundo.Text = "Primeiro Coloca";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::United_Blocks.Properties.Resources.silver;
            this.pictureBox2.Location = new System.Drawing.Point(20, 156);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lbPrimeiro
            // 
            this.lbPrimeiro.AutoSize = true;
            this.lbPrimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrimeiro.Location = new System.Drawing.Point(90, 56);
            this.lbPrimeiro.Name = "lbPrimeiro";
            this.lbPrimeiro.Size = new System.Drawing.Size(217, 32);
            this.lbPrimeiro.TabIndex = 7;
            this.lbPrimeiro.Text = "Primeiro Coloca";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::United_Blocks.Properties.Resources.gold;
            this.pictureBox1.Location = new System.Drawing.Point(20, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPlacar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(689, 336);
            this.Controls.Add(this.lbTerceiro);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbSegundo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbPrimeiro);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbPlacar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPlacar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Placar de jogadores";
            this.Load += new System.EventHandler(this.FrmPlacar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlacar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource2)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource4)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHard)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJedi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource5)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArcade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jogadorBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource jogadorBindingSource;
        private System.Windows.Forms.BindingSource jogadorBindingSource1;
        private System.Windows.Forms.DataGridView dgvPlacar;
        private System.Windows.Forms.BindingSource jogadorBindingSource2;
        private System.Windows.Forms.Label lbPlacar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pontuacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.Windows.Forms.BindingSource jogadorBindingSource4;
        private System.Windows.Forms.BindingSource jogadorBindingSource5;
        private System.Windows.Forms.BindingSource jogadorBindingSource6;
        private System.Windows.Forms.BindingSource jogadorBindingSource3;
        private System.Windows.Forms.Label lbTerceiro;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbSegundo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbPrimeiro;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}