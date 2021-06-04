using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

//ƒtƒ@ƒCƒ‹“Ç‚Ýž‚Ý—p
using System.IO;


namespace SampleEmptyApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //ŠÈˆÕ“I‚ÈHTML•\Ž¦ƒŠƒXƒg‚P|‚R
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        context.Response.ContentType = "text/html";
            //        await context.Response.WriteAsync("<html><title>Hello World!</title></head>");
            //        await context.Response.WriteAsync("<body><h1>Hello World!</h1>");
            //        await context.Response.WriteAsync("<p>This is sample page.</p>");
            //        await context.Response.WriteAsync("</body></html>");
            //    });
            //});

            //welcomeƒy[ƒW@ƒŠƒXƒg‚P|‚S
            //app.UseWelcomePage();

            //‚Ó‚Ÿ‚¢‚é‚Ì“Ç‚Ýž‚ÝƒŠƒXƒg‚P|‚T
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    context.Response.ContentType = "text/plain";
                    using (FileStream stream = File.Open(@"./Startup.cs", FileMode.Open))
                    {
                        int num = (int)stream.Length;
                        byte[] bytes = new byte[num];
                        stream.Read(bytes, 0, num);
                        string result = System.Text.Encoding.UTF8.GetString(bytes);
                        await context.Response.WriteAsync(result);
                    }
                });
            });
        }
    }
}
