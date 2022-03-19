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
            this.pnlDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // ListEvents
            // 
            this.ListEvents.FormattingEnabled = true;
            this.ListEvents.Items.AddRange(new object[] {
            "Debugging Console is ON!"});
            this.ListEvents.Location = new System.Drawing.Point(0, 0);
            this.ListEvents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListEvents.Name = "ListEvents";
            this.ListEvents.Size = new System.Drawing.Size(298, 641);
            this.ListEvents.TabIndex = 0;
            this.ListEvents.SelectedIndexChanged += new System.EventHandler(this.ListEvents_SelectedIndexChanged);
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.AutoScroll = true;
            this.pnlDisplay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlDisplay.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pnlDisplay.Location = new System.Drawing.Point(303, 0);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(10);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(300, 641);
            this.pnlDisplay.TabIndex = 1;
            // 
            // DebugConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 640);
            this.Controls.Add(this.pnlDisplay);
            this.Controls.Add(this.ListEvents);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DebugConsole";
            this.Text = "DebugConsole";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox ListEvents;
        public System.Windows.Forms.FlowLayoutPanel pnlDisplay;
    }
}