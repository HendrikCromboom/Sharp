using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp.Model
{
    class Calculate
    {
        private Random random = new Random(101);
        private int randomize()
        {
            
            return this.random.Next();
        }
        public bool hitChance()
        {
            if(this.randomize() < 50)
            {
                return false;
            }
            else { return true; }
        }
    }
}
