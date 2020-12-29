using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace DirectDebitApi.Migrations
{
    public partial class DBInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    accountno = table.Column<string>(nullable: true),
                    customerid = table.Column<int>(nullable: false),
                    bankid = table.Column<int>(nullable: false),
                    createdat = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<int>(nullable: false),
                    updatedat = table.Column<DateTime>(nullable: false),
                    updatedby = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "app_bunits",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    clientid = table.Column<string>(nullable: true),
                    bunitid = table.Column<string>(nullable: true),
                    unitname = table.Column<string>(nullable: true),
                    frontend = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    businessnature = table.Column<string>(nullable: true),
                    startupcapital = table.Column<string>(nullable: true),
                    env = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    mainbunit = table.Column<string>(nullable: true),
                    mod_fx = table.Column<string>(nullable: true),
                    mod_inv = table.Column<string>(nullable: true),
                    mod_hotelrooms = table.Column<string>(nullable: true),
                    mod_restaurant = table.Column<string>(nullable: true),
                    mod_sms = table.Column<string>(nullable: true),
                    mod_payroll = table.Column<string>(nullable: true),
                    policy_autoapproval = table.Column<string>(nullable: true),
                    policy_outstock = table.Column<string>(nullable: true),
                    policy_abovefixed = table.Column<string>(nullable: true),
                    policy_directsales = table.Column<string>(nullable: true),
                    policy_autocash = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_bunits", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "app_loans",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    loanbatchid = table.Column<string>(nullable: true),
                    loanid = table.Column<string>(nullable: true),
                    clientid = table.Column<string>(nullable: true),
                    bvn = table.Column<int>(nullable: false),
                    tel = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    fullname = table.Column<string>(nullable: true),
                    loanstatus = table.Column<string>(nullable: true),
                    loanamount = table.Column<string>(nullable: true),
                    loanapplydate = table.Column<string>(nullable: true),
                    loanduedate = table.Column<string>(nullable: true),
                    loaninterest = table.Column<string>(nullable: true),
                    loanrepaycycle = table.Column<string>(nullable: true),
                    loantotal = table.Column<string>(nullable: true),
                    loanapprovedate = table.Column<string>(nullable: true),
                    process_status = table.Column<string>(nullable: true),
                    process_date = table.Column<string>(nullable: true),
                    process_time = table.Column<string>(nullable: true),
                    process_user = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_loans", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "app_loans_logs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    loanbatchid = table.Column<string>(nullable: true),
                    loanid = table.Column<string>(nullable: true),
                    clientid = table.Column<string>(nullable: true),
                    logtype = table.Column<string>(nullable: true),
                    logdate = table.Column<string>(nullable: true),
                    logtime = table.Column<string>(nullable: true),
                    activity = table.Column<string>(nullable: true),
                    process_user = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_loans_logs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "app_log",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    clientid = table.Column<string>(nullable: true),
                    userid = table.Column<string>(nullable: true),
                    activity = table.Column<string>(nullable: true),
                    userip = table.Column<string>(nullable: true),
                    usertime = table.Column<string>(nullable: true),
                    userdate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_log", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "app_notifications_settings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    clientid = table.Column<string>(nullable: true),
                    notificationid = table.Column<string>(nullable: true),
                    emailsubject = table.Column<string>(nullable: true),
                    emailbody = table.Column<string>(nullable: true),
                    smsbody = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_notifications_settings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "app_notifications_templates",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    notification = table.Column<string>(nullable: true),
                    emailsubject = table.Column<string>(nullable: true),
                    emailbody = table.Column<string>(nullable: true),
                    smsbody = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_notifications_templates", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "app_perm_table",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    perm = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_perm_table", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "app_repayments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    loanid = table.Column<string>(nullable: true),
                    clientid = table.Column<string>(nullable: true),
                    repaymentstatus = table.Column<string>(nullable: true),
                    repaymentamount = table.Column<string>(nullable: true),
                    repaymentdate = table.Column<string>(nullable: true),
                    repaymentcycle = table.Column<string>(nullable: true),
                    repaymentmode = table.Column<string>(nullable: true),
                    repaymentlog = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_repayments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "app_settings_preferences",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    clientid = table.Column<string>(nullable: true),
                    singlewarehouse = table.Column<string>(nullable: true),
                    email_statement = table.Column<string>(nullable: true),
                    sms_alert = table.Column<string>(nullable: true),
                    email_expire = table.Column<string>(nullable: true),
                    email_depletion = table.Column<string>(nullable: true),
                    saleabovefixed = table.Column<string>(nullable: true),
                    saleoutofstock = table.Column<string>(nullable: true),
                    totalreversal = table.Column<string>(nullable: true),
                    sms_alert_self = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_settings_preferences", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "app_user_preferences",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    userid = table.Column<string>(nullable: true),
                    email_message = table.Column<string>(nullable: true),
                    email_statement = table.Column<string>(nullable: true),
                    sms_alert = table.Column<string>(nullable: true),
                    invoice_autopay = table.Column<string>(nullable: true),
                    wallet_autorefill = table.Column<string>(nullable: true),
                    api_access = table.Column<string>(nullable: true),
                    social_feeds = table.Column<string>(nullable: true),
                    wallet_transactions = table.Column<string>(nullable: true),
                    free_transactions = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_user_preferences", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "app_user_privileges",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    userid = table.Column<string>(nullable: true),
                    perms = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_app_user_privileges", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AppSettings",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    clientid = table.Column<int>(nullable: false),
                    clientalias = table.Column<string>(nullable: true),
                    clientstatus = table.Column<string>(nullable: true),
                    company = table.Column<string>(nullable: true),
                    industry = table.Column<string>(nullable: true),
                    compslogan = table.Column<string>(nullable: true),
                    currency = table.Column<string>(nullable: true),
                    add1 = table.Column<string>(nullable: true),
                    add2 = table.Column<string>(nullable: true),
                    tel = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    logo = table.Column<string>(nullable: true),
                    startdate = table.Column<string>(nullable: true),
                    summary = table.Column<string>(nullable: true),
                    env = table.Column<string>(nullable: true),
                    smsid = table.Column<string>(nullable: true),
                    masterpin = table.Column<string>(nullable: true),
                    applogo = table.Column<string>(nullable: true),
                    appname = table.Column<string>(nullable: true),
                    appcolor1 = table.Column<string>(nullable: true),
                    appcolor2 = table.Column<string>(nullable: true),
                    appdomainstatus = table.Column<string>(nullable: true),
                    appdomain = table.Column<string>(nullable: true),
                    bpmprice = table.Column<string>(nullable: true),
                    agentmarkup = table.Column<string>(nullable: true),
                    agentphone = table.Column<string>(nullable: true),
                    agenturl = table.Column<string>(nullable: true),
                    agentcompany = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSettings", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "banks",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    bankname = table.Column<string>(nullable: true),
                    cbncode = table.Column<string>(nullable: true),
                    routingno = table.Column<string>(nullable: true),
                    sortcode = table.Column<string>(nullable: true),
                    createdat = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<int>(nullable: false),
                    updatedat = table.Column<DateTime>(nullable: false),
                    updatedby = table.Column<int>(nullable: false),
                    contactname = table.Column<string>(nullable: true),
                    contactphone = table.Column<string>(nullable: true),
                    contactemail = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_banks", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "collaterals",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    description = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    value = table.Column<decimal>(nullable: false),
                    customerid = table.Column<int>(nullable: false),
                    createdat = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<int>(nullable: false),
                    updatedat = table.Column<DateTime>(nullable: false),
                    updatedby = table.Column<int>(nullable: false),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_collaterals", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "contacts",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    firstname = table.Column<string>(nullable: true),
                    middlename = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    category = table.Column<string>(nullable: true),
                    createdat = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<int>(nullable: false),
                    updatedat = table.Column<DateTime>(nullable: false),
                    updatedby = table.Column<int>(nullable: false),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contacts", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    firstname = table.Column<string>(nullable: true),
                    middlename = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    dob = table.Column<DateTime>(nullable: false),
                    street = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    bvn = table.Column<string>(maxLength: 11, nullable: true),
                    createdat = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<int>(nullable: false),
                    updatedat = table.Column<DateTime>(nullable: false),
                    updatedby = table.Column<int>(nullable: false),
                    sex = table.Column<string>(nullable: true),
                    maritalstatus = table.Column<string>(nullable: true),
                    workplace = table.Column<string>(nullable: true),
                    employeeno = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    imagepath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "disbursements",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    amount = table.Column<decimal>(nullable: false),
                    loanid = table.Column<int>(nullable: false),
                    transactionreference = table.Column<string>(nullable: true),
                    createdat = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<int>(nullable: false),
                    updatedat = table.Column<DateTime>(nullable: false),
                    updatedby = table.Column<int>(nullable: false),
                    disbursementmode = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_disbursements", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "invoices",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    amount = table.Column<decimal>(nullable: false),
                    customerid = table.Column<int>(nullable: false),
                    accountid = table.Column<int>(nullable: false),
                    createdat = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<int>(nullable: false),
                    updatedat = table.Column<DateTime>(nullable: false),
                    updatedby = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_invoices", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "loans",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    loanid = table.Column<string>(nullable: true),
                    amount = table.Column<decimal>(nullable: false),
                    customerid = table.Column<int>(nullable: false),
                    accountid = table.Column<int>(nullable: false),
                    interestrate = table.Column<decimal>(nullable: false),
                    createdat = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<int>(nullable: false),
                    updatedat = table.Column<DateTime>(nullable: false),
                    updatedby = table.Column<int>(nullable: false),
                    merchantid = table.Column<string>(nullable: true),
                    lastpaymentdate = table.Column<DateTime>(nullable: false),
                    nextpaymentdate = table.Column<DateTime>(nullable: false),
                    amountpaid = table.Column<decimal>(nullable: false),
                    amountleft = table.Column<decimal>(nullable: false),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loans", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "mandates",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    customerid = table.Column<int>(nullable: false),
                    amount = table.Column<decimal>(nullable: false),
                    mandatereference = table.Column<string>(nullable: true),
                    accountid = table.Column<int>(nullable: false),
                    createdat = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<int>(nullable: false),
                    updatedat = table.Column<DateTime>(nullable: false),
                    updatedby = table.Column<int>(nullable: false),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mandates", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "merchants",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    merchantname = table.Column<string>(nullable: true),
                    street = table.Column<string>(nullable: true),
                    city = table.Column<string>(nullable: true),
                    state = table.Column<string>(nullable: true),
                    country = table.Column<string>(nullable: true),
                    cacnumber = table.Column<string>(nullable: true),
                    contactname = table.Column<string>(nullable: true),
                    contactphone = table.Column<string>(nullable: true),
                    contactemail = table.Column<string>(nullable: true),
                    createdat = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<int>(nullable: false),
                    updatedby = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_merchants", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    loanid = table.Column<int>(nullable: false),
                    paymentreference = table.Column<string>(nullable: true),
                    amount = table.Column<decimal>(nullable: false),
                    createdat = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<int>(nullable: false),
                    updatedat = table.Column<DateTime>(nullable: false),
                    updatedby = table.Column<int>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    paymentmode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    firstname = table.Column<string>(nullable: true),
                    middlename = table.Column<string>(nullable: true),
                    lastname = table.Column<string>(nullable: true),
                    usertype = table.Column<string>(nullable: true),
                    merchantid = table.Column<string>(nullable: true),
                    createdat = table.Column<DateTime>(nullable: false),
                    createdby = table.Column<int>(nullable: false),
                    updatedat = table.Column<DateTime>(nullable: false),
                    updatedby = table.Column<int>(nullable: false),
                    status = table.Column<string>(nullable: true),
                    lastlogindate = table.Column<DateTime>(nullable: false),
                    role = table.Column<string>(nullable: true),
                    imagepath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "app_bunits");

            migrationBuilder.DropTable(
                name: "app_loans");

            migrationBuilder.DropTable(
                name: "app_loans_logs");

            migrationBuilder.DropTable(
                name: "app_log");

            migrationBuilder.DropTable(
                name: "app_notifications_settings");

            migrationBuilder.DropTable(
                name: "app_notifications_templates");

            migrationBuilder.DropTable(
                name: "app_perm_table");

            migrationBuilder.DropTable(
                name: "app_repayments");

            migrationBuilder.DropTable(
                name: "app_settings_preferences");

            migrationBuilder.DropTable(
                name: "app_user_preferences");

            migrationBuilder.DropTable(
                name: "app_user_privileges");

            migrationBuilder.DropTable(
                name: "AppSettings");

            migrationBuilder.DropTable(
                name: "banks");

            migrationBuilder.DropTable(
                name: "collaterals");

            migrationBuilder.DropTable(
                name: "contacts");

            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "disbursements");

            migrationBuilder.DropTable(
                name: "invoices");

            migrationBuilder.DropTable(
                name: "loans");

            migrationBuilder.DropTable(
                name: "mandates");

            migrationBuilder.DropTable(
                name: "merchants");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
