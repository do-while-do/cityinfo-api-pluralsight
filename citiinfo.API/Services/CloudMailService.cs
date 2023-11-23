namespace citiinfo.API.Services
{
    public class CloudMailService : IMailService
    {
        private readonly string _mailTo = string.Empty;
        private readonly string _mailFrom = string.Empty;
        private readonly IConfiguration configuration;

        public CloudMailService(IConfiguration configuration)
        {
            this.configuration = configuration;
            _mailTo = this.configuration["mailSettings:mailToAddress"];
            _mailFrom = this.configuration["mailSettings:mailFromAddress"];
        }

        public void Send(string subject, string message)
        {
            Console.WriteLine($" Mail form {_mailFrom} to {_mailTo} with {nameof(CloudMailService)}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}