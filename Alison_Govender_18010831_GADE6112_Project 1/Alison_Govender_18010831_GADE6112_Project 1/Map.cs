using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6112_Project_1
{
    public partial class Map
    {

        const int WIDTH = 20;
        const int HEIGHT = 20;
        string[,] map = new string[20, 20];
        int x = 0;
        int y = 0;
        Random rnd = new Random();
        
    
        

        public void InitializeMap()
        {
            x = rnd.Next(0,20);
            y = rnd.Next(0,20);

            for (int cy = 0; cy < map.GetLength(1); cy++)
            {
                for (int cx = 0; cx < map.GetLength(0); cx++)
                {
                    map[cx, cy] = ".";

                }
            }
        }


    }
}

