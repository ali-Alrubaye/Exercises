using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public class Bicycle: Vehicle
    {
        //Field
        private string colourOfBicycle;
        
        public Bicycle()
        {
            addVehicle("bicycle");
        }
        //Methods
        public string GetColour()
        {
            return  colourOfBicycle;

        }
    }
}
