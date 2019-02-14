using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToets
{
    class Program
    {
        public static List<string> Ingredients;
        public static float Price = 0;

        static void Main(string[] args)
        {
            string DrinkOutput = null;
            AskIngredients();

            Console.Clear();
            Console.WriteLine("-----");
            Console.WriteLine("Je gekozen sandwich heeft " + Ingredients.Count + " ingredienten:");

            for (int i = 0; i < Ingredients.Count; i++)
            {
                Price += 1.20f;
                Console.WriteLine("- " + Ingredients[i] + " 1,20 euro");
            }
            Console.WriteLine("-----");
            Console.WriteLine("Het totaal bedrag is nu: " + Price + " euro.");

            DrinkOutput = AskDrinks();

            Console.WriteLine(DrinkOutput);
            Console.WriteLine("-----");
            Console.WriteLine("Het totaalbedrag voor dit is: " + Price + " euro.");
            Console.WriteLine("-----");
        }

        public static string AskDrinks()
        {
            string ReturnDrinkString = null;
            string UserInputHolder;
            string UserInput;

            string[] Drinks = new string[] {"cola", "appelsap", "koffie", "thee", "water"};

            Console.WriteLine("-----");
            Console.WriteLine("De beschikbare drankjes zijn:");

            for (int i = 0; i < Drinks.Length; i++)
            {
                Console.WriteLine("- " + Drinks[i]);
            }

            Console.WriteLine("Welk drankje wil je hebben?");
            
            //Hier zorg ik ervoor dat het niet hoofdletter gevoelig is, zodat daar geen fouten mee gemaakt kunnen worden, en het er netter uitziet
            UserInputHolder = Console.ReadLine();
            UserInput = UserInputHolder.ToLower();

            if (Drinks.Contains(UserInput))
            {
                int pos = Array.IndexOf(Drinks, UserInput);
                Price += 2.50f;
                ReturnDrinkString = "Je gekozen drankje is: " + Drinks[pos] + " - 2,5 euro";
            }

            else
            {
                Console.WriteLine("Dit drankje hebben wij niet.");
                ReturnDrinkString = null;
            }

            return ReturnDrinkString;
        }

        public static List<string> AskIngredients()
        {
            string UserInputHolder = null;
            string UserInput = null;

            Ingredients = new List<string>();
            bool isDone = false;

            Console.WriteLine("Wat voor ingrediënten wil je op je sandwich? Je betaalt 1,2 euro per toegevoegd ingredient.");

            while (!isDone)
            {
                UserInputHolder = Console.ReadLine();
                UserInput = UserInputHolder.ToLower();

                if (UserInput == "klaar")
                {
                    isDone = true;
                }

                else
                {
                    Ingredients.Add(UserInput);
                }
            }
            return Ingredients;
        }
    }
}
