using OL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class OrderListManager
    {
        public ObjOrderList SetOrderList(ObjOrderList User)   
        {
            
            DL.Sql sql = new DL.Sql();
            string Script = "INSERT INTO TblOrderLists(OrderListname,UserId) VALUES (@OrderListname,@UserId)";

            sql.addparameter("@OrderListname", User.OrderListname); //Fonksiyona gönderip tabloya yazılıyor
            sql.addparameter("@UserId", User.UserId);

            sql.Execute(Script);
            return User;
        }
    }
}
