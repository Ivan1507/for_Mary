namespace laborat4
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Town = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Country = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KolMarok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOtkr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WebSait = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SrednStoim = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Region = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Индекс = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Настройка фильтра";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Filter_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 394);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(638, 394);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "Добавить автосалон";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Creator_click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Town,
            this.Street,
            this.Country,
            this.KolMarok,
            this.DateOtkr,
            this.WebSait,
            this.SrednStoim,
            this.Region,
            this.Индекс});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 43);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 351);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // Name
            // 
            this.Name.Text = "Название";
            this.Name.Width = 70;
            // 
            // Town
            // 
            this.Town.Text = "Город";
            this.Town.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Town.Width = 70;
            // 
            // Street
            // 
            this.Street.Text = "Улица";
            this.Street.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Street.Width = 70;
            // 
            // Country
            // 
            this.Country.Text = "Страна";
            this.Country.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Country.Width = 70;
            // 
            // KolMarok
            // 
            this.KolMarok.Text = "Колво_марок";
            this.KolMarok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KolMarok.Width = 90;
            // 
            // DateOtkr
            // 
            this.DateOtkr.Text = "Дата_открытия";
            this.DateOtkr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.DateOtkr.Width = 100;
            // 
            // WebSait
            // 
            this.WebSait.Text = "Веб_сайт";
            this.WebSait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WebSait.Width = 70;
            // 
            // SrednStoim
            // 
            this.SrednStoim.Text = "Средняя_стоимость";
            this.SrednStoim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SrednStoim.Width = 120;
            // 
            // Region
            // 
            this.Region.Text = "Регион";
            this.Region.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Индекс
            // 
            this.Индекс.Text = "Индекс";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Автосалоны";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.button4.Location = new System.Drawing.Point(438, 400);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 33);
            this.button4.TabIndex = 5;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 448);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            //this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Town;
        private System.Windows.Forms.ColumnHeader Street;
        private System.Windows.Forms.ColumnHeader Country;
        private System.Windows.Forms.ColumnHeader KolMarok;
        private System.Windows.Forms.ColumnHeader DateOtkr;
        private System.Windows.Forms.ColumnHeader WebSait;
        private System.Windows.Forms.ColumnHeader SrednStoim;
        private System.Windows.Forms.ColumnHeader Region;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader Индекс;
    }
}

