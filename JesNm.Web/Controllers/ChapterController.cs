using JesNm.Jes;
using System.Collections.Generic;
using System.Web.Mvc;
using Abp.AutoMapper;
using JesNm.Jes.Dto;

namespace JesNm.Web.Controllers
{
    public class ChapterController : Controller
    {
        private readonly IChapterService _chapterService;

        public ChapterController(IChapterService chapterService)
        {
            _chapterService = chapterService;
        }

        // GET: Chapter
        public ActionResult Index()
        {
            var chapters =_chapterService.GetAllChapter();
            AutoMapper.Mapper.CreateMap<ChapterListDto, JesNm.Web.Models.Jes.GetChapterViewModel>();

            var chaptersview = AutoMapper.Mapper.Map<List<JesNm.Web.Models.Jes.GetChapterViewModel>>(chapters);
            return View(chaptersview);
        }
    }
}