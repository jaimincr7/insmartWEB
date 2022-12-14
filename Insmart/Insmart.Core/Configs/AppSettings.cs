namespace Insmart.Core.Configs
{
    public class AppSettings
    {
        public static AppSettings Current { get; set; }
        public AppSettings()
        {
            Current = this;
        }
        public JWT JWT { get; set; }
        public int DefaultLanguageId { get; set; } = Constants.Engilish;
    }

    public class JWT
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpiryMinutes { get; set; }
    }
}
