using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class Dinosaur
    {
        //Member Variables (Has A)
        public string dinosaurType;
        public int healthLevel;
        public int energyLevel;
        public int attackPower;
        public int damageDone;



        //Constructor (spawner)

        public Dinosaur()
        {
            this.dinosaurType = dinosaurType;
            int health = healthLevel;
            int stamina = energyLevel;
            int attack = attackPower;
            int strike = damageDone;




        }



        // Member Methods (Can Do)


        public int Hit(Random random)
        {
            random.Next(1, 100);
            int x = random.Next(1, 100);


            if (x >= 70)
            {
                healthLevel -= 15;
            }
            return healthLevel;

        }
        public int Fight(Random random)
        {
            random.Next(1, 100);
            int y = random.Next(1, 100);

            if (y >= 60)
            {
                attackPower = 70;
            }
            else
            {
                attackPower = 0;
            }
            return attackPower;
        }
        public int Attack(Random random)
        {
            random.Next(1, 100);
            int z = random.Next(1, 100);
            if (z >= 65)
            {
                energyLevel -= 10;
            }
            else
            {
                energyLevel = 0;
            }
            return energyLevel;
        }
        public int Bite(Random random)
        {
            random.Next(1, 100);
            int z = random.Next(1, 100);
            if (z >= 65)
            {
                damageDone = 150;
            }
            else
            {
                damageDone = 0;
            }
            return damageDone;
        }
    }
}
