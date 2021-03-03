namespace Cinema_Complex
{
    partial class Hall
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
            this.barButton = new System.Windows.Forms.Button();
            this.ticketsButton = new System.Windows.Forms.Button();
            this.screensButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.πΙΣΩToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.βΟΗΘΕΙΑToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.σΧΕΤΙΚΑToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // barButton
            // 
            this.barButton.BackColor = System.Drawing.Color.Transparent;
            this.barButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barButton.FlatAppearance.BorderSize = 0;
            this.barButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.barButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButton.Location = new System.Drawing.Point(2, 340);
            this.barButton.Name = "barButton";
            this.barButton.Size = new System.Drawing.Size(583, 317);
            this.barButton.TabIndex = 0;
            this.barButton.UseVisualStyleBackColor = false;
            this.barButton.Click += new System.EventHandler(this.barButton_Click);
            // 
            // ticketsButton
            // 
            this.ticketsButton.BackColor = System.Drawing.Color.Transparent;
            this.ticketsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ticketsButton.FlatAppearance.BorderSize = 0;
            this.ticketsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ticketsButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketsButton.Location = new System.Drawing.Point(962, 397);
            this.ticketsButton.Name = "ticketsButton";
            this.ticketsButton.Size = new System.Drawing.Size(301, 204);
            this.ticketsButton.TabIndex = 1;
            this.ticketsButton.UseVisualStyleBackColor = false;
            this.ticketsButton.Click += new System.EventHandler(this.ticketsButton_Click);
            // 
            // screensButton
            // 
            this.screensButton.BackColor = System.Drawing.Color.Transparent;
            this.screensButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.screensButton.FlatAppearance.BorderSize = 0;
            this.screensButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.screensButton.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screensButton.Location = new System.Drawing.Point(718, 480);
            this.screensButton.Name = "screensButton";
            this.screensButton.Size = new System.Drawing.Size(124, 99);
            this.screensButton.TabIndex = 2;
            this.screensButton.UseVisualStyleBackColor = false;
            this.screensButton.Click += new System.EventHandler(this.screensButton_Click);
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
            this.menuStrip1.TabIndex = 3;
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
            // Hall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cinema_Complex.Properties.Resources.Untitled_1;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.screensButton);
            this.Controls.Add(this.ticketsButton);
            this.Controls.Add(this.barButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Hall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Hall_FormClosed);
            this.Load += new System.EventHandler(this.Hall_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button barButton;
        private System.Windows.Forms.Button ticketsButton;
        private System.Windows.Forms.Button screensButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem βΟΗΘΕΙΑToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem σΧΕΤΙΚΑToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem πΙΣΩToolStripMenuItem;
    }
}