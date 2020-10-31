using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp.Model
{
    class Game
    {
        private Communicate communicate;
        private Player player;
        private Battle battle;
        private string end = "This is the end of the current alpha... thanks alot for checking this out!";

        public Game()
        {
            this.communicate = new Communicate();
            this.player = new Player();
            this.intro();
            this.start();
        }

        private void intro()
        {
            this.communicate.setPause();
            this.communicate.sayHi();
            this.player.setName(this.communicate.getName());
            this.communicate.sayName();
            this.communicate.setPause();
            this.communicate.warnUser();
            this.communicate.setPause();
            this.communicate.explainGame();
            this.communicate.setPause();
            Console.Clear();
        }
        private void start()
        {
            Console.WriteLine(this.player.getName() + "  " + this.player.showHealth());
            Console.WriteLine(this.communicate.drawLine());
            Console.WriteLine(this.end);
            Console.WriteLine(this.communicate.drawLine());
            this.battle = new Battle(this.player, "1");

        }
    }
}
