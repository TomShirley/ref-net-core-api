using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using TomShirley.EFCore.Sample.Database;
using TomShirley.EFCore.Sample.Endpoint.Configuration;

namespace TomShirley.EFCore.Sample.Endpoint.Startup
{
    public class Startup
    {
        private IContainer ApplicationContainer { get; set; }
        public IConfiguration Configuration { get; }

        public Startup(IWebHostEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();

            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(Configuration)
                .Enrich.WithProperty("appcode", Assembly.GetExecutingAssembly().GetName().Name)
                .Enrich.WithProperty("appversion", Configuration.GetSection("ApiVersion").Value)
                .CreateLogger();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.Configure<StatusSetting>(Configuration);

            services.AddResponseCompression();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddControllers().AddNewtonsoftJson();

            services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));

            services.AddDbContext<BlogsDbContext>(
                options => options.UseSqlServer(
                    Configuration["DatabaseConnectionString"],
                     x => x.MigrationsAssembly("TomShirley.EFCore.Sample.Database")));

            var builder = AutofacConfiguration.Configure(services, Configuration);

            ApplicationContainer = builder.Build();

            return new AutofacServiceProvider(ApplicationContainer);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime appLifetime)
        {
            if (env.IsDevelopment())
            {
            }

            app.UseRouting();

            // for localdev
            app.UseCors(options => options.AllowAnyOrigin());

            app.UseResponseCompression();
           
            app.UseEndpoints(x => { x.MapControllers(); });
            appLifetime.ApplicationStopped.Register(() => ApplicationContainer.Dispose());
        }
    }
}
