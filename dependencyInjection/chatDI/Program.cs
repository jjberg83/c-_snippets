// See https://aka.ms/new-console-template for more information

// Without dependency injection

UserService jjberg = new UserService(); // injecter ingenting her
jjberg.RegisterUser("jjberg83", "jjberg@gmailcom");

class EmailService
{
    public void SendEmail(string to, string message)
    {
        // code to send an email
        Console.WriteLine($"ToMail: {to}, TheMessage: {message}");
    }
}

class UserService
{
    private EmailService emailService = new EmailService();

    public void RegisterUser(string username, string email)
    {
        // register the user and send a welcome email
        emailService.SendEmail(email, "Welcome to our website");
    }
}


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