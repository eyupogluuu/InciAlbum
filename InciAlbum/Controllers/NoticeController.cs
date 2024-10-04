using InciAlbum.BusinessLayer.Abstract;
using InciAlbum.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace InciAlbum.Controllers
{
    public class NoticeController : Controller
    {
        private readonly INoticeService noticeService;

        public NoticeController(INoticeService noticeService)
        {
            this.noticeService = noticeService;
        }

        public IActionResult Index()
        {
            var values = noticeService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddNotice()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNotice(Notice notice)
        {
            notice.date = DateTime.Parse(DateTime.Now.ToShortDateString());
            notice.status = false;
            noticeService.Insert(notice);            
            return RedirectToAction("Index");
        }
        public IActionResult DeleteNotice(int id)
        {
            var sil = noticeService.GetById(id);
            noticeService.Delete(sil);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateNotice(int id)
        {
            var value = noticeService.GetById(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateNotice(Notice n)
        {
            noticeService.Update(n);
            return RedirectToAction("Index");
        }
    }
}
