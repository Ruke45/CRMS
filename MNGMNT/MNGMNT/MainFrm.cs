using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNGMNT
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            MainPanel.Controls.Add(new Dashboard());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in MainPanel.Controls)
            {
                ctrl.Dispose();
            }
            MainPanel.Controls.Add(new Dashboard());
        }

        private void btnDProduct_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in MainPanel.Controls)
            {
                ctrl.Dispose();
            }
            MainPanel.Controls.Add(new Products());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure To Exit Programe ?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in MainPanel.Controls)
            {
                ctrl.Dispose();
            }
            MainPanel.Controls.Add(new Employee());
        }

        private void btnAttendence_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in MainPanel.Controls)
            {
                ctrl.Dispose();
            }
            MainPanel.Controls.Add(new Attendence());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in MainPanel.Controls)
            {
                ctrl.Dispose();
            }
            MainPanel.Controls.Add(new Settings());
        }
    }
}
