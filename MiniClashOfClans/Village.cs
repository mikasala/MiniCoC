using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MiniClashOfClans
{
    class Village
    {
        private int _resources;
        private int _currentArmy;
        //private int _collectors;
        private int _armyCamp;
        private int _barbCount;
        private int _archerCount;
        private int _wbCount;
        //private bool _isFullArmy;

        //Constructor
        public Village()
        {
            _resources = 0;
           // _collectors = 0;
            _armyCamp = 100;
            _currentArmy = 0;
            _barbCount = 0;
            _archerCount = 0;
            _wbCount = 0;
            //_isFullArmy = false;
        }

        //Properties
        public int Resources
        {
            get { return _resources; }
            set { _resources = value; }
        }

        /*public int Collectors
        {
            get { return _collectors; }
            set { _collectors = value; }
        }*/

        public int ArmyCamp
        {
            get { return _armyCamp; }
            set { _armyCamp = value; }
        }

        public int CurrentArmy
        {
            get 
            {
                _currentArmy = _barbCount + _archerCount + (_wbCount*2);
                return _currentArmy;
            }
            set { _currentArmy = value; }
        }

        public int BarbCount
        {
            get { return _barbCount; }
            set { _barbCount = value; }
        }

        public int ArcherCount
        {
            get { return _archerCount; }
            set { _archerCount = value; }
        }
        public int WBCount
        {
            get { return _wbCount; }
            set { _wbCount = value; }
        }

        /*public bool IsFullArmy
        {
            get { return (_currentArmy == _armyCamp); }
            set { _isFullArmy = value; }
        }*/

        public bool IsFullArmy()
        {
            return (_armyCamp == _currentArmy);
        }

        

        
    }
}
