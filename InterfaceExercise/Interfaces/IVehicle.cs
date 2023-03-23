using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Interfaces
{
    public interface IVehicle
    {
        

        public bool IsElectric { get; set; }
        public double NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; }
        public string ModelName { get; set; }




    }
}
