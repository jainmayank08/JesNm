using Abp.Application.Services;
using JesNm.Jes.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesNm.Jes
{
    public interface IChapterService : IApplicationService
    {
        List<ChapterListDto> GetAllChapter();
    }
}
