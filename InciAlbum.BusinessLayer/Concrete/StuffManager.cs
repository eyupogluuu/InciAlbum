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
    public class StuffManager:IStuffService
    {
        private readonly IStuffDal stuffDal;

        public StuffManager(IStuffDal stuffDal)
        {
            this.stuffDal = stuffDal;
        }

        public void Delete(Stuff t)
        {
            stuffDal.Delete(t);
        }

        public Stuff GetById(int id)
        {
           return stuffDal.GetById(id);
        }

        public List<Stuff> GetListAll()
        {
            return stuffDal.GetListAll();
        }

        public void Insert(Stuff t)
        {
            stuffDal.Insert(t);
        }

        public void Update(Stuff t)
        {
            stuffDal.Update(t);
        }
    }
}
