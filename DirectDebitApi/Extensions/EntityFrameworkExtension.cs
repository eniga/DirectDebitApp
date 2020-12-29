using DirectDebitApi.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DirectDebitApi.Extensions
{
    public static class EntityFrameworkExtension
    {
        //DB Auto migration
        public static void UseDBAutoMigration(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope();
            using (var context = serviceScope.ServiceProvider.GetService<DirectDebitContext>())
            {
                //  context.AuditLogs.AsNoTracking();
                context.Database.Migrate();
            }
        }
    }
}
