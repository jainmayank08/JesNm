using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace JesNm.EntityFramework.Repositories
{
    public abstract class JesNmRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<JesNmDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected JesNmRepositoryBase(IDbContextProvider<JesNmDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class JesNmRepositoryBase<TEntity> : JesNmRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected JesNmRepositoryBase(IDbContextProvider<JesNmDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
