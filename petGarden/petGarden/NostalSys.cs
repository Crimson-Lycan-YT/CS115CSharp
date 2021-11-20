using System;

namespace petGarden
{
    public class NostalSys
    {
        private PetInfoBase petBase = new PetInfoBase();
        private PlayerInfoBase playerBase = new PlayerInfoBase();

        public NostalSys()
        {
            //Default constructor method.
        }

        public PetInfoBase PetBase
        {
            get
            {
                return petBase;
            }
            set
            {
                petBase = value;
            }
        }

        public PlayerInfoBase PlayerBase
        {
            get
            {
                return playerBase;
            }
            set
            {
                playerBase = value;
            }
        }

        public PlayerInfoBase initNewGamePlayer(PlayerInfoBase playerBase)
        {
            playerBase.Money = 100;
            return playerBase;
        }

        public PetInfoBase petCommand(PetInfoBase petBase)
        {
            //Before running this command, try to check if the pet's mood is already 10.
            //If not, run this.

            if (petBase.Mood < 10)
            {
                petBase.Mood += 1;
                petBase.MoodTimekeeper = 0;
            }

            return petBase;

            //Now check the pet's mood and return a fitting message.
        }
    }
}
