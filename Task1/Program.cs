using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDbContext context = new MyDbContext();
            //context.Database.EnsureCreated();
            
            context.Countries.Add(new Country() { Name = "Ukrine" });
            context.Countries.Add(new Country() { Name = "Poland" });
            context.SaveChanges();
            foreach (var c in context.Countries)
            {
                Console.WriteLine("Country:"+c.Name);
            }

        }
    }
}
