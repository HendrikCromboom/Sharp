using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp.Model
{
    class Communicate
    {
        private string name = "";
        public void sayHi()
        {
            Console.WriteLine("Hello there wanderer, what ist thine name?");
            this.name = Console.ReadLine();
        }
        public void sayName()
        {
            Console.WriteLine(this.name + " huh, that is a fine name indeed...");
        }
        public void setPause()
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("...");
        }
        public void warnUser()
        {
            Console.WriteLine("Hast thou heard of the game of life?");
            string answer = Console.ReadLine();
            if (answer == "Yes" || answer == "yes" || answer == "y" || answer == "ye")
            {
                Console.WriteLine("Ah ... I see thou art a man of culture as well");
            }
            else
            {
                Console.WriteLine("Not to fret, allow me to explain");
            }
        }
        public void explainGame()
        {
            Console.WriteLine("I must warn you ... this isn't JUST a game");
        }
        public string getName()
        {
            return this.name;
        }
        public string drawLine()
        {
            return "---------------------------------------------";
        }
    }
}
