using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InciAlbum.EntityLayer.Concrete
{
    public class Notice
    {
        public int noticeId { get; set; }
        public string tittle { get; set; }
        public string descreption { get; set; }
        public DateTime date { get; set; }
        public bool status { get; set; }
        
    }
}
