namespace PlanningBet.Core.Config
{
    public class ConfigAppSettings
    {
        public string SecretKey { get; set; }
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int ExpireTimeInHours { get; set; }
    }
}
