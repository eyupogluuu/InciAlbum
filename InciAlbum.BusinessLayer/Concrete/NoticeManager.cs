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
    public class NoticeManager : INoticeService
    {
        private readonly INoticeDal noticeDal;

        public NoticeManager(INoticeDal noticeDal)
        {
            this.noticeDal = noticeDal;
        }

        public void Delete(Notice t)
        {
            noticeDal.Delete(t);
        }

        public Notice GetById(int id)
        {
            return noticeDal.GetById(id);
        }

        public List<Notice> GetListAll()
        {
          return noticeDal.GetListAll();
        }

        public void Insert(Notice t)
        {
            noticeDal.Insert(t);
        }

        public void Update(Notice t)
        {
            noticeDal.Update(t);
        }
    }
}
