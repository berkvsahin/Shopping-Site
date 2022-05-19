using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OL
{
    public class ObjUser:Db.ObjDbUser
    {
        public string AdSoyad { get { return this.name + " " + this.surname; } }

    }
}
