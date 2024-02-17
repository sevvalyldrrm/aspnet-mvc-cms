namespace Cms.WebAPI.Services.Abstract
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string to, string subject, string body);
    }
}
