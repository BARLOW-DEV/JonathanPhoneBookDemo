using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LibraryDemo.MultiTenancy.HostDashboard.Dto;

namespace LibraryDemo.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}