using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp.Model
{
    class Player
    {
        private string name;
        private int maxHealth;
        private int health;

        public Player()
        {
            this.maxHealth = 30;
            this.health = 30;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public string showHealth()
        {
            return this.health + "/" + this.maxHealth + " HP";
        }
        public bool isAlive()
        {
            return this.health < 0 ;
        }
    }
}
