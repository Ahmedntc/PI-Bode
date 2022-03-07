namespace Game
{
    partial class Client
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.pnlMatch = new System.Windows.Forms.Panel();
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCriarNovaPartida = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listUsuarios = new System.Windows.Forms.ListView();
            this.idUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboFilters = new System.Windows.Forms.ComboBox();
            this.lstMatches = new System.Windows.Forms.ListView();
            this.ID_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stats_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSelected_Match = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMatch_Date = new System.Windows.Forms.Label();
            this.lblMatch_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblError1 = new System.Windows.Forms.Label();
            this.lblProp2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblProp1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblSelected_Match = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.debugcall = new System.Windows.Forms.Button();
            this.txtNomeNovaPartida = new System.Windows.Forms.TextBox();
            this.txtSenhaNovaPartida = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMatch.SuspendLayout();
            this.pnlSelected_Match.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(22, 31);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(223, 69);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Procurar Partidas";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlMatch
            // 
            this.pnlMatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMatch.Controls.Add(this.label4);
            this.pnlMatch.Controls.Add(this.txtSenhaNovaPartida);
            this.pnlMatch.Controls.Add(this.txtNomeNovaPartida);
            this.pnlMatch.Controls.Add(this.Nome);
            this.pnlMatch.Controls.Add(this.label2);
            this.pnlMatch.Controls.Add(this.btnCriarNovaPartida);
            this.pnlMatch.Controls.Add(this.label3);
            this.pnlMatch.Controls.Add(this.listUsuarios);
            this.pnlMatch.Controls.Add(this.label1);
            this.pnlMatch.Controls.Add(this.comboFilters);
            this.pnlMatch.Controls.Add(this.lstMatches);
            this.pnlMatch.Controls.Add(this.pnlSelected_Match);
            this.pnlMatch.Controls.Add(this.btnSearch);
            this.pnlMatch.Location = new System.Drawing.Point(16, 35);
            this.pnlMatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlMatch.Name = "pnlMatch";
            this.pnlMatch.Size = new System.Drawing.Size(1043, 604);
            this.pnlMatch.TabIndex = 1;
            this.pnlMatch.Tag = "";
            // 
            // Nome
            // 
            this.Nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.Nome.Location = new System.Drawing.Point(390, 414);
            this.Nome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(69, 26);
            this.Nome.TabIndex = 12;
            this.Nome.Text = "Nome";
            this.Nome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nome.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 366);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Criar Partida";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCriarNovaPartida
            // 
            this.btnCriarNovaPartida.Location = new System.Drawing.Point(473, 538);
            this.btnCriarNovaPartida.Name = "btnCriarNovaPartida";
            this.btnCriarNovaPartida.Size = new System.Drawing.Size(148, 41);
            this.btnCriarNovaPartida.TabIndex = 8;
            this.btnCriarNovaPartida.Text = "Nova Partida";
            this.btnCriarNovaPartida.UseVisualStyleBackColor = true;
            this.btnCriarNovaPartida.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 35);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jogadores\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listUsuarios
            // 
            this.listUsuarios.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listUsuarios.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idUsuario,
            this.NomeUsuario});
            this.listUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUsuarios.FullRowSelect = true;
            this.listUsuarios.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listUsuarios.HideSelection = false;
            this.listUsuarios.Location = new System.Drawing.Point(390, 109);
            this.listUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listUsuarios.MinimumSize = new System.Drawing.Size(4, 44);
            this.listUsuarios.Name = "listUsuarios";
            this.listUsuarios.Size = new System.Drawing.Size(297, 252);
            this.listUsuarios.TabIndex = 7;
            this.listUsuarios.TileSize = new System.Drawing.Size(1, 1);
            this.listUsuarios.UseCompatibleStateImageBehavior = false;
            this.listUsuarios.View = System.Windows.Forms.View.Details;
            this.listUsuarios.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // idUsuario
            // 
            this.idUsuario.Text = "ID";
            this.idUsuario.Width = 55;
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.Text = "Nome";
            this.NomeUsuario.Width = 169;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtros";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboFilters
            // 
            this.comboFilters.Items.AddRange(new object[] {
            "Todos",
            "Abertas",
            "Jogando",
            "Encerradas",
            "Ahmed"});
            this.comboFilters.Location = new System.Drawing.Point(252, 55);
            this.comboFilters.Name = "comboFilters";
            this.comboFilters.Size = new System.Drawing.Size(130, 28);
            this.comboFilters.TabIndex = 4;
            this.comboFilters.Text = "Todos";
            // 
            // lstMatches
            // 
            this.lstMatches.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstMatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Column,
            this.Name_Column,
            this.Stats_Column});
            this.lstMatches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMatches.FullRowSelect = true;
            this.lstMatches.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMatches.HideSelection = false;
            this.lstMatches.Location = new System.Drawing.Point(22, 109);
            this.lstMatches.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstMatches.MinimumSize = new System.Drawing.Size(4, 44);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(360, 470);
            this.lstMatches.TabIndex = 3;
            this.lstMatches.TileSize = new System.Drawing.Size(1, 1);
            this.lstMatches.UseCompatibleStateImageBehavior = false;
            this.lstMatches.View = System.Windows.Forms.View.Details;
            this.lstMatches.SelectedIndexChanged += new System.EventHandler(this.lstMatches_SelectedIndexChanged);
            // 
            // ID_Column
            // 
            this.ID_Column.Text = "ID";
            this.ID_Column.Width = 40;
            // 
            // Name_Column
            // 
            this.Name_Column.Text = "Partida";
            this.Name_Column.Width = 120;
            // 
            // Stats_Column
            // 
            this.Stats_Column.Text = "Status";
            this.Stats_Column.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Stats_Column.Width = 76;
            // 
            // pnlSelected_Match
            // 
            this.pnlSelected_Match.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlSelected_Match.Controls.Add(this.panel2);
            this.pnlSelected_Match.Controls.Add(this.panel1);
            this.pnlSelected_Match.Controls.Add(this.lblSelected_Match);
            this.pnlSelected_Match.Location = new System.Drawing.Point(695, 31);
            this.pnlSelected_Match.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSelected_Match.Name = "pnlSelected_Match";
            this.pnlSelected_Match.Size = new System.Drawing.Size(333, 548);
            this.pnlSelected_Match.TabIndex = 2;
            this.pnlSelected_Match.Visible = false;
            this.pnlSelected_Match.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSelected_Match_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblMatch_Date);
            this.panel2.Controls.Add(this.lblMatch_Name);
            this.panel2.Location = new System.Drawing.Point(4, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(324, 188);
            this.panel2.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(170, 137);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(150, 35);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "label2";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblMatch_Date
            // 
            this.lblMatch_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblMatch_Date.Location = new System.Drawing.Point(2, 83);
            this.lblMatch_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatch_Date.Name = "lblMatch_Date";
            this.lblMatch_Date.Size = new System.Drawing.Size(136, 83);
            this.lblMatch_Date.TabIndex = 1;
            this.lblMatch_Date.Text = "label2";
            // 
            // lblMatch_Name
            // 
            this.lblMatch_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblMatch_Name.Location = new System.Drawing.Point(0, 0);
            this.lblMatch_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatch_Name.Name = "lblMatch_Name";
            this.lblMatch_Name.Size = new System.Drawing.Size(312, 83);
            this.lblMatch_Name.TabIndex = 0;
            this.lblMatch_Name.Text = "label2";
            this.lblMatch_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMatch_Name.Click += new System.EventHandler(this.lblMatch_Name_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblError1);
            this.panel1.Controls.Add(this.lblProp2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblProp1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Location = new System.Drawing.Point(4, 326);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 217);
            this.panel1.TabIndex = 3;
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(12, 206);
            this.lblError1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(0, 29);
            this.lblError1.TabIndex = 6;
            // 
            // lblProp2
            // 
            this.lblProp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblProp2.Location = new System.Drawing.Point(72, 128);
            this.lblProp2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProp2.Name = "lblProp2";
            this.lblProp2.Size = new System.Drawing.Size(189, 31);
            this.lblProp2.TabIndex = 5;
            this.lblProp2.Text = "Senha da partida";
            this.lblProp2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(72, 88);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(187, 30);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(72, 12);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(187, 30);
            this.txtUsername.TabIndex = 3;
            // 
            // lblProp1
            // 
            this.lblProp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblProp1.Location = new System.Drawing.Point(72, 52);
            this.lblProp1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProp1.Name = "lblProp1";
            this.lblProp1.Size = new System.Drawing.Size(189, 31);
            this.lblProp1.TabIndex = 2;
            this.lblProp1.Text = "Nome de usuário";
            this.lblProp1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(0, 163);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(157, 55);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(165, 164);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(159, 55);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSelected_Match
            // 
            this.lblSelected_Match.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected_Match.Location = new System.Drawing.Point(100, 15);
            this.lblSelected_Match.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelected_Match.Name = "lblSelected_Match";
            this.lblSelected_Match.Size = new System.Drawing.Size(150, 35);
            this.lblSelected_Match.TabIndex = 0;
            this.lblSelected_Match.Text = "Partida";
            this.lblSelected_Match.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(909, 644);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(150, 35);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Versão";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblVersion.Click += new System.EventHandler(this.lblVersion_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic);
            this.lblTitle.Location = new System.Drawing.Point(32, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(282, 52);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Bode Of War\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // debugcall
            // 
            this.debugcall.Location = new System.Drawing.Point(16, 647);
            this.debugcall.Name = "debugcall";
            this.debugcall.Size = new System.Drawing.Size(90, 29);
            this.debugcall.TabIndex = 4;
            this.debugcall.Text = "Console";
            this.debugcall.UseVisualStyleBackColor = true;
            this.debugcall.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtNomeNovaPartida
            // 
            this.txtNomeNovaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeNovaPartida.Location = new System.Drawing.Point(500, 410);
            this.txtNomeNovaPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNomeNovaPartida.Name = "txtNomeNovaPartida";
            this.txtNomeNovaPartida.Size = new System.Drawing.Size(187, 30);
            this.txtNomeNovaPartida.TabIndex = 8;
            // 
            // txtSenhaNovaPartida
            // 
            this.txtSenhaNovaPartida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaNovaPartida.Location = new System.Drawing.Point(500, 478);
            this.txtSenhaNovaPartida.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSenhaNovaPartida.Name = "txtSenhaNovaPartida";
            this.txtSenhaNovaPartida.Size = new System.Drawing.Size(187, 30);
            this.txtSenhaNovaPartida.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(390, 478);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Senha";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 695);
            this.Controls.Add(this.debugcall);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pnlMatch);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1094, 751);
            this.MinimumSize = new System.Drawing.Size(1094, 751);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.pnlMatch.ResumeLayout(false);
            this.pnlMatch.PerformLayout();
            this.pnlSelected_Match.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlMatch;
        private System.Windows.Forms.Panel pnlSelected_Match;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSelected_Match;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMatch_Name;
        private System.Windows.Forms.ListView lstMatches;
        private System.Windows.Forms.ColumnHeader ID_Column;
        private System.Windows.Forms.ColumnHeader Name_Column;
        private System.Windows.Forms.ColumnHeader Stats_Column;
        private System.Windows.Forms.Label lblMatch_Date;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblProp2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblProp1;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button debugcall;
        private System.Windows.Forms.ComboBox comboFilters;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listUsuarios;
        private System.Windows.Forms.ColumnHeader idUsuario;
        private System.Windows.Forms.ColumnHeader NomeUsuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCriarNovaPartida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenhaNovaPartida;
        private System.Windows.Forms.TextBox txtNomeNovaPartida;
    }
}

