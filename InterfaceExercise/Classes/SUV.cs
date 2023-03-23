using InterfaceExercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Classes
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
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
        public bool HasFivePlusSeats { get; set; }


        public bool IsAllWheelDrive { get; set; }


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

        public void SUVFeatures()
        {
            if (HasFivePlusSeats == true && IsAllWheelDrive == true)
            {
                Console.WriteLine("This vehicle is All Wheel Drive, and has room for a growing family!");
            }

            else if (HasFivePlusSeats == true && !IsAllWheelDrive == false)
            {
                Console.WriteLine("This vehicle is not All Wheel Drive, but does have room for a growing family!");
            }
            else if (!HasFivePlusSeats == false && !IsAllWheelDrive == true)
            {
                Console.WriteLine("This is a smaller, but would be great for touring the great outdoors.");
            }
            else
            {
                Console.WriteLine("This is a smaller, affordable SUV for general use.");
            }
        }

    }
}
