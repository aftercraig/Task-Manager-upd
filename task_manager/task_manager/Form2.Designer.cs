namespace task_manager
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            acceptbtn = new Button();
            cancelbtn = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // acceptbtn
            // 
            acceptbtn.Location = new Point(12, 272);
            acceptbtn.Name = "acceptbtn";
            acceptbtn.Size = new Size(75, 23);
            acceptbtn.TabIndex = 0;
            acceptbtn.Text = "Применть";
            acceptbtn.UseVisualStyleBackColor = true;
            acceptbtn.Click += acceptbtn_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.Location = new Point(111, 272);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(75, 23);
            cancelbtn.TabIndex = 1;
            cancelbtn.Text = "Отмена";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(57, 84);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(73, 19);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "я крутой";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            AcceptButton = acceptbtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelbtn;
            ClientSize = new Size(198, 307);
            Controls.Add(checkBox1);
            Controls.Add(cancelbtn);
            Controls.Add(acceptbtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button acceptbtn;
        private Button cancelbtn;
        private CheckBox checkBox1;
    }
}