using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MitchumNaidoo_GADE_RERUN_ICE4
{
    public abstract class Hero
    {
        //varibles
        protected int hp;
        protected int attack;
        protected int crit;
        protected int defense;
        protected string name;
        protected string battlecry;

        //constructor
        public Hero(int hp, int attack, int crit, int defense, string name, string battlecry)
        {
            this.hp = hp;
            this.attack = attack;
            this.crit = crit;
            this.defense = defense;
            this.name = name;
            this.battlecry = battlecry;
        }

        //Deconstructor
        ~Hero()
        {

        }

        //Methods
        //public abstract int SetHp();
        //public abstract int SetAtk();
        //public abstract int SetCrit();
        //public abstract int SetDef();
        //public abstract string SetName();
        //public abstract string SetCry();
        public abstract string ToString();
    }
}
