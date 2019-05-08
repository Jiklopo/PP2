namespace SuperBaza
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
            this.TelikIzAeroporta = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Klikuha = new System.Windows.Forms.TextBox();
            this.TrueName = new System.Windows.Forms.TextBox();
            this.Baba = new System.Windows.Forms.TextBox();
            this.Tachila = new System.Windows.Forms.TextBox();
            this.Puha = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Ataman = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.TelikIzAeroporta)).BeginInit();
            this.SuspendLayout();
            // 
            // TelikIzAeroporta
            // 
            this.TelikIzAeroporta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TelikIzAeroporta.Location = new System.Drawing.Point(118, 8);
            this.TelikIzAeroporta.Margin = new System.Windows.Forms.Padding(2);
            this.TelikIzAeroporta.Name = "TelikIzAeroporta";
            this.TelikIzAeroporta.RowTemplate.Height = 28;
            this.TelikIzAeroporta.Size = new System.Drawing.Size(743, 381);
            this.TelikIzAeroporta.TabIndex = 0;
            this.TelikIzAeroporta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TelikIzAeroporta_CellContentClick);
            this.TelikIzAeroporta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.TelikIzAeroporta_CellEndEdit);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(11, 32);
            this.Add.Margin = new System.Windows.Forms.Padding(2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(103, 20);
            this.Add.TabIndex = 1;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(11, 56);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(103, 20);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "Удалить";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Klikuha
            // 
            this.Klikuha.Location = new System.Drawing.Point(11, 249);
            this.Klikuha.Margin = new System.Windows.Forms.Padding(2);
            this.Klikuha.Name = "Klikuha";
            this.Klikuha.Size = new System.Drawing.Size(103, 20);
            this.Klikuha.TabIndex = 3;
            this.Klikuha.Text = "Klikuha";
            // 
            // TrueName
            // 
            this.TrueName.Location = new System.Drawing.Point(11, 273);
            this.TrueName.Margin = new System.Windows.Forms.Padding(2);
            this.TrueName.Name = "TrueName";
            this.TrueName.Size = new System.Drawing.Size(103, 20);
            this.TrueName.TabIndex = 4;
            this.TrueName.Text = "TrueName";
            // 
            // Baba
            // 
            this.Baba.Location = new System.Drawing.Point(11, 321);
            this.Baba.Margin = new System.Windows.Forms.Padding(2);
            this.Baba.Name = "Baba";
            this.Baba.Size = new System.Drawing.Size(103, 20);
            this.Baba.TabIndex = 6;
            this.Baba.Text = "Baba";
            // 
            // Tachila
            // 
            this.Tachila.Location = new System.Drawing.Point(11, 345);
            this.Tachila.Margin = new System.Windows.Forms.Padding(2);
            this.Tachila.Name = "Tachila";
            this.Tachila.Size = new System.Drawing.Size(103, 20);
            this.Tachila.TabIndex = 7;
            this.Tachila.Text = "Tachila";
            // 
            // Puha
            // 
            this.Puha.Location = new System.Drawing.Point(11, 369);
            this.Puha.Margin = new System.Windows.Forms.Padding(2);
            this.Puha.Name = "Puha";
            this.Puha.Size = new System.Drawing.Size(103, 20);
            this.Puha.TabIndex = 8;
            this.Puha.Text = "Puha";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(11, 104);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 20);
            this.button3.TabIndex = 10;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Change
            // 
            this.Change.Location = new System.Drawing.Point(11, 80);
            this.Change.Margin = new System.Windows.Forms.Padding(2);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(103, 20);
            this.Change.TabIndex = 9;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(11, 8);
            this.Refresh.Margin = new System.Windows.Forms.Padding(2);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(103, 20);
            this.Refresh.TabIndex = 12;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 128);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(103, 20);
            this.button6.TabIndex = 11;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Ataman
            // 
            this.Ataman.AutoSize = true;
            this.Ataman.Location = new System.Drawing.Point(11, 299);
            this.Ataman.Name = "Ataman";
            this.Ataman.Size = new System.Drawing.Size(62, 17);
            this.Ataman.TabIndex = 13;
            this.Ataman.Text = "Ataman";
            this.Ataman.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 398);
            this.Controls.Add(this.Ataman);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Puha);
            this.Controls.Add(this.Tachila);
            this.Controls.Add(this.Baba);
            this.Controls.Add(this.TrueName);
            this.Controls.Add(this.Klikuha);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.TelikIzAeroporta);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TelikIzAeroporta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TelikIzAeroporta;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox Klikuha;
        private System.Windows.Forms.TextBox TrueName;
        private System.Windows.Forms.TextBox Baba;
        private System.Windows.Forms.TextBox Tachila;
        private System.Windows.Forms.TextBox Puha;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox Ataman;
    }
}

