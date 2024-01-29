namespace task_manager
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            label1 = new Label();
            txtLaunch = new TextBox();
            btnLaunch = new Button();
            cnclBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 0;
            label1.Text = "Открыть:";
            label1.Click += label1_Click;
            // 
            // txtLaunch
            // 
            txtLaunch.Location = new Point(87, 20);
            txtLaunch.Name = "txtLaunch";
            txtLaunch.Size = new Size(296, 23);
            txtLaunch.TabIndex = 1;
            txtLaunch.TextChanged += textBox1_TextChanged;
            // 
            // btnLaunch
            // 
            btnLaunch.Location = new Point(212, 50);
            btnLaunch.Name = "btnLaunch";
            btnLaunch.Size = new Size(75, 23);
            btnLaunch.TabIndex = 2;
            btnLaunch.Text = "ОК";
            btnLaunch.UseVisualStyleBackColor = true;
            btnLaunch.Click += button1_Click;
            // 
            // cnclBtn
            // 
            cnclBtn.Location = new Point(308, 50);
            cnclBtn.Name = "cnclBtn";
            cnclBtn.Size = new Size(75, 23);
            cnclBtn.TabIndex = 3;
            cnclBtn.Text = "Отменить";
            cnclBtn.UseVisualStyleBackColor = true;
            cnclBtn.Click += cnclBtn_Click;
            // 
            // Form3
            // 
            AcceptButton = btnLaunch;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cnclBtn;
            ClientSize = new Size(406, 85);
            Controls.Add(cnclBtn);
            Controls.Add(btnLaunch);
            Controls.Add(txtLaunch);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Новая задача";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLaunch;
        private Button btnLaunch;
        private Button cnclBtn;
    }
}