using Abp.Domain.Repositories;
using JesNm.Jes;
using System.Collections.Generic;

namespace JesNm.Reporsitory
{
    public interface IChapterRepository : IRepository<Chapter>
    {
        List<Chapter> GetAllChapter();
    }
}
