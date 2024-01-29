using System.Diagnostics;

namespace task_manager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Process[] processes;

        void GetAllProcesses()
        {
            processes = Process.GetProcesses();

            listView1.Items.Clear();
            foreach (Process proc in processes.OrderBy(alph => alph.ProcessName))
            {
                listView1.Items.Add(proc.ProcessName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllProcesses();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void новаяЗадачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Обновить_Click(object sender, EventArgs e)
        {
            GetAllProcesses();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings form = new Settings();
            form.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Process process in processes)
            {
                try
                {
                    // Загружаем иконку процесса
                    Icon icon = Icon.ExtractAssociatedIcon(process.MainModule.FileName);

                    // Создаем новый PictureBox для отображения иконки
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = icon.ToBitmap();
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    // Устанавливаем положение PictureBox на форме
                    pictureBox.Left = 10;
                    pictureBox.Top = this.Controls.Count * 50;

                    // Добавляем PictureBox на форму
                    this.Controls.Add(pictureBox);
                }
                catch { };
                listView1.Items.Add(process.ProcessName);
            }
        }
    }
}
