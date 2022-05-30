namespace Game.Game.Running_Folder
{
    partial class Running
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
            this.lstPlayers = new System.Windows.Forms.ListView();
            this.idUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NomeUsuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblTurn = new System.Windows.Forms.Label();
            this.btnNarration = new System.Windows.Forms.Button();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblProp1 = new System.Windows.Forms.Label();
            this.lblPlayerBodes = new System.Windows.Forms.Label();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnTable = new System.Windows.Forms.Button();
            this.btnAllCards = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cmbIslands = new System.Windows.Forms.ComboBox();
            this.btnChooseIsland = new System.Windows.Forms.Button();
            this.btnShowIslands = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cmbCards = new System.Windows.Forms.ComboBox();
            this.pnlMesa = new System.Windows.Forms.Panel();
            this.pnlBode = new System.Windows.Forms.Panel();
            this.pnlIlhas = new System.Windows.Forms.Panel();
            this.lblIlhas = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrTrigger = new System.Windows.Forms.Timer(this.components);
            this.lblB_Nome3 = new System.Windows.Forms.Label();
            this.lblB_Nome2 = new System.Windows.Forms.Label();
            this.lblB_Nome1 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlMesa.SuspendLayout();
            this.pnlBode.SuspendLayout();
            this.pnlIlhas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPlayers
            // 
            this.lstPlayers.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.lstPlayers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPlayers.BackColor = System.Drawing.SystemColors.Control;
            this.lstPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idUsuario,
            this.NomeUsuario});
            this.lstPlayers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPlayers.FullRowSelect = true;
            this.lstPlayers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstPlayers.HideSelection = false;
            this.lstPlayers.Location = new System.Drawing.Point(3, 3);
            this.lstPlayers.MinimumSize = new System.Drawing.Size(4, 30);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Scrollable = false;
            this.lstPlayers.Size = new System.Drawing.Size(178, 156);
            this.lstPlayers.TabIndex = 8;
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
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(448, 243);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(145, 40);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Gray;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(459, 284);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(110, 40);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Sair";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTurn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(153, 523);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(113, 31);
            this.lblTurn.TabIndex = 12;
            this.lblTurn.Text = "Vez";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNarration
            // 
            this.btnNarration.Location = new System.Drawing.Point(46, 390);
            this.btnNarration.Name = "btnNarration";
            this.btnNarration.Size = new System.Drawing.Size(191, 37);
            this.btnNarration.TabIndex = 14;
            this.btnNarration.Text = "Atualizar a narração";
            this.btnNarration.UseVisualStyleBackColor = true;
            this.btnNarration.Click += new System.EventHandler(this.btnNarration_Click);
            // 
            // txtNarration
            // 
            this.txtNarration.BackColor = System.Drawing.Color.White;
            this.txtNarration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNarration.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNarration.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNarration.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtNarration.Location = new System.Drawing.Point(0, 0);
            this.txtNarration.MaximumSize = new System.Drawing.Size(999, 999);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.ReadOnly = true;
            this.txtNarration.Size = new System.Drawing.Size(269, 384);
            this.txtNarration.TabIndex = 15;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DimGray;
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Controls.Add(this.btnStart);
            this.pnlMain.Controls.Add(this.pnlMesa);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1080, 697);
            this.pnlMain.TabIndex = 16;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBottom.Controls.Add(this.lblProp1);
            this.pnlBottom.Controls.Add(this.lblPlayerBodes);
            this.pnlBottom.Controls.Add(this.pnlCards);
            this.pnlBottom.Controls.Add(this.lstPlayers);
            this.pnlBottom.Location = new System.Drawing.Point(9, 528);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(791, 166);
            this.pnlBottom.TabIndex = 18;
            // 
            // lblProp1
            // 
            this.lblProp1.AutoSize = true;
            this.lblProp1.Location = new System.Drawing.Point(652, 40);
            this.lblProp1.Name = "lblProp1";
            this.lblProp1.Size = new System.Drawing.Size(109, 13);
            this.lblProp1.TabIndex = 25;
            this.lblProp1.Text = "Quantidade de bodes";
            // 
            // lblPlayerBodes
            // 
            this.lblPlayerBodes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPlayerBodes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerBodes.Location = new System.Drawing.Point(648, 9);
            this.lblPlayerBodes.Name = "lblPlayerBodes";
            this.lblPlayerBodes.Size = new System.Drawing.Size(113, 31);
            this.lblPlayerBodes.TabIndex = 24;
            this.lblPlayerBodes.Text = "0";
            this.lblPlayerBodes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.Color.Transparent;
            this.pnlCards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlCards.ForeColor = System.Drawing.Color.Transparent;
            this.pnlCards.Location = new System.Drawing.Point(187, 2);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(418, 156);
            this.pnlCards.TabIndex = 22;
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRight.Controls.Add(this.btnTable);
            this.pnlRight.Controls.Add(this.btnAllCards);
            this.pnlRight.Controls.Add(this.lblTurn);
            this.pnlRight.Controls.Add(this.btnCheck);
            this.pnlRight.Controls.Add(this.cmbIslands);
            this.pnlRight.Controls.Add(this.btnNarration);
            this.pnlRight.Controls.Add(this.btnChooseIsland);
            this.pnlRight.Controls.Add(this.txtNarration);
            this.pnlRight.Controls.Add(this.btnShowIslands);
            this.pnlRight.Controls.Add(this.btnPlay);
            this.pnlRight.Controls.Add(this.cmbCards);
            this.pnlRight.Location = new System.Drawing.Point(804, 3);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(273, 691);
            this.pnlRight.TabIndex = 17;
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.Location = new System.Drawing.Point(3, 608);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(127, 31);
            this.btnTable.TabIndex = 20;
            this.btnTable.Text = "Verificar Mesa";
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // btnAllCards
            // 
            this.btnAllCards.Location = new System.Drawing.Point(46, 434);
            this.btnAllCards.Name = "btnAllCards";
            this.btnAllCards.Size = new System.Drawing.Size(191, 37);
            this.btnAllCards.TabIndex = 16;
            this.btnAllCards.Text = "Visualizar todas as cartas";
            this.btnAllCards.UseVisualStyleBackColor = true;
            this.btnAllCards.Click += new System.EventHandler(this.btnAllCards_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(153, 555);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(113, 32);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "Checa Vez";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // cmbIslands
            // 
            this.cmbIslands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslands.FormattingEnabled = true;
            this.cmbIslands.Location = new System.Drawing.Point(92, 566);
            this.cmbIslands.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIslands.Name = "cmbIslands";
            this.cmbIslands.Size = new System.Drawing.Size(38, 21);
            this.cmbIslands.TabIndex = 19;
            // 
            // btnChooseIsland
            // 
            this.btnChooseIsland.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChooseIsland.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseIsland.Location = new System.Drawing.Point(6, 559);
            this.btnChooseIsland.Name = "btnChooseIsland";
            this.btnChooseIsland.Size = new System.Drawing.Size(81, 31);
            this.btnChooseIsland.TabIndex = 18;
            this.btnChooseIsland.Text = "Escolher Ilha";
            this.btnChooseIsland.UseVisualStyleBackColor = false;
            this.btnChooseIsland.Click += new System.EventHandler(this.btnChooseIsland_Click);
            // 
            // btnShowIslands
            // 
            this.btnShowIslands.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowIslands.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowIslands.Location = new System.Drawing.Point(6, 523);
            this.btnShowIslands.Name = "btnShowIslands";
            this.btnShowIslands.Size = new System.Drawing.Size(124, 31);
            this.btnShowIslands.TabIndex = 17;
            this.btnShowIslands.Text = "Mostrar Ilhas";
            this.btnShowIslands.UseVisualStyleBackColor = false;
            this.btnShowIslands.Click += new System.EventHandler(this.btnShowIslands_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(3, 645);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(60, 31);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.Text = "Jogar";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cmbCards
            // 
            this.cmbCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCards.FormattingEnabled = true;
            this.cmbCards.Location = new System.Drawing.Point(67, 650);
            this.cmbCards.Margin = new System.Windows.Forms.Padding(2);
            this.cmbCards.Name = "cmbCards";
            this.cmbCards.Size = new System.Drawing.Size(60, 21);
            this.cmbCards.TabIndex = 16;
            // 
            // pnlMesa
            // 
            this.pnlMesa.BackgroundImage = global::Game.Properties.Resources.mesa_base;
            this.pnlMesa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMesa.Controls.Add(this.pnlBode);
            this.pnlMesa.Location = new System.Drawing.Point(9, 5);
            this.pnlMesa.Name = "pnlMesa";
            this.pnlMesa.Size = new System.Drawing.Size(791, 522);
            this.pnlMesa.TabIndex = 5;
            this.pnlMesa.Visible = false;
            // 
            // pnlBode
            // 
            this.pnlBode.BackColor = System.Drawing.Color.Transparent;
            this.pnlBode.BackgroundImage = global::Game.Properties.Resources.bode3;
            this.pnlBode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBode.Controls.Add(this.pnlIlhas);
            this.pnlBode.Location = new System.Drawing.Point(0, 0);
            this.pnlBode.Name = "pnlBode";
            this.pnlBode.Size = new System.Drawing.Size(791, 522);
            this.pnlBode.TabIndex = 0;
            // 
            // pnlIlhas
            // 
            this.pnlIlhas.BackColor = System.Drawing.Color.Transparent;
            this.pnlIlhas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlIlhas.Controls.Add(this.lblB_Nome1);
            this.pnlIlhas.Controls.Add(this.lblB_Nome2);
            this.pnlIlhas.Controls.Add(this.lblB_Nome3);
            this.pnlIlhas.Controls.Add(this.lblIlhas);
            this.pnlIlhas.Controls.Add(this.flpTable);
            this.pnlIlhas.Controls.Add(this.btnQuit);
            this.pnlIlhas.Location = new System.Drawing.Point(0, 0);
            this.pnlIlhas.Name = "pnlIlhas";
            this.pnlIlhas.Size = new System.Drawing.Size(791, 522);
            this.pnlIlhas.TabIndex = 1;
            // 
            // lblIlhas
            // 
            this.lblIlhas.BackColor = System.Drawing.Color.Transparent;
            this.lblIlhas.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIlhas.ForeColor = System.Drawing.Color.Yellow;
            this.lblIlhas.Location = new System.Drawing.Point(332, 306);
            this.lblIlhas.Name = "lblIlhas";
            this.lblIlhas.Size = new System.Drawing.Size(121, 45);
            this.lblIlhas.TabIndex = 21;
            this.lblIlhas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpTable
            // 
            this.flpTable.BackColor = System.Drawing.Color.Transparent;
            this.flpTable.Location = new System.Drawing.Point(268, 417);
            this.flpTable.Margin = new System.Windows.Forms.Padding(2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(262, 101);
            this.flpTable.TabIndex = 20;
            // 
            // tmrTrigger
            // 
            this.tmrTrigger.Interval = 2000;
            this.tmrTrigger.Tick += new System.EventHandler(this.tmrTrigger_Tick);
            // 
            // lblB_Nome3
            // 
            this.lblB_Nome3.BackColor = System.Drawing.Color.Gainsboro;
            this.lblB_Nome3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblB_Nome3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB_Nome3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblB_Nome3.Location = new System.Drawing.Point(439, 42);
            this.lblB_Nome3.Name = "lblB_Nome3";
            this.lblB_Nome3.Size = new System.Drawing.Size(100, 38);
            this.lblB_Nome3.TabIndex = 22;
            this.lblB_Nome3.Text = "label1";
            this.lblB_Nome3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblB_Nome3.Visible = false;
            // 
            // lblB_Nome2
            // 
            this.lblB_Nome2.BackColor = System.Drawing.Color.Gainsboro;
            this.lblB_Nome2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblB_Nome2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB_Nome2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblB_Nome2.Location = new System.Drawing.Point(244, 56);
            this.lblB_Nome2.Name = "lblB_Nome2";
            this.lblB_Nome2.Size = new System.Drawing.Size(100, 38);
            this.lblB_Nome2.TabIndex = 23;
            this.lblB_Nome2.Text = "label1";
            this.lblB_Nome2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblB_Nome2.Visible = false;
            // 
            // lblB_Nome1
            // 
            this.lblB_Nome1.BackColor = System.Drawing.Color.Gainsboro;
            this.lblB_Nome1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblB_Nome1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB_Nome1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblB_Nome1.Location = new System.Drawing.Point(83, 105);
            this.lblB_Nome1.Name = "lblB_Nome1";
            this.lblB_Nome1.Size = new System.Drawing.Size(100, 38);
            this.lblB_Nome1.TabIndex = 24;
            this.lblB_Nome1.Text = "label2";
            this.lblB_Nome1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblB_Nome1.Visible = false;
            // 
            // Running
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.liquid_bg;
            this.ClientSize = new System.Drawing.Size(1104, 721);
            this.Controls.Add(this.pnlMain);
            this.MaximumSize = new System.Drawing.Size(1120, 760);
            this.MinimumSize = new System.Drawing.Size(1120, 760);
            this.Name = "Running";
            this.Text = "Running";
            this.Load += new System.EventHandler(this.Running_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlMesa.ResumeLayout(false);
            this.pnlBode.ResumeLayout(false);
            this.pnlIlhas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstPlayers;
        private System.Windows.Forms.ColumnHeader idUsuario;
        private System.Windows.Forms.ColumnHeader NomeUsuario;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Button btnNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnAllCards;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cmbCards;
        private System.Windows.Forms.Button btnShowIslands;
        private System.Windows.Forms.ComboBox cmbIslands;
        private System.Windows.Forms.Button btnChooseIsland;
        private System.Windows.Forms.Panel pnlMesa;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        public System.Windows.Forms.Timer tmrTrigger;
        private System.Windows.Forms.Label lblIlhas;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Panel pnlBode;
        private System.Windows.Forms.Panel pnlIlhas;
        private System.Windows.Forms.Label lblProp1;
        private System.Windows.Forms.Label lblPlayerBodes;
        private System.Windows.Forms.Label lblB_Nome1;
        private System.Windows.Forms.Label lblB_Nome2;
        private System.Windows.Forms.Label lblB_Nome3;
    }
}