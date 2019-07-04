namespace MovieStore.WinUI
{
    partial class Form1
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
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcılarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMüşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniFilmKiralamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralananFilmlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKullanıcıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriDüzenlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşterilerToolStripMenuItem,
            this.filmlerToolStripMenuItem,
            this.kiralamaToolStripMenuItem,
            this.kullanıcılarToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniMüşteriToolStripMenuItem,
            this.müşteriDüzenlemeToolStripMenuItem});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müşterilerToolStripMenuItem.Text = "Müşteriler";
            // 
            // filmlerToolStripMenuItem
            // 
            this.filmlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniFilmToolStripMenuItem,
            this.filmDüzenlemeToolStripMenuItem});
            this.filmlerToolStripMenuItem.Name = "filmlerToolStripMenuItem";
            this.filmlerToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.filmlerToolStripMenuItem.Text = "Filmler";
            // 
            // kiralamaToolStripMenuItem
            // 
            this.kiralamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniFilmKiralamaToolStripMenuItem,
            this.kiralananFilmlerToolStripMenuItem,
            this.düzenlemeToolStripMenuItem});
            this.kiralamaToolStripMenuItem.Name = "kiralamaToolStripMenuItem";
            this.kiralamaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.kiralamaToolStripMenuItem.Text = "Kiralama";
            // 
            // kullanıcılarToolStripMenuItem
            // 
            this.kullanıcılarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKullanıcıToolStripMenuItem,
            this.kullanıcıDüzenlemeToolStripMenuItem});
            this.kullanıcılarToolStripMenuItem.Name = "kullanıcılarToolStripMenuItem";
            this.kullanıcılarToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.kullanıcılarToolStripMenuItem.Text = "Kullanıcılar";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // yeniMüşteriToolStripMenuItem
            // 
            this.yeniMüşteriToolStripMenuItem.Name = "yeniMüşteriToolStripMenuItem";
            this.yeniMüşteriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniMüşteriToolStripMenuItem.Text = "Yeni Müşteri";
            this.yeniMüşteriToolStripMenuItem.Click += new System.EventHandler(this.yeniMüşteriToolStripMenuItem_Click);
            // 
            // yeniFilmToolStripMenuItem
            // 
            this.yeniFilmToolStripMenuItem.Name = "yeniFilmToolStripMenuItem";
            this.yeniFilmToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniFilmToolStripMenuItem.Text = "Yeni Film";
            this.yeniFilmToolStripMenuItem.Click += new System.EventHandler(this.yeniFilmToolStripMenuItem_Click);
            // 
            // yeniFilmKiralamaToolStripMenuItem
            // 
            this.yeniFilmKiralamaToolStripMenuItem.Name = "yeniFilmKiralamaToolStripMenuItem";
            this.yeniFilmKiralamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniFilmKiralamaToolStripMenuItem.Text = "Yeni Film Kiralama";
            this.yeniFilmKiralamaToolStripMenuItem.Click += new System.EventHandler(this.yeniFilmKiralamaToolStripMenuItem_Click);
            // 
            // kiralananFilmlerToolStripMenuItem
            // 
            this.kiralananFilmlerToolStripMenuItem.Name = "kiralananFilmlerToolStripMenuItem";
            this.kiralananFilmlerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kiralananFilmlerToolStripMenuItem.Text = "Kiralanan Filmler";
            // 
            // yeniKullanıcıToolStripMenuItem
            // 
            this.yeniKullanıcıToolStripMenuItem.Name = "yeniKullanıcıToolStripMenuItem";
            this.yeniKullanıcıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniKullanıcıToolStripMenuItem.Text = "Yeni Kullanıcı";
            this.yeniKullanıcıToolStripMenuItem.Click += new System.EventHandler(this.yeniKullanıcıToolStripMenuItem_Click);
            // 
            // kullanıcıDüzenlemeToolStripMenuItem
            // 
            this.kullanıcıDüzenlemeToolStripMenuItem.Name = "kullanıcıDüzenlemeToolStripMenuItem";
            this.kullanıcıDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.kullanıcıDüzenlemeToolStripMenuItem.Text = "Kullanıcı Düzenleme";
            this.kullanıcıDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıDüzenlemeToolStripMenuItem_Click);
            // 
            // düzenlemeToolStripMenuItem
            // 
            this.düzenlemeToolStripMenuItem.Name = "düzenlemeToolStripMenuItem";
            this.düzenlemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.düzenlemeToolStripMenuItem.Text = "Düzenleme";
            this.düzenlemeToolStripMenuItem.Click += new System.EventHandler(this.düzenlemeToolStripMenuItem_Click);
            // 
            // filmDüzenlemeToolStripMenuItem
            // 
            this.filmDüzenlemeToolStripMenuItem.Name = "filmDüzenlemeToolStripMenuItem";
            this.filmDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.filmDüzenlemeToolStripMenuItem.Text = "Film Düzenleme";
            this.filmDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.filmDüzenlemeToolStripMenuItem_Click);
            // 
            // müşteriDüzenlemeToolStripMenuItem
            // 
            this.müşteriDüzenlemeToolStripMenuItem.Name = "müşteriDüzenlemeToolStripMenuItem";
            this.müşteriDüzenlemeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.müşteriDüzenlemeToolStripMenuItem.Text = "Müşteri Düzenleme";
            this.müşteriDüzenlemeToolStripMenuItem.Click += new System.EventHandler(this.müşteriDüzenlemeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Movie Store";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcılarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniMüşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniFilmKiralamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralananFilmlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKullanıcıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmDüzenlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem düzenlemeToolStripMenuItem;
    }
}

