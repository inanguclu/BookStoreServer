using GenericEmailService;
using System.Net.Mail;

namespace BookStoreServer.WebApi.Services;

public static class MailService
{
    public static async Task<string> SendEmailAsync(string email, string subject, string body)
    {
        EmailConfigurations configurations = new(
            Smtp: "smtp.example.com",
            Password: "password",
            Port: 587,
            SSL: true,
            Html: true);

        List<string> emails = new() { email };

        EmailModel<Stream> model = new(
            Configurations: configurations,
            FromEmail: "mymail@gmail.com",
            ToEmails: emails,
            Subject: subject,
            Body: body,
            Attachments: null);


        string response = await EmailService.SendEmailWithMailKitAsync(model);

    }
}
