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
            this.btnTable = new System.Windows.Forms.Button();
            this.cmbIslands = new System.Windows.Forms.ComboBox();
            this.btnChooseIsland = new System.Windows.Forms.Button();
            this.btnShowIslands = new System.Windows.Forms.Button();
            this.cmbCards = new System.Windows.Forms.ComboBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnAllCards = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIlhas = new System.Windows.Forms.Label();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.flpHand = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrTrigger = new System.Windows.Forms.Timer(this.components);
            this.pnlMain.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.lstPlayers.Location = new System.Drawing.Point(4, 4);
            this.lstPlayers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstPlayers.MinimumSize = new System.Drawing.Size(4, 36);
            this.lstPlayers.Name = "lstPlayers";
            this.lstPlayers.Scrollable = false;
            this.lstPlayers.Size = new System.Drawing.Size(255, 146);
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
            this.btnStart.Location = new System.Drawing.Point(597, 299);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(200, 49);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(597, 356);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(200, 49);
            this.btnQuit.TabIndex = 10;
            this.btnQuit.Text = "Sair";
            this.btnQuit.UseVisualStyleBackColor = true;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // lblTurn
            // 
            this.lblTurn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTurn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.Location = new System.Drawing.Point(279, 4);
            this.lblTurn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(193, 46);
            this.lblTurn.TabIndex = 12;
            this.lblTurn.Text = "Vez";
            this.lblTurn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNarration
            // 
            this.btnNarration.Location = new System.Drawing.Point(99, 702);
            this.btnNarration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNarration.Name = "btnNarration";
            this.btnNarration.Size = new System.Drawing.Size(255, 46);
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
            this.txtNarration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNarration.MaximumSize = new System.Drawing.Size(1331, 1229);
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.ReadOnly = true;
            this.txtNarration.Size = new System.Drawing.Size(417, 694);
            this.txtNarration.TabIndex = 15;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.DimGray;
            this.pnlMain.Controls.Add(this.pnlBottom);
            this.pnlMain.Controls.Add(this.pnlRight);
            this.pnlMain.Controls.Add(this.btnStart);
            this.pnlMain.Controls.Add(this.btnQuit);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Location = new System.Drawing.Point(16, 15);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1387, 809);
            this.pnlMain.TabIndex = 16;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBottom.Controls.Add(this.btnTable);
            this.pnlBottom.Controls.Add(this.cmbIslands);
            this.pnlBottom.Controls.Add(this.btnChooseIsland);
            this.pnlBottom.Controls.Add(this.btnShowIslands);
            this.pnlBottom.Controls.Add(this.cmbCards);
            this.pnlBottom.Controls.Add(this.btnPlay);
            this.pnlBottom.Controls.Add(this.lstPlayers);
            this.pnlBottom.Controls.Add(this.btnCheck);
            this.pnlBottom.Controls.Add(this.lblTurn);
            this.pnlBottom.Location = new System.Drawing.Point(12, 640);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(941, 158);
            this.pnlBottom.TabIndex = 18;
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.Location = new System.Drawing.Point(513, 4);
            this.btnTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(191, 46);
            this.btnTable.TabIndex = 20;
            this.btnTable.Text = "Verificar Mesa";
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // cmbIslands
            // 
            this.cmbIslands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslands.FormattingEnabled = true;
            this.cmbIslands.Location = new System.Drawing.Point(744, 107);
            this.cmbIslands.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIslands.Name = "cmbIslands";
            this.cmbIslands.Size = new System.Drawing.Size(189, 24);
            this.cmbIslands.TabIndex = 19;
            // 
            // btnChooseIsland
            // 
            this.btnChooseIsland.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChooseIsland.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseIsland.Location = new System.Drawing.Point(744, 4);
            this.btnChooseIsland.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChooseIsland.Name = "btnChooseIsland";
            this.btnChooseIsland.Size = new System.Drawing.Size(191, 46);
            this.btnChooseIsland.TabIndex = 18;
            this.btnChooseIsland.Text = "Escolher Ilha";
            this.btnChooseIsland.UseVisualStyleBackColor = false;
            this.btnChooseIsland.Click += new System.EventHandler(this.btnChooseIsland_Click);
            // 
            // btnShowIslands
            // 
            this.btnShowIslands.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnShowIslands.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowIslands.Location = new System.Drawing.Point(744, 57);
            this.btnShowIslands.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnShowIslands.Name = "btnShowIslands";
            this.btnShowIslands.Size = new System.Drawing.Size(191, 46);
            this.btnShowIslands.TabIndex = 17;
            this.btnShowIslands.Text = "Mostrar Ilhas";
            this.btnShowIslands.UseVisualStyleBackColor = false;
            this.btnShowIslands.Click += new System.EventHandler(this.btnShowIslands_Click);
            // 
            // cmbCards
            // 
            this.cmbCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCards.FormattingEnabled = true;
            this.cmbCards.Location = new System.Drawing.Point(513, 107);
            this.cmbCards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCards.Name = "cmbCards";
            this.cmbCards.Size = new System.Drawing.Size(189, 24);
            this.cmbCards.TabIndex = 16;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(513, 55);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(191, 46);
            this.btnPlay.TabIndex = 15;
            this.btnPlay.Text = "Jogar";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(279, 55);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(193, 46);
            this.btnCheck.TabIndex = 13;
            this.btnCheck.Text = "Checa Vez";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlRight.Controls.Add(this.btnAllCards);
            this.pnlRight.Controls.Add(this.btnNarration);
            this.pnlRight.Controls.Add(this.txtNarration);
            this.pnlRight.Location = new System.Drawing.Point(960, 4);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(421, 800);
            this.pnlRight.TabIndex = 17;
            // 
            // btnAllCards
            // 
            this.btnAllCards.Location = new System.Drawing.Point(99, 745);
            this.btnAllCards.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAllCards.Name = "btnAllCards";
            this.btnAllCards.Size = new System.Drawing.Size(255, 46);
            this.btnAllCards.TabIndex = 16;
            this.btnAllCards.Text = "Visualizar todas as cartas";
            this.btnAllCards.UseVisualStyleBackColor = true;
            this.btnAllCards.Click += new System.EventHandler(this.btnAllCards_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Game.Properties.Resources.mesa_skol;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblIlhas);
            this.panel1.Controls.Add(this.flpTable);
            this.panel1.Controls.Add(this.flpHand);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 630);
            this.panel1.TabIndex = 5;
            // 
            // lblIlhas
            // 
            this.lblIlhas.BackColor = System.Drawing.Color.Transparent;
            this.lblIlhas.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIlhas.ForeColor = System.Drawing.Color.Black;
            this.lblIlhas.Location = new System.Drawing.Point(401, 293);
            this.lblIlhas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIlhas.Name = "lblIlhas";
            this.lblIlhas.Size = new System.Drawing.Size(161, 55);
            this.lblIlhas.TabIndex = 21;
            this.lblIlhas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpTable
            // 
            this.flpTable.BackColor = System.Drawing.Color.Transparent;
            this.flpTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpTable.Location = new System.Drawing.Point(109, 80);
            this.flpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(697, 189);
            this.flpTable.TabIndex = 20;
            // 
            // flpHand
            // 
            this.flpHand.BackColor = System.Drawing.Color.Transparent;
            this.flpHand.Location = new System.Drawing.Point(5, 447);
            this.flpHand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpHand.Name = "flpHand";
            this.flpHand.Size = new System.Drawing.Size(927, 181);
            this.flpHand.TabIndex = 19;
            // 
            // tmrTrigger
            // 
            this.tmrTrigger.Interval = 1500;
            this.tmrTrigger.Tick += new System.EventHandler(this.tmrTrigger_Tick);
            // 
            // Running
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game.Properties.Resources.liquid_bg;
            this.ClientSize = new System.Drawing.Size(1416, 825);
            this.Controls.Add(this.pnlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(1434, 872);
            this.MinimumSize = new System.Drawing.Size(1434, 872);
            this.Name = "Running";
            this.Text = "Running";
            this.Load += new System.EventHandler(this.Running_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlBottom.ResumeLayout(false);
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flpHand;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cmbCards;
        private System.Windows.Forms.Button btnShowIslands;
        private System.Windows.Forms.ComboBox cmbIslands;
        private System.Windows.Forms.Button btnChooseIsland;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Timer tmrTrigger;
        private System.Windows.Forms.Label lblIlhas;
    }
}