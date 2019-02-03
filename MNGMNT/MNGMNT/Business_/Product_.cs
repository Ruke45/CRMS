using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNGMNT.Business_
{
    public class Product_
    {

        /* Database Columns */

        public Int64 PortfolioID { set; get; }     
        public string ProductOwner { set; get; }
        public string NameofProduct { set; get; }
        public DateTime LaunchedDate { set; get; }
        public string AnalysisID { set; get; }
        public string ProductStatus { set; get; }
        public int ProductDuration { set; get; }
        public string CancledReason { set; get; }
        public string ProductLifeCycle { set; get; }
        public string Description { set; get; }

        /* Database Columns */

        public int addNew_Product()
        {
            try
            {
                /* Sql Query */
                string sql = "INSERT INTO tblProduct VALUES ('"+ ProductOwner + "','" 
                                                               + NameofProduct + "','" 
                                                               + DateTime.Now + "'," 
                                                               + AnalysisID + ",'" 
                                                               + ProductStatus + "'," 
                                                               + ProductDuration + ",'" 
                                                               + "N/A" + "','" 
                                                               + ProductLifeCycle + "','" 
                                                               + Description + "')";
                /* object of DBOperation Class*/
                DBOperations db = new DBOperations();

                /* Query Execution Result "It will return 1 if Success or 0 if faild"*/
                return db.Add_Update(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public int updateProduct()
        {
            try
            {
                string sql = "UPDATE tblProduct SET ProductStatus='" + ProductStatus + "' WHERE PortfolioID = " + PortfolioID;
                DBOperations db = new DBOperations();
                return db.Add_Update(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public int deleteProduct()
        {
            try
            {
                string sql = "DELETE FROM tblProduct WHERE PortfolioID = " + PortfolioID;
                DBOperations db = new DBOperations();
                return db.Add_Update(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
