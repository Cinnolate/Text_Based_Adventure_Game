using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Combat
    {
        public int enemyHealth;
        public int[] enemyDamage = {5, 6, 7, 8, 9, 10};
        public int enemyCritical;
        public int enemyAmount;

        public string enemyName;

        public Combat (int e, int[] ED, int EC, int EA)
        {
            enemyHealth = e;
            enemyCritical = EC;
            enemyDamage = ED;
            enemyAmount = EA;
        }

        public override string ToString()
        {
            return ("Time to fight the " + enemyName + "! You can only attack.");
        }
    }
}
