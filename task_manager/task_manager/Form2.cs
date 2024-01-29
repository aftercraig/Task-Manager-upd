using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_manager
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void acceptbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Изменения применены");
            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
                MessageBox.Show("Изменения отменены");
                this.Close();
        }
    }
}
