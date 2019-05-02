using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class CPU : Player
    {
        //Does have
        public Random random;

        //could just use array

        //Constructor
        public CPU()
        {
            random = new Random();
        }
        //Can do this
        public override string ChooseYourTarget()
        {
            int index = random.Next(TargetList.Count);
            TargetChoice = TargetList[index];
            Validate.IsItValid(TargetChoice);
            return TargetChoice;
            */

        }
    }
}
