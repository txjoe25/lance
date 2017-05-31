using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Joe.Factories;


namespace Joe
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
                
        public Startup(IHostingEnvironment env)
        {
            var Builder = new ConfigurationBuilder()
            .SetBasePath(env.ContentRootPath)
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables();

            Configuration = Builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<MySqlOptions>(Configuration.GetSection("DBInfo"));
            services.AddScoped<MessageFactory>();
            services.AddSession();
            services.AddMvc();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc();
        }
    }
}
