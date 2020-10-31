using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp.Model
{
    class Battle
    {
        private Player player;
        private Enemy enemy;
        private int turn;
        private bool batleOver;
    public Battle(Player player, string id)
        {
            this.player = player;
            this.enemy = new Enemy(id);
        }
    }
}
