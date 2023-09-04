// See https://aka.ms/new-console-template for more information
using System;
using Microsoft.Extensions.DependencyInjection;

// Without dependency injection

// UserService jjberg = new UserService(); // injecter ingenting her
// jjberg.RegisterUser("jjberg83", "jjberg@gmailcom");

// class EmailService
// {
//     public void SendEmail(string to, string message)
//     {
//         // code to send an email
//         Console.WriteLine($"ToMail: {to}, TheMessage: {message}");
//     }
// }

// class UserService
// {
//     private EmailService emailService = new EmailService();

//     public void RegisterUser(string username, string email)
//     {
//         // register the user and send a welcome email
//         emailService.SendEmail(email, "Welcome to our website");
//     }
// }


// with dependency injection

// UserService jjberg = new UserService(new EmailService());
// jjberg.RegisterUser("jjberg83", "jjberg@gmailcom");

// interface IEmailService
// {
//     void SendEmail(string to, string message);
// }

// class EmailService : IEmailService
// {
//     public void SendEmail(string to, string message)
//     {
//         // code to send email
//         Console.WriteLine($"ToMail: {to}, TheMessage: {message}");
//     }
// }

// class UserService
// {
//     private readonly IEmailService emailService;

//     public UserService(IEmailService emailService) // konstruktør krever at instans må injectes
//     {
//         this.emailService = emailService;
//     }

//     public void RegisterUser(string username, string email)
//     {
//         // register the user and send a welcome email
//         emailService.SendEmail(email, "Welcome to our website");
//     }
// }

// EKSEMPEL SOM VISER HVORDAN USERSERVICE BLIR UANFEKTET NÅR
// MAN BRUKER DEPENDENCY INJECTION

var serviceProvider = new ServiceCollection()
                      .AddSingleton<IEmailService, SmtpEmailService>()
                      .AddSingleton<UserService>()
                      .BuildServiceProvider();

var userService = serviceProvider.GetRequiredService<UserService>();

userService.RegisterUser("ajberg83", "audunjb@gmail.com");


interface IEmailService
{
    void SendEmail(string to, string message);
}

// Her kommer ny implementasjon av IEmailService (steg 1)
class SmtpEmailService : IEmailService
{
    public void SendEmail(string to, string message)
    {
        // code to send email
        Console.WriteLine($"ToMail: {to}, TheMessage: {message}, Implementation: SmtpEmailService");
    }
}

class EmailService : IEmailService
{
    public void SendEmail(string to, string message)
    {
        // code to send email
        Console.WriteLine($"ToMail: {to}, TheMessage: {message}, Implementation: EmailService");
    }
}

class UserService
{
    private readonly IEmailService emailService;

    public UserService(IEmailService emailService) // konstruktør krever at instans må injectes
    {
        this.emailService = emailService;
    }

    // uten DI ville de to blokkene kokt ned til følgende
    // (som jeg måttet skiftet mellom, alt etter hvilken jeg ville bruke)
    // (mao, jeg måtte endret kode inni UserService klassen)
    // private SmtpEmailService emailService = new SmtpEmailService();
    // private SmtpEmailService emailService = new EmailService();

    public void RegisterUser(string username, string email)
    {
        // register the user and send a welcome email
        emailService.SendEmail(email, "Welcome to our website");
    }
}