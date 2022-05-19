using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL.Db
{
    public class ObjDbUser
    {
        public int UserId { get; set; }

        public string name { get; set; }

        public string surname { get; set; }

        public string eMail { get; set; }

        public string pass { get; set; }

        public bool ActiveFlg { get; set; }


    }
}
