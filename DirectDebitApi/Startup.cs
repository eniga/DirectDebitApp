using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DirectDebitApi.Helpers;
using DirectDebitApi.Repositories;
using DirectDebitApi.Services;
using DirectDebitApi.Services.Account;
using DirectDebitApi.Services.AppBUnit;
using DirectDebitApi.Services.AppLoansLog;
using DirectDebitApi.Services.AppLog;
using DirectDebitApi.Services.AppNotificationsSetting;
using DirectDebitApi.Services.AppNotificationsTemplate;
using DirectDebitApi.Services.AppPermTable;
using DirectDebitApi.Services.AppRepayment;
using DirectDebitApi.Services.AppSetting;
using DirectDebitApi.Services.AppSettingsPreference;
using DirectDebitApi.Services.AppUserPreference;
using DirectDebitApi.Services.Bank;
using DirectDebitApi.Services.Collateral;
using DirectDebitApi.Services.Contact;
using DirectDebitApi.Services.Customer;
using DirectDebitApi.Services.Disbursement;
using DirectDebitApi.Services.Invoice;
using DirectDebitApi.Services.Loan;
using DirectDebitApi.Services.Mandate;
using DirectDebitApi.Services.Merchant;
using DirectDebitApi.Services.Payment;
using DirectDebitApi.Services.User;
using MicroOrm.Dapper.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MySql.Data.MySqlClient;

namespace DirectDebitApi
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "DirectDebitApi", Version = "v1" });
            });

            // Register Dapper Dependencies
            services.AddTransient<IDbConnection>(prov => new MySqlConnection(prov.GetService<IConfiguration>().GetConnectionString("DefaultConnection")));
            services.AddTransient(typeof(DapperRepository<>));

            // Add cors support
            services.AddCors();

            // Register components that access external systems
            services.AddTransient<IEncryptor, Encryptor>();
            //services.AddTransient<IJwtUtil, JwtUtil>();

            // Register Services
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddTransient<IAppBUnitService, AppBUnitService>();
            services.AddTransient<IAppLoansLogService, AppLoansLogService>();
            services.AddTransient<IAppLogService, AppLogService>();
            services.AddTransient<IAppNotificationsSettingService, AppNotificationsSettingService>();
            services.AddTransient<IAppNotificationsTemplateService, AppNotificationsTemplateService>();
            services.AddTransient<IAppPermTableService, AppPermTableService>();
            services.AddTransient<IAppRepaymentService, AppRepaymentService>();
            services.AddTransient<IAppSettingService, AppSettingService>();
            services.AddTransient<IAppSettingsPreferenceService, AppSettingsPreferenceService>();
            services.AddTransient<IAppUserPreferenceService, AppUserPreferenceService>();
            services.AddTransient<IBankService, BankService>();
            services.AddTransient<ICollateralService, CollateralService>();
            services.AddTransient<IContactService, ContactService>();
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IDisbursementService, DisbursementService>();
            services.AddTransient<IInvoiceService, InvoiceService>();
            services.AddTransient<ILoanService, LoanService>();
            services.AddTransient<IMandateService, MandateService>();
            services.AddTransient<IMerchantService, MerchantService>();
            services.AddTransient<IPaymentService, PaymentService>();

            // Add authentication header to use JWT
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "JwtBearer";
                options.DefaultChallengeScheme = "JwtBearer";
            })
            .AddJwtBearer("JwtBearer", jwtOptions =>
            {
                jwtOptions.TokenValidationParameters = new TokenValidationParameters()
                {
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtUtil.SECRET_KEY)),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.Zero
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedFor | Microsoft.AspNetCore.HttpOverrides.ForwardedHeaders.XForwardedProto
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DirectDebitApi v1"));
            }

            // Enable cors
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                );

            if(env.IsDevelopment())
            {
                app.UseHttpsRedirection();
            }

            app.UseRouting();

            // Enable use of authentication header
            //app.UseAuthentication();

            // Enable use of authorization header
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
