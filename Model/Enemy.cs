using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp.Model
{
    class Enemy
    {
        private string name;
        private int maxHealth;
        private int health;
        private int exp;
        private int strength;
        private List<List<string>> enemies = new List<List<string>>();
        public Enemy(string id)
        {
            this.initiateEnemies();
            List<string> thisEnemy = this.fetchEnemy(id);
            this.name = thisEnemy[1];
            this.maxHealth = int.Parse(thisEnemy[2]);
            this.health = this.maxHealth;
            this.exp = int.Parse(thisEnemy[3]);
            this.strength = int.Parse(thisEnemy[4]);
            Console.WriteLine(this.name);

        }
        public List<string> fetchEnemy(string id)
        {
            return this.enemies.Find(item => item[0] == id);
            
        }
        public void initiateEnemies() // For testing purposes this is how we create the data for the enemy types, ill have to learn how to implement data in a C# console app
        {
            
            var minorAnomality = new List<string> { "1", "Minor Anomality", "20", "2", "2"};
            var mayorAnomality = new List<string> { "2", "Mayor Anomality", "30", "4", "3" };
            this.enemies.Add(minorAnomality);
            this.enemies.Add(mayorAnomality);


        }

    }
    

}
