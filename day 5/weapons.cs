using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    class weapons
    {
        //meber methods ( Has A)
        public string name;
        public int hitPower;



        // constructor (spawner)
        public weapons()
        {
            this.name = name;
            int damage = hitPower;
        }


        // member varibales (Can Do)

        public int Fight(Random random)
        {
            random.Next(1, 100);
            int y = random.Next(1, 100);

            if (y >= 60)
            {
                hitPower = 25;
            }
            else
            {
                hitPower = 0;
            }
            return hitPower;
        }

    }   
}
