namespace APMS.Frontend.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public double Efficiency { get; set; }
        public string? RiskLevel { get; set; }
        public DateTime LastChecked { get; set; }
    }
}