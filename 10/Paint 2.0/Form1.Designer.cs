namespace Paint_2._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ecran = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.VybCvet4 = new System.Windows.Forms.Button();
            this.VybCvet2 = new System.Windows.Forms.Button();
            this.VybCvet3 = new System.Windows.Forms.Button();
            this.VybCvet1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.VyborCveta = new System.Windows.Forms.Button();
            this.Cvet = new System.Windows.Forms.ColorDialog();
            this.Pencil = new System.Windows.Forms.Button();
            this.Oshirgish = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.Curve = new System.Windows.Forms.Button();
            this.FillEllipse = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Rect = new System.Windows.Forms.Button();
            this.FillRect = new System.Windows.Forms.Button();
            this.CurInstrum = new System.Windows.Forms.PictureBox();
            this.CurColor = new System.Windows.Forms.PictureBox();
            this.Razmershik = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.фалйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Ecran)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurInstrum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Razmershik)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ecran
            // 
            this.Ecran.BackColor = System.Drawing.Color.White;
            this.Ecran.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Ecran.Location = new System.Drawing.Point(149, 38);
            this.Ecran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ecran.Name = "Ecran";
            this.Ecran.Size = new System.Drawing.Size(800, 550);
            this.Ecran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ecran.TabIndex = 0;
            this.Ecran.TabStop = false;
            this.Ecran.Paint += new System.Windows.Forms.PaintEventHandler(this.Ecran_Paint);
            this.Ecran.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Nazhal);
            this.Ecran.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Otpustil);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(81, 38);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 62);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Cvetik);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Pink;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(81, 109);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 62);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Cvetik);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Aqua;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(81, 251);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 62);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Cvetik);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lime;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(81, 180);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 62);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Cvetik);
            // 
            // VybCvet4
            // 
            this.VybCvet4.BackColor = System.Drawing.Color.White;
            this.VybCvet4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VybCvet4.Location = new System.Drawing.Point(82, 395);
            this.VybCvet4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VybCvet4.Name = "VybCvet4";
            this.VybCvet4.Size = new System.Drawing.Size(60, 62);
            this.VybCvet4.TabIndex = 6;
            this.VybCvet4.UseVisualStyleBackColor = false;
            this.VybCvet4.Click += new System.EventHandler(this.Cvetik);
            // 
            // VybCvet2
            // 
            this.VybCvet2.BackColor = System.Drawing.Color.White;
            this.VybCvet2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VybCvet2.Location = new System.Drawing.Point(82, 323);
            this.VybCvet2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VybCvet2.Name = "VybCvet2";
            this.VybCvet2.Size = new System.Drawing.Size(60, 62);
            this.VybCvet2.TabIndex = 5;
            this.VybCvet2.UseVisualStyleBackColor = false;
            this.VybCvet2.Click += new System.EventHandler(this.Cvetik);
            // 
            // VybCvet3
            // 
            this.VybCvet3.BackColor = System.Drawing.Color.White;
            this.VybCvet3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VybCvet3.Location = new System.Drawing.Point(12, 395);
            this.VybCvet3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VybCvet3.Name = "VybCvet3";
            this.VybCvet3.Size = new System.Drawing.Size(60, 62);
            this.VybCvet3.TabIndex = 12;
            this.VybCvet3.UseVisualStyleBackColor = false;
            this.VybCvet3.Click += new System.EventHandler(this.Cvetik);
            // 
            // VybCvet1
            // 
            this.VybCvet1.BackColor = System.Drawing.Color.White;
            this.VybCvet1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VybCvet1.Location = new System.Drawing.Point(12, 323);
            this.VybCvet1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VybCvet1.Name = "VybCvet1";
            this.VybCvet1.Size = new System.Drawing.Size(60, 62);
            this.VybCvet1.TabIndex = 11;
            this.VybCvet1.UseVisualStyleBackColor = false;
            this.VybCvet1.Click += new System.EventHandler(this.Cvetik);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Blue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(12, 251);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 62);
            this.button9.TabIndex = 10;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Cvetik);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Green;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(12, 180);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 62);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Cvetik);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Red;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(12, 109);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 62);
            this.button11.TabIndex = 8;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Cvetik);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Black;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(12, 38);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 62);
            this.button12.TabIndex = 7;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Cvetik);
            // 
            // VyborCveta
            // 
            this.VyborCveta.Location = new System.Drawing.Point(12, 467);
            this.VyborCveta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.VyborCveta.Name = "VyborCveta";
            this.VyborCveta.Size = new System.Drawing.Size(129, 32);
            this.VyborCveta.TabIndex = 13;
            this.VyborCveta.Text = "Выбор цвета";
            this.VyborCveta.UseVisualStyleBackColor = true;
            this.VyborCveta.Click += new System.EventHandler(this.VyborCveta_Click);
            // 
            // Pencil
            // 
            this.Pencil.BackColor = System.Drawing.Color.White;
            this.Pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pencil.Image = ((System.Drawing.Image)(resources.GetObject("Pencil.Image")));
            this.Pencil.Location = new System.Drawing.Point(12, 607);
            this.Pencil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pencil.Name = "Pencil";
            this.Pencil.Size = new System.Drawing.Size(60, 62);
            this.Pencil.TabIndex = 15;
            this.Pencil.UseVisualStyleBackColor = false;
            this.Pencil.Click += new System.EventHandler(this.Instrumentik);
            // 
            // Oshirgish
            // 
            this.Oshirgish.BackColor = System.Drawing.Color.White;
            this.Oshirgish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Oshirgish.Location = new System.Drawing.Point(81, 607);
            this.Oshirgish.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Oshirgish.Name = "Oshirgish";
            this.Oshirgish.Size = new System.Drawing.Size(60, 62);
            this.Oshirgish.TabIndex = 16;
            this.Oshirgish.UseVisualStyleBackColor = false;
            this.Oshirgish.Click += new System.EventHandler(this.Instrumentik);
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.White;
            this.Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Line.Image = ((System.Drawing.Image)(resources.GetObject("Line.Image")));
            this.Line.Location = new System.Drawing.Point(12, 678);
            this.Line.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(60, 62);
            this.Line.TabIndex = 17;
            this.Line.UseVisualStyleBackColor = false;
            this.Line.Click += new System.EventHandler(this.Instrumentik);
            // 
            // Curve
            // 
            this.Curve.BackColor = System.Drawing.Color.White;
            this.Curve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Curve.Image = ((System.Drawing.Image)(resources.GetObject("Curve.Image")));
            this.Curve.Location = new System.Drawing.Point(81, 678);
            this.Curve.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Curve.Name = "Curve";
            this.Curve.Size = new System.Drawing.Size(60, 62);
            this.Curve.TabIndex = 18;
            this.Curve.UseVisualStyleBackColor = false;
            this.Curve.Click += new System.EventHandler(this.Instrumentik);
            // 
            // FillEllipse
            // 
            this.FillEllipse.BackColor = System.Drawing.Color.White;
            this.FillEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillEllipse.Image = ((System.Drawing.Image)(resources.GetObject("FillEllipse.Image")));
            this.FillEllipse.Location = new System.Drawing.Point(81, 749);
            this.FillEllipse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FillEllipse.Name = "FillEllipse";
            this.FillEllipse.Size = new System.Drawing.Size(60, 62);
            this.FillEllipse.TabIndex = 19;
            this.FillEllipse.UseVisualStyleBackColor = false;
            this.FillEllipse.Click += new System.EventHandler(this.Instrumentik);
            // 
            // Ellipse
            // 
            this.Ellipse.BackColor = System.Drawing.Color.White;
            this.Ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ellipse.Image = ((System.Drawing.Image)(resources.GetObject("Ellipse.Image")));
            this.Ellipse.Location = new System.Drawing.Point(12, 749);
            this.Ellipse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(60, 62);
            this.Ellipse.TabIndex = 20;
            this.Ellipse.UseVisualStyleBackColor = false;
            this.Ellipse.Click += new System.EventHandler(this.Instrumentik);
            // 
            // Rect
            // 
            this.Rect.BackColor = System.Drawing.Color.White;
            this.Rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rect.Image = ((System.Drawing.Image)(resources.GetObject("Rect.Image")));
            this.Rect.Location = new System.Drawing.Point(12, 820);
            this.Rect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rect.Name = "Rect";
            this.Rect.Size = new System.Drawing.Size(60, 62);
            this.Rect.TabIndex = 21;
            this.Rect.UseVisualStyleBackColor = false;
            this.Rect.Click += new System.EventHandler(this.Instrumentik);
            // 
            // FillRect
            // 
            this.FillRect.BackColor = System.Drawing.Color.White;
            this.FillRect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FillRect.Image = ((System.Drawing.Image)(resources.GetObject("FillRect.Image")));
            this.FillRect.Location = new System.Drawing.Point(81, 820);
            this.FillRect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FillRect.Name = "FillRect";
            this.FillRect.Size = new System.Drawing.Size(60, 62);
            this.FillRect.TabIndex = 22;
            this.FillRect.UseVisualStyleBackColor = false;
            this.FillRect.Click += new System.EventHandler(this.Instrumentik);
            // 
            // CurInstrum
            // 
            this.CurInstrum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurInstrum.Image = ((System.Drawing.Image)(resources.GetObject("CurInstrum.Image")));
            this.CurInstrum.Location = new System.Drawing.Point(82, 497);
            this.CurInstrum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurInstrum.Name = "CurInstrum";
            this.CurInstrum.Size = new System.Drawing.Size(59, 60);
            this.CurInstrum.TabIndex = 23;
            this.CurInstrum.TabStop = false;
            // 
            // CurColor
            // 
            this.CurColor.BackColor = System.Drawing.Color.Black;
            this.CurColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CurColor.Location = new System.Drawing.Point(12, 497);
            this.CurColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurColor.Name = "CurColor";
            this.CurColor.Size = new System.Drawing.Size(59, 60);
            this.CurColor.TabIndex = 24;
            this.CurColor.TabStop = false;
            // 
            // Razmershik
            // 
            this.Razmershik.Location = new System.Drawing.Point(12, 567);
            this.Razmershik.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Razmershik.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Razmershik.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Razmershik.Name = "Razmershik";
            this.Razmershik.Size = new System.Drawing.Size(129, 26);
            this.Razmershik.TabIndex = 25;
            this.Razmershik.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Razmershik.ValueChanged += new System.EventHandler(this.Razmer);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фалйToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 33);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // фалйToolStripMenuItem
            // 
            this.фалйToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem});
            this.фалйToolStripMenuItem.Name = "фалйToolStripMenuItem";
            this.фалйToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.фалйToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 882);
            this.Controls.Add(this.Razmershik);
            this.Controls.Add(this.CurColor);
            this.Controls.Add(this.CurInstrum);
            this.Controls.Add(this.FillRect);
            this.Controls.Add(this.Rect);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.FillEllipse);
            this.Controls.Add(this.Curve);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Oshirgish);
            this.Controls.Add(this.Pencil);
            this.Controls.Add(this.VyborCveta);
            this.Controls.Add(this.VybCvet3);
            this.Controls.Add(this.VybCvet1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.VybCvet4);
            this.Controls.Add(this.VybCvet2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ecran);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Risovalka 9000";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dvinul);
            ((System.ComponentModel.ISupportInitialize)(this.Ecran)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurInstrum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CurColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Razmershik)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ecran;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button VybCvet4;
        private System.Windows.Forms.Button VybCvet2;
        private System.Windows.Forms.Button VybCvet3;
        private System.Windows.Forms.Button VybCvet1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button VyborCveta;
        private System.Windows.Forms.ColorDialog Cvet;
        private System.Windows.Forms.Button Pencil;
        private System.Windows.Forms.Button Oshirgish;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Curve;
        private System.Windows.Forms.Button FillEllipse;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button Rect;
        private System.Windows.Forms.Button FillRect;
        private System.Windows.Forms.PictureBox CurInstrum;
        private System.Windows.Forms.PictureBox CurColor;
        private System.Windows.Forms.NumericUpDown Razmershik;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem фалйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
    }
}

