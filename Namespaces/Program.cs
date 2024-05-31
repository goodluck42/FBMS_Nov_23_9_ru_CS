using MailKit.Net.Smtp;
using System.Net.Mail;
using System.Security.Cryptography;

using Namespaces;
using static System.Console;

using CUOException = System.Security.Cryptography.CryptographicUnexpectedOperationException;

Player player = new Player();
GameService service = new GameService();

try
{
    WriteLine();
    ReadLine();
    
    MailKit.Net.Smtp.SmtpClient client1 = new MailKit.Net.Smtp.SmtpClient();
    System.Net.Mail.SmtpClient client2 = new System.Net.Mail.SmtpClient();
    // ... some code
    
    
}
catch (Exception ex)
{
    // var cast2 = (ArgumentNullException)ex; // static_cast
    //
    // //
    // dynamic_cast<ArgumentNullException*>(ex) != nullptr
    // if (ex is ArgumentNullException cast)
    // {
    //     // ArgumentNullException? cast = ex as ArgumentNullException; // dynamic_cast<ArgumentNullException*>(ex)
    // }
    
    Console.WriteLine(ex.Message);
    
}