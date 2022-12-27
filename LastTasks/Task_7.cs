using System;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

//Напишите программу для отправки сообщений на почту. Как SMTP-сервер использовать сервер Яндекса (smtp.yandex.ru).
//Программа должна получать и валидировать с помощью регулярного выражения почтовый адрес.
//Сообщение для отправки может содержать любой текст. Ввод: электронная почта.

namespace LastTasks
{
    public class Task_7
    {
        private string? MailAdressOfRecipient = null;
        Regex Reg = new Regex("""(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])""");

        public void Init()
        {
            Console.Write("\nВведите адрес электронной почты получателя: ");
            MailAdressOfRecipient = Console.ReadLine();
        }
        public void ValidateMailAddress()
        {
            if (MailAdressOfRecipient is not null && Reg.IsMatch(MailAdressOfRecipient))
            {
                Console.WriteLine("\nАдрес получен.");
            }
            else
            {
                Console.WriteLine("\nВведённый адрес не прошёл валидацию.");
                Init();
                ValidateMailAddress();
            }
        }
        public void SendMessage()
        {
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
