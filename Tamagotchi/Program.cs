using System;


namespace tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "I love Tamagotchi super motchi, and so should you.";
            Console.WriteLine("Hi there!");
            Console.WriteLine("Well what do we have here hm? Someone looking to take care of a Tamagotchi?");
            Console.WriteLine("Good luck with that... They die if their boredom or hunger reaches a value of 10. Whatever that means.");
            Console.WriteLine("Press enter and this creature will be yours! (At least try not to kill it)");
            Console.ReadLine();
            Console.Clear();

            Tamagotchi tg = new Tamagotchi();
            Console.WriteLine("This here is your new best friend. (No seeing, only imagining)");
            Console.WriteLine("What will you name them?");
            tg.name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Wonderful.");
            Console.WriteLine("Now, there are a couple different things you can do while you spend time with your new bff.");
            
            while(tg.GetAlive() == true)
            {
                tg.PrintStats();
                
                Console.WriteLine();
                Console.WriteLine("What do you want to do?");
                Console.WriteLine("1. Say hello");
                Console.WriteLine("2. Feed them");
                Console.WriteLine("3. Teach them a word (no profanities please)");
                Console.WriteLine("4. Nothing at all");
                string action = Console.ReadLine();

                while (action != "1" && action != "2" && action != "3" && action != "4")
                {
                    Console.WriteLine("Hey now, I can only work with numeric answers. Please correct yourself.");
                    action = Console.ReadLine();
                }
                Console.Clear();

                if (action == "1")
                {
                    tg.Hi();
                
                }

                if (action == "2")
                {
                    tg.Feed();
                }

                if (action == "3")
                {
                    Console.WriteLine("What verbal wisdom do you have to offer your tamagotchi?");
                    string word = Console.ReadLine();
                    tg.Teach(word);
                    Console.WriteLine("Wow. Such wisdom. I am amazed.");
                }

                if (action == "4")
                {
                    Console.WriteLine("Alright. Nothing it is!");
                    Console.WriteLine("Time has now passed.");
                    Console.WriteLine("You are older. (but not by very much)");
                }
                
                Console.WriteLine("Press enter to continue.");
                Console.ReadLine();

                tg.Tick();
                Console.Clear();
            }

            tg.PrintStats();
            Console.WriteLine("It seems one or more of your tamagotchi's values have reached the limit.");
            Console.WriteLine("Dude, I thought I told you to keep them below 10.");
            Console.WriteLine("Well, nothing to do about it now. See you next time!");
            Console.ReadLine();
        }
    }
}
