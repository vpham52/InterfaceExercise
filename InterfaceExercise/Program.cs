using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany -- DONE

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle -- DONE

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany -- DONE

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes -- DONE

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var vehicles = new List<IVehicle>();
           

            var bmwX5 = new SUV()
            {
                Year = 2023,
                Make = "BMW",
                Model = "X5",
                CountryProduced = "Germany",
                AutomaticTrans = true,
                GpsSystem = true,

                ThirdRowSeat = true,
                AllWheelDrive = true,

                CompanyName = "Million Dollar House Hunters",
                CompanyType = "Realty Business"

            };

            var toyotaTacoma = new Truck()
            {
                Year = 2004,
                Make = "Toyota",
                Model = "Tacoma",
                CountryProduced = "Japan",
                AutomaticTrans = false,
                GpsSystem = false,               
               
                BedSize = "Large",
                TowingCapable = true,

                CompanyName = "Utah Parks and Rec",
                CompanyType = "National Park Service",

            };

            var dodgeCharger = new Car()
            {
                Year = 2023,
                Make = "Dodge",
                Model = "Charger",
                CountryProduced = "USA",
                AutomaticTrans = true,
                GpsSystem = true,
                
                LeatherSeats = false,
                TrunkSpace = false,

                CompanyName = "LA Sanitation",
                CompanyType = "City of Los Angeles Services",

            };

            vehicles.Add(bmwX5);
            vehicles.Add(toyotaTacoma);
            vehicles.Add(dodgeCharger);

           

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.GetType().Name}\n" +
                    $"{vehicle.Year} {vehicle.Make} {vehicle.Model}\n" +
                    $"Produced in: {vehicle.CountryProduced}\n" +
                    $"Automatic Transmission: {vehicle.AutomaticTrans}\n" +
                    $"GPS System: {vehicle.GpsSystem}\n");              
                
            }






        }
    }
}
