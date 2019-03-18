using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MNGMNT.Business_
{
    public class TaskCategory_
    {
        public int TaskCategoryId { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }

        /* Database Columns */

        public int addNew_TCategory()
        {
            try
            {
                string sql = "INSERT INTO tblTaskCategory VALUES ('" + Name + "','" + Description + "')";
                DBOperations db = new DBOperations();
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
                string sql = "UPDATE tblTaskCategory SET Name='" + Name + "' WHERE TaskCategoryId = " + TaskCategoryId;
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
                string sql = "DELETE FROM tblTaskCategory WHERE TaskCategoryId = " + TaskCategoryId;
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
