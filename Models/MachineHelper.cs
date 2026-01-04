namespace APMS.Frontend.Models
{
    public static class MachineHelper
    {
        public static string GetRiskColor(string? riskLevel)
        {
            return riskLevel switch
            {
                "low" => "text-green-500",
                "medium" => "text-yellow-500",
                "high" => "text-red-600",
                _ => "text-gray-500"
            };
        }

        public static string GetBarColor(double efficiency)
        {
            if (efficiency >= 80) return "bg-green-500";
            if (efficiency >= 70) return "bg-yellow-500";
            return "bg-red-500";
        }

        public static string GetPriorityClass(string? priority)
        {
            return priority switch
            {
                "urgent" => "bg-red-900 text-red-200",
                "soon" => "bg-yellow-900 text-yellow-200",
                _ => "bg-green-900 text-green-200"
            };
        }

        public static string GetAlertBorderColor(string? severity)
        {
            return severity switch
            {
                "critical" => "border-red-600 bg-red-900 bg-opacity-30",
                "warning" => "border-yellow-500 bg-yellow-900 bg-opacity-30",
                _ => "border-blue-500 bg-blue-900 bg-opacity-30"
            };
        }

        public static string GetAlertTextColor(string? severity)
        {
            return severity switch
            {
                "critical" => "text-red-400",
                "warning" => "text-yellow-400",
                _ => "text-blue-400"
            };
        }
    }
}