using StopBeingJerk.DataAccess;
using StopBeingJerk.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Context context = new Context())
            {
                List<RegistrationNumber> collection = context.RegistrationNumbers.ToList();
                foreach (var item in collection.OrderBy(i => i.Id))
                {
                    System.Console.WriteLine($"{item.Id} - {item.Number}");
                }
            }
        }
    }
}
