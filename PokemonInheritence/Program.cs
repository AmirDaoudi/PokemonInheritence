using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

namespace PokemonInheritence
{
    internal class Program
    {
        //makse abstract pokemon class with:
        //abstract string type
        //abstract string secondary type
        //abstract function for each of 3 moves

        //Make seperate class for
        //different pokemon that all inherit the pokemon class

        //Make menu system to choose and fight pokemon
        static Pokemon[] pokemons =
         {
                new Charizard(),
                new Toedschool(),
                new Jynx(),
                new Onix(),
                new Exeggutor(),
                new DewGong(),
                new PrimeApe()
        };
        static bool playAgain()
        {
            Console.WriteLine("Would you like to play again y/n");
            string decision = Console.ReadLine();
            if (decision == "y")
            {
                return true;
            }
            else if (decision == "n")
            {
                return false;
            }
            else
            { 
                Console.WriteLine("Invalid! Auto Exit!");
                return false;
            }
        }
        static bool CheckDead(int userPokemon, int aiPokemon)
        {
            if (pokemons[userPokemon].Health <= 0)
            {
                Console.WriteLine("GAME OVER YOU LOSE");
                return true;
            }
            else if (pokemons[aiPokemon].Health <= 0)
            {
                Console.WriteLine("YOU WIN");
                return true;
            }
            else
            {
                Console.WriteLine(pokemons[userPokemon].HealthCheck());
                Console.WriteLine(pokemons[aiPokemon].HealthCheck());
                return false;
            }
        }
        static void AiFight(int userPokemon, int aipokemon, int randommove)
        {
            int damagetouser = 0;
            switch (randommove)
            {
                case 1:
                    damagetouser = pokemons[aipokemon].Move1();
                    Console.WriteLine($"Opponent pokemon elected to use move 1");
                    break;
                case 2:        
                    damagetouser = pokemons[aipokemon].Move2();
                    Console.WriteLine($"Opponent pokemon elected to use move 2");
                    break;
                case 3:        
                    damagetouser = pokemons[aipokemon].Move3();
                    Console.WriteLine($"Opponent pokemon elected to use move 3");
                    break;
            }
            pokemons[userPokemon].Health = pokemons[userPokemon].Health - damagetouser;
        }
        
        static void Fighting(int userPokemon, int aipokemon)
        {
            Random rand = new Random();
            int randommove = rand.Next(3);
            Console.WriteLine(pokemons[userPokemon].Print());
            while (CheckDead(userPokemon, aipokemon) == false)
            {
                randommove = rand.Next(3);
                Console.WriteLine(pokemons[userPokemon].MoveDisplay());
                string MoveChoice = Console.ReadLine();
                int damagetoopponent = 0;
                switch (MoveChoice)
                {
                    case "1":
                        damagetoopponent = pokemons[userPokemon].Move1();                     
                        break;
                    case "2":
                        damagetoopponent = pokemons[userPokemon].Move2();
                        break;
                    case "3":
                        damagetoopponent = pokemons[userPokemon].Move3();                       
                        break;

                }
                pokemons[aipokemon].Health = pokemons[aipokemon].Health - damagetoopponent;
                if (CheckDead(userPokemon, aipokemon)) break;
                AiFight(userPokemon, aipokemon, randommove);
            }

        }
        static void Main(string[] args)
        {
             int userchosenI = 0;
            Console.WriteLine("Hello please enter name:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Welcome to Pokemon fighter " + UserName);
            Random r = new Random();
            int randomPokemon = r.Next(7);
            Console.WriteLine("You stumble upon a " + pokemons[randomPokemon].Name);
            Console.WriteLine("Would you like to fight this pokemon yes or no");
            string fightDecision = Console.ReadLine();
            fightDecision = fightDecision.ToLower();
            if (fightDecision == "yes")
            {
                Console.WriteLine($"which pokemon would you like to select out of: ");
                for (int i = 0; i < pokemons.Length; i++)
                {
                    Console.WriteLine(pokemons[i].Name);
                }
                string FighterPokemonChoice = Console.ReadLine();
                for (int i = 0; i < pokemons.Length; i++)
                {
                    if (FighterPokemonChoice == pokemons[i].Name)
                    {
                        userchosenI = i; 
                    }
                }
                while (userchosenI == 0 && FighterPokemonChoice != "Charizard")
                {
                    Console.WriteLine("Invalid! Please try again.");
                    FighterPokemonChoice = Console.ReadLine();
                    for (int i = 0; i < pokemons.Length; i++)
                    {
                        if (FighterPokemonChoice == pokemons[i].Name)
                        {
                            userchosenI = i;
                        }
                    }
                }
                Fighting(userchosenI, randomPokemon);
                // Console.WriteLine("Invalid Choice Check Spelling");
            }
            else 
            {
            //note from 3/9/24 make sure that you finish the restart. the function is already made just make sure to place it and implemeant it.
            }

        }
    }
}