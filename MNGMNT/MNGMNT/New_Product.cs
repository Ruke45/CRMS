using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MNGMNT.Business_; /* Import the  Business_ to Access the Class Object */

namespace MNGMNT
{
    public partial class New_Product : Form
    {
        public New_Product()
        {
            InitializeComponent();
        }

        private void New_Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cRMSDataSet1.tblProductStatus' table. You can move, or remove it, as needed.
            this.tblProductStatusTableAdapter.Fill(this.cRMSDataSet1.tblProductStatus);
            // TODO: This line of code loads data into the 'cRMSDataSet.tblEmployee' table. You can move, or remove it, as needed.
            this.tblEmployeeTableAdapter.Fill(this.cRMSDataSet.tblEmployee);

        }

        private void btnSaveNewProduct_Click(object sender, EventArgs e)
        {
            Product_ NP = new Product_(); /* New Product Class Object */

            /* Add Textbox values to the NP(Product object value holders ) */
            NP.ProductOwner = txtPO.Text;
            NP.NameofProduct = txtPN.Text;
            NP.AnalysisID = cbAID.SelectedValue.ToString();
            NP.ProductStatus = cbPS.SelectedValue.ToString();
            NP.ProductDuration = Convert.ToInt32(txtPDUra.Text);
            NP.ProductLifeCycle = txtPM.Text;
            NP.Description = txtPD.Text;

            int result = NP.addNew_Product(); /* Call the Proudct Add Class form NP Object*/

            if (result != 0) { MessageBox.Show("Success"); }
            else { MessageBox.Show("Error"); }
            /* if the product add was success show message box success */


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
