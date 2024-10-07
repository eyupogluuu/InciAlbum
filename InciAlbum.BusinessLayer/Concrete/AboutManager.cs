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
	public class AboutManager : IAboutService
	{
		private readonly IAboutDal aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			this.aboutDal = aboutDal;
		}

		public void Delete(About t)
		{
			aboutDal.Delete(t);
		}

		public About GetById(int id)
		{
			return aboutDal.GetById(id);
		}

		public List<About> GetListAll()
		{
			return aboutDal.GetListAll();
		}

		public void Insert(About t)
		{
			aboutDal.Insert(t);
		}

		public void Update(About t)
		{
			aboutDal.Update(t);
		}
	}
}
