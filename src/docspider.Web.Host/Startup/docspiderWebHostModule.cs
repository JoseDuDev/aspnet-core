using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using docspider.Configuration;

namespace docspider.Web.Host.Startup
{
    [DependsOn(
       typeof(docspiderWebCoreModule))]
    public class docspiderWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public docspiderWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(docspiderWebHostModule).GetAssembly());
        }
    }
}
