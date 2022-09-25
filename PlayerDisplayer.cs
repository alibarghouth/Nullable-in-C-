using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Launch_2
{
    public class PlayerDisplayer
    {
        public static void displayPlayer(PlayerCharacter player)
        {
            DateTime dateTime = player.DateOfBirth.GetValueOrDefault();
            //int DaysSinceLastLogin = player.DaysSinceLastLogin.GetValueOrDefault(122);
            //int DaysSinceLastLogin = player.DaysSinceLastLogin.HasValue?player.DaysSinceLastLogin.Value:-1;
            int DaysSinceLastLogin = player.DaysSinceLastLogin??-1;
            Console.WriteLine($"{DaysSinceLastLogin}");
            if (String.IsNullOrWhiteSpace(player.Name))
                Console.WriteLine("no Name");
            else
                Console.WriteLine(player.Name);
            //if (!player.DaysSinceLastLogin.HasValue)
            //{
              //  Console.WriteLine("no login");
            //    Console.WriteLine(DaysSinceLastLogin);
           // }
          //  else
                //Console.WriteLine(player.DaysSinceLastLogin.Value);
            if (!player.DateOfBirth.HasValue)
            {
                Console.WriteLine("no date of birth");
                //Console.WriteLine(player.DateOfBirth.Value);    Error

                Console.WriteLine(dateTime);
            }

            else
                Console.WriteLine(player.DateOfBirth.GetValueOrDefault());
        }
    }
}
