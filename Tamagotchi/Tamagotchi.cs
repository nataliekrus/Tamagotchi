using System;
using System.Collections.Generic;

namespace tamagotchi
{
    public class Tamagotchi
    {
        int hunger = 0;
        int boredom = 0;
        List<string> words = new List<string>();
        bool isAlive = true;
        Random generator = new Random();
        public string name;



        public void Feed()
        {
            ReduceBoredom();
            hunger -= generator.Next(2, 3);
            Console.WriteLine("It is food time for your tamagotchi that you love very motchi.");
            Console.WriteLine("...");
            Console.WriteLine("...");
            Console.WriteLine("It has been fed.");
        }

        public void Hi()
        {
            ReduceBoredom();
            Console.WriteLine("You greet your best bff of all time.");            
            Console.WriteLine("This is their response:");
            if (words.Count > 0)
            {
                Console.Write("'");
                Console.Write(words[generator.Next(words.Count)]);
                Console.WriteLine("'");
            }

            else
            {
                Console.WriteLine("Nothing. They say absolutely nothing at all.");
                Console.WriteLine("Maybe you're not as good bff best friends of all bff time as you thought.");
            }

        }

        public void Teach(string word)
        {
            ReduceBoredom();
            words.Add(word);
        }

        public void Tick()
        {
            hunger++;
            boredom++;
            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            }

            if (hunger < 0)
            {
                hunger = 0;
            }
            if (boredom < 0)
            {
                boredom = 0;
            }
        }

        public void PrintStats()
        {
            Console.WriteLine("Hunger: " + hunger);
            Console.WriteLine("Boredom: " + boredom);
            if (isAlive == true)
            {
            Console.WriteLine("Your Tamagotchi is still alive and kicking.");                
            }
            else
            {
                Console.WriteLine("It seems we've got a situation here, Mr. Officer.");
            }
        }
    
        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {
            boredom -= generator.Next(1, 2);
        }



    }
}
