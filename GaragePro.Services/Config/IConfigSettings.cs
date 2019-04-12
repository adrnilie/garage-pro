namespace GaragePro.Services.Configuration
{
    public interface IConfigSettings
    {
        string ClientId { get; }
        string ClientSecret { get; }
        string RedirectUri { get; }
    }
}