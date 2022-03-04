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
            this.lstMatches = new System.Windows.Forms.ListView();
            this.ID_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Name_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stats_Column = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlSelected_Match = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMatch_Date = new System.Windows.Forms.Label();
            this.lblMatch_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProp2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblProp1 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblSelected_Match = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblError1 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
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
            this.btnSearch.Location = new System.Drawing.Point(15, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(241, 45);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Procurar Partidas";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pnlMatch
            // 
            this.pnlMatch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMatch.Controls.Add(this.lstMatches);
            this.pnlMatch.Controls.Add(this.pnlSelected_Match);
            this.pnlMatch.Controls.Add(this.btnSearch);
            this.pnlMatch.Location = new System.Drawing.Point(11, 23);
            this.pnlMatch.Name = "pnlMatch";
            this.pnlMatch.Size = new System.Drawing.Size(505, 393);
            this.pnlMatch.TabIndex = 1;
            this.pnlMatch.Tag = "";
            // 
            // lstMatches
            // 
            this.lstMatches.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstMatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Column,
            this.Name_Column,
            this.Stats_Column});
            this.lstMatches.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstMatches.Font = new System.Drawing.Font("Fira Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMatches.FullRowSelect = true;
            this.lstMatches.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstMatches.HideSelection = false;
            this.lstMatches.Location = new System.Drawing.Point(15, 71);
            this.lstMatches.MinimumSize = new System.Drawing.Size(4, 30);
            this.lstMatches.Name = "lstMatches";
            this.lstMatches.Size = new System.Drawing.Size(241, 305);
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
            this.Stats_Column.Width = 75;
            // 
            // pnlSelected_Match
            // 
            this.pnlSelected_Match.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlSelected_Match.Controls.Add(this.panel2);
            this.pnlSelected_Match.Controls.Add(this.panel1);
            this.pnlSelected_Match.Controls.Add(this.lblSelected_Match);
            this.pnlSelected_Match.Location = new System.Drawing.Point(262, 20);
            this.pnlSelected_Match.Name = "pnlSelected_Match";
            this.pnlSelected_Match.Size = new System.Drawing.Size(222, 356);
            this.pnlSelected_Match.TabIndex = 2;
            this.pnlSelected_Match.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lblStatus);
            this.panel2.Controls.Add(this.lblMatch_Date);
            this.panel2.Controls.Add(this.lblMatch_Name);
            this.panel2.Location = new System.Drawing.Point(3, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(216, 122);
            this.panel2.TabIndex = 4;
            // 
            // lblMatch_Date
            // 
            this.lblMatch_Date.Font = new System.Drawing.Font("Fira Code SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.lblMatch_Date.Location = new System.Drawing.Point(9, 71);
            this.lblMatch_Date.Name = "lblMatch_Date";
            this.lblMatch_Date.Size = new System.Drawing.Size(91, 54);
            this.lblMatch_Date.TabIndex = 1;
            this.lblMatch_Date.Text = "label2";
            // 
            // lblMatch_Name
            // 
            this.lblMatch_Name.Font = new System.Drawing.Font("Fira Code SemiBold", 14F, System.Drawing.FontStyle.Bold);
            this.lblMatch_Name.Location = new System.Drawing.Point(5, 17);
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
            this.panel1.Location = new System.Drawing.Point(3, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 141);
            this.panel1.TabIndex = 3;
            // 
            // lblProp2
            // 
            this.lblProp2.Font = new System.Drawing.Font("Fira Code SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.lblProp2.Location = new System.Drawing.Point(48, 83);
            this.lblProp2.Name = "lblProp2";
            this.lblProp2.Size = new System.Drawing.Size(126, 20);
            this.lblProp2.TabIndex = 5;
            this.lblProp2.Text = "Senha da partida";
            this.lblProp2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Fira Code Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(48, 57);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(126, 23);
            this.txtPassword.TabIndex = 4;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Fira Code Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(48, 8);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(126, 23);
            this.txtUsername.TabIndex = 3;
            // 
            // lblProp1
            // 
            this.lblProp1.Font = new System.Drawing.Font("Fira Code SemiBold", 8F, System.Drawing.FontStyle.Bold);
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
            this.btnLogin.Location = new System.Drawing.Point(0, 106);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(216, 36);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            this.lblVersion.Location = new System.Drawing.Point(415, 421);
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
            // lblError1
            // 
            this.lblError1.AutoSize = true;
            this.lblError1.Font = new System.Drawing.Font("Fira Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(8, 134);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(0, 20);
            this.lblError1.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(113, 89);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(100, 23);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "label2";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 452);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pnlMatch);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.pnlMatch.ResumeLayout(false);
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
    }
}

