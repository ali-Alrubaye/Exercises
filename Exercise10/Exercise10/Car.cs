using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public class Car:Vehicle
    {
        // Fields
        
        private bool EngineIsRunning;
       

        //Inherited class constructor :
        public Car(string model, string manufacturar, string year, string regNumber,bool engineIsRunning) : base( model,manufacturar,year,regNumber)
        {
            this.EngineIsRunning = false;
        }
        public Car ()
        { }
        public bool StartEngine()
        {
            // If the Engine is already Start, the action fails
            if (EngineIsRunning)
                return false;
            EngineIsRunning = true;
            return true;
        }
        // If the Engine is already stop, the action fails
        public bool StopEngine()
        {
            if (!EngineIsRunning)
                return false;
            EngineIsRunning = false;
            return true;
        }

        //public void UpdateYear(string newYear)
        //{
        //    this.Year = newYear;
        //}

        public string GetCarInfo()
        {
            return RegNumber + ": " + Model;
        }

    }
}
