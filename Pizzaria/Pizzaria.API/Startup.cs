using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Pizzaria.Business.Business;
using Pizzaria.Business.Repositories;
using Pizzaria.Data;
using Pizzaria.Model.Models;

namespace Pizzaria.API
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
           
            services.AddScoped<DataContext, DataContext>();

            services.AddTransient<PedidoRepository<Pedido>, PedidoRepository<Pedido>>();
            services.AddTransient<ClienteRepository<Cliente>, ClienteRepository<Cliente>>();
            services.AddTransient<ItemRepository<Item>, ItemRepository<Item>>();

            services.AddTransient<PedidoBusiness, PedidoBusiness>();
            services.AddTransient<ClienteBusiness, ClienteBusiness>();
            services.AddTransient<ItemBusiness, ItemBusiness>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
