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
    public partial class Products : UserControl
    {
        public Products()
        {
            InitializeComponent();
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            New_Product N = new New_Product(); /*Call the New_Product Window*/
            N.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View_Product V = new View_Product();
            V.Show();
        }
    }
}
