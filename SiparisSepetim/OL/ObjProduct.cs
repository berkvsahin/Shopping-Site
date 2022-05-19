using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL
{
    public class ObjProduct : Db.ObjDbProduct
    {
        private ObjCategory _category { get; set; } = new ObjCategory();
 
        public ObjCategory category // Sadece okumak için
        { //singleton Design Pattern
            get
            {
            

                if (_category.categoryId == 0)
                {
                    DataTable dt = new DL.Sql().ExecuteDatatable("select * from TblCategories where CategoryId=" + this.categoryId);

                    if (dt.Rows.Count > 0)
                    {
                        _category.categoryId = Convert.ToInt32(dt.Rows[0]["categoryId"]);
                        _category.categoryName = dt.Rows[0]["categoryName"].ToString();
                    }
                } 
                return _category;
            }
        }

    }
}
