using System;
using System.Linq;

namespace Module15
{
    class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new List<Contact>() 
            { 
                new Contact("Игорь", 79990000001, "igor@example.com"),
                new Contact("Сергей", 79990000010, "serge@example.com"),
                new Contact("Анатолий", 79990000011, "anatoly@example.com"),
                new Contact("Валерий", 79990000012, "valera@example.com"),
                new Contact("Сергей", 799900000013, "serg@gmail.com"),
                new Contact("Иннокентий", 799900000013, "innokentii@example.com")
            };

            var checkEmail = phoneBook.GroupBy(x => x.Email.Contains("example"));

            foreach (var contact in checkEmail)
            {
                Console.WriteLine(contact.Key);

                foreach (var contact2 in contact)
                    Console.WriteLine(contact2.Name);
            }

            ////  в качестве критерия группировки передаем домен адреса электронной почты
            //var grouped = phoneBook.GroupBy(c => c.Email.Split("@").Last());

            //// обрабатываем получившиеся группы
            //foreach (var group in grouped)
            //{
            //    // если ключ содержит example, значит, это фейк
            //    if (group.Key.Contains("example"))
            //    {
            //        Console.WriteLine("Фейковые адреса: ");

            //        foreach (var contact in group)
            //            Console.WriteLine(contact.Name + " " + contact.Email);

            //    }
            //    else
            //    {
            //        Console.WriteLine("Реальные адреса: ");
            //        foreach (var contact in group)
            //            Console.WriteLine(contact.Name + " " + contact.Email);
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}