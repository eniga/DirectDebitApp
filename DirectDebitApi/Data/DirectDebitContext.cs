using DirectDebitApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DirectDebitApi.Data
{
    public class DirectDebitContext : DbContext
    {
        public DirectDebitContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map entities to tables  
            modelBuilder.Entity<Accounts>().ToTable("accounts");
            modelBuilder.Entity<AppBUnits>().ToTable("app_bunits");
            modelBuilder.Entity<AppLoans>().ToTable("app_loans");
            modelBuilder.Entity<AppLoansLogs>().ToTable("app_loans_logs");
            modelBuilder.Entity<AppLogs>().ToTable("app_log");
            modelBuilder.Entity<AppNotificationsSettings>().ToTable("app_notifications_settings");
            modelBuilder.Entity<AppNotificatonsTemplate>().ToTable("app_notifications_templates");
            modelBuilder.Entity<AppPermTables>().ToTable("app_perm_table");
            modelBuilder.Entity<AppRepayments>().ToTable("app_repayments");
            modelBuilder.Entity<AppSettings>().ToTable("AppSettings");
            modelBuilder.Entity<AppSettingsPreferences>().ToTable("app_settings_preferences");
            modelBuilder.Entity<AppUserPreferences>().ToTable("app_user_preferences");
            modelBuilder.Entity<AppUserPrivileges>().ToTable("app_user_privileges");
            modelBuilder.Entity<Banks>().ToTable("banks");
            modelBuilder.Entity<Collaterals>().ToTable("collaterals");
            modelBuilder.Entity<Contacts>().ToTable("contacts");
            modelBuilder.Entity<Customers>().ToTable("customers");
            modelBuilder.Entity<Disbursements>().ToTable("disbursements");
            modelBuilder.Entity<Invoices>().ToTable("invoices");
            modelBuilder.Entity<Loans>().ToTable("loans");
            modelBuilder.Entity<Mandates>().ToTable("mandates");
            modelBuilder.Entity<Merchants>().ToTable("merchants");
            modelBuilder.Entity<Payments>().ToTable("payments");
            modelBuilder.Entity<Users>().ToTable("users");
        }
        public DbSet<Accounts> Accounts { get; set; }
        public DbSet<AppBUnits> AppBunit { get; set; }
        public DbSet<AppLoans> AppLoans { get; set; }
        public DbSet<AppLoansLogs> AppLoansLogs { get; set; }
        public DbSet<AppLogs> AppLogs { get; set; }
        public DbSet<AppNotificationsSettings> AppNotificationsSettings { get; set; }
        public DbSet<AppNotificatonsTemplate> AppNotificatonsTemplates { get; set; }
        public DbSet<AppPermTables> AppPermTables { get; set; }
        public DbSet<AppRepayments> AppRepayments { get; set; }
        public DbSet<AppSettings> AppSettings { get; set; }
        public DbSet<AppSettingsPreferences> AppSettingsPreferences { get; set; }
        public DbSet<AppUserPreferences> AppUserPreferences { get; set; }
        public DbSet<AppUserPrivileges> AppUserPrivileges { get; set; }
        public DbSet<Banks> Banks { get; set; }
        public DbSet<Collaterals> Collaterals { get; set; }
        public DbSet<Contacts> Contacts { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Disbursements> Disbursements { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<Loans> Loans { get; set; }
        public DbSet<Mandates> Mandates { get; set; }
        public DbSet<Merchants> Merchants { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<Users> Users { get; set; }
    }

}
