namespace imageProc
{
    partial class Form3
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
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ortalamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaynakBox = new System.Windows.Forms.PictureBox();
            this.islemBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bT709ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.açıklıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kanalÇıkarımıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.açToolStripMenuItem,
            this.kaydetToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // açToolStripMenuItem
            // 
            this.açToolStripMenuItem.Name = "açToolStripMenuItem";
            this.açToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.açToolStripMenuItem.Text = "Aç";
            this.açToolStripMenuItem.Click += new System.EventHandler(this.açToolStripMenuItem_Click);
            // 
            // kaydetToolStripMenuItem
            // 
            this.kaydetToolStripMenuItem.Name = "kaydetToolStripMenuItem";
            this.kaydetToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.kaydetToolStripMenuItem.Text = "Kaydet";
            this.kaydetToolStripMenuItem.Click += new System.EventHandler(this.kaydetToolStripMenuItem_Click);
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ortalamaToolStripMenuItem,
            this.bT709ToolStripMenuItem,
            this.lumaToolStripMenuItem,
            this.açıklıkToolStripMenuItem,
            this.kanalÇıkarımıToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.işlemlerToolStripMenuItem.Text = "Gri Yöntemleri";
            // 
            // ortalamaToolStripMenuItem
            // 
            this.ortalamaToolStripMenuItem.Name = "ortalamaToolStripMenuItem";
            this.ortalamaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ortalamaToolStripMenuItem.Text = "Ortalama";
            this.ortalamaToolStripMenuItem.Click += new System.EventHandler(this.ortalamaToolStripMenuItem_Click);
            // 
            // kaynakBox
            // 
            this.kaynakBox.Location = new System.Drawing.Point(13, 28);
            this.kaynakBox.Name = "kaynakBox";
            this.kaynakBox.Size = new System.Drawing.Size(460, 480);
            this.kaynakBox.TabIndex = 1;
            this.kaynakBox.TabStop = false;
            this.kaynakBox.Click += new System.EventHandler(this.kaynakBox_Click);
            // 
            // islemBox
            // 
            this.islemBox.Location = new System.Drawing.Point(511, 28);
            this.islemBox.Name = "islemBox";
            this.islemBox.Size = new System.Drawing.Size(460, 480);
            this.islemBox.TabIndex = 2;
            this.islemBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bT709ToolStripMenuItem
            // 
            this.bT709ToolStripMenuItem.Name = "bT709ToolStripMenuItem";
            this.bT709ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bT709ToolStripMenuItem.Text = "BT-709";
            this.bT709ToolStripMenuItem.Click += new System.EventHandler(this.bT709ToolStripMenuItem_Click);
            // 
            // lumaToolStripMenuItem
            // 
            this.lumaToolStripMenuItem.Name = "lumaToolStripMenuItem";
            this.lumaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lumaToolStripMenuItem.Text = "Luma";
            this.lumaToolStripMenuItem.Click += new System.EventHandler(this.lumaToolStripMenuItem_Click);
            // 
            // açıklıkToolStripMenuItem
            // 
            this.açıklıkToolStripMenuItem.Name = "açıklıkToolStripMenuItem";
            this.açıklıkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.açıklıkToolStripMenuItem.Text = "Açıklık";
            this.açıklıkToolStripMenuItem.Click += new System.EventHandler(this.açıklıkToolStripMenuItem_Click);
            // 
            // kanalÇıkarımıToolStripMenuItem
            // 
            this.kanalÇıkarımıToolStripMenuItem.Name = "kanalÇıkarımıToolStripMenuItem";
            this.kanalÇıkarımıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kanalÇıkarımıToolStripMenuItem.Text = "Kanal Çıkarımı";
            this.kanalÇıkarımıToolStripMenuItem.Click += new System.EventHandler(this.kanalÇıkarımıToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 606);
            this.Controls.Add(this.islemBox);
            this.Controls.Add(this.kaynakBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Gri Yöntemleri Formu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kaynakBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.islemBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ortalamaToolStripMenuItem;
        private System.Windows.Forms.PictureBox kaynakBox;
        private System.Windows.Forms.PictureBox islemBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem bT709ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem açıklıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kanalÇıkarımıToolStripMenuItem;
    }
}