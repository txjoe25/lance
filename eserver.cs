using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Net;

namespace Joe
{
    class Mail
    {
        static void Main(string[] args)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("txjoe75@gmail.com", "***"),
                EnableSsl = true
            };
            client.Send("txjoe75@gmail.com", "txjoe75@gmail.com", "test", "testbody");
            Console.WriteLine("Sent");
            Console.ReadLine();
        }
    }
}