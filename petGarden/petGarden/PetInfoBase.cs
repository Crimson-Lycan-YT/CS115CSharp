using System;

namespace petGarden
{
    public class PetInfoBase
    {
        // Basic Stats used in almost every pet sim.
        private string name = "";
        private int age = 0;
        private int mood = 0;
        private int belly = 0;
        private int secretIQ = 0;
        private int secretLuck = 0;
        private int affinity = 0;
        private string identificationNum = "";
        private int mainTimekeeper = 0;
        private int moodTimekeeper = 0;
        private int bellyTimekeeper = 0;

        public PetInfoBase()
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

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public int Mood
        {
            get
            {
                return mood;
            }
            set
            {
                mood = value;
            }
        }

        public int Belly
        {
            get
            {
                return belly;
            }
            set
            {
                belly = value;
            }
        }

        public int SecretIQ
        {
            get
            {
                return secretIQ;
            }
            set
            {
                secretIQ = value;
            }
        }

        public int SecretLuck
        {
            get
            {
                return secretLuck;
            }
            set
            {
                secretLuck = value;
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

        public int MainTimekeeper
        {
            get
            {
                return mainTimekeeper;
            }
            set
            {
                mainTimekeeper = value;
            }
        }

        public int MoodTimekeeper
        {
            get
            {
                return moodTimekeeper;
            }
            set
            {
                moodTimekeeper = value;
            }
        }

        public int BellyTimekeeper
        {
            get
            {
                return bellyTimekeeper;
            }
            set
            {
                bellyTimekeeper = value;
            }
        }
    }
}