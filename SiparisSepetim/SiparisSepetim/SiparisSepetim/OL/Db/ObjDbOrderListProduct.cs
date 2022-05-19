using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.Db
{
    public class ObjDbOrderListProduct
    {
        public int OrderListProductId { get; set; }

        public int productId { get; set; }

        public int OrderListId { get; set; }

        public int credate { get; set; }

        public bool Activeflg { get; set; }
    }
}
