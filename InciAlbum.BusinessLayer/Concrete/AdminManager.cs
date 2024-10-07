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
	public class AdminManager : IAdminService
	{
		private readonly IAdminDal adminDal;

		public AdminManager(IAdminDal adminDal)
		{
			this.adminDal = adminDal;
		}

		public void Delete(Admin t)
		{
			adminDal.Delete(t);
		}

		public Admin GetById(int id)
		{
			return adminDal.GetById(id);
		}

		public List<Admin> GetListAll()
		{
			return adminDal.GetListAll();
		}

		public void Insert(Admin t)
		{
			adminDal.Insert(t);
		}

		public void Update(Admin t)
		{
			adminDal.Update(t);
		}
	}
}
