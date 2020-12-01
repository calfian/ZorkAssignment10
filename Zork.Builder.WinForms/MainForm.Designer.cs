namespace Zork.Builder.WinForms
{
    partial class MainForm
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
            System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem newWorldToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem openWorldToolStripMenuItem;
            System.Windows.Forms.ToolStripSeparator separator1ToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem saveWorldToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
            System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
            this.saveWorldAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.gameTabPage = new System.Windows.Forms.TabPage();
            this.worldTabPage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.modifiedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.isModifiedToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gameView = new Zork.Builder.WinForms.GameView();
            this.worldView = new Zork.Builder.WinForms.WorldView();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            openWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            separator1ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            saveWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.gameTabPage.SuspendLayout();
            this.worldTabPage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            newWorldToolStripMenuItem,
            openWorldToolStripMenuItem,
            separator1ToolStripMenuItem,
            saveWorldToolStripMenuItem,
            this.saveWorldAsToolStripMenuItem,
            this.separator2ToolStripMenuItem,
            exitToolStripMenuItem});
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newWorldToolStripMenuItem
            // 
            newWorldToolStripMenuItem.Name = "newWorldToolStripMenuItem";
            newWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            newWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            newWorldToolStripMenuItem.Text = "&New World...";
            newWorldToolStripMenuItem.Click += new System.EventHandler(this.NewWorldToolStripMenuItem_Click);
            // 
            // openWorldToolStripMenuItem
            // 
            openWorldToolStripMenuItem.Name = "openWorldToolStripMenuItem";
            openWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            openWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            openWorldToolStripMenuItem.Text = "&Open World...";
            openWorldToolStripMenuItem.Click += new System.EventHandler(this.OpenWorldToolStripMenuItem_Click);
            // 
            // separator1ToolStripMenuItem
            // 
            separator1ToolStripMenuItem.Name = "separator1ToolStripMenuItem";
            separator1ToolStripMenuItem.Size = new System.Drawing.Size(187, 6);
            // 
            // saveWorldToolStripMenuItem
            // 
            saveWorldToolStripMenuItem.Name = "saveWorldToolStripMenuItem";
            saveWorldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            saveWorldToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            saveWorldToolStripMenuItem.Text = "&Save World";
            saveWorldToolStripMenuItem.Click += new System.EventHandler(this.SaveWorldToolStripMenuItem_Click);
            // 
            // saveWorldAsToolStripMenuItem
            // 
            this.saveWorldAsToolStripMenuItem.Name = "saveWorldAsToolStripMenuItem";
            this.saveWorldAsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveWorldAsToolStripMenuItem.Text = "Save World &As...";
            this.saveWorldAsToolStripMenuItem.Click += new System.EventHandler(this.SaveWorldAsToolStripMenuItem_Click);
            // 
            // separator2ToolStripMenuItem
            // 
            this.separator2ToolStripMenuItem.Name = "separator2ToolStripMenuItem";
            this.separator2ToolStripMenuItem.Size = new System.Drawing.Size(187, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            aboutToolStripMenuItem});
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            fileToolStripMenuItem,
            helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifiedToolStripStatusLabel,
            this.isModifiedToolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // gameTabPage
            // 
            this.gameTabPage.Controls.Add(this.gameView);
            this.gameTabPage.Location = new System.Drawing.Point(4, 22);
            this.gameTabPage.Name = "gameTabPage";
            this.gameTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.gameTabPage.Size = new System.Drawing.Size(792, 378);
            this.gameTabPage.TabIndex = 1;
            this.gameTabPage.Text = "Game";
            this.gameTabPage.UseVisualStyleBackColor = true;
            // 
            // worldTabPage
            // 
            this.worldTabPage.Controls.Add(this.worldView);
            this.worldTabPage.Location = new System.Drawing.Point(4, 22);
            this.worldTabPage.Name = "worldTabPage";
            this.worldTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.worldTabPage.Size = new System.Drawing.Size(792, 378);
            this.worldTabPage.TabIndex = 0;
            this.worldTabPage.Text = "World";
            this.worldTabPage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.worldTabPage);
            this.tabControl1.Controls.Add(this.gameTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 404);
            this.tabControl1.TabIndex = 2;
            // 
            // modifiedToolStripStatusLabel
            // 
            this.modifiedToolStripStatusLabel.Name = "modifiedToolStripStatusLabel";
            this.modifiedToolStripStatusLabel.Size = new System.Drawing.Size(58, 17);
            this.modifiedToolStripStatusLabel.Text = "Modified:";
            // 
            // isModifiedToolStripStatusLabel
            // 
            this.isModifiedToolStripStatusLabel.Name = "isModifiedToolStripStatusLabel";
            this.isModifiedToolStripStatusLabel.Size = new System.Drawing.Size(23, 17);
            this.isModifiedToolStripStatusLabel.Text = "No";
            // 
            // gameView
            // 
            this.gameView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameView.Location = new System.Drawing.Point(3, 3);
            this.gameView.Name = "gameView";
            this.gameView.Size = new System.Drawing.Size(786, 372);
            this.gameView.TabIndex = 0;
            this.gameView.ViewModel = null;
            // 
            // worldView
            // 
            this.worldView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.worldView.Location = new System.Drawing.Point(3, 3);
            this.worldView.Name = "worldView";
            this.worldView.Size = new System.Drawing.Size(786, 372);
            this.worldView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.gameTabPage.ResumeLayout(false);
            this.worldTabPage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem saveWorldAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separator2ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabPage gameTabPage;
        private System.Windows.Forms.TabPage worldTabPage;
        private System.Windows.Forms.TabControl tabControl1;
        private GameView gameView;
        private System.Windows.Forms.ToolStripStatusLabel modifiedToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel isModifiedToolStripStatusLabel;
        private WorldView worldView;
    }
}

