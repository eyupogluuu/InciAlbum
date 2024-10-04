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
    public class ImageManager : IImageService
    {
        private readonly IImageDal imageDal;

        public ImageManager(IImageDal imageDal)
        {
            this.imageDal = imageDal;
        }

        public void Delete(Image t)
        {
            imageDal.Delete(t);
        }

        public Image GetById(int id)
        {
            return imageDal.GetById(id);
        }

        public List<Image> GetListAll()
        {
            return imageDal.GetListAll();
        }

        public void Insert(Image t)
        {
            imageDal.Insert(t);
        }

        public void Update(Image t)
        {
            imageDal.Update(t);
        }
    }
}
