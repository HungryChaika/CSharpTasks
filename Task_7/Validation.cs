using System;
using System.Text.RegularExpressions;

namespace Task_7
{
    public static class Validation
    {
        static Regex Reg = new Regex("""(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|"(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])""");
        public static string ReadAndValidateMailAddress()
        {
            string? MailAdressOfRecipient = Console.ReadLine();
            if (MailAdressOfRecipient is not null && Reg.IsMatch(MailAdressOfRecipient))
            {
                Console.WriteLine("\nАдрес получен.");
                return MailAdressOfRecipient;
            }
            else
            {
                Console.WriteLine("\nВведённый адрес не прошёл валидацию.");
                Console.Write("\nВведите адрес электронной почты получателя: ");
                return ReadAndValidateMailAddress();
            }
        }
    }
}
