using CorrelationId;
using CorrelationId.DependencyInjection;
using Listasupermercado.Infrastructure.Repository;
using ListaSupermercado.Application.UseCase;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ListaSupermercado.API
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
            services.AddDbContext<ProdutoRepository>(opt => {
                opt.UseSqlServer(Configuration.GetConnectionString("ConexaoApp"));
            });

            // Example of adding default correlation ID (using the GUID generator) services
            // As shown here, options can be configured via the configure degelate overload
            services.AddDefaultCorrelationId(options =>
            {
                //options.CorrelationIdGenerator = () => "Foo";
                options.AddToLoggingScope = true;
                options.EnforceHeader = false;
                options.IgnoreRequestHeader = false;
                options.IncludeInResponse = true;
                options.RequestHeader = "X-Correlation-Id";
                options.ResponseHeader = "X-Correlation-Id";
                options.UpdateTraceIdentifier = false;
            });

            services.AddControllers();
            
            services.AddSwaggerDocument();
            services.AddTransient<CriarProdutoUseCase, CriarProdutoUseCase>();
            services.AddTransient<ObterProdutoUseCase, ObterProdutoUseCase>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();

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

            app.UseCorrelationId();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}
