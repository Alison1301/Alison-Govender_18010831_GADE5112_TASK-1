using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6112_Project_1
{
    public class GameEngine
    {
        GameEngineFrm gameEngineFrm = new GameEngineFrm();
        int[] Round;

        public void Rounds()
        {
            Round = new int[10];
            string combostring = "Round" + (Round);

            Round[0] = Round[1] + 1;


            if (Round[0] > 10)
            {
                Round[0] = 1;

               
            }
            else if (Round[0] < 10)
            {
                Round[0] = 1;

                
            }

        }



    }
}
