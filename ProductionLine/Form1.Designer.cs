namespace ProductionLine
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.линииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЛинийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генераторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.генераторыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логированиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.логгерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.линииToolStripMenuItem,
            this.генераторToolStripMenuItem,
            this.логированиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1986, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // линииToolStripMenuItem
            // 
            this.линииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокЛинийToolStripMenuItem});
            this.линииToolStripMenuItem.Name = "линииToolStripMenuItem";
            this.линииToolStripMenuItem.Size = new System.Drawing.Size(99, 38);
            this.линииToolStripMenuItem.Text = "Линии";
            // 
            // списокЛинийToolStripMenuItem
            // 
            this.списокЛинийToolStripMenuItem.Name = "списокЛинийToolStripMenuItem";
            this.списокЛинийToolStripMenuItem.Size = new System.Drawing.Size(270, 38);
            this.списокЛинийToolStripMenuItem.Text = "Список линий";
            this.списокЛинийToolStripMenuItem.Click += new System.EventHandler(this.списокЛинийToolStripMenuItem_Click);
            // 
            // генераторToolStripMenuItem
            // 
            this.генераторToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.генераторыToolStripMenuItem});
            this.генераторToolStripMenuItem.Name = "генераторToolStripMenuItem";
            this.генераторToolStripMenuItem.Size = new System.Drawing.Size(142, 38);
            this.генераторToolStripMenuItem.Text = "Генератор";
            // 
            // генераторыToolStripMenuItem
            // 
            this.генераторыToolStripMenuItem.Name = "генераторыToolStripMenuItem";
            this.генераторыToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.генераторыToolStripMenuItem.Text = "Генераторы";
            this.генераторыToolStripMenuItem.Click += new System.EventHandler(this.генераторыToolStripMenuItem_Click);
            // 
            // логированиеToolStripMenuItem
            // 
            this.логированиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.логгерToolStripMenuItem});
            this.логированиеToolStripMenuItem.Name = "логированиеToolStripMenuItem";
            this.логированиеToolStripMenuItem.Size = new System.Drawing.Size(174, 38);
            this.логированиеToolStripMenuItem.Text = "Логирование";
            // 
            // логгерToolStripMenuItem
            // 
            this.логгерToolStripMenuItem.Name = "логгерToolStripMenuItem";
            this.логгерToolStripMenuItem.Size = new System.Drawing.Size(324, 38);
            this.логгерToolStripMenuItem.Text = "Логгер";
            this.логгерToolStripMenuItem.Click += new System.EventHandler(this.логгерToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1986, 1036);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1986, 1076);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem линииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЛинийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem генераторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem генераторыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логированиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem логгерToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

