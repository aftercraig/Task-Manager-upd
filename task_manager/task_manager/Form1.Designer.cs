namespace task_manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnEndTask = new Button();
            файлToolStripMenuItem = new ToolStripMenuItem();
            новаяЗадачаToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            Обновить = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEndTask
            // 
            btnEndTask.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEndTask.Cursor = Cursors.Hand;
            btnEndTask.Location = new Point(406, 475);
            btnEndTask.Name = "btnEndTask";
            btnEndTask.Size = new Size(105, 23);
            btnEndTask.TabIndex = 1;
            btnEndTask.Text = "Снять задачу";
            btnEndTask.UseVisualStyleBackColor = true;
            btnEndTask.Click += button2_Click;
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { новаяЗадачаToolStripMenuItem, настройкиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            файлToolStripMenuItem.Click += файлToolStripMenuItem_Click;
            // 
            // новаяЗадачаToolStripMenuItem
            // 
            новаяЗадачаToolStripMenuItem.Name = "новаяЗадачаToolStripMenuItem";
            новаяЗадачаToolStripMenuItem.Size = new Size(147, 22);
            новаяЗадачаToolStripMenuItem.Text = "Новая задача";
            новаяЗадачаToolStripMenuItem.Click += новаяЗадачаToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(147, 22);
            настройкиToolStripMenuItem.Text = "Настройки";
            настройкиToolStripMenuItem.Click += настройкиToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(526, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // Обновить
            // 
            Обновить.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Обновить.Location = new Point(12, 475);
            Обновить.Name = "Обновить";
            Обновить.Size = new Size(105, 23);
            Обновить.TabIndex = 4;
            Обновить.Text = "Обновить";
            Обновить.UseVisualStyleBackColor = true;
            Обновить.Click += Обновить_Click;
            // 
            // listView1
            // 
            listView1.Alignment = ListViewAlignment.Left;
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            listView1.GridLines = true;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.Location = new Point(0, 27);
            listView1.Name = "listView1";
            listView1.Size = new Size(307, 252);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 512);
            Controls.Add(Обновить);
            Controls.Add(btnEndTask);
            Controls.Add(menuStrip1);
            Controls.Add(listView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Task manager";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEndTask;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem новаяЗадачаToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button Обновить;
        private ListView listView1;
        private ColumnHeader columnHeader1;
    }
}
