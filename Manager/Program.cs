using crm.service.database;
using System;
using System.Linq;

namespace Manager
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CrmDataBaseContext())
            {
                // создаем два объекта User
                var Events1 = new EventLink { CrmKey = 123, lCKey = Guid.NewGuid(), Title = "Test EventLink", Type = "Seminar", PartTime = "FullTime", Department = "Study" };
                var Events2 = new EventLink { CrmKey = 321, lCKey = Guid.NewGuid(), Title = "Test EventLink 222", Type = "Program", PartTime = "HalfTim", Department = "Manage" };

                // добавляем их в бд
                db.Events.Add(Events1);
                db.Events.Add(Events2);
                db.SaveChanges();

                // получаем объекты из бд и выводим на консоль
                var Events = db.Events.ToList();
                Console.WriteLine("Users list:");
                foreach (var u in Events)
                {
                    Console.WriteLine($"{u.Id}.{u.Title} - {u.lCKey}");
                }
            }
            Console.Read();
        }
    }
}
