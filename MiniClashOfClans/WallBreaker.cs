using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniClashOfClans
{
    //sealed class meaning no more class can or will inherit this class
    sealed class WallBreaker: GroundTroop
    {
        private int _damageMult;

        //Constructor
        public WallBreaker()
        {
            Name = "Wall Breaker";
            Damage = 12;
            _damageMult = 40;
            Health = 20;
            TrainCost = 1000;
            Level = 1;
            FavTarget = "Walls";
            Target = "Ground";
            HousingCost = 2;
            TrainingTime = 20;
        }

        //property
        public int DamageMult
        {
            get { return _damageMult; }
            set { _damageMult = value; }
        }

        //methods
        public int DamageWall()
        {
            return Damage * _damageMult;
        }

        //method sealed override
        //sealed meaning, there will be no more class that can override this method
        public sealed override void LevelUp()
        {
            if (Level < 6 && Level > 0)
            {
                switch (Level)
                {
                    case 1:
                        Damage += 4;
                        Health += 4;
                        break;
                    case 2:
                        Damage += 8;
                        Health += 5;
                        break;
                    case 3:
                        Damage += 8;
                        Health += 6;
                        break;
                    case 4:
                        Damage += 14;
                        Health += 7;
                        break;
                    case 5:
                        Damage += 14;
                        Health += 12;
                        break;
                    default:
                        break;
                }
                TrainCost += 500;
                Level++;
            }
        }

        //tries to override sealed
        //public override void LevelUp(int level){}
    }
}
