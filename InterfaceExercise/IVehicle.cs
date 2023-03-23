using System;
namespace InterfaceExercise
{
	public interface IVehicle
	{
		public int Year { get; set; }
		public string Make { get; set; }
		public string Model { get; set; }
        public string CountryProduced { get; set; }


        public int NumberOfWheels { get; set; }
		public int NumberOfSeats { get; set; }
		public bool AutomaticTrans { get; set; }
		public bool GpsSystem { get; set; }

	}
}

