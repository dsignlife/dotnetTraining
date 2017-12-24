using System;

namespace PragueParking2
{
    /// <summary>
    /// Class Vehicles./
    /// </summary>
    [Serializable]
    public class Vehicle
    {
        public string RegNumber { get; set; }
        public string VehicleType { get; set; }
        public int VehicleSize { get; set; }
        public DateTime ArrivedTime { get; set; }
        public string VehicleIdentification { get; set; }

        public Vehicle(string regNumber, string vehicleIdentification)
        {
            RegNumber = regNumber;
            VehicleIdentification = vehicleIdentification;
            ArrivedTime = DateTime.Now;
        }

        public Vehicle()
        {
        }
    }

    /// <summary>
    /// Class Car./
    /// </summary>
    /// <seealso cref="PragueParking2.Vehicle" />
    [Serializable]
    public class Car : Vehicle
    {
        public Car(string regNumber, string vehicleIdentification) : base(regNumber, vehicleIdentification)
        {
            VehicleSize = 4;
            VehicleType = "CAR";
        }
    }

    /// <summary>
    /// Class Motorbike./
    /// </summary>
    /// <seealso cref="PragueParking2.Vehicle" />
    [Serializable]
    public class Motorbike : Vehicle
    {
        public Motorbike(string regNumber, string vehicleIdentification) : base(regNumber, vehicleIdentification)
        {
            VehicleSize = 2;
            VehicleType = "MOTORBIKE";
        }
    }

    /// <summary>
    /// Class Bike.
    /// </summary>
    /// <seealso cref="PragueParking2.Vehicle" />
    [Serializable]
    public class Bike : Vehicle

    {
        public Bike(string regNumber, string vehicleIdentification) : base(regNumber, vehicleIdentification)
        {
            VehicleSize = 1;
            VehicleType = "BIKE";
        }
    }

    /// <summary>
    /// Class Tricycle./
    /// </summary>
    /// <seealso cref="PragueParking2.Vehicle" />
    [Serializable]
    public class Tricycle : Vehicle
    {
        public Tricycle(string regNumber, string vehicleIdentification) : base(regNumber, vehicleIdentification)
        {
            VehicleSize = 3;
            VehicleType = "TRICYCLE";
        }
    }
}