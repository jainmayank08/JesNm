using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesNm.Jes
{
    public interface IChapterService : IApplicationService
    {
        List<Chapter> GetAllChapter();
    }
}
