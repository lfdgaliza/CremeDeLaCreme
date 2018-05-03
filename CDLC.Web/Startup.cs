using System.IO;
using CDLC.Domain.Repositories;
using CDLC.Domain.Services;
using CDLC.Domain.Services.Impl;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace CDLC.Web
{
  public class Startup
  {
    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
          .SetBasePath(env.ContentRootPath)
          .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
          .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
          .AddEnvironmentVariables();
      Configuration = builder.Build();
    }

    public IConfigurationRoot Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      // Add framework services.
      services.AddMvc();

      // Add CDLC services
      services.AddSingleton(typeof(IMailService), typeof(MailService));

      // Add CDLC database context
      var optionsBuilder = new DbContextOptionsBuilder<CdlcDbContext>();
      services.AddDbContext<CdlcDbContext>(options =>
        options.UseMySql(Configuration.GetConnectionString("CdlcDatabase")));
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
    {
      loggerFactory.AddConsole(Configuration.GetSection("Logging"));
      loggerFactory.AddDebug();

      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
        app.UseBrowserLink();
      }
      else
      {
       app.UseExceptionHandler("/Home/Error");
      }

      app.Use(async (context, next) =>
      {
        await next();
        if (context.Response.StatusCode == 404 &&
                 !Path.HasExtension(context.Request.Path.Value) &&
                 !context.Request.Path.Value.StartsWith("/api/"))
        {
          context.Request.Path = "/index.html";
          await next();
        }
      });

      app.UseMvcWithDefaultRoute();

      app.UseDefaultFiles();
      app.UseStaticFiles();
    }
  }
}
