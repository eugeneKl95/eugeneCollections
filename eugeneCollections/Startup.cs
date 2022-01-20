using eugeneCollections.Domain;
using eugeneCollections.Domain.Entities;
using eugeneCollections.Domain.Repositories.Abstract;
using eugeneCollections.Domain.Repositories.EntityFramework;
using eugeneCollections.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace eugeneCollections
{

    public class Startup
    {
       public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            Configuration.Bind("Project", new Config()); //connection config from appsetting.json
            services.AddTransient<ICollectionRepository, EFCollectionRepository>();
            services.AddTransient<ICommentRepository, EFCommentRepository>();
            services.AddTransient<IItemRepository, EFItemRepository>();
            services.AddTransient<ILikeRepository, EFLikeRepository>();
            services.AddTransient<ITagRepository, EFTagRepository>();
            services.AddTransient<IThemeRepository, EFThemeRepository>();
            services.AddTransient<IUserRepository, EFUserRepository>();
            services.AddTransient<DataManager>();
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));
            services.AddIdentity<User, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();
            //настраиваем authentication cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "eugeneCollectionAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });
            //настраиваем политику авторизации для Admin area
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });
            services.AddControllersWithViews(x=> 
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));            
            })
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddSessionStateTempDataProvider();
        }

        
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) //information about errors
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles(); //add supporting static files
            app.UseRouting();            
            //подключаем аутентификацию и авторизацию
            app.UseCookiePolicy();
            app.UseAuthentication();//ко времени обращения к системе маршрутизации, контроллерам и их методам, куки должным образом обработаны и установлены
            app.UseAuthorization();
            app.UseEndpoints(endpoints => // registration need routes
            {
                endpoints.MapControllerRoute("admin", "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");               
            });
        }
    }
}
