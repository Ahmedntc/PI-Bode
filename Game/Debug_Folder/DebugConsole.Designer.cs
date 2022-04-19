namespace Game
{
    partial class DebugConsole
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
            this.ListEvents = new System.Windows.Forms.ListBox();
            this.pnlTest = new System.Windows.Forms.Panel();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.pnlTest.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListEvents
            // 
            this.ListEvents.FormattingEnabled = true;
            this.ListEvents.Items.AddRange(new object[] {
            "Debugging Console is ON!"});
            this.ListEvents.Location = new System.Drawing.Point(0, 0);
            this.ListEvents.Margin = new System.Windows.Forms.Padding(2);
            this.ListEvents.Name = "ListEvents";
            this.ListEvents.Size = new System.Drawing.Size(47, 641);
            this.ListEvents.TabIndex = 0;
            // 
            // pnlTest
            // 
            this.pnlTest.Controls.Add(this.pnlCards);
            this.pnlTest.Location = new System.Drawing.Point(52, 12);
            this.pnlTest.Name = "pnlTest";
            this.pnlTest.Size = new System.Drawing.Size(540, 616);
            this.pnlTest.TabIndex = 1;
            // 
            // pnlCards
            // 
            this.pnlCards.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlCards.Location = new System.Drawing.Point(19, 17);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(507, 234);
            this.pnlCards.TabIndex = 0;
            // 
            // DebugConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 640);
            this.Controls.Add(this.pnlTest);
            this.Controls.Add(this.ListEvents);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DebugConsole";
            this.Text = "DebugConsole";
            this.pnlTest.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox ListEvents;
        private System.Windows.Forms.Panel pnlTest;
        private System.Windows.Forms.Panel pnlCards;
    }
}