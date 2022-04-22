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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProp4 = new System.Windows.Forms.Label();
            this.txtNewMatchPass = new System.Windows.Forms.TextBox();
            this.txtNewMatchName = new System.Windows.Forms.TextBox();
            this.lblProp3 = new System.Windows.Forms.Label();
            this.btnCreateMatch = new System.Windows.Forms.Button();
            this.lblProp5 = new System.Windows.Forms.Label();
            this.cmbFilters = new System.Windows.Forms.ComboBox();
            this.lstMatches = new System.Windows.Forms.ListView();
            this.ID_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stats_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSelected_Match = new System.Windows.Forms.Panel();
            this.pnlMatch_Info = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblMatch_Date = new System.Windows.Forms.Label();
            this.lblMatch_Name = new System.Windows.Forms.Label();
            this.lstPlayers = new System.Windows.Forms.ListView();
            this.idUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnRetMatch = new System.Windows.Forms.Button();
            this.lblError1 = new System.Windows.Forms.Label();
            this.lblProp2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblProp1 = new System.Windows.Forms.Label();
            this.lblSelected_Match = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDebugcall = new System.Windows.Forms.Button();
            this.pnlMatch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlSelected_Match.SuspendLayout();
            this.pnlMatch_Info.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(20, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(199, 55);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Procurar Partidas";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlMatch
            // 
            this.pnlMatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMatch.Controls.Add(this.panel1);
            this.pnlMatch.Controls.Add(this.lblProp5);
            this.pnlMatch.Controls.Add(this.cmbFilters);
            this.pnlMatch.Controls.Add(this.lstMatches);
            this.pnlMatch.Controls.Add(this.pnlSelected_Match);
            this.pnlMatch.Controls.Add(this.btnSearch);
            this.pnlMatch.Location = new System.Drawing.Point(15, 28);
            this.pnlMatch.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMatch.Name = "pnlMatch";
            this.pnlMatch.Size = new System.Drawing.Size(813, 686);
            this.pnlMatch.TabIndex = 1;
            this.pnlMatch.Tag = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblProp4);
            this.panel1.Controls.Add(this.txtNewMatchPass);
            this.panel1.Controls.Add(this.txtNewMatchName);
            this.panel1.Controls.Add(this.lblProp3);
            this.panel1.Controls.Add(this.btnCreateMatch);
            this.panel1.Location = new System.Drawing.Point(20, 502);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 174);
            this.panel1.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(11, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 6;
            // 
            // lblProp4
            // 
            this.lblProp4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblProp4.Location = new System.Drawing.Point(192, 91);
            this.lblProp4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProp4.Name = "lblProp4";
            this.lblProp4.Size = new System.Drawing.Size(168, 25);
            this.lblProp4.TabIndex = 5;
            this.lblProp4.Text = "Senha da partida";
            this.lblProp4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNewMatchPass
            // 
            this.txtNewMatchPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewMatchPass.Location = new System.Drawing.Point(192, 59);
            this.txtNewMatchPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewMatchPass.Name = "txtNewMatchPass";
            this.txtNewMatchPass.PasswordChar = '*';
            this.txtNewMatchPass.Size = new System.Drawing.Size(167, 26);
            this.txtNewMatchPass.TabIndex = 4;
            // 
            // txtNewMatchName
            // 
            this.txtNewMatchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewMatchName.Location = new System.Drawing.Point(16, 59);
            this.txtNewMatchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewMatchName.Name = "txtNewMatchName";
            this.txtNewMatchName.Size = new System.Drawing.Size(167, 26);
            this.txtNewMatchName.TabIndex = 3;
            // 
            // lblProp3
            // 
            this.lblProp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblProp3.Location = new System.Drawing.Point(16, 91);
            this.lblProp3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProp3.Name = "lblProp3";
            this.lblProp3.Size = new System.Drawing.Size(168, 25);
            this.lblProp3.TabIndex = 2;
            this.lblProp3.Text = "Nome da partida";
            this.lblProp3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCreateMatch
            // 
            this.btnCreateMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateMatch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMatch.Location = new System.Drawing.Point(4, 126);
            this.btnCreateMatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateMatch.Name = "btnCreateMatch";
            this.btnCreateMatch.Size = new System.Drawing.Size(365, 44);
            this.btnCreateMatch.TabIndex = 1;
            this.btnCreateMatch.Text = "Criar Partida";
            this.btnCreateMatch.UseVisualStyleBackColor = true;
            this.btnCreateMatch.Click += new System.EventHandler(this.btnCreateMatch_Click);
            // 
            // lblProp5
            // 
            this.lblProp5.AutoSize = true;
            this.lblProp5.Location = new System.Drawing.Point(225, 25);
            this.lblProp5.Name = "lblProp5";
            this.lblProp5.Size = new System.Drawing.Size(43, 16);
            this.lblProp5.TabIndex = 5;
            this.lblProp5.Text = "Filtros";
            // 
            // cmbFilters
            // 
            this.cmbFilters.Items.AddRange(new object[] {
            "Todos",
            "Abertas",
            "Jogando",
            "Encerradas",
            "Ahmed"});
            this.cmbFilters.Location = new System.Drawing.Point(224, 44);
            this.cmbFilters.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilters.Name = "cmbFilters";
            this.cmbFilters.Size = new System.Drawing.Size(116, 24);
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
            this.lstMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lstMatches.FullRowSelect = true;
            this.lstMatches.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMatches.HideSelection = false;
            this.lstMatches.Location = new System.Drawing.Point(20, 87);
            this.lstMatches.Margin = new System.Windows.Forms.Padding(4);
            this.lstMatches.MinimumSize = new System.Drawing.Size(4, 36);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(372, 405);
            this.lstMatches.TabIndex = 3;
            this.lstMatches.TileSize = new System.Drawing.Size(1, 1);
            this.lstMatches.UseCompatibleStateImageBehavior = false;
            this.lstMatches.View = System.Windows.Forms.View.Details;
            this.lstMatches.SelectedIndexChanged += new System.EventHandler(this.lstMatches_SelectedIndexChanged);
            // 
            // ID_Column
            // 
            this.ID_Column.Text = "ID";
            this.ID_Column.Width = 30;
            // 
            // Name_Column
            // 
            this.Name_Column.Text = "Partida";
            this.Name_Column.Width = 125;
            // 
            // Stats_Column
            // 
            this.Stats_Column.Text = "Status";
            this.Stats_Column.Width = 95;
            // 
            // pnlSelected_Match
            // 
            this.pnlSelected_Match.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlSelected_Match.Controls.Add(this.pnlMatch_Info);
            this.pnlSelected_Match.Controls.Add(this.pnlLogin);
            this.pnlSelected_Match.Controls.Add(this.lblSelected_Match);
            this.pnlSelected_Match.Location = new System.Drawing.Point(401, 25);
            this.pnlSelected_Match.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSelected_Match.Name = "pnlSelected_Match";
            this.pnlSelected_Match.Size = new System.Drawing.Size(396, 661);
            this.pnlSelected_Match.TabIndex = 2;
            this.pnlSelected_Match.Visible = false;
            // 
            // pnlMatch_Info
            // 
            this.pnlMatch_Info.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMatch_Info.Controls.Add(this.lblStatus);
            this.pnlMatch_Info.Controls.Add(this.lblMatch_Date);
            this.pnlMatch_Info.Controls.Add(this.lblMatch_Name);
            this.pnlMatch_Info.Controls.Add(this.lstPlayers);
            this.pnlMatch_Info.Location = new System.Drawing.Point(8, 63);
            this.pnlMatch_Info.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMatch_Info.Name = "pnlMatch_Info";
            this.pnlMatch_Info.Size = new System.Drawing.Size(373, 409);
            this.pnlMatch_Info.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(236, 123);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(133, 28);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "label2";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblMatch_Date
            // 
            this.lblMatch_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblMatch_Date.Location = new System.Drawing.Point(1, 66);
            this.lblMatch_Date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatch_Date.Name = "lblMatch_Date";
            this.lblMatch_Date.Size = new System.Drawing.Size(121, 66);
            this.lblMatch_Date.TabIndex = 1;
            this.lblMatch_Date.Text = "label2";
            // 
            // lblMatch_Name
            // 
            this.lblMatch_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblMatch_Name.Location = new System.Drawing.Point(0, 0);
            this.lblMatch_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMatch_Name.Name = "lblMatch_Name";
            this.lblMatch_Name.Size = new System.Drawing.Size(277, 66);
            this.lblMatch_Name.TabIndex = 0;
            this.lblMatch_Name.Text = "label2";
            this.lblMatch_Name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lstPlayers
            // 
            this.lstPlayers.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstPlayers.BackColor = System.Drawing.SystemColors.Control;
            this.lstPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idUsuario,
            this.NomeUsuario});
            this.lstPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlayers.FullRowSelect = true;
            this.lstPlayers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstPlayers.HideSelection = false;
            this.lstPlayers.Location = new System.Drawing.Point(0, 208);
            this.lstPlayers.Margin = new System.Windows.Forms.Padding(4);
            this.lstPlayers.MinimumSize = new System.Drawing.Size(4, 36);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Scrollable = false;
            this.lstPlayers.Size = new System.Drawing.Size(372, 196);
            this.lstPlayers.TabIndex = 7;
            this.lstPlayers.TileSize = new System.Drawing.Size(1, 1);
            this.lstPlayers.UseCompatibleStateImageBehavior = false;
            this.lstPlayers.View = System.Windows.Forms.View.Details;
            // 
            // idUsuario
            // 
            this.idUsuario.Text = "ID";
            // 
            // NomeUsuario
            // 
            this.NomeUsuario.Text = " Jogadores";
            this.NomeUsuario.Width = 215;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLogin.Controls.Add(this.btnRetMatch);
            this.pnlLogin.Controls.Add(this.lblError1);
            this.pnlLogin.Controls.Add(this.lblProp2);
            this.pnlLogin.Controls.Add(this.txtPassword);
            this.pnlLogin.Controls.Add(this.txtUsername);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.lblProp1);
            this.pnlLogin.Location = new System.Drawing.Point(8, 479);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(373, 172);
            this.pnlLogin.TabIndex = 3;
            // 
            // btnRetMatch
            // 
            this.btnRetMatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetMatch.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetMatch.Location = new System.Drawing.Point(8, 120);
            this.btnRetMatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnRetMatch.Name = "btnRetMatch";
            this.btnRetMatch.Size = new System.Drawing.Size(180, 48);
            this.btnRetMatch.TabIndex = 7;
            this.btnRetMatch.Text = "Retornar";
            this.btnRetMatch.UseVisualStyleBackColor = true;
            this.btnRetMatch.Click += new System.EventHandler(this.btnRetMatch_Click);
            // 
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(11, 165);
            this.lblError1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(0, 25);
            this.lblError1.TabIndex = 6;
            // 
            // lblProp2
            // 
            this.lblProp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblProp2.Location = new System.Drawing.Point(192, 91);
            this.lblProp2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProp2.Name = "lblProp2";
            this.lblProp2.Size = new System.Drawing.Size(168, 25);
            this.lblProp2.TabIndex = 5;
            this.lblProp2.Text = "Senha da partida";
            this.lblProp2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(192, 59);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(167, 26);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(16, 59);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(167, 26);
            this.txtUsername.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(189, 120);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 48);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblProp1
            // 
            this.lblProp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.lblProp1.Location = new System.Drawing.Point(16, 91);
            this.lblProp1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProp1.Name = "lblProp1";
            this.lblProp1.Size = new System.Drawing.Size(168, 25);
            this.lblProp1.TabIndex = 2;
            this.lblProp1.Text = "Nome de usuário";
            this.lblProp1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSelected_Match
            // 
            this.lblSelected_Match.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected_Match.Location = new System.Drawing.Point(11, 31);
            this.lblSelected_Match.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelected_Match.Name = "lblSelected_Match";
            this.lblSelected_Match.Size = new System.Drawing.Size(133, 28);
            this.lblSelected_Match.TabIndex = 0;
            this.lblSelected_Match.Text = "Partida";
            this.lblSelected_Match.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            this.lblVersion.Location = new System.Drawing.Point(683, 727);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(133, 28);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Versão";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Italic);
            this.lblTitle.Location = new System.Drawing.Point(28, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 42);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Bode Of War\r\n";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDebugcall
            // 
            this.btnDebugcall.Location = new System.Drawing.Point(15, 727);
            this.btnDebugcall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDebugcall.Name = "btnDebugcall";
            this.btnDebugcall.Size = new System.Drawing.Size(80, 23);
            this.btnDebugcall.TabIndex = 4;
            this.btnDebugcall.Text = "Console";
            this.btnDebugcall.UseVisualStyleBackColor = true;
            this.btnDebugcall.Click += new System.EventHandler(this.btnDebugcall_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 754);
            this.Controls.Add(this.btnDebugcall);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pnlMatch);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(861, 801);
            this.MinimumSize = new System.Drawing.Size(861, 801);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.pnlMatch.ResumeLayout(false);
            this.pnlMatch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSelected_Match.ResumeLayout(false);
            this.pnlMatch_Info.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlMatch;
        private System.Windows.Forms.Panel pnlSelected_Match;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSelected_Match;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlMatch_Info;
        private System.Windows.Forms.Panel pnlLogin;
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
        private System.Windows.Forms.Button btnDebugcall;
        private System.Windows.Forms.ComboBox cmbFilters;
        private System.Windows.Forms.Label lblProp5;
        private System.Windows.Forms.ListView lstPlayers;
        private System.Windows.Forms.ColumnHeader idUsuario;
        private System.Windows.Forms.ColumnHeader NomeUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblProp4;
        private System.Windows.Forms.TextBox txtNewMatchPass;
        private System.Windows.Forms.TextBox txtNewMatchName;
        private System.Windows.Forms.Label lblProp3;
        private System.Windows.Forms.Button btnCreateMatch;
        private System.Windows.Forms.Button btnRetMatch;
    }
}

