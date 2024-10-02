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
    public class myServiceManager:ImyServiceService
    {
        private readonly ImyServiceDal ımyServiceDal;

        public myServiceManager(ImyServiceDal ımyServiceDal)
        {
            this.ımyServiceDal = ımyServiceDal;
        }

        public void Delete(myService t)
        {
            ımyServiceDal.Delete(t);
        }

        public myService GetById(int id)
        {
            return ımyServiceDal.GetById(id);
        }

        public List<myService> GetListAll()
        {
            return ımyServiceDal.GetListAll();
        }

        public void Insert(myService t)
        {
            ımyServiceDal.Insert(t);
        }

        public void Update(myService t)
        {
            ımyServiceDal.Update(t);
        }
    }
}
