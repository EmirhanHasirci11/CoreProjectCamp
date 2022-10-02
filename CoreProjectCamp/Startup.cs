using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp
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
            services.AddScoped<IBlogService, BlogManager>();
            services.AddScoped<IBlogDal, EFBlogDal>();
            services.AddScoped<ICategoryDal, EFCategoryDal>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<IAuthorDal, EFAuthorDal>();
            services.AddScoped<IAuthorService, AuthorManager>();
            services.AddScoped<IAdminDal, EFAdminDal>();
            services.AddScoped<IAdminService, AdminManager>();
            services.AddScoped<IAboutDal, EFAboutDal>();
            services.AddScoped<IAboutService, AboutManager>();
            services.AddScoped<ICommentDal, EFCommentDal>();
            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<IContactDal, EFContactDal>();
            services.AddScoped<IContactService, ContactManager>();
            services.AddScoped<IMessage2Dal, EFMessage2Dal>();
            services.AddScoped<IMessage2Service, Message2Manager>();
            services.AddScoped<INewsLetterDal, EFNewsLetterDal>();
            services.AddScoped<INewsLetterService, NewsLetterManager>();
            services.AddScoped<INotificationDal, EFNotificationDal>();
            services.AddScoped<INotificationService, NotificationManager>();
            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>(x =>
            {
                x.Password.RequireUppercase = false; x.Password.RequireNonAlphanumeric = false;
            })
            .AddEntityFrameworkStores<Context>();
            //todo proje seviyesinde authorize
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });
            //todo authentication olmayan sayfadaysak return url kýsmý ile login kýsmýna yönlendiriyor
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(cookie =>
                {
                    cookie.LoginPath = "/Login/Index";
                });
            services.AddControllersWithViews();


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
            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code={0}");
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                     name: "areas",
                     pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
           );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Blog}/{action=Index}/{id?}");

            });
        }
    }
}
