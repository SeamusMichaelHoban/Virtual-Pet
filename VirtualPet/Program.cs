using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {

            VirtualPets marley = new VirtualPets("Marley", 25, 5, 6 );
            Console.WriteLine("Welcome to Virtual Pets management Console");
            Console.WriteLine("Please type Yes to manage {0} ?", marley.Name);
            string userResponse = Console.ReadLine().ToLower();
            while (userResponse.Equals("yes"))
            {
                Console.WriteLine("Please select from the following to manage your Virtual Pet {0} ", marley.Name);

                Console.WriteLine("Select 1 to get the status of your Virtual Pet {0} ", marley.Name);
                Console.WriteLine("Select 2 to feed {0} food", marley.Name);
                Console.WriteLine("Select 3 to give {0} water", marley.Name);
                Console.WriteLine("Select 4 to take {0} outside to go potty", marley.Name);
                int userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                    marley.Tick();
                if (marley.HungerAlert)
                {
                    Console.WriteLine(" {0} is hungry {1} and needs to be fed some food.", marley.Name, marley.Hunger);
                    Console.WriteLine("Please enter how much food you would like to give {0} ", marley.Name);
                    int newHunger = int.Parse(Console.ReadLine());
                    marley.SetHunger(newHunger);
                }
                if (marley.ThirstAlert)
                {
                    Console.WriteLine(" {0}  is dehydrated and needs water.", marley.Name);
                    Console.WriteLine("Please enter how much water you want to give {0} ", marley.Name);
                    marley.SetThirst(int.Parse(Console.ReadLine()));
                }
                if (marley.WasteAlert)
                {
                    Console.WriteLine(" {0} hasnt been outside in a long time and needs to potty.", marley.Name);
                    Console.WriteLine("Please enter a new level of waste you want {0} to have left", marley.Name);
                    Console.WriteLine(" {0} hasnt been outside in a long time and needs to potty.", marley.Name);
                    marley.SetWaste(int.Parse(Console.ReadLine()));
                }
                    Console.WriteLine(" {0} now has a {1} hunger level and a {2} thirst level and a {3} waste level", marley.Name, marley.Hunger, marley.Thirst, marley.Waste);

                break;
                     case 2:
                        marley.Tick();
                        Console.WriteLine("Enter a new hunger level.");
                        int hunger = int.Parse(Console.ReadLine());
                        marley.SetHunger(hunger);
                        Console.WriteLine("The new depth of the {0} river is {1}", marley.Name, marley.Hunger);
                break;

                     case 3:
                        marley.Tick();
                        Console.WriteLine("Enter a new thirst level.");
                        int thirst = int.Parse(Console.ReadLine());
                        marley.SetThirst(thirst);
                         Console.WriteLine("The new thirst level of {0} is {1}", marley.Name, marley.Thirst);
                break;
                     case 4:
                        marley.Tick();
                        Console.WriteLine("Enter a new waste level.");
                        int waste = int.Parse(Console.ReadLine());
                        marley.SetWaste(waste);
                        Console.WriteLine("The new waste level of {0} is {1}", marley.Name, marley.Waste);
                break;
                default:
                break;
                }
            
            }
                    Console.WriteLine("Please type Yes to manage Virtual Pet {0} ?", marley.Name);
                    userResponse = Console.ReadLine().ToLower();






        }
    }
}
