using Abp.EntityFramework;
using JesNm.EntityFramework;
using JesNm.EntityFramework.Repositories;
using JesNm.Jes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JesNm.Reporsitory
{
    public class ChapterRepository : JesNmRepositoryBase<Chapter>, IChapterRepository
    {
        public ChapterRepository(IDbContextProvider<JesNmDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public List<Chapter> GetAllChapter()
        {
            return Context.Chapters.ToList();
        }
    }
}
