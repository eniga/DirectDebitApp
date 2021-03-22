using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DirectDebitApi.Entities;
using DirectDebitApi.Repositories;
using DirectDebitApi.Services.AppRepayment;
using MicroOrm.Dapper.Repositories;
using Microsoft.EntityFrameworkCore.Internal;

namespace DirectDebitApi.Services.AppLoan
{
    public class AppLoanService : GenericRepository<AppLoans>, IAppLoanService
    {
        private IAppRepaymentService repaymentService;

        public AppLoanService(DapperRepository<AppLoans> repository, IAppRepaymentService repaymentService) : base(repository)
        {
            this.repaymentService = repaymentService;
        }

        public async Task<int> AddRepayments(AppLoans items)
        {
            var record = await repaymentService.GetAllAsync(x => x.loanid == items.loanid);
            if (record.Any())
                return await Task.FromResult(1);
            int cycle = int.Parse(items.loanrepaycycle);
            decimal total = decimal.Add(items.insurance_amount, decimal.Parse(items.loanamount)) + decimal.Add(decimal.Parse(items.loaninterest), items.management_fee);
            decimal amount = decimal.Divide(total, cycle);
            List<AppRepayments> repayments = new List<AppRepayments>();
            int start = 1;
            while(start <= cycle)
            {
                AppRepayments repayment = new AppRepayments()
                {
                    clientid = items.clientid,
                    id = 0,
                    loanid = items.loanid,
                    repaymentamount = amount.ToString(),
                    repaymentcycle = start.ToString(),
                    repaymentdate = DateTime.Parse(items.loanapprovedate).AddMonths(start).ToString("yyyy-MM-dd"),
                    repaymentstatus = "Pending"
                };
                repayments.Add(repayment);
                start++;
            }
            var result = await repaymentService.AddBulkAsync(repayments);
            return result;
        }
    }
}
