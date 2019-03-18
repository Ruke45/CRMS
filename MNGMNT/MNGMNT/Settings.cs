using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNGMNT
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            New_Task_Category N = new New_Task_Category();
            N.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_TaskCategory N = new View_TaskCategory();
            N.Show();
        }
    }
}
