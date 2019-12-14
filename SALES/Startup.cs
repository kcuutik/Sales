using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SALES.Entities;
using SALES.Repository;
using SALES.Services;

namespace SALES
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
            services.AddDistributedMemoryCache();

            services.AddSession(options =>
            {
                // Set a short timeout for easy testing.
                options.IdleTimeout = TimeSpan.FromSeconds(10);
                options.Cookie.HttpOnly = true;
                // Make the session cookie essential
                options.Cookie.IsEssential = true;
            });

            // khoa Install-Package Microsoft.EntityFrameworkCore.SqlServer
            services.AddEntityFrameworkSqlServer().AddDbContext<SalesContext>((serviceProvider, options) =>
                options.UseSqlServer(this.Configuration.GetConnectionString("DefaultConnection")));

            // Uniti
            //services.AddHttpClient<ProductServices>();

            services.AddTransient<IProductServices, ProductServices>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddTransient<ICategoryServices, CategoryServices>();
            services.AddTransient<IImageRepository, ImageRepository>();
            services.AddTransient<IImageServices, ImageServices>();
            services.AddTransient<IAkUserServices, AkUserServices>();
            services.AddTransient<IAkUserRepository, AkUserRepository>();

            services.AddOptions();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute("product", "product/{*article}",
                         defaults: new { controller = "Product", action = "Index" });
                routes.MapRoute("default", "{controller=AdminCategory}/{action=Index}/{id?}");
            });
        }
    }
}
