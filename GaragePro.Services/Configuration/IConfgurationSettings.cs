namespace GaragePro.Services.Configuration
{
    public interface IConfigurationSettings
    {
        string ClientId { get; }
        string ClientSecret { get; }
        string RedirectUri { get; }
    }
}