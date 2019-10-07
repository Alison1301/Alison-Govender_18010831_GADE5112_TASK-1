using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Alison_Govender_18010831_GADE6112_Project_1
{
    public partial class GameEngineFrm : Form
    {
        Map Map  = new Map();
        const int WIDTH = 20;
        const int HEIGHT = 20;
        string[,] map = new string[20, 20];
        int ux = 0;
        int uy = 0;
        int x;
        int y;
        Random rnd = new Random();
        private int[] Rounds;
   
   

        public void draw()
        {
            UnitLbl.Text = "";

            for (int cy = 0; cy < map.GetLength(0); cy++)
            {
                for (int cx = 0; cx < map.GetLength(1); cx++)
                {
                    UnitLbl.Text += map[cx, cy];
                }

                UnitLbl.Text += "\n";
            }


        }


        public void InitializeMap()
        {
            ux = rnd.Next(0, 20);
            uy = rnd.Next(0, 20);

            for (int cy = 0; cy < map.GetLength(1); cy++)
            {
                for (int cx = 0; cx < map.GetLength(0); cx++)
                {
                    map[cx, cy] = ".";

                }
            }
        }

        public void units()
        {
            if (ux == x && uy == y)
            {
                map[x, y] = "X";
            }
            else
            {
                double xSqr = (x - ux) * (x - ux);
                double ySqr = Math.Pow(y - uy, 2);
                double dist = Math.Sqrt(xSqr + ySqr);
                dist = Math.Round(dist);
                map[x, y] = dist + "";

            }
        }

       
        public GameEngineFrm()
        {
            InitializeComponent();
            InitializeMap();
           


        }

        private void GameEngineFrm_Load(object sender, EventArgs e)
        {

            Map.InitializeMap();

        }




        private void UnitLbl_Click(object sender, EventArgs e)
        {
           
            InitializeMap();
           
        }



        private void Start_btn_Click(object sender, EventArgs e)
        {
            draw();
            InitializeMap();
            units();
            Rounds = new int[10];
            string combostring = "Round" + (Rounds);

            Rounds[0] = Rounds[1] + 1;

            RoundLbl.Text =  "Round " + Rounds[0];

        }

        private void Pause_btn_Click(object sender, EventArgs e)
        {

            

        }

        private void Game_Rtb_TextChanged(object sender, EventArgs e)
        {
            GameEngine gameEngine = new GameEngine();
          
        }

        private void RoundLbl_Click(object sender, EventArgs e)
        {
            Rounds[0] = Rounds[0] + 1;


            if (Rounds[0] > 10)
            {
                Rounds[0] = 0;
            }
            RoundLbl.Text = Rounds[0] + "";
        }
    }

        
}
