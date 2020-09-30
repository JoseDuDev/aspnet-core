using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using docspider.Authorization;

namespace docspider
{
    [DependsOn(
        typeof(docspiderCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class docspiderApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<docspiderAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(docspiderApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
