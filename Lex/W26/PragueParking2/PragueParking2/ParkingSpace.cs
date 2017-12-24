using System;
using System.Collections.Generic;
using System.Linq;

namespace PragueParking2
{
    /* Parkingspace
   +int size -Sätts till 4 i när den skapas, fast värde
   +int freeSpace – hur mycket finns kvar av kapaciteten
   -List VehicleList
       ---

   bool Remove(string) – ta bort bil/mc om det går
   bool Find(string) – Hitta fordon baserat på regnr
   string Content(int spacenumber) – Returnera vilka fordon som finns på denna plats(obs denna metod skriver EJ ut till skärmen direkt)

   */

    /// <summary>
    /// Class ParkingSpace.
    /// </summary>
    [Serializable]
    public class ParkingSpace
    {
        public int Size { get; set; }
        public int FreeSpace { get; set; }

        private List<Vehicle> VehicleList;
        private Vehicle VehicleInfo = new Vehicle();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParkingSpace"/> class.
        /// </summary>
        public ParkingSpace()
        {
            VehicleList = new List<Vehicle>();
            Size = 4;
            FreeSpace = 4;
            
        }

        ///ta bort bil/mc om det går
        /// <summary>
        /// Removes the specified reg number.
        /// </summary>
        /// <param name="regNumber">The reg number.</param>
        /// <param name="timeParked">The time parked.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Remove(string regNumber, out TimeSpan timeParked)
        {
            bool result = true;

            timeParked = TimeSpan.Zero;
            foreach (Vehicle VehicleInfo in VehicleList.ToList())
            {
                if (VehicleInfo.RegNumber = regNumber)
                {
                    VehicleList.Remove(VehicleInfo);
                    FreeSpace += VehicleInfo.VehicleSize;

                    timeParked =
                        DateTime.Now.Subtract(VehicleInfo
                            .ArrivedTime); //subtract parked time from current time to get difference
                    //vehicle.VehicleSize -= vehicle.VehicleSize;

                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        /// Hitta fordon baserat på regnr
        /// <summary>
        /// Finds the specified reg number.
        /// </summary>
        /// <param name="regNumber">The reg number.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Find(string regNumber)
        {
            //bool result = false;
            foreach (Vehicle<Type> Vehicle in VehicleList)
            {
                if (Vehicle.RegNumber == regNumber)
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Finds the reg number.
        /// </summary>
        /// <returns>System.String[].</returns>
        public string[] FindRegNum()
        {
            string[] RegNumArray = new string[VehicleList.Count];
            for (int i = 0; i < VehicleList.Count; i++)
            {
                RegNumArray[i] = VehicleList[i].RegNumber;
            }

            return RegNumArray;
        }

        /// <summary>
        /// Finds the vehicle sizes.
        /// </summary>
        /// <returns>System.Int32[].</returns>
        public int[] FindVehicleSizes()
        {
            int[] sizeArray = new int[VehicleList.Count];
            for (int i = 0; i < VehicleList.Count; i++)
            {
                sizeArray[i] = VehicleList[i].VehicleSize;
            }
            return sizeArray;
        }

        /// <summary>
        /// Finds the specified reg number.
        /// </summary>
        /// <param name="_regNumber">The reg number.</param>
        /// <param name="size">The size.</param>
        /// <param name="identification">The identification.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Find(string regNumber, out int size, out string identification)
        {
            //bool result = false;
            size = 0;
            identification = "";
            foreach (Vehicle<Type> Vehicle in VehicleList)
            {
                if (Vehicle.RegNumber == regNumber)
                {
                    size = Vehicle.VehicleSize;
                    identification = Vehicle.VehicleIdentification;

                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Contents the specified i.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns>System.String.</returns>
        public string Content(int i)
            ///Returnera vilka fordon som finns på denna plats(obs denna metod skriver EJ ut till skärmen direkt)
        {
            string output = "";
            for (int j = 0; j < VehicleList.Count; j++)
            {
                if (j > 0)
                {
                    output += "\n     ";
                    if (i > 8)
                    {
                        output += " ";
                        if (i > 98)
                        {
                            output += " ";
                        }
                    }
                    output += "and ";
                }
                output +=
                    $"{VehicleList[j].RegNumber}, type: {VehicleList[j].VehicleType}, {VehicleList[j].VehicleIdentification}, {VehicleList[j].ArrivedTime}";
            }
            return output;
        }

        /// <summary>
        /// Adds the specified reg number.
        /// </summary>
        /// <param name="regNumber">The reg number.</param>
        /// <param name="type">The type.</param>
        /// <param name="identifier">The identifier.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        public bool Add(string regNumber, int type, string identifier)
        {
            bool result = false;
            switch (type)
            {
                case 1:
                    if (FreeSpace >= type)
                    {
                        VehicleInfo = new Bike(regNumber, identifier);
                        VehicleList.Add(VehicleInfo);
                        result = true;
                        FreeSpace -= type;
                    }
                    break;

                case 2:
                    if (FreeSpace >= type)
                    {
                        VehicleInfo = new Motorbike(regNumber, identifier);
                        VehicleList.Add(VehicleInfo);
                        result = true;
                        FreeSpace -= type;
                    }
                    break;

                case 3:
                    if (FreeSpace >= type)
                    {
                        VehicleInfo = new Tricycle(regNumber, identifier);
                        VehicleList.Add(VehicleInfo);
                        result = true;
                        FreeSpace -= type;
                    }
                    break;

                case 4:
                    if (FreeSpace == type)
                    {
                        VehicleInfo = new Car(regNumber, identifier);
                        VehicleList.Add(VehicleInfo);
                        result = true;
                        FreeSpace -= type;
                    }
                    break;

                default:
                    break;
            }

            return result;
        }
    }
}