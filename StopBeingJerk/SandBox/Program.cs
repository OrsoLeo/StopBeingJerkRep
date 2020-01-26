using StopBeingJerk.ApplicationLogic.Comments;
using StopBeingJerk.DataAccess;
using StopBeingJerk.Dto.Comments;
using StopBeingJerk.Shared;
using System;

namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //using(Context context = new Context())
            //{
            //    var collection = context.RegistrationNumbers;
            //    foreach (var item in collection)
            //    {
            //        Console.WriteLine(item.Number);
            //    }
            //}

            var collection = EnumHelper.GetValuesForAutocomplete(typeof(CommentTopicType));
            foreach (var item in collection)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
