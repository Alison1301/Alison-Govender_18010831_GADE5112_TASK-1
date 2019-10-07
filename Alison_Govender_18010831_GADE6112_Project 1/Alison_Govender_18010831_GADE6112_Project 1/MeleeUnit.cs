using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6112_Project_1
{

    public abstract class MeleeUnit : Unit
    {

        public MeleeUnit(int X, int Y, int hp, int Us, int Attack, int AR, string Fact, string Sym, bool UnitAtck)
        {
            X = x;
            Y = y;
            Health = 100;
            UnitSpeed = 2;
            attack = 25;
            AttackRange = 1;
            Faction = "Melee";
            Symbol = "M";
           
        }

        public MeleeUnit() : base()
        {

        }

        public override void Move()
        {
            
        }

        public override void Attack_Range()
        {
            
        }


        public override void Combact()
        {
           
        }


        public override void Position()
        {
        }
            

        public override void Dealth()
        {
            
        }

        public override string ToString()
        {
            return "Units"+ Faction;
        }

    }







}
