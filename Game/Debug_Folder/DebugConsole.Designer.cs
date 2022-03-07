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
            this.SuspendLayout();
            // 
            // ListEvents
            // 
            this.ListEvents.FormattingEnabled = true;
            this.ListEvents.ItemHeight = 20;
            this.ListEvents.Items.AddRange(new object[] {
            "Debugging Console is ON!"});
            this.ListEvents.Location = new System.Drawing.Point(0, 0);
            this.ListEvents.Name = "ListEvents";
            this.ListEvents.Size = new System.Drawing.Size(799, 444);
            this.ListEvents.TabIndex = 0;
            this.ListEvents.SelectedIndexChanged += new System.EventHandler(this.ListEvents_SelectedIndexChanged);
            // 
            // DebugConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListEvents);
            this.Name = "DebugConsole";
            this.Text = "DebugConsole";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListEvents;
    }
}