using APMS.Frontend.Models;

namespace APMS.Frontend.Models
{
    public class DashboardViewModel
    {
        public List<Machine> Machines { get; set; } = new();
        public List<Alert> Alerts { get; set; } = new();
        public List<MaintenanceSchedule> MaintenanceSchedules { get; set; } = new();
        
        public int SystemsOnline { get; set; }
        public int AlertsPending { get; set; }
        public double AvgEfficiency { get; set; }
        public int CriticalIssues { get; set; }
    }
}