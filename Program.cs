using Sharp.Model;
using System;

namespace Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Communicate communicate1 = new Communicate;
 
            setPause();
            sayHi();
            string name = Console.ReadLine();
            sayName(name);
            setPause();
            warnUser();
            setPause();
            explainGame();
            setPause();
            Console.Clear();

            
        }
    }
}
