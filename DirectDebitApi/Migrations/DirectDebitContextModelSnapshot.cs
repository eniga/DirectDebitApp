﻿// <auto-generated />
using System;
using DirectDebitApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DirectDebitApi.Migrations
{
    [DbContext(typeof(DirectDebitContext))]
    partial class DirectDebitContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DirectDebitApi.Entities.Accounts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("accountno")
                        .HasColumnType("text");

                    b.Property<int>("bankid")
                        .HasColumnType("int");

                    b.Property<DateTime>("createdat")
                        .HasColumnType("datetime");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<int>("customerid")
                        .HasColumnType("int");

                    b.Property<DateTime>("updatedat")
                        .HasColumnType("datetime");

                    b.Property<int>("updatedby")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.AppBUnits", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("bunitid")
                        .HasColumnType("text");

                    b.Property<string>("businessnature")
                        .HasColumnType("text");

                    b.Property<string>("clientid")
                        .HasColumnType("text");

                    b.Property<string>("env")
                        .HasColumnType("text");

                    b.Property<string>("frontend")
                        .HasColumnType("text");

                    b.Property<string>("location")
                        .HasColumnType("text");

                    b.Property<string>("mainbunit")
                        .HasColumnType("text");

                    b.Property<string>("mod_fx")
                        .HasColumnType("text");

                    b.Property<string>("mod_hotelrooms")
                        .HasColumnType("text");

                    b.Property<string>("mod_inv")
                        .HasColumnType("text");

                    b.Property<string>("mod_payroll")
                        .HasColumnType("text");

                    b.Property<string>("mod_restaurant")
                        .HasColumnType("text");

                    b.Property<string>("mod_sms")
                        .HasColumnType("text");

                    b.Property<string>("policy_abovefixed")
                        .HasColumnType("text");

                    b.Property<string>("policy_autoapproval")
                        .HasColumnType("text");

                    b.Property<string>("policy_autocash")
                        .HasColumnType("text");

                    b.Property<string>("policy_directsales")
                        .HasColumnType("text");

                    b.Property<string>("policy_outstock")
                        .HasColumnType("text");

                    b.Property<string>("startupcapital")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.Property<string>("unitname")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("app_bunits");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.AppLoans", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("bvn")
                        .HasColumnType("int");

                    b.Property<string>("clientid")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("fullname")
                        .HasColumnType("text");

                    b.Property<string>("loanamount")
                        .HasColumnType("text");

                    b.Property<string>("loanapplydate")
                        .HasColumnType("text");

                    b.Property<string>("loanapprovedate")
                        .HasColumnType("text");

                    b.Property<string>("loanbatchid")
                        .HasColumnType("text");

                    b.Property<string>("loanduedate")
                        .HasColumnType("text");

                    b.Property<string>("loanid")
                        .HasColumnType("text");

                    b.Property<string>("loaninterest")
                        .HasColumnType("text");

                    b.Property<string>("loanrepaycycle")
                        .HasColumnType("text");

                    b.Property<string>("loanstatus")
                        .HasColumnType("text");

                    b.Property<string>("loantotal")
                        .HasColumnType("text");

                    b.Property<string>("process_date")
                        .HasColumnType("text");

                    b.Property<string>("process_status")
                        .HasColumnType("text");

                    b.Property<string>("process_time")
                        .HasColumnType("text");

                    b.Property<string>("process_user")
                        .HasColumnType("text");

                    b.Property<string>("tel")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("app_loans");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.AppLoansLogs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("activity")
                        .HasColumnType("text");

                    b.Property<string>("clientid")
                        .HasColumnType("text");

                    b.Property<string>("loanbatchid")
                        .HasColumnType("text");

                    b.Property<string>("loanid")
                        .HasColumnType("text");

                    b.Property<string>("logdate")
                        .HasColumnType("text");

                    b.Property<string>("logtime")
                        .HasColumnType("text");

                    b.Property<string>("logtype")
                        .HasColumnType("text");

                    b.Property<string>("process_user")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("app_loans_logs");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.AppLogs", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("activity")
                        .HasColumnType("text");

                    b.Property<string>("clientid")
                        .HasColumnType("text");

                    b.Property<string>("userdate")
                        .HasColumnType("text");

                    b.Property<string>("userid")
                        .HasColumnType("text");

                    b.Property<string>("userip")
                        .HasColumnType("text");

                    b.Property<string>("usertime")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("app_log");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.AppNotificationsSettings", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("clientid")
                        .HasColumnType("text");

                    b.Property<string>("emailbody")
                        .HasColumnType("text");

                    b.Property<string>("emailsubject")
                        .HasColumnType("text");

                    b.Property<string>("notificationid")
                        .HasColumnType("text");

                    b.Property<string>("smsbody")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("app_notifications_settings");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.AppNotificatonsTemplate", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("emailbody")
                        .HasColumnType("text");

                    b.Property<string>("emailsubject")
                        .HasColumnType("text");

                    b.Property<string>("notification")
                        .HasColumnType("text");

                    b.Property<string>("smsbody")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("app_notifications_templates");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.AppPermTables", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("perm")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("app_perm_table");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.AppRepayments", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("clientid")
                        .HasColumnType("text");

                    b.Property<string>("loanid")
                        .HasColumnType("text");

                    b.Property<string>("repaymentamount")
                        .HasColumnType("text");

                    b.Property<string>("repaymentcycle")
                        .HasColumnType("text");

                    b.Property<string>("repaymentdate")
                        .HasColumnType("text");

                    b.Property<string>("repaymentlog")
                        .HasColumnType("text");

                    b.Property<string>("repaymentmode")
                        .HasColumnType("text");

                    b.Property<string>("repaymentstatus")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("app_repayments");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.AppSettings", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("add1")
                        .HasColumnType("text");

                    b.Property<string>("add2")
                        .HasColumnType("text");

                    b.Property<string>("agentcompany")
                        .HasColumnType("text");

                    b.Property<string>("agentmarkup")
                        .HasColumnType("text");

                    b.Property<string>("agentphone")
                        .HasColumnType("text");

                    b.Property<string>("agenturl")
                        .HasColumnType("text");

                    b.Property<string>("appcolor1")
                        .HasColumnType("text");

                    b.Property<string>("appcolor2")
                        .HasColumnType("text");

                    b.Property<string>("appdomain")
                        .HasColumnType("text");

                    b.Property<string>("appdomainstatus")
                        .HasColumnType("text");

                    b.Property<string>("applogo")
                        .HasColumnType("text");

                    b.Property<string>("appname")
                        .HasColumnType("text");

                    b.Property<string>("bpmprice")
                        .HasColumnType("text");

                    b.Property<string>("clientalias")
                        .HasColumnType("text");

                    b.Property<int>("clientid")
                        .HasColumnType("int");

                    b.Property<string>("clientstatus")
                        .HasColumnType("text");

                    b.Property<string>("company")
                        .HasColumnType("text");

                    b.Property<string>("compslogan")
                        .HasColumnType("text");

                    b.Property<string>("country")
                        .HasColumnType("text");

                    b.Property<string>("currency")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("env")
                        .HasColumnType("text");

                    b.Property<string>("industry")
                        .HasColumnType("text");

                    b.Property<string>("logo")
                        .HasColumnType("text");

                    b.Property<string>("masterpin")
                        .HasColumnType("text");

                    b.Property<string>("smsid")
                        .HasColumnType("text");

                    b.Property<string>("startdate")
                        .HasColumnType("text");

                    b.Property<string>("state")
                        .HasColumnType("text");

                    b.Property<string>("summary")
                        .HasColumnType("text");

                    b.Property<string>("tel")
                        .HasColumnType("text");

                    b.Property<string>("url")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("AppSettings");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.AppSettingsPreferences", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("clientid")
                        .HasColumnType("text");

                    b.Property<string>("email_depletion")
                        .HasColumnType("text");

                    b.Property<string>("email_expire")
                        .HasColumnType("text");

                    b.Property<string>("email_statement")
                        .HasColumnType("text");

                    b.Property<string>("saleabovefixed")
                        .HasColumnType("text");

                    b.Property<string>("saleoutofstock")
                        .HasColumnType("text");

                    b.Property<string>("singlewarehouse")
                        .HasColumnType("text");

                    b.Property<string>("sms_alert")
                        .HasColumnType("text");

                    b.Property<string>("sms_alert_self")
                        .HasColumnType("text");

                    b.Property<string>("totalreversal")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("app_settings_preferences");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.AppUserPreferences", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("api_access")
                        .HasColumnType("text");

                    b.Property<string>("email_message")
                        .HasColumnType("text");

                    b.Property<string>("email_statement")
                        .HasColumnType("text");

                    b.Property<string>("free_transactions")
                        .HasColumnType("text");

                    b.Property<string>("invoice_autopay")
                        .HasColumnType("text");

                    b.Property<string>("sms_alert")
                        .HasColumnType("text");

                    b.Property<string>("social_feeds")
                        .HasColumnType("text");

                    b.Property<string>("userid")
                        .HasColumnType("text");

                    b.Property<string>("wallet_autorefill")
                        .HasColumnType("text");

                    b.Property<string>("wallet_transactions")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("app_user_preferences");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.AppUserPrivileges", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("perms")
                        .HasColumnType("text");

                    b.Property<string>("userid")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("app_user_privileges");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.Banks", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("bankname")
                        .HasColumnType("text");

                    b.Property<string>("cbncode")
                        .HasColumnType("text");

                    b.Property<string>("contactemail")
                        .HasColumnType("text");

                    b.Property<string>("contactname")
                        .HasColumnType("text");

                    b.Property<string>("contactphone")
                        .HasColumnType("text");

                    b.Property<DateTime>("createdat")
                        .HasColumnType("datetime");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<string>("routingno")
                        .HasColumnType("text");

                    b.Property<string>("sortcode")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedat")
                        .HasColumnType("datetime");

                    b.Property<int>("updatedby")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("banks");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.Collaterals", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("createdat")
                        .HasColumnType("datetime");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<int>("customerid")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("text");

                    b.Property<string>("location")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedat")
                        .HasColumnType("datetime");

                    b.Property<int>("updatedby")
                        .HasColumnType("int");

                    b.Property<decimal>("value")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("id");

                    b.ToTable("collaterals");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.Contacts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("category")
                        .HasColumnType("text");

                    b.Property<DateTime>("createdat")
                        .HasColumnType("datetime");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("firstname")
                        .HasColumnType("text");

                    b.Property<string>("lastname")
                        .HasColumnType("text");

                    b.Property<string>("middlename")
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedat")
                        .HasColumnType("datetime");

                    b.Property<int>("updatedby")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("contacts");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.Customers", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("bvn")
                        .HasColumnType("varchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("city")
                        .HasColumnType("text");

                    b.Property<string>("country")
                        .HasColumnType("text");

                    b.Property<DateTime>("createdat")
                        .HasColumnType("datetime");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<DateTime>("dob")
                        .HasColumnType("datetime");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("employeeno")
                        .HasColumnType("text");

                    b.Property<string>("firstname")
                        .HasColumnType("text");

                    b.Property<string>("imagepath")
                        .HasColumnType("text");

                    b.Property<string>("lastname")
                        .HasColumnType("text");

                    b.Property<string>("maritalstatus")
                        .HasColumnType("text");

                    b.Property<string>("middlename")
                        .HasColumnType("text");

                    b.Property<string>("phone")
                        .HasColumnType("text");

                    b.Property<string>("sex")
                        .HasColumnType("text");

                    b.Property<string>("state")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.Property<string>("street")
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedat")
                        .HasColumnType("datetime");

                    b.Property<int>("updatedby")
                        .HasColumnType("int");

                    b.Property<string>("workplace")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("customers");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.Disbursements", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("createdat")
                        .HasColumnType("datetime");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<string>("disbursementmode")
                        .HasColumnType("text");

                    b.Property<int>("loanid")
                        .HasColumnType("int");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.Property<string>("transactionreference")
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedat")
                        .HasColumnType("datetime");

                    b.Property<int>("updatedby")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("disbursements");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.Invoices", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("accountid")
                        .HasColumnType("int");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("createdat")
                        .HasColumnType("datetime");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<int>("customerid")
                        .HasColumnType("int");

                    b.Property<DateTime>("updatedat")
                        .HasColumnType("datetime");

                    b.Property<int>("updatedby")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("invoices");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.Loans", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("accountid")
                        .HasColumnType("int");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("amountleft")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("amountpaid")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("createdat")
                        .HasColumnType("datetime");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<int>("customerid")
                        .HasColumnType("int");

                    b.Property<decimal>("interestrate")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("lastpaymentdate")
                        .HasColumnType("datetime");

                    b.Property<string>("loanid")
                        .HasColumnType("text");

                    b.Property<string>("merchantid")
                        .HasColumnType("text");

                    b.Property<DateTime>("nextpaymentdate")
                        .HasColumnType("datetime");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedat")
                        .HasColumnType("datetime");

                    b.Property<int>("updatedby")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("loans");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.Mandates", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("accountid")
                        .HasColumnType("int");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("createdat")
                        .HasColumnType("datetime");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<int>("customerid")
                        .HasColumnType("int");

                    b.Property<string>("mandatereference")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedat")
                        .HasColumnType("datetime");

                    b.Property<int>("updatedby")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("mandates");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.Merchants", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cacnumber")
                        .HasColumnType("text");

                    b.Property<string>("city")
                        .HasColumnType("text");

                    b.Property<string>("contactemail")
                        .HasColumnType("text");

                    b.Property<string>("contactname")
                        .HasColumnType("text");

                    b.Property<string>("contactphone")
                        .HasColumnType("text");

                    b.Property<string>("country")
                        .HasColumnType("text");

                    b.Property<DateTime>("createdat")
                        .HasColumnType("datetime");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<string>("merchantname")
                        .HasColumnType("text");

                    b.Property<string>("state")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.Property<string>("street")
                        .HasColumnType("text");

                    b.Property<string>("updatedby")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("merchants");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.Payments", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("amount")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("createdat")
                        .HasColumnType("datetime");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<int>("loanid")
                        .HasColumnType("int");

                    b.Property<string>("paymentmode")
                        .HasColumnType("text");

                    b.Property<string>("paymentreference")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedat")
                        .HasColumnType("datetime");

                    b.Property<int>("updatedby")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("payments");
                });

            modelBuilder.Entity("DirectDebitApi.Entities.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("createdat")
                        .HasColumnType("datetime");

                    b.Property<int>("createdby")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("firstname")
                        .HasColumnType("text");

                    b.Property<string>("imagepath")
                        .HasColumnType("text");

                    b.Property<DateTime>("lastlogindate")
                        .HasColumnType("datetime");

                    b.Property<string>("lastname")
                        .HasColumnType("text");

                    b.Property<string>("merchantid")
                        .HasColumnType("text");

                    b.Property<string>("middlename")
                        .HasColumnType("text");

                    b.Property<string>("password")
                        .HasColumnType("text");

                    b.Property<string>("role")
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .HasColumnType("text");

                    b.Property<DateTime>("updatedat")
                        .HasColumnType("datetime");

                    b.Property<int>("updatedby")
                        .HasColumnType("int");

                    b.Property<string>("usertype")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("users");
                });
#pragma warning restore 612, 618
        }
    }
}
