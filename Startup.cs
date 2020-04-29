using DesignPatterns.Behavioral.Strategy;
using DesignPatterns.Creational.FactoryMethod;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DesignPatterns
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
            services.AddScoped<IPaymentService, PaymentService>();

            services.AddSingleton<DebitCardStrategy>();
            services.AddSingleton<CashStrategy>();

            //register interfaces using factory that return implementation singleton
            services.AddSingleton<IPaymentMethod, DebitCardStrategy>(p => p.GetService<DebitCardStrategy>());
            services.AddSingleton<IPaymentMethod, CashStrategy>(p => p.GetService<CashStrategy>());


            services.AddScoped<ICreditCardService, CreditCardService>();

            services.AddSingleton<CreditCardGolden>();
            services.AddSingleton<CreditCardSilver>();
            services.AddSingleton<CreditCardPlatinum>();

            //register collection that return implementation singleton
            services.AddSingleton<ICreditCard, CreditCardGolden>(p => p.GetService<CreditCardGolden>());
            services.AddSingleton<ICreditCard, CreditCardSilver>(p => p.GetService<CreditCardSilver>());
            services.AddSingleton<ICreditCard, CreditCardPlatinum>(p => p.GetService<CreditCardPlatinum>());

            services.AddMvcCore().AddJsonFormatters();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}