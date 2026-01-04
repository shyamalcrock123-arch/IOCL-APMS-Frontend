namespace APMS.Frontend.Models
{
    public class Alert
    {
        public int Id { get; set; }
        public string? Severity { get; set; }
        public string? Message { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? Time { get; set; }
    }
}