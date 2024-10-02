using InciAlbum.DataAccessLayer.Abstract;
using InciAlbum.DataAccessLayer.Concrete.Repositories;
using InciAlbum.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InciAlbum.DataAccessLayer.Concrete.EntityFramework
{
    public class EFNoticeDal:GenericRepository<Notice>,INoticeDal
    {
    }
}
