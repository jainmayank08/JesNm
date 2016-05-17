using JesNm.Reporsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesNm.Jes
{
    public class ChapterService : JesNmAppServiceBase , IChapterService
    {
        private readonly IChapterRepository _chapterRepository;

        public ChapterService(IChapterRepository ChapterRepository)
        {
            _chapterRepository = ChapterRepository;
        }
        public List<Chapter> GetAllChapter()
        {
           return _chapterRepository.GetAllChapter();
        }
    }
}
