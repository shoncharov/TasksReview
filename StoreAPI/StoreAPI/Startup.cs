using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAPI
{
    public class Startup
    {
        // метод-настривает объекты использ.в приложении
        //настр.конфигурации
      public void ConfigureServices (IServiceCollection services)
        {
            services.AddMvc();
        }
        //настр.средств,что получают и обрабат.HTTP запросы
        //каждый метод явл.расшир.метод.что настр. средства обраб.запросов
      public void Configure(IApplicationBuilder appBuild, IHostEnvironment env)
        {
            appBuild.UseDeveloperExceptionPage();
            appBuild.UseStatusCodePages();
            appBuild.UseStaticFiles(); 
            
            appBuild.UseMvc(routes => { });//включ.инфраструкт.МВС
        }
        
    }
}
