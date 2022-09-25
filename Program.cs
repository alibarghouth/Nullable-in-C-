
namespace Quick_Launch_2
{


    class Program
    {
        static void Main(string[] args)
        {
            // var player = new PlayerCharacter();
            //PlayerCharacter player = null;
            //PlayerDisplayer.displayPlayer(player);
            //int days  = player.DaysSinceLastLogin.Value;
            // player.DaysSinceLastLogin = 10;
            //  PlayerDisplayer.displayPlayer(player);
            //  int days  = player?.DaysSinceLastLogin??-1;
            // Console.WriteLine(days);
            PlayerCharacter[] players = new PlayerCharacter[3]
            {
                new PlayerCharacter{Name = "ali"},
                new PlayerCharacter(),  //name is null
                null  //playerCharcter = null
            };  
            string p1= players?[0].Name; 
            string p2= players?[1].Name;
            string p3 = players?[2]?.Name??"ali";
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
   
            
        }
    }
}