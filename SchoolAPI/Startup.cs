using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Domain.Interface.IBusiness;
using Domain.Business;
using Microsoft.EntityFrameworkCore;
using Infrastructure;
using Domain.Interface.IData;
using Infrastructure.Data;

namespace SchoolAPI
{
    public class Startup
    {
        readonly string schoolAPI = "SchoolAPI";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddDbContext<SchoolContext>(options =>
                options.UseSqlite("Data Source = schooldb.db")
                ,ServiceLifetime.Singleton);

            services.AddCors(options =>
            {
                options.AddPolicy(name: schoolAPI,
                                  builder =>
                                  {
                                      builder
                                      .WithOrigins("http://localhost:4200", "https://localhost:4200");
                                  });
            });

            services.AddMvc();
            //services.AddDbContext<TodoContext>(opt => opt.UseInMemoryDatabase("TodoList"));
            services.AddControllers();
            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "School API",
                    Description = "Schools ASP.NET Core Web API",
                });
            });

            //Business 
            services.AddSingleton<IHeroBusiness, HeroBusiness>();
            services.AddSingleton<IStudentBusiness, StudentBusiness>();
            services.AddSingleton<ISchoolBusiness, SchoolBusiness>();
            services.AddSingleton<IClassBusiness, ClassBusiness>();

            //Data
            services.AddSingleton<IHeroData, HeroData>();
            services.AddSingleton<ISchoolData, SchoolData>();
            services.AddSingleton<IStudentData, StudentData>();
            services.AddSingleton<IClassData, ClassData>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger(c =>
            {
                
                c.SerializeAsV2 = true;
            });

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            //must be after UserRouting and before UseAuthorization and also before UseEndpoint
            app.UseCors(schoolAPI);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
