using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Classes
{
    public class Truck : IVehicle, ICompany
    {

        public Truck()
        { }
        // Inheriting from IVehicle
        public bool IsElectric { get; set; }
        public double NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; }
        public string ModelName { get; set; }

        //Inheriting from ICompany
        public string ManufacturerName { get; set; }

        public bool IsReliable { get; set; }

        //No inheritance
        public int BedSize { get; set; }
        public bool CanTow { get; set; }


        public void ElectricCaller()
        {
            if (IsElectric == true)
            {
                Console.WriteLine("This vehicle uses no fuel, and is driven by an electric motor.");
            }
            else { Console.WriteLine("This vehicle uses a fuel source to drive it's engine."); }
        }

        public void MakeModel()
        {
            Console.WriteLine($"{ManufacturerName} {ModelName}");
        }

        public void ReliabilityWriter()
        {
            Console.WriteLine($"The notion that this {ManufacturerName} is reliable is {IsReliable}.");
        }
        public void TruckFeatures()
        {
            if (CanTow == true)
            {
                Console.WriteLine($"This truck has a {BedSize} inch bed and can tow easily.");
            }
            
            else 
            { 
                Console.WriteLine($"This truck has a {BedSize} inch bed, but should not be used for towing large loads.");
            }
                    
        }
    }
}
