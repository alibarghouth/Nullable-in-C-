using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Launch_2
{
    public class PlayerCharacter
    {
        public PlayerCharacter()
        {
         //   DateOfBirth = DateTime.MinValue; // magic number
           // DaysSinceLastLogin = -1; // magic number
            DaysSinceLastLogin = null; //NULLABLE
            DateOfBirth = null; //nullable
        }
        public String Name { get; set; }
        public int? DaysSinceLastLogin { get; set; }
        public DateTime? DateOfBirth { get; set; }
       
    }
}
