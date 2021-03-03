namespace Cinema_Complex
{
    partial class Screens
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
            this.screen1Button = new System.Windows.Forms.Button();
            this.sceen2Button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.πΙΣΩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.βΟΗΘΕΙΑToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.σΧΕΤΙΚΑToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // screen1Button
            // 
            this.screen1Button.BackColor = System.Drawing.Color.Transparent;
            this.screen1Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.screen1Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.screen1Button.Location = new System.Drawing.Point(78, 296);
            this.screen1Button.Name = "screen1Button";
            this.screen1Button.Size = new System.Drawing.Size(268, 140);
            this.screen1Button.TabIndex = 0;
            this.screen1Button.UseVisualStyleBackColor = false;
            this.screen1Button.Click += new System.EventHandler(this.screen1Button_Click);
            // 
            // sceen2Button
            // 
            this.sceen2Button.BackColor = System.Drawing.Color.Transparent;
            this.sceen2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sceen2Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sceen2Button.Location = new System.Drawing.Point(352, 296);
            this.sceen2Button.Name = "sceen2Button";
            this.sceen2Button.Size = new System.Drawing.Size(268, 140);
            this.sceen2Button.TabIndex = 1;
            this.sceen2Button.UseVisualStyleBackColor = false;
            this.sceen2Button.Click += new System.EventHandler(this.sceen2Button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.πΙΣΩToolStripMenuItem,
            this.βΟΗΘΕΙΑToolStripMenuItem,
            this.σΧΕΤΙΚΑToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // πΙΣΩToolStripMenuItem
            // 
            this.πΙΣΩToolStripMenuItem.Name = "πΙΣΩToolStripMenuItem";
            this.πΙΣΩToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.πΙΣΩToolStripMenuItem.Text = "ΠΙΣΩ";
            this.πΙΣΩToolStripMenuItem.Click += new System.EventHandler(this.πΙΣΩToolStripMenuItem_Click);
            // 
            // βΟΗΘΕΙΑToolStripMenuItem
            // 
            this.βΟΗΘΕΙΑToolStripMenuItem.Name = "βΟΗΘΕΙΑToolStripMenuItem";
            this.βΟΗΘΕΙΑToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.βΟΗΘΕΙΑToolStripMenuItem.Text = "ΒΟΗΘΕΙΑ";
            this.βΟΗΘΕΙΑToolStripMenuItem.Click += new System.EventHandler(this.βΟΗΘΕΙΑToolStripMenuItem_Click);
            // 
            // σΧΕΤΙΚΑToolStripMenuItem
            // 
            this.σΧΕΤΙΚΑToolStripMenuItem.Name = "σΧΕΤΙΚΑToolStripMenuItem";
            this.σΧΕΤΙΚΑToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.σΧΕΤΙΚΑToolStripMenuItem.Text = "ΣΧΕΤΙΚΑ";
            this.σΧΕΤΙΚΑToolStripMenuItem.Click += new System.EventHandler(this.σΧΕΤΙΚΑToolStripMenuItem_Click);
            // 
            // Screens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinema_Complex.Properties.Resources.screens;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.sceen2Button);
            this.Controls.Add(this.screen1Button);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Screens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Screens_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button screen1Button;
        private System.Windows.Forms.Button sceen2Button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem πΙΣΩToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem βΟΗΘΕΙΑToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem σΧΕΤΙΚΑToolStripMenuItem;
    }
}