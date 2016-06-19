using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Refrigerator_Lesson5Task5
{
    class MyRefrigerator
    {
        private bool state;
        private FrostLevel frostLevels;
        private bool doorState;
        private bool frostDoorState;
        private bool ligthState;
        private string name;


        public MyRefrigerator(bool state, FrostLevel mode, bool doorState, bool frostDoorState, string name)
        {
            this.state = state;
            this.frostLevels = mode;
            this.doorState = doorState;
            this.frostDoorState = frostDoorState;
            this.name = name;
        }

        public void RefrigeratorON()
        {
            state = true;
        }

        
        public void RefrigeratorOFF()
        {
            state = false;
        }

        public void RefrigeratDoorOpen()
        {
            doorState = true;
            if (state)
            {
                ligthState = true;
            }
            else
            {
            ligthState = false;
            }
            doorState = true;
            
        }

        public void RefrigeratDoorClose()
        {
            doorState = false;
            ligthState = false;
        }

        public void frostDoorStateOpen()
        {
            frostDoorState = true;
        }

        public void frostDoorStateClose()
        {
            frostDoorState = false;
        }

        public void SetFrostLevelOFF()
        {
            frostLevels = FrostLevel.OFF;
        }

        public void SetFrostLevelLOW()
        {
            frostLevels = FrostLevel.Low;
        }

        public void SetFrostLevelMiddle()
        {
            frostLevels = FrostLevel.Middle;
        }

        public void SetFrostLevelHigh()
        {
            frostLevels = FrostLevel.High;
        }

        public string Info()
        {
            return "State ON/OFF: " + state.ToString() + ", FrostLevel: " + frostLevels.ToString() + ", Door Open/Close: " + doorState.ToString() + ", Light ON/OFF: " + ligthState.ToString() + ", Frost Door Open/Close: " + frostDoorState.ToString();
        }

       /* public string Info()
        {

            string state;
            if (this.state)
            {
                state = "Refrigirator ON";
            }
            else
            {
                state = "Refrigirator OFF";
            }


            string mode;
            if (this.frostLevels == FrostLevel.OFF)
            {
                mode = "Frost OFF";
            }
            else if (this.frostLevels == FrostLevel.Low)
            {
                mode = "Frost Low";
            }
            else if (this.frostLevels == FrostLevel.Middle)
            {
                mode = "Frost Middle";
            }
            else
            {
                mode = "Frost High";
            }


            string doorState;
            if (this.doorState)
            {
                doorState = "Opened";
            }
            else
            {
                doorState = "Closed";
            }


            string ligthState;
            if (this.ligthState)
            {
                ligthState = "ON";
            }
            else
            {
                ligthState = "OFF";
            }

            string frostDoorState;
            if (this.frostDoorState)
            {
                frostDoorState = "Opened";
            }
            else
            {
                frostDoorState = "Closed";
            }

            return "State: " + state + " ,FrostLevel: " + mode + " ,Door State: " + doorState + " ,Light: " + ligthState + " ,Frost Door: " + frostDoorState;
        } */


    }
}
