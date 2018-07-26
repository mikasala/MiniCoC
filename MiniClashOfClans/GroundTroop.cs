using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniClashOfClans
{
    //abstract class means it is a common definition for its sub classes
    abstract class GroundTroop: Troop
    {
        //constructor - but usually abstract classes are not instantiated
        public GroundTroop()
        {

        }

        //abstract methods - meaning, its inheritting class wont inherit the its parent class method, Troop.Levelup method,
        //instead, the inheritting classes must implement their own LevelUp method
        //this is like declaring the method. and the sub class will define the method
        public abstract override void LevelUp();

        //sealed, meaning, there will be no more sub class that can override this method
        public sealed override void LevelUp(int level)
        {
            int i;
            for (i = 0; i < level; i++)
                LevelUp();

        }
    }
}
