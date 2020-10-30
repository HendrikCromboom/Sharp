using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp.Model
{
    class Game
    {
        private Communicate communicate;

        public Game()
        {
            this.communicate = new Communicate();
            this.intro();
        }

        private void intro()
        {
            this.communicate.setPause();
            this.communicate.sayHi();
            this.communicate.sayName();
            this.communicate.setPause();
            this.communicate.warnUser();
            this.communicate.setPause();
            this.communicate.explainGame();
            this.communicate.setPause();
            Console.Clear();
        }
    }
}
