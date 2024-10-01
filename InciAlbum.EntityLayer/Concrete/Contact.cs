using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InciAlbum.EntityLayer.Concrete
{
    public class Contact
    {
        public int contactId { get; set; }
        public string name { get; set; }
        public string mail { get; set; }
        public string comment { get; set; }
        public DateTime date { get; set; }
    }
}
