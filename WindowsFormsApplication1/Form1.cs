using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {   //создадим таймер, который будет делать скриншот
        
        private Timer t = new Timer();

        //Конструктор формы
        public Form1()
        {
            InitializeComponent();
            //создадим событие срабатывания таймера
            t.Tick += new EventHandler(t_Tick);
        }

        private void t_Tick(object sender, EventArgs e)
        {
            //Делаем скриншот
            do_screenshot();
        }

        //Переопределим выход из программы 
        //Занесем значения элементв с формы в объект Properties.Settings и сохраним настройки
        protected override void OnClosing(CancelEventArgs e)
        {
            Properties.Settings.Default.Title = folderBrowserDialog1.SelectedPath;
            Properties.Settings.Default.AutoExist = (int)this.interval.Value;
            Properties.Settings.Default.Save();
        }

        //функция которая будет вызывать при загрузке приложения
            private void LoadSettings()
        {
            this.interval.Value = (decimal)Properties.Settings.Default.AutoExist;
            
            if (this.interval.Value > 0)
            {
                //если значение autoexit > 0 то запускаем таймер
                t.Interval = (int)this.interval.Value * 1000 *60;
                t.Enabled = true;
            }

            folderBrowserDialog1.SelectedPath = Properties.Settings.Default.Title;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //вызываем функцию считывания настроек, после загрузки программы
            this.LoadSettings();
        }
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Программа SuperLook. Версия 1.2.4\nВсе права принадлежат компании Vertical LLC.\nCopyright 2015","О программе");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void запуститьДиспетчерЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //создаем новый процесс
            Process proc = new Process();
            //Запускаем Диспетчер задач
            proc.StartInfo.FileName = @"taskmgr.exe";
            proc.StartInfo.Arguments = "";
            proc.Start();
        }

        private void запуститьМониторРесурсовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //создаем новый процесс
            Process proc = new Process();
            //Запускаем Монитор ресурсов
            proc.StartInfo.FileName = @"perfmon.exe";
            proc.StartInfo.Arguments = "/res";
            proc.Start();
        }

        private void скачатьTeamViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //создаем новый процесс
            Process proc = new Process();
            //Запускаем Internet Explorer
            proc.StartInfo.FileName = @"iexplore.exe";
            proc.StartInfo.Arguments = "https://www.teamviewer.com/ru/index.aspx";
            proc.Start();
        }

        private void задатьЧастотуСканированияToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void открытьПапкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@Properties.Settings.Default.Title);
        }

        private void задатьПапкуДляСохраненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void открытьЖурналыСобытийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //создаем новый процесс
            Process proc = new Process();
            //Запускаем Журнал событий
            proc.StartInfo.FileName = @"eventvwr.msc";
            proc.Start();
            
        }

        private void сделатьСнимокЭкранаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            do_screenshot();
        }
        private void do_screenshot()
        {
            //создаём скриншот
            Bitmap bmpScreenshot;
            Graphics gfxScreenshot;
            bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0,
                Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            //сохраняем скриншот в файл
            //bmpScreenshot.Save(Properties.Settings.Default.Title + String.Format("{0:dd-MM-yyyy HH-mm-ss}", DateTime.Now) + ".jpeg", ImageFormat.Jpeg);
            string fullpath = String.Format("{0:dd-MM-yyyy HH-mm-ss}", DateTime.Now) + ".jpeg";
        //меняем каталог на сохранённый в настройках
        Environment.CurrentDirectory = (Properties.Settings.Default.Title);
            //сохраняем
            bmpScreenshot.Save(fullpath, ImageFormat.Jpeg);
        }

        private void сохранитьНастройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Title = folderBrowserDialog1.SelectedPath;
            Properties.Settings.Default.AutoExist = (int)this.interval.Value;
            Properties.Settings.Default.Save();
        }

        private void запуститьТаймерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void помощьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Описание основных функций программы SuperLook.\nПри первом запуске программы необходимо её настроить:\n1.Для начала работы с программой необходимо выбрать папку для сохранения файлов: 'Настройки' - 'Задать папку для сохранения'.\n2.Установить нужный интервал в минутах, задаётся в правом нижнем углу основного окна программы.\n3.После этого нужно сохранить настройки: 'Файл' - 'Сохранить настройки'.\n4.Запускаем таймер через: 'Действия' - 'Запустить таймер', при необходимости его можно остановить: 'Действия' - 'Остановить таймер'.\nпри последующих запусках программы настройки будут загружаться автоматически.\n5.Для автоматического запуска программы нужно добавить ее ярлык в автозагрузку.", "Помощь");
        }

        private void поддержкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для отправки запроса в техподдержку напишите письмо по адресу: support@superlook.com ", "Поддержка");
        }

        private void остановитьТаймерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t.Enabled = false;
        }
    }

}
