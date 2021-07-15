using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using SampleAuthApp.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;

namespace SampleAuthApp
{
    // インターフェイス
    public interface ISampleDependency
    {
        public SampleData getData();
    }


    // 実装クラス
    public class SampleDependency : ISampleDependency
    {
        private List<SampleData> _data;


        public SampleDependency()
        {
            _data = new List<SampleData>();
            _data.Add(new SampleData("YAMADA-Taro", "taro@yamda", "999-9999"));
            _data.Add(new SampleData("Tanaka-Hanako", "hanako@flwer", "888-888"));
            _data.Add(new SampleData("Ito-Sachiko", "sachico@happy", "777-7777"));
            _data.Add(new SampleData("Oda-mami", "mami@mumemo", "666-6666"));
            _data.Add(new SampleData("Nakamura-Jiro", "jiro@change", "555-5555"));
        }


        public SampleData getData()
        {
            int n = new Random().Next(_data.Count());
            return _data[n];
        }
    }

    public class Startup
    {
        // mapの割り当て
        private static void Hello(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Hello");
            });
        }
        private static void Bye(IApplicationBuilder app)
        {
            app.Run(async context =>
            {
                await context.Response.WriteAsync("Good-Bye!");
            });
        }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection")));

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddAuthentication().AddGoogle(options =>
            {
                IConfigurationSection googleAuthNSection = Configuration.GetSection("Authentication:Google");

                options.ClientId = googleAuthNSection["ClientId"];
                options.ClientSecret = googleAuthNSection["ClientSecret"];
            });
            //プライバシーをログイン者専用に
            services.AddRazorPages().AddRazorPagesOptions(options =>
                {
                    options.Conventions.AuthorizePage("/Privacy");
                });

            //ミドルウェアの追加
            services.AddSession();

            services.AddScoped<ISampleDependency, SampleDependency>();
            //services.AddSingleton<ISampleDependency, SampleDependency>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //app.Map("/map1", Hello);
            //app.Use(async (context , next) =>
            //{
            //    await context.Response.WriteAsync("Use 1!");
            //    await next();
            //});
            //app.Map("/map2", Bye);

            app.UseSession();
            app.UseSample();


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }

    public class SampleMiddleware
    {
        private readonly RequestDelegate _next;

        public SampleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            SampleData data = new SampleData("YAADA=Taro", "taro@yamdata", "999-9999");
            context.Session.SetString("SampleData", data.ToString());
            await _next(context);
        }
    }

    public class SampleData
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }

        public SampleData(string name, string mail, string tel)
        {
            Name = name;
            Mail = mail;
            Tel = tel;
        }

        public override string ToString()
        {
            return "{ " + Name + ", " + Mail + ", " + Tel + " }";
        }
    }

    public static class SampleMiddlewareExtensions
    {
        public static IApplicationBuilder UseSample(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SampleMiddleware>();
        }
    }
}
