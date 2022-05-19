using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using OL;
namespace BL
{
    public class ProductManager
    {
        public List<ObjProduct> GetProducts()
        {
            DL.Sql sql = new DL.Sql();

            string Script = "Select * from TblProducts";
            DataTable dt = sql.ExecuteDatatable(Script);
            List<ObjProduct> Categories = new List<ObjProduct>();

            foreach (DataRow dr in dt.Rows)
            {
                ObjProduct ctgr = new ObjProduct();
                //categoryId //categoryName // price

                ctgr.productName = (dr["productName"].ToString());
                ctgr.categoryId = Int32.Parse(dr["categoryId"].ToString());
                ctgr.price = float.Parse(dr["price"].ToString());

                Categories.Add(ctgr);

            }
            return Categories;
        }

        //public List<ObjProduct> GetList()
        //{

        //    DL.Sql sql = new DL.Sql();

        //    string Script = "select * from TblProducts U left join TblCategories K on (U.categoryId=K.categoryId)"; //İki tabloyu birleştirip bilgileri aldım.

        //    DataTable dt = sql.ExecuteDatatable(Script);
        //    List<ObjProduct> List = new List<ObjProduct>();

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        ObjProduct ctgr = new ObjProduct();
        //        //categoryId //categoryName //price //productName

        //        ctgr.categoryId = Int32.Parse(dr["categoryId"].ToString());
        //        ctgr.productName = (dr["productName"].ToString());
        //        ctgr.price = float.Parse(dr["price"].ToString()); 
        //        List.Add(ctgr);
        //    }

        //    return List;
        //}

    }
}
