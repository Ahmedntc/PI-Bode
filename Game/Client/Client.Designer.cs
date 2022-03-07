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
            this.lblCreateMatch2 = new System.Windows.Forms.Label();
            this.txtNewMatchPass = new System.Windows.Forms.TextBox();
            this.txtNewMatchName = new System.Windows.Forms.TextBox();
            this.lblCreateMatch1 = new System.Windows.Forms.Label();
            this.lblCreateMatch = new System.Windows.Forms.Label();
            this.btnCreateMatch = new System.Windows.Forms.Button();
            this.lblFilters = new System.Windows.Forms.Label();
            this.cmbFilters = new System.Windows.Forms.ComboBox();
            this.lstMatches = new System.Windows.Forms.ListView();
            this.ID_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stats_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSelected_Match = new System.Windows.Forms.Panel();
            this.pnlMatchInfo = new System.Windows.Forms.Panel();
            this.lstPlayers = new System.Windows.Forms.ListView();
            this.idUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.Debugcall = new System.Windows.Forms.Button();
            this.pnlMatch.SuspendLayout();
            this.pnlSelected_Match.SuspendLayout();
            this.pnlMatchInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 10F);
            this.btnSearch.Location = new System.Drawing.Point(3, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(145, 36);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Procurar Partidas";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlMatch
            // 
            this.pnlMatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMatch.Controls.Add(this.lblCreateMatch2);
            this.pnlMatch.Controls.Add(this.txtNewMatchPass);
            this.pnlMatch.Controls.Add(this.txtNewMatchName);
            this.pnlMatch.Controls.Add(this.lblCreateMatch1);
            this.pnlMatch.Controls.Add(this.lblCreateMatch);
            this.pnlMatch.Controls.Add(this.btnCreateMatch);
            this.pnlMatch.Controls.Add(this.lblFilters);
            this.pnlMatch.Controls.Add(this.cmbFilters);
            this.pnlMatch.Controls.Add(this.lstMatches);
            this.pnlMatch.Controls.Add(this.pnlSelected_Match);
            this.pnlMatch.Controls.Add(this.btnSearch);
            this.pnlMatch.Location = new System.Drawing.Point(11, 23);
            this.pnlMatch.Name = "pnlMatch";
            this.pnlMatch.Size = new System.Drawing.Size(741, 501);
            this.pnlMatch.TabIndex = 1;
            this.pnlMatch.Tag = "";
            // 
            // lblCreateMatch2
            // 
            this.lblCreateMatch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblCreateMatch2.Location = new System.Drawing.Point(36, 427);
            this.lblCreateMatch2.Name = "lblCreateMatch2";
            this.lblCreateMatch2.Size = new System.Drawing.Size(46, 17);
            this.lblCreateMatch2.TabIndex = 14;
            this.lblCreateMatch2.Text = "Senha";
            this.lblCreateMatch2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNewMatchPass
            // 
            this.txtNewMatchPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewMatchPass.Location = new System.Drawing.Point(88, 422);
            this.txtNewMatchPass.Name = "txtNewMatchPass";
            this.txtNewMatchPass.PasswordChar = '*';
            this.txtNewMatchPass.Size = new System.Drawing.Size(126, 22);
            this.txtNewMatchPass.TabIndex = 13;
            // 
            // txtNewMatchName
            // 
            this.txtNewMatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewMatchName.Location = new System.Drawing.Point(88, 380);
            this.txtNewMatchName.Name = "txtNewMatchName";
            this.txtNewMatchName.Size = new System.Drawing.Size(126, 22);
            this.txtNewMatchName.TabIndex = 8;
            // 
            // lblCreateMatch1
            // 
            this.lblCreateMatch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblCreateMatch1.Location = new System.Drawing.Point(36, 385);
            this.lblCreateMatch1.Name = "lblCreateMatch1";
            this.lblCreateMatch1.Size = new System.Drawing.Size(46, 17);
            this.lblCreateMatch1.TabIndex = 12;
            this.lblCreateMatch1.Text = "Nome";
            this.lblCreateMatch1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCreateMatch
            // 
            this.lblCreateMatch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateMatch.Location = new System.Drawing.Point(37, 345);
            this.lblCreateMatch.Name = "lblCreateMatch";
            this.lblCreateMatch.Size = new System.Drawing.Size(123, 23);
            this.lblCreateMatch.TabIndex = 9;
            this.lblCreateMatch.Text = "Criar Partida";
            this.lblCreateMatch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.Location = new System.Drawing.Point(88, 459);
            this.btnCreateMatch.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(99, 27);
            this.btnCreateMatch.TabIndex = 8;
            this.btnCreateMatch.Text = "Nova Partida";
            this.btnCreateMatch.UseVisualStyleBackColor = true;
            this.btnCreateMatch.Click += new System.EventHandler(this.btnCreateMatch_Click);
            // 
            // lblFilters
            // 
            this.lblFilters.AutoSize = true;
            this.lblFilters.Location = new System.Drawing.Point(177, 29);
            this.lblFilters.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilters.Name = "lblFilters";
            this.lblFilters.Size = new System.Drawing.Size(34, 13);
            this.lblFilters.TabIndex = 5;
            this.lblFilters.Text = "Filtros";
            // 
            // cmbFilters
            // 
            this.cmbFilters.Items.AddRange(new object[] {
            "Todos",
            "Abertas",
            "Jogando",
            "Encerradas",
            "Ahmed"});
            this.cmbFilters.Location = new System.Drawing.Point(180, 44);
            this.cmbFilters.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFilters.Name = "cmbFilters";
            this.cmbFilters.Size = new System.Drawing.Size(88, 21);
            this.cmbFilters.TabIndex = 4;
            this.cmbFilters.Text = "Todos";
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
            this.lstMatches.Location = new System.Drawing.Point(3, 71);
            this.lstMatches.MinimumSize = new System.Drawing.Size(4, 30);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(265, 240);
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
            this.Stats_Column.Width = 100;
            // 
            // pnlSelected_Match
            // 
            this.pnlSelected_Match.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlSelected_Match.Controls.Add(this.pnlMatchInfo);
            this.pnlSelected_Match.Controls.Add(this.panel1);
            this.pnlSelected_Match.Controls.Add(this.lblSelected_Match);
            this.pnlSelected_Match.Location = new System.Drawing.Point(358, 19);
            this.pnlSelected_Match.Name = "pnlSelected_Match";
            this.pnlSelected_Match.Size = new System.Drawing.Size(234, 467);
            this.pnlSelected_Match.TabIndex = 2;
            this.pnlSelected_Match.Visible = false;
            // 
            // pnlMatchInfo
            // 
            this.pnlMatchInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMatchInfo.Controls.Add(this.lstPlayers);
            this.pnlMatchInfo.Controls.Add(this.lblStatus);
            this.pnlMatchInfo.Controls.Add(this.lblMatch_Date);
            this.pnlMatchInfo.Controls.Add(this.lblMatch_Name);
            this.pnlMatchInfo.Location = new System.Drawing.Point(3, 36);
            this.pnlMatchInfo.Name = "pnlMatchInfo";
            this.pnlMatchInfo.Size = new System.Drawing.Size(216, 122);
            this.pnlMatchInfo.TabIndex = 4;
            // 
            // lstPlayers
            // 
            this.lstPlayers.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idUsuario,
            this.NomeUsuario});
            this.lstPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlayers.FullRowSelect = true;
            this.lstPlayers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstPlayers.HideSelection = false;
            this.lstPlayers.Location = new System.Drawing.Point(0, 128);
            this.lstPlayers.MinimumSize = new System.Drawing.Size(4, 30);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Size = new System.Drawing.Size(216, 156);
            this.lstPlayers.TabIndex = 10;
            this.lstPlayers.TileSize = new System.Drawing.Size(1, 1);
            this.lstPlayers.UseCompatibleStateImageBehavior = false;
            this.lstPlayers.View = System.Windows.Forms.View.Details;
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
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(113, 89);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "label2";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblMatch_Date
            // 
            this.lblMatch_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblMatch_Date.Location = new System.Drawing.Point(1, 54);
            this.lblMatch_Date.Name = "lblMatch_Date";
            this.lblMatch_Date.Size = new System.Drawing.Size(91, 54);
            this.lblMatch_Date.TabIndex = 1;
            this.lblMatch_Date.Text = "label2";
            // 
            // lblMatch_Name
            // 
            this.lblMatch_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblMatch_Name.Location = new System.Drawing.Point(0, 0);
            this.lblMatch_Name.Name = "lblMatch_Name";
            this.lblMatch_Name.Size = new System.Drawing.Size(208, 54);
            this.lblMatch_Name.TabIndex = 0;
            this.lblMatch_Name.Text = "label2";
            this.lblMatch_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panel1.Location = new System.Drawing.Point(3, 323);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 141);
            this.panel1.TabIndex = 3;
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(8, 134);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(0, 20);
            this.lblError1.TabIndex = 6;
            // 
            // lblProp2
            // 
            this.lblProp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblProp2.Location = new System.Drawing.Point(48, 83);
            this.lblProp2.Name = "lblProp2";
            this.lblProp2.Size = new System.Drawing.Size(126, 20);
            this.lblProp2.TabIndex = 5;
            this.lblProp2.Text = "Senha da partida";
            this.lblProp2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(48, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(126, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(48, 8);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(126, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // lblProp1
            // 
            this.lblProp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblProp1.Location = new System.Drawing.Point(48, 34);
            this.lblProp1.Name = "lblProp1";
            this.lblProp1.Size = new System.Drawing.Size(126, 20);
            this.lblProp1.TabIndex = 2;
            this.lblProp1.Text = "Nome de usuário";
            this.lblProp1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(3, 102);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 36);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(119, 102);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(106, 36);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // lblSelected_Match
            // 
            this.lblSelected_Match.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected_Match.Location = new System.Drawing.Point(67, 10);
            this.lblSelected_Match.Name = "lblSelected_Match";
            this.lblSelected_Match.Size = new System.Drawing.Size(100, 23);
            this.lblSelected_Match.TabIndex = 0;
            this.lblSelected_Match.Text = "Partida";
            this.lblSelected_Match.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(672, 527);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(100, 23);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Versão";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic);
            this.lblTitle.Location = new System.Drawing.Point(21, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 34);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Bode Of War\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Debugcall
            // 
            this.Debugcall.Location = new System.Drawing.Point(11, 531);
            this.Debugcall.Margin = new System.Windows.Forms.Padding(2);
            this.Debugcall.Name = "Debugcall";
            this.Debugcall.Size = new System.Drawing.Size(60, 19);
            this.Debugcall.TabIndex = 4;
            this.Debugcall.Text = "Console";
            this.Debugcall.UseVisualStyleBackColor = true;
            this.Debugcall.Click += new System.EventHandler(this.btnDebugcall_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 561);
            this.Controls.Add(this.Debugcall);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pnlMatch);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 600);
            this.MinimumSize = new System.Drawing.Size(780, 600);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.pnlMatch.ResumeLayout(false);
            this.pnlMatch.PerformLayout();
            this.pnlSelected_Match.ResumeLayout(false);
            this.pnlMatchInfo.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlMatchInfo;
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
        private System.Windows.Forms.Button Debugcall;
        private System.Windows.Forms.ComboBox cmbFilters;
        private System.Windows.Forms.Label lblFilters;
        private System.Windows.Forms.ListView lstPlayers;
        private System.Windows.Forms.ColumnHeader idUsuario;
        private System.Windows.Forms.ColumnHeader NomeUsuario;
        private System.Windows.Forms.Label lblCreateMatch1;
        private System.Windows.Forms.Label lblCreateMatch;
        private System.Windows.Forms.Button btnCreateMatch;
        private System.Windows.Forms.Label lblCreateMatch2;
        private System.Windows.Forms.TextBox txtNewMatchPass;
        private System.Windows.Forms.TextBox txtNewMatchName;
    }
}

