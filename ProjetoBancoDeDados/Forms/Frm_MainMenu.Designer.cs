namespace ProjetoBancoDeDados
{
    partial class Frm_MainMenu
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
            this.Mnu_MainMenu = new System.Windows.Forms.MenuStrip();
            this.fileExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exploreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shareListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browsePlansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Tbc_Apps = new System.Windows.Forms.TabControl();
            this.Mnu_MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mnu_MainMenu
            // 
            this.Mnu_MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileExplorerToolStripMenuItem,
            this.myProfileToolStripMenuItem,
            this.getHelpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.Mnu_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.Mnu_MainMenu.Name = "Mnu_MainMenu";
            this.Mnu_MainMenu.Size = new System.Drawing.Size(851, 24);
            this.Mnu_MainMenu.TabIndex = 0;
            this.Mnu_MainMenu.Text = "menuStrip1";
            // 
            // fileExplorerToolStripMenuItem
            // 
            this.fileExplorerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myFilesToolStripMenuItem,
            this.exploreToolStripMenuItem,
            this.shareListToolStripMenuItem});
            this.fileExplorerToolStripMenuItem.Name = "fileExplorerToolStripMenuItem";
            this.fileExplorerToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.fileExplorerToolStripMenuItem.Text = "File Explorer";
            // 
            // myFilesToolStripMenuItem
            // 
            this.myFilesToolStripMenuItem.Name = "myFilesToolStripMenuItem";
            this.myFilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.myFilesToolStripMenuItem.Text = "My Files";
            this.myFilesToolStripMenuItem.Click += new System.EventHandler(this.myFilesToolStripMenuItem_Click);
            // 
            // exploreToolStripMenuItem
            // 
            this.exploreToolStripMenuItem.Name = "exploreToolStripMenuItem";
            this.exploreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exploreToolStripMenuItem.Text = "New File";
            this.exploreToolStripMenuItem.Click += new System.EventHandler(this.exploreToolStripMenuItem_Click);
            // 
            // shareListToolStripMenuItem
            // 
            this.shareListToolStripMenuItem.Name = "shareListToolStripMenuItem";
            this.shareListToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shareListToolStripMenuItem.Text = "Share List";
            this.shareListToolStripMenuItem.Click += new System.EventHandler(this.shareListToolStripMenuItem_Click);
            // 
            // myProfileToolStripMenuItem
            // 
            this.myProfileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProfileToolStripMenuItem,
            this.browsePlansToolStripMenuItem,
            this.notificationsToolStripMenuItem});
            this.myProfileToolStripMenuItem.Name = "myProfileToolStripMenuItem";
            this.myProfileToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.myProfileToolStripMenuItem.Text = "My Profile";
            // 
            // editProfileToolStripMenuItem
            // 
            this.editProfileToolStripMenuItem.Name = "editProfileToolStripMenuItem";
            this.editProfileToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.editProfileToolStripMenuItem.Text = "Edit Profile";
            this.editProfileToolStripMenuItem.Click += new System.EventHandler(this.editProfileToolStripMenuItem_Click);
            // 
            // browsePlansToolStripMenuItem
            // 
            this.browsePlansToolStripMenuItem.Name = "browsePlansToolStripMenuItem";
            this.browsePlansToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.browsePlansToolStripMenuItem.Text = "Browse Plans";
            this.browsePlansToolStripMenuItem.Click += new System.EventHandler(this.browsePlansToolStripMenuItem_Click);
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.notificationsToolStripMenuItem.Text = "Notifications";
            this.notificationsToolStripMenuItem.Click += new System.EventHandler(this.notificationsToolStripMenuItem_Click);
            // 
            // getHelpToolStripMenuItem
            // 
            this.getHelpToolStripMenuItem.Name = "getHelpToolStripMenuItem";
            this.getHelpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.getHelpToolStripMenuItem.Text = "Get Help";
            this.getHelpToolStripMenuItem.Click += new System.EventHandler(this.getHelpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Tbc_Apps
            // 
            this.Tbc_Apps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tbc_Apps.Location = new System.Drawing.Point(0, 24);
            this.Tbc_Apps.Name = "Tbc_Apps";
            this.Tbc_Apps.SelectedIndex = 0;
            this.Tbc_Apps.Size = new System.Drawing.Size(851, 555);
            this.Tbc_Apps.TabIndex = 1;
            // 
            // Frm_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(851, 579);
            this.Controls.Add(this.Tbc_Apps);
            this.Controls.Add(this.Mnu_MainMenu);
            this.MainMenuStrip = this.Mnu_MainMenu;
            this.Name = "Frm_MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Mnu_MainMenu.ResumeLayout(false);
            this.Mnu_MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Mnu_MainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exploreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shareListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browsePlansToolStripMenuItem;
        private System.Windows.Forms.TabControl Tbc_Apps;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
    }
}

