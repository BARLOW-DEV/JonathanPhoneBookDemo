using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Acme.PhoneBookDemo.MultiTenancy.HostDashboard.Dto;

namespace Acme.PhoneBookDemo.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}