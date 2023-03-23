using InterfaceExercise.Classes;
using InterfaceExercise.Interfaces;
using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany


            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var Z = new Car();
            {
                Z.IsElectric = false;
                Z.ManufacturerName = "Nissan";
                Z.isRearWheelDrive = true;
                Z.NumberOfWheels = 4;
                Z.ModelName = "350z";
                Z.IsReliable = false;
                Z.NumberOfSeats = 2;
                Z.TrunkSpace = 40;

            }

            var Tundra = new Truck ();
            {
                Tundra.IsElectric = false;
                Tundra.ManufacturerName = "Toyota";
                Tundra.NumberOfSeats = 5;
                Tundra.NumberOfWheels = 4;
                Tundra.BedSize = 72;
                Tundra.CanTow = true;
                Tundra.ModelName = "Tundra";
                Tundra.IsReliable = true;

            }

            var RX = new SUV();
            {
                RX.IsElectric = false;
                RX.ManufacturerName = "Lexus";
                RX.NumberOfSeats = 6;
                RX.NumberOfWheels = 4;
                RX.ModelName = "RX350";
                RX.IsReliable = true;
                RX.HasFivePlusSeats = true;
                RX.IsAllWheelDrive = true;



            }

            //Method call section, all methods contained within individual classes within the folder.

            Z.MakeModel();
            Z.ElectricCaller();
            Z.ReliabilityWriter();
            Z.CarFeatures();

            Console.WriteLine("\n");

            RX.MakeModel();
            RX.ElectricCaller();
            RX.ReliabilityWriter();
            RX.SUVFeatures();

            Console.WriteLine("\n");

            Tundra.MakeModel();
            Tundra.ElectricCaller();
            Tundra.ReliabilityWriter();
            Tundra.TruckFeatures();


        }
    }
}
