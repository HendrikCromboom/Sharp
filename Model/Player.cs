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
        private int level;
        private int exp;
        private int maxExp;
        public Player()
        {
            this.maxHealth = 30;
            this.health = 30;
            this.level = 1;
            this.exp = 0;
            this.maxExp = 10;
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
        public void checkLevelUp()
        {
            if(this.exp >= this.maxExp)
            {
                this.exp = this.exp - this.maxExp;
                this.maxExp = this.maxExp + (5 * this.level);
                this.level++;
            }
        }
    }
}
