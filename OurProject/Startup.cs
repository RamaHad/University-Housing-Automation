using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OurProject.IRepo;
using OurProject.Repo;
using OurProject.Repo.Profiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurProject
{
    public class Startup
    {

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //profile services
            services.AddControllersWithViews();
            services.AddAutoMapper(typeof(AccessoryProfile));
            services.AddAutoMapper(typeof(CityProfile));
            services.AddAutoMapper(typeof(DateTypeProfile));
            services.AddAutoMapper(typeof(RoleProfile));
            services.AddAutoMapper(typeof(RoomProfile));
            services.AddAutoMapper(typeof(StoreDetailProfile));
            services.AddAutoMapper(typeof(StudentAccessoriesProfile));
            services.AddAutoMapper(typeof(StudentDateProfile));
            services.AddAutoMapper(typeof(StudentProfile));
            services.AddAutoMapper(typeof(StudyBranchProfile));
            services.AddAutoMapper(typeof(TimeSloteProfile));
            services.AddAutoMapper(typeof(UnitProfile));
            services.AddAutoMapper(typeof(UnitRoomProfile));
            services.AddAutoMapper(typeof(UnitStoreProfile));
            services.AddAutoMapper(typeof(UserProfile));

            //table services
            services.AddTransient<RoleIRepo, RoleRepo>();



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
