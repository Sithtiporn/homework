    class Program
    {
        static void Main(string[] args)
        {
            string menu;
            int dayOfWeek, timeOfDay;
            int breakfastSet = 5;
            int weekendSet = 2;
            int coffee = 3;

            
            Console.WriteLine("Please enter a number from 1 to 7 to represent the day of the week:");
            Console.WriteLine("1: Monday, 2: Tuesday, 3: Wednesday, 4: Thursday, 5: Friday, 6: Saturday, 7: Sunday");
            dayOfWeek = int.Parse(Console.ReadLine());

            
            Console.WriteLine("Please enter a number from 8 to 18 to represent the time of day (in 24-hour format):");
            Console.WriteLine("8:00 AM to 6:00 PM");
            timeOfDay = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Please enter your menu choice:");
                Console.WriteLine("1. Breakfast Set");
                Console.WriteLine("2. Weekend Set");
                Console.WriteLine("3. Coffee");
                Console.WriteLine("Type 'End' to exit.");
                menu = Console.ReadLine();

                if (menu == "End")
                {
                    break;
                }
                else if (menu == "Breakfast Set")
                {
                    if (timeOfDay > 11)
                    {
                        Console.WriteLine("Sorry your order is not available");
                        continue;
                    }
                     if (breakfastSet == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                        continue;
                 }
              }
          }
     }
}