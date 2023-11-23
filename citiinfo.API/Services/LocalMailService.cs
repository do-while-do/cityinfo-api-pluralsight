namespace citiinfo.API.Services
{
    public class LocalMailService : IMailService
    {
        private readonly IConfiguration configuration;
        private readonly string _mailTo = string.Empty;
        private readonly string _mailFrom = string.Empty;

        public LocalMailService(IConfiguration configuration)
        {
            this.configuration = configuration;
            _mailTo = this.configuration["mailSettings:mailToAddress"];
            _mailFrom = this.configuration["mailSettings:mailFromAddress"];
        }

        public void Send(string subject, string message)
        {
            Console.WriteLine($" Mail form {_mailFrom} to {_mailTo} with {nameof(LocalMailService)}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Message: {message}");
        }
    }
}