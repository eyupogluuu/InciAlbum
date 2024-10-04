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
    public class ContactManager : IContactService
    {
        private readonly IContactDal contactDal;

        public ContactManager(IContactDal contactDal)
        {
            this.contactDal = contactDal;
        }

        public void Delete(Contact t)
        {
           contactDal.Delete(t);
        }

        public Contact GetById(int id)
        {
            return contactDal.GetById   (id);
        }

        public List<Contact> GetListAll()
        {
            return contactDal.GetListAll();
        }

        public void Insert(Contact t)
        {
            contactDal.Insert(t);
        }

        public void Update(Contact t)
        {
            contactDal.Update(t);
        }
    }
}
