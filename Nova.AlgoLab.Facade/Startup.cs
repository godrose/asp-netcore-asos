using JetBrains.Annotations;
using LogoFX.Bootstrapping;
using LogoFX.Server.Bootstrapping.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BootstrapperBase = LogoFX.Server.Bootstrapping.BootstrapperBase;

namespace Nova.AlgoLab.Facade
{
    internal sealed class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        [UsedImplicitly]
        public IConfiguration Configuration { get; }

        [UsedImplicitly]
        public void ConfigureServices(IServiceCollection services)
        {
            var bootstrapper = new Bootstrapper(services)
                .UseCompositionModules<BootstrapperBase, IServiceCollection>()
                .Use(new RegisterCoreMiddleware<BootstrapperBase>());           
            bootstrapper.Initialize();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [UsedImplicitly]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors("AllowAny")
                .UseAuthentication()
                .UseMvc();
        }
    }
}
