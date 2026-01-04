using Microsoft.AspNetCore.Mvc;
using APMS.Frontend.Models;

namespace APMS.Frontend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // Mock data
            var machines = new List<Machine>
            {
                new Machine { Id = 1, Name = "Pump Assembly A1", Status = "healthy", Efficiency = 94, RiskLevel = "low", LastChecked = DateTime.Now },
                new Machine { Id = 2, Name = "Compressor B2", Status = "warning", Efficiency = 72, RiskLevel = "medium", LastChecked = DateTime.Now },
                new Machine { Id = 3, Name = "Motor Unit C3", Status = "healthy", Efficiency = 89, RiskLevel = "low", LastChecked = DateTime.Now },
                new Machine { Id = 4, Name = "Heat Exchanger D4", Status = "critical", Efficiency = 45, RiskLevel = "high", LastChecked = DateTime.Now },
                new Machine { Id = 5, Name = "Turbine E5", Status = "healthy", Efficiency = 91, RiskLevel = "low", LastChecked = DateTime.Now },
                new Machine { Id = 6, Name = "Valve Assembly F6", Status = "warning", Efficiency = 68, RiskLevel = "medium", LastChecked = DateTime.Now }
            };

            var alerts = new List<Alert>
            {
                new Alert { Id = 1, Severity = "critical", Message = "Heat Exchanger D4: Immediate maintenance required", CreatedAt = DateTime.Now.AddMinutes(-2), Time = "2 min ago" },
                new Alert { Id = 2, Severity = "warning", Message = "Compressor B2: Degradation detected, schedule maintenance", CreatedAt = DateTime.Now.AddMinutes(-15), Time = "15 min ago" },
                new Alert { Id = 3, Severity = "warning", Message = "Valve Assembly F6: Performance below threshold", CreatedAt = DateTime.Now.AddHours(-1), Time = "1 hour ago" },
                new Alert { Id = 4, Severity = "info", Message = "System backup completed successfully", CreatedAt = DateTime.Now.AddHours(-3), Time = "3 hours ago" }
            };

            var maintenanceSchedules = new List<MaintenanceSchedule>
            {
                new MaintenanceSchedule { Machine = "Pump Assembly A1", NextMaintenance = "2026-02-15", HoursRemaining = 336, Priority = "scheduled" },
                new MaintenanceSchedule { Machine = "Compressor B2", NextMaintenance = "2026-01-20", HoursRemaining = 48, Priority = "soon" },
                new MaintenanceSchedule { Machine = "Heat Exchanger D4", NextMaintenance = "2026-01-10", HoursRemaining = 8, Priority = "urgent" }
            };

            var viewModel = new DashboardViewModel
            {
                Machines = machines,
                Alerts = alerts,
                MaintenanceSchedules = maintenanceSchedules,
                SystemsOnline = machines.Count,
                AlertsPending = alerts.Count(a => a.Severity != "info"),
                AvgEfficiency = Math.Round(machines.Average(m => m.Efficiency), 1),
                CriticalIssues = machines.Count(m => m.RiskLevel == "high")
            };

            return View(viewModel);
        }
    }
}