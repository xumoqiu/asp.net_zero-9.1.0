using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DynasysSolution.MultiTenancy.HostDashboard.Dto;

namespace DynasysSolution.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}