using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using JesNm.EntityFramework;

namespace JesNm
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(JesNmCoreModule))]
    public class JesNmDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
