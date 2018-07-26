using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniClashOfClans
{
    //sealed class meaning no more class can or will inherit this class
    sealed class Archer: GroundTroop
    {
        //Constructor
        public Archer()
        {
            Name = "Archer";
            Damage = 7;
            Health = 20;
            TrainCost = 50;
            Level = 1;
            FavTarget = "Any";
            Target = "Ground and Air";
            HousingCost = 1;
            TrainingTime = 3;
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
                        Damage += 2;
                        Health += 3;
                        TrainCost += 30;
                        break;
                    case 2:
                        Damage += 3;
                        Health += 5;
                        TrainCost += 40;
                        break;
                    case 3:
                        Damage += 4;
                        Health += 5;
                        TrainCost += 80;
                        break;
                    case 4:
                        Damage += 4;
                        Health += 7;
                        TrainCost += 100;
                        break;
                    case 5:
                        Damage += 2;
                        Health += 4;
                        TrainCost += 100;
                        break;
                    case 6:
                        Damage += 3;
                        Health += 4;
                        TrainCost += 100;
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
