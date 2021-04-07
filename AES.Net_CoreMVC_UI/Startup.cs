using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AES.Net_BusinessLogicalLayer.Abstract;
using AES.Net_BusinessLogicalLayer.Concrete;
using AES.Net_BusinessLogicalLayer.UnitOfWork;
using AES.Net_DataAccessLayer.Abstract;
using AES.Net_DataAccessLayer.Concrete;
using AES.Net_DataAccessLayer.Concrete.Ado.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AES.Net_CoreMVC_UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddMvc();
            services.AddMvc(options => options.EnableEndpointRouting = false);

            /*IOC container*/
            /*Data Access Layer*/
            services.AddSingleton<IMatrixDal, MatrixDal>();
            services.AddSingleton<IStreetDal, StreetDal>();
            services.AddSingleton<ISubcontrolDal, SubcontrolDal>();
            services.AddSingleton<ISubjectDal, SubjectDal>();
            services.AddSingleton<ISubmeterDal, SubmeterDal>();
            services.AddSingleton<ISubscriberDal, SubscriberDal>();

            /*Business Logical Layer*/
            services.AddSingleton<IMatrixService, MatrixManager>();
            services.AddSingleton<IStreetService, StreetManager>();
            services.AddSingleton<ISubcontrolService, SubcontrolManager>();
            services.AddSingleton<ISubjectService, SubjectManager>();
            services.AddSingleton<ISubmeterService, SubmeterManager>();
            services.AddSingleton<ISubscriberService, SubscriberManager>();

            services.AddSingleton<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseMvc();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
            app.UseMvcWithDefaultRoute();
        }
    }
}
