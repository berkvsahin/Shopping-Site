using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OL;
using System.Data.SqlClient;

namespace BL
{
    public class CategoryManager
    {
        public List<ObjCategory> GetCategories()
        {

            DL.Sql sql =new DL.Sql();

            string Script = "Select * from TblCategories";

            DataTable dt = sql.ExecuteDatatable(Script);
            List<ObjCategory> Categories = new List<ObjCategory>();

            foreach (DataRow dr in dt.Rows)
            {
                ObjCategory ctgr =new ObjCategory();
                //CategoryId //categoryName

                ctgr.categoryId = Int32.Parse(dr["categoryId"].ToString());
                ctgr.categoryName = (dr["categoryName"].ToString());
                Categories.Add(ctgr);
            }

            return Categories;
        }


    }
}
