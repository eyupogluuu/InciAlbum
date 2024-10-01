using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InciAlbum.EntityLayer.Concrete
{
    public class Product
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public string descreption { get; set; }
        public string imageUrl { get; set; }
        public decimal price { get; set; }
    }
}
