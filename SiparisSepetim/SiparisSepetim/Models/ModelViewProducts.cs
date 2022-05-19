using OL;
using System.Collections.Generic;

namespace SiparisSepetim.Models
{
    public class ModelViewProducts
    {
        public List<ObjProduct> Product { get; set; } = new List<ObjProduct>();

        public List<ObjCategory> Categories { get; set; } = new List<ObjCategory>();
    }
}
