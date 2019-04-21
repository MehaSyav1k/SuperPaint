namespace WindowsFormsApp8
{
    partial class SuperPaint
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поворотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повернутьВправоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.повернутьВлевоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.OrangeRed;
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.поворотToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1184, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.BackColor = System.Drawing.Color.OrangeRed;
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // поворотToolStripMenuItem
            // 
            this.поворотToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.повернутьВправоToolStripMenuItem,
            this.повернутьВлевоToolStripMenuItem});
            this.поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            this.поворотToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.поворотToolStripMenuItem.Text = "Поворот";
            // 
            // повернутьВправоToolStripMenuItem
            // 
            this.повернутьВправоToolStripMenuItem.Name = "повернутьВправоToolStripMenuItem";
            this.повернутьВправоToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.повернутьВправоToolStripMenuItem.Text = "Повернуть вправо";
            this.повернутьВправоToolStripMenuItem.Click += new System.EventHandler(this.повернутьВправоToolStripMenuItem_Click);
            // 
            // повернутьВлевоToolStripMenuItem
            // 
            this.повернутьВлевоToolStripMenuItem.Name = "повернутьВлевоToolStripMenuItem";
            this.повернутьВлевоToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.повернутьВлевоToolStripMenuItem.Text = "Повернуть влево";
            this.повернутьВлевоToolStripMenuItem.Click += new System.EventHandler(this.повернутьВлевоToolStripMenuItem_Click);
            // 
            // Picture
            // 
            this.Picture.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Picture.Location = new System.Drawing.Point(0, 27);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(1184, 589);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 1;
            this.Picture.TabStop = false;
            this.Picture.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.MouseDoubleClick);
            this.Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown);
            this.Picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MouseMove);
            this.Picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            this.OpenFile.Filter = "Image Files|*.jpg;*.png;*.bmp;*";
            // 
            // SuperPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "SuperPaint";
            this.Text = "SuperPaint";
            this.Load += new System.EventHandler(this.FormLoad);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.ToolStripMenuItem поворотToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутьВправоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem повернутьВлевоToolStripMenuItem;
    }
}

