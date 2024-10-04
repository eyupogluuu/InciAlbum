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
    public class myAdressManager : ImyAdressService
    {
        private readonly ImyAdressDal myAdressDal;

        public myAdressManager(ImyAdressDal myAdressDal)
        {
            this.myAdressDal = myAdressDal;
        }

        public void Delete(myAdress t)
        {
            myAdressDal.Delete(t);
        }

        public myAdress GetById(int id)
        {
            return myAdressDal.GetById(id);
        }

        public List<myAdress> GetListAll()
        {
            return myAdressDal.GetListAll();
        }

        public void Insert(myAdress t)
        {
            myAdressDal.Insert(t);
        }

        public void Update(myAdress t)
        {
            myAdressDal.Update(t);
        }
    }
}
