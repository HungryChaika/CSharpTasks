using System;
using System.Net.Mail;
using System.Net;

//Напишите программу для отправки сообщений на почту. Как SMTP-сервер использовать сервер Яндекса (smtp.yandex.ru).
//Программа должна получать и валидировать с помощью регулярного выражения почтовый адрес.
//Сообщение для отправки может содержать любой текст. Ввод: электронная почта.

namespace Task_7
{
    class Programm
    {
        public static void Main(string[] args)
        {
            string? MailAdressOfRecipient;
            Console.Write("\nВведите адрес электронной почты получателя: ");
            MailAdressOfRecipient = Validation.ReadAndValidateMailAddress();
            MailMessage Message = new MailMessage();
            Message.From = new MailAddress("vologzhaninegor@yandex.ru");
            Message.To.Add(new MailAddress(MailAdressOfRecipient));
            Message.Subject = "Результат выполнения задания";
            Message.Body = "Программа работает";
            SmtpClient Client = new SmtpClient();
            Client.Host = "smtp.yandex.ru";
            Client.Port = 587;
            Client.EnableSsl = true;
            Client.Credentials = new NetworkCredential("vologzhaninegor@yandex.ru", "bzovlwklqmsztvxf");
            Client.Send(Message);
            Console.WriteLine("Готово!");
        }
    }
}