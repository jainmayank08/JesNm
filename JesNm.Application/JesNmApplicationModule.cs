using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace JesNm
{
    [DependsOn(typeof(JesNmCoreModule), typeof(AbpAutoMapperModule))]
    public class JesNmApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
