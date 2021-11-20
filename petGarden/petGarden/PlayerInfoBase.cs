using System;

namespace petGarden
{
    public class PlayerInfoBase
    {
        private string name = "";
        private string password = "";
        private int money = 0;
        private string identificationNum = "";
        private int moneyTimekeeper = 0;
        private int affinity = 0;
        private int level = 0;
        private int experience = 0;

        public PlayerInfoBase()
        {
            //Default constructor method.
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        public int Money
        {
            get
            {
                return money;
            }
            set
            {
                money = value;
            }
        }

        public string ID
        {
            get
            {
                return identificationNum;
            }
            set
            {
                identificationNum = value;
            }
        }

        public int MoneyTimekeeper
        {
            get
            {
                return moneyTimekeeper;
            }
            set
            {
                moneyTimekeeper = value;
            }
        }

        public int Affinity
        {
            get
            {
                return affinity;
            }
            set
            {
                affinity = value;
            }
        }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }

        public int Experience
        {
            get
            {
                return experience;
            }
            set
            {
                experience = value;
            }
        }
    }
}
