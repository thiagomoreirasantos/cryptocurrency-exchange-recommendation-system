namespace CryptoCurrencyRecommendations.Api.Configurations
{
    public interface IApplicationSettings
    {
        public string ApiKey { get; }
        public string Url { get; }
        public string Main { get; }
    }
}