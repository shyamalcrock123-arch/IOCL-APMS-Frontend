namespace APMS.Frontend.Models
{
    public class MaintenanceSchedule
    {
        public string? Machine { get; set; }
        public string? NextMaintenance { get; set; }
        public int HoursRemaining { get; set; }
        public string? Priority { get; set; }
    }
}