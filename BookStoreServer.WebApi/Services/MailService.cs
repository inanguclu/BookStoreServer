using GenericEmailService;
using System.Net.Mail;

namespace BookStoreServer.WebApi.Services;

public static class MailService
{
    public static async Task<string> SendEmailAsync (string email, string subject, string body)
    {
        EmailConfigurations configurations = new(
            Smtp: "smtp.office365.com",
            Password: "Iyzico.3838",
            Port: 587,
            SSL: false,
            Html: true);

        List<string> emails = new() { email };

        EmailModel<Stream> model = new(
            Configurations: configurations,
            FromEmail: "iyzico3838@hotmail.com",
            ToEmails: emails,
            Subject: subject,
            Body: body,
            Attachments: null);


        string response = await EmailService.SendEmailWithMailKitAsync(model);


        return response;

    }
}
