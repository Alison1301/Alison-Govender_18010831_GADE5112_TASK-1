using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alison_Govender_18010831_GADE6112_Project_1
{
    public abstract class Unit
    {
        GameEngineFrm gameEngineFrm = new GameEngineFrm();


        protected int x;
        protected int y;
        protected int Health;
        protected int maxHealth{ get; }
        protected int UnitSpeed;
        protected int attack;
        protected int AttackRange;
        protected string Faction;
        protected string Symbol;
        bool unitAttack = false;

        public Unit()
        {
            maxHealth = 100;
            attack = 10;
            AttackRange = 4;


        }

        public Unit(int X, int Y, int hp, int Us, int Attack, int AR, string Fact, string Sym, bool UnitAtck)
        {
            X = x;
            Y = y;
            Health = hp;
            UnitSpeed = Us;
            attack = Attack;
            AttackRange = AR;
            Faction = Fact;
            Symbol = Sym;
            unitAttack = UnitAtck;

        }

        public int X { get; set; }

        public abstract void Move();

        public abstract void Combact();

        public abstract void Attack_Range();

        public abstract void Position();

        public abstract void Dealth();

        public override string ToString()
        {
            return "Unit:"+ Faction;
        }
        

       




    }
}
