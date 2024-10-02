using InciAlbum.DataAccessLayer.Abstract;
using InciAlbum.DataAccessLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InciAlbum.DataAccessLayer.Concrete.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, new()
    {
        public void Delete(T t)
        {
            using var context = new InciAlbumContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            using var context = new InciAlbumContext();
            return context.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var context = new InciAlbumContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new InciAlbumContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new InciAlbumContext();
            context.Update(t);
            context.SaveChanges();
        }
    }
}
