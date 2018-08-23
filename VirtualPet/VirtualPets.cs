using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPets
    {// declare fields
        private int hunger;
        private int thirst;
        private int waste;
        private string name;
        private bool hungerAlert;
        private bool thirstAlert;
        private bool wasteAlert;
        //declare properties
        public bool HungerAlert
        {
            get { return this.hungerAlert; }
            set { this.hungerAlert = value; }
        }
        public bool ThirstAlert
        {
            get { return this.thirstAlert; }
            set { this.thirstAlert = value; }
        }
        public bool WasteAlert
        {
            get { return this.wasteAlert; }
            set { this.wasteAlert = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }

        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        public int Waste
        {
            get { return this.waste; }
            set { this.waste = value; }
        }

        //Create constructors

        public VirtualPets()
        {
            //Default Costructor
        }
        public VirtualPets(string name, int hunger, int thirst, int waste)
        {
            this.Name = name;
            this.Hunger = hunger;
            this.Thirst = thirst;
            this.Waste = waste;
        }
        //Create Methods
        public int SetHunger(int num)
        {
            this.Hunger = num;
            return Hunger;
        }
        public int SetThirst(int num)
        {
            this.Thirst = num;
            return Thirst;
        }
        public int SetWaste(int num)
        {
            this.Waste = num;
            return Waste;
        }

        public string SetName(string name)
        {
            this.Name = name;
            return Name;
        }

        public void Tick()
        {
            Hunger++;
            if (Hunger > 25)
            {
                HunAlert(true);
            }
            else
            {
                HunAlert(false);
            }
            Thirst--;
            if (Thirst > 5)
            {
                ThirAlert(true);
            }
            else
            {
                ThirAlert(false);
            }
            Waste++;
            if (Waste > 6)
            {
                WasAlert(true);
            }
            else
            {
                WasAlert(true);
            }
        }

        public bool HunAlert(bool status)
        {  
                hungerAlert = status;
                return hungerAlert;
         }
        public bool ThirAlert(bool status)
        {
                thirstAlert = status;
                return thirstAlert;
        }
        public bool WasAlert(bool status)
        {
            wasteAlert = status;
            return wasteAlert;
        }





    }
}   

