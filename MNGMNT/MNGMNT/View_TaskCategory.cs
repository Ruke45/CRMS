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
    public partial class View_TaskCategory : Form
    {
        public View_TaskCategory()
        {
            InitializeComponent();
        }

        private void View_TaskCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet3.tblTaskCategory' table. You can move, or remove it, as needed.
            this.tblTaskCategoryTableAdapter.Fill(this.cRMSDataSet3.tblTaskCategory);

        }
    }
}
