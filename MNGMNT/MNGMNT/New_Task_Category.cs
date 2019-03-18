using MNGMNT.Business_;
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
    public partial class New_Task_Category : Form
    {
        public New_Task_Category()
        {
            InitializeComponent();
        }

        private void btnSaveNewProduct_Click(object sender, EventArgs e)
        {
            if (txtTCN.Text == "")
            {
                MessageBox.Show("Insert Task Category Name");
                return;
            }
            if (txtDes.Text == "")
            {
                MessageBox.Show("Insert Task Category Description");
                return;
            }

            TaskCategory_ NP = new TaskCategory_();

            NP.Name = txtTCN.Text;
            NP.Description = txtDes.Text;

            int result = NP.addNew_TCategory();

            if (result != 0) { MessageBox.Show("Success"); }
            else { MessageBox.Show("Error"); }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
