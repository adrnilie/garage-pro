namespace GaragePro.Services.Configuration
{
    using System.Configuration;

    public class ConfigSettings : IConfigSettings
    {
        private const string ClientIdKey = "ClientId";
        private const string ClientSecretKey = "ClientSecret";
        private const string RedirectUriKey = "RedirectUri";

        public string ClientId => GetConfigurationValue(ClientIdKey);
        public string ClientSecret => GetConfigurationValue(ClientSecretKey);
        public string RedirectUri => GetConfigurationValue(RedirectUriKey);

        private static string GetConfigurationValue(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}