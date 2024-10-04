using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.DataAccessLayer.Abstract;
using InciAlbum.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InciAlbum.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal productDal;

        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }

        public void Delete(Product t)
        {
            productDal.Delete(t);
        }

        public Product GetById(int id)
        {
           return productDal.GetById(id);
        }

        public List<Product> GetListAll()
        {
            return productDal.GetListAll();
        }

        public void Insert(Product t)
        {
             productDal.Insert(t);
        }

        public void Update(Product t)
        {
            productDal.Update(t);
        }
    }
}
