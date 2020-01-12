using StopBeingJerk.ApplicationLogic.CarManagement;
using StopBeingJerk.DataAccess;
using StopBeingJerk.DataAccess.Comments;
using StopBeingJerk.Domain.Entities;
using StopBeingJerk.Mapper;
using StopBeingJerk.Web.Controllers;
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
                //List<RegistrationNumber> collection = context.RegistrationNumbers.ToList();
                //foreach (var item in collection.OrderBy(i => i.Id))
                //{
                //    System.Console.WriteLine($"{item.Id} - {item.Number}");
                //}

                CarController carController = new CarController(new CarService(new DtoMapper().mapper));
                var item = carController.GetCarInfo("СВ7743АЕ");

                System.Console.WriteLine(item.Result);
            }

        }
    }
}
