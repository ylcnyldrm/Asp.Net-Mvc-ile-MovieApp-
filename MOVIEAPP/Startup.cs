using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIEAPP
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            //properties / louncsetting dosyas�nda devolopment �zelli�i varsa hata sayfalar�n� g�sterir di�er t�rl� g�stermez
            //uygulama yay�nlad�ktan sonra bunlr� g�stermeye gerek yok yay�nlarken devolopment k�sm�n� productiona �evirmek gerek
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseStaticFiles(); //varsay�lan olarak wwwroot klas�r�m�z d��ar�ya a��lm�� olur yol => /css/style.css /img/1.jpeg
            // node_modules klas�r�n� d��ar�ya a�mak i�in bu k�sm� yaz�yoruz 
            app.UseStaticFiles(new StaticFileOptions {
            FileProvider= new PhysicalFileProvider(Path.Combine
            ( Directory.GetCurrentDirectory(),"node_modules")),
               RequestPath="/modules"   //modules/bootstrap/dist/css/bootstrap.min.css �eklinde bir yol olacak
            });


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {

                endpoints.MapControllerRoute(
                    name: "default",
                    // action = controller i�indeki her bir metoda veri�imiz isim
                    // id? = Soru i�areti iste�e ba�l� olarak kullan�laca��n� belirtir. 
                    pattern: "{controller=Home}/{action=Index}/{id?}");

                //url yolu course released year ve ay �eklinde olmas� laz�m year ve month da ? olsayd�
                // year ve month alanlar�n� doldurmaya gerek kalmayacakt�.
                endpoints.MapControllerRoute(
                    name: "CoursesByReleased",
                    pattern: "course/released/{id?}",
                    new { controller = "Movie", action = "Index" } 
                    );

                endpoints.MapControllerRoute(
                   name: "register",
                   pattern: "register/released/{id?}",
                   new { controller = "User", action = "Login" }
                   );

            });

        }
    }
}
