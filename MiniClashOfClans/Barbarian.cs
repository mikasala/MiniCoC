using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniClashOfClans
{
    //sealed class meaning no more class can or will inherit this class
    sealed class Barbarian : GroundTroop
    {
        //Constructor
        public Barbarian()
        {
            Name = "Barbarian";
            Damage = 8;
            Health = 45;
            TrainCost = 25;
            Level = 1;
            FavTarget = "Any";
            Target = "Ground";
            HousingCost = 1;
            TrainingTime = 2;
        }

        //method sealed override
        //sealed meaning, there will be no more class that can override this method
        public sealed override void LevelUp()
        {
            if (Level < 7 && Level > 0)
            {
                switch (Level)
                {
                    case 1:
                        Damage += 3;
                        Health += 9;
                        TrainCost += 15;
                        break;
                    case 2:
                        Damage += 3;
                        Health += 11;
                        TrainCost += 20;
                        break;
                    case 3:
                        Damage += 4;
                        Health += 13;
                        TrainCost += 40;
                        break;
                    case 4:
                        Damage += 5;
                        Health += 17;
                        TrainCost += 50;
                        break;
                    case 5:
                        Damage += 3;
                        Health += 15;
                        TrainCost += 50;
                        break;
                    case 6:
                        Damage += 4;
                        Health += 15;
                        TrainCost += 50;
                        break;
                    default:
                        break;
                }
                Level++;
            }
        }

        //tries to override sealed
        //public override void LevelUp(int level){}
    }
}
