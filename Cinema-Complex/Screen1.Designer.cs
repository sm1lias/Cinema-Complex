namespace Cinema_Complex
{
    partial class Screen1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.πΙΣΩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.σΧΕΤΙΚΑToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.πΙΣΩToolStripMenuItem,
            this.σΧΕΤΙΚΑToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // πΙΣΩToolStripMenuItem
            // 
            this.πΙΣΩToolStripMenuItem.Name = "πΙΣΩToolStripMenuItem";
            this.πΙΣΩToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.πΙΣΩToolStripMenuItem.Text = "ΠΙΣΩ";
            this.πΙΣΩToolStripMenuItem.Click += new System.EventHandler(this.πΙΣΩToolStripMenuItem_Click);
            // 
            // σΧΕΤΙΚΑToolStripMenuItem
            // 
            this.σΧΕΤΙΚΑToolStripMenuItem.Name = "σΧΕΤΙΚΑToolStripMenuItem";
            this.σΧΕΤΙΚΑToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.σΧΕΤΙΚΑToolStripMenuItem.Text = "ΣΧΕΤΙΚΑ";
            this.σΧΕΤΙΚΑToolStripMenuItem.Click += new System.EventHandler(this.σΧΕΤΙΚΑToolStripMenuItem_Click);
            // 
            // Screen1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinema_Complex.Properties.Resources.screen1;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Screen1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Screen1_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem πΙΣΩToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem σΧΕΤΙΚΑToolStripMenuItem;
    }
}