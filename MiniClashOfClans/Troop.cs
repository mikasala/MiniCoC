using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniClashOfClans
{
    class Troop
    {
        private string _name;
        private int _damage;
        private int _health;
        private int _trainCost;
        private int _level;
        private string _favTarget;
        private string _target;
        private int _housingCost;
        private int _trainingTime;

        //Constructor
        public Troop()
        {
            _name = "Trooper";
            _damage = 0;
            _health = 0;
            _trainCost = 0;
            _level = 0;
            _favTarget = "Any";
            _target = "Ground and Air";
            _housingCost = 0;
            _trainingTime = 0;
        }

        public Troop(string name, int damage, int health, int trainCost, int level, string favTarget, string target, int housingCost, int trainingTime)
        {
            _name = name;
            _damage = damage;
            _health = health;
            _trainCost = trainCost;
            _level = level;
            _favTarget = favTarget;
            _target = target;
            _housingCost = housingCost;
            _trainingTime = trainingTime;
        }

        //Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Damage
        {
           get { return _damage; }
           set { _damage = value; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int TrainCost
        {
            get { return _trainCost; }
            set { _trainCost = value; }
        }

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public string FavTarget
        {
            get { return _favTarget; }
            set { _favTarget = value; }
        }

        public string Target
        {
            get { return _target; }
            set { _target = value; }
        }

        public int HousingCost
        {
            get { return _housingCost; }
            set { _housingCost = value; }
        }

        public int TrainingTime
        {
            get { return _trainingTime; }
            set { _trainingTime = value; }
        }

        //public abstract void LevelUp();
        //virtual method -  meaning can be overriden by inheritting class
        public virtual void LevelUp()
        {
            _damage ++;
            _health ++;
            _trainCost ++;
            _level ++;
        }

        //virtual method overload
        public virtual void LevelUp(int level)
        {
            _damage += level;
            _health += level;
            _trainCost += level;
            _level += level;
        }
    }
}
