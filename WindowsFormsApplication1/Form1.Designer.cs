namespace WindowsFormsApplication1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьНастройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.задатьПапкуДляСохраненияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сделатьСнимокЭкранаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьТаймерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалённыйПомошникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скачатьTeamViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производительностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьДиспетчерЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запуститьМониторРесурсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.журналыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьЖурналыСобытийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поддержкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.помощьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.interval = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.остановитьТаймерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.настройкиToolStripMenuItem,
            this.просмотрToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.удалённыйПомошникToolStripMenuItem,
            this.производительностьToolStripMenuItem,
            this.журналыToolStripMenuItem,
            this.поддержкаToolStripMenuItem,
            this.помощьToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьНастройкиToolStripMenuItem,
            this.загрузитьНастройкиToolStripMenuItem,
            this.toolStripMenuItem1,
            this.tsmiExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            this.файлToolStripMenuItem.Click += new System.EventHandler(this.файлToolStripMenuItem_Click);
            // 
            // сохранитьНастройкиToolStripMenuItem
            // 
            this.сохранитьНастройкиToolStripMenuItem.Name = "сохранитьНастройкиToolStripMenuItem";
            this.сохранитьНастройкиToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.сохранитьНастройкиToolStripMenuItem.Text = "Сохранить настройки";
            this.сохранитьНастройкиToolStripMenuItem.Click += new System.EventHandler(this.сохранитьНастройкиToolStripMenuItem_Click);
            // 
            // загрузитьНастройкиToolStripMenuItem
            // 
            this.загрузитьНастройкиToolStripMenuItem.Name = "загрузитьНастройкиToolStripMenuItem";
            this.загрузитьНастройкиToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.загрузитьНастройкиToolStripMenuItem.Text = "Загрузить настройки";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(193, 22);
            this.tsmiExit.Text = "Выход";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.задатьПапкуДляСохраненияToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // задатьПапкуДляСохраненияToolStripMenuItem
            // 
            this.задатьПапкуДляСохраненияToolStripMenuItem.Name = "задатьПапкуДляСохраненияToolStripMenuItem";
            this.задатьПапкуДляСохраненияToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.задатьПапкуДляСохраненияToolStripMenuItem.Text = "Задать папку для сохранения";
            this.задатьПапкуДляСохраненияToolStripMenuItem.Click += new System.EventHandler(this.задатьПапкуДляСохраненияToolStripMenuItem_Click);
            // 
            // просмотрToolStripMenuItem
            // 
            this.просмотрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьПапкуToolStripMenuItem});
            this.просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            this.просмотрToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // открытьПапкуToolStripMenuItem
            // 
            this.открытьПапкуToolStripMenuItem.Name = "открытьПапкуToolStripMenuItem";
            this.открытьПапкуToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.открытьПапкуToolStripMenuItem.Text = "Открыть папку";
            this.открытьПапкуToolStripMenuItem.Click += new System.EventHandler(this.открытьПапкуToolStripMenuItem_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сделатьСнимокЭкранаToolStripMenuItem,
            this.запуститьТаймерToolStripMenuItem,
            this.остановитьТаймерToolStripMenuItem});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // сделатьСнимокЭкранаToolStripMenuItem
            // 
            this.сделатьСнимокЭкранаToolStripMenuItem.Name = "сделатьСнимокЭкранаToolStripMenuItem";
            this.сделатьСнимокЭкранаToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.сделатьСнимокЭкранаToolStripMenuItem.Text = "Сделать снимок экрана";
            this.сделатьСнимокЭкранаToolStripMenuItem.Click += new System.EventHandler(this.сделатьСнимокЭкранаToolStripMenuItem_Click);
            // 
            // запуститьТаймерToolStripMenuItem
            // 
            this.запуститьТаймерToolStripMenuItem.Name = "запуститьТаймерToolStripMenuItem";
            this.запуститьТаймерToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.запуститьТаймерToolStripMenuItem.Text = "Запустить таймер";
            this.запуститьТаймерToolStripMenuItem.Click += new System.EventHandler(this.запуститьТаймерToolStripMenuItem_Click);
            // 
            // удалённыйПомошникToolStripMenuItem
            // 
            this.удалённыйПомошникToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скачатьTeamViewerToolStripMenuItem});
            this.удалённыйПомошникToolStripMenuItem.Name = "удалённыйПомошникToolStripMenuItem";
            this.удалённыйПомошникToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.удалённыйПомошникToolStripMenuItem.Text = "Удалённый помошник";
            // 
            // скачатьTeamViewerToolStripMenuItem
            // 
            this.скачатьTeamViewerToolStripMenuItem.Name = "скачатьTeamViewerToolStripMenuItem";
            this.скачатьTeamViewerToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.скачатьTeamViewerToolStripMenuItem.Text = "Скачать TeamViewer";
            this.скачатьTeamViewerToolStripMenuItem.Click += new System.EventHandler(this.скачатьTeamViewerToolStripMenuItem_Click);
            // 
            // производительностьToolStripMenuItem
            // 
            this.производительностьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьДиспетчерЗадачToolStripMenuItem,
            this.запуститьМониторРесурсовToolStripMenuItem});
            this.производительностьToolStripMenuItem.Name = "производительностьToolStripMenuItem";
            this.производительностьToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.производительностьToolStripMenuItem.Text = "Производительность";
            // 
            // запуститьДиспетчерЗадачToolStripMenuItem
            // 
            this.запуститьДиспетчерЗадачToolStripMenuItem.Name = "запуститьДиспетчерЗадачToolStripMenuItem";
            this.запуститьДиспетчерЗадачToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.запуститьДиспетчерЗадачToolStripMenuItem.Text = "Запустить диспетчер задач";
            this.запуститьДиспетчерЗадачToolStripMenuItem.Click += new System.EventHandler(this.запуститьДиспетчерЗадачToolStripMenuItem_Click);
            // 
            // запуститьМониторРесурсовToolStripMenuItem
            // 
            this.запуститьМониторРесурсовToolStripMenuItem.Name = "запуститьМониторРесурсовToolStripMenuItem";
            this.запуститьМониторРесурсовToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.запуститьМониторРесурсовToolStripMenuItem.Text = "Запустить монитор ресурсов";
            this.запуститьМониторРесурсовToolStripMenuItem.Click += new System.EventHandler(this.запуститьМониторРесурсовToolStripMenuItem_Click);
            // 
            // журналыToolStripMenuItem
            // 
            this.журналыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьЖурналыСобытийToolStripMenuItem});
            this.журналыToolStripMenuItem.Name = "журналыToolStripMenuItem";
            this.журналыToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.журналыToolStripMenuItem.Text = "Журналы";
            // 
            // открытьЖурналыСобытийToolStripMenuItem
            // 
            this.открытьЖурналыСобытийToolStripMenuItem.Name = "открытьЖурналыСобытийToolStripMenuItem";
            this.открытьЖурналыСобытийToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.открытьЖурналыСобытийToolStripMenuItem.Text = "Открыть журналы событий";
            this.открытьЖурналыСобытийToolStripMenuItem.Click += new System.EventHandler(this.открытьЖурналыСобытийToolStripMenuItem_Click);
            // 
            // поддержкаToolStripMenuItem
            // 
            this.поддержкаToolStripMenuItem.Name = "поддержкаToolStripMenuItem";
            this.поддержкаToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.поддержкаToolStripMenuItem.Text = "Поддержка";
            this.поддержкаToolStripMenuItem.Click += new System.EventHandler(this.поддержкаToolStripMenuItem_Click);
            // 
            // помощьToolStripMenuItem
            // 
            this.помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            this.помощьToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.помощьToolStripMenuItem.Text = "Помощь";
            this.помощьToolStripMenuItem.Click += new System.EventHandler(this.помощьToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Yellow;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(710, 73);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(172, 357);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Программный комплекс \r\nSuperLook, предназначен \r\nдля учёта рабочего времени, \r\nпр" +
    "оведённого сотрудником \r\nза компьютером.\r\n";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // interval
            // 
            this.interval.AccessibleDescription = "";
            this.interval.AccessibleName = "";
            this.interval.BackColor = System.Drawing.SystemColors.Info;
            this.interval.Location = new System.Drawing.Point(819, 436);
            this.interval.Maximum = new decimal(new int[] {
            1440,
            0,
            0,
            0});
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(54, 20);
            this.interval.TabIndex = 4;
            this.interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.interval.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(707, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Интервал(мин):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 407);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.monitor__1_;
            this.pictureBox2.Location = new System.Drawing.Point(299, 73);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(384, 384);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // остановитьТаймерToolStripMenuItem
            // 
            this.остановитьТаймерToolStripMenuItem.Name = "остановитьТаймерToolStripMenuItem";
            this.остановитьТаймерToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.остановитьТаймерToolStripMenuItem.Text = "Остановить таймер";
            this.остановитьТаймерToolStripMenuItem.Click += new System.EventHandler(this.остановитьТаймерToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(936, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SuperLook";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem помощьToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem задатьПапкуДляСохраненияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалённыйПомошникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьНастройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьНастройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скачатьTeamViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьПапкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem производительностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьДиспетчерЗадачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьМониторРесурсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сделатьСнимокЭкранаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.NumericUpDown interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripMenuItem журналыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поддержкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьЖурналыСобытийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запуститьТаймерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem остановитьТаймерToolStripMenuItem;
    }
}

