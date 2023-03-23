using System;
namespace InterfaceExercise
{
	public class Truck:IVehicle, ICompany
	{
		public Truck()
		{
		}

		public string BedSize { get; set; }
		public bool TowingCapable { get; set; }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string CountryProduced { get; set; }

        public bool AutomaticTrans { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfSeats { get; set; }
        public bool GpsSystem { get; set; }

        public string CompanyName { get; set; }
        public string CompanyType { get; set; }




    }
}

