using StopBeingJerk.DataAccess;
using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Context context = new Context())
            {
                var collection = context.RegistrationNumbers;
                foreach (var item in collection)
                {
                    Console.WriteLine(item.Number);
                }
            }
        }
    }
}
