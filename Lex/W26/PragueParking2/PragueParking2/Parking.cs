using System;

namespace PragueParking2
{
    [Serializable]
    internal class Parking
    {
        /// <summary>
        /// The parking spaces
        /// </summary>
        private ParkingSpace[] parkingSpaces;

        //private int emptySpaces;
        //private int partlyEmptySpaces;

        /// <summary>
        /// Gets the empty spaces.
        /// </summary>
        /// <value>The empty spaces.</value>
        public int EmptySpaces
        {
            get
            {
                int emptySpaces = 0;
                foreach (ParkingSpace parkingSpace in parkingSpaces)
                {
                    if (parkingSpace.FreeSpace == 4)
                    {
                        emptySpaces += 1;
                    }
                }
                return emptySpaces;
            }
        }

        /// <summary>
        /// Gets the partly empty spaces.
        /// </summary>
        /// <value>The partly empty spaces.</value>
        public int PartlyEmptySpaces
        {
            get
            {
                int partlyEmptySpaces = 0;
                foreach (ParkingSpace parkingSpace in parkingSpaces)
                {
                    if (parkingSpace.FreeSpace > 0 && parkingSpace.FreeSpace < parkingSpace.Size)
                    {
                        partlyEmptySpaces += 1;
                    }
                }
                return partlyEmptySpaces;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Parking"/> class.
        /// </summary>
        public Parking()
        {
            parkingSpaces = new ParkingSpace[100];

            for (int i = 0; i < parkingSpaces.Length; i++)
            {
                parkingSpaces[i] = new ParkingSpace();
            }
        }

        /// <summary>
        /// Adds vehicle to the first space with room enough.
        /// </summary>
        /// <param name="reg">The registration number</param>
        /// <param name="type">The type of vehicle</param>
        /// <param name="identifier">The identifier of the vehicle.</param>
        /// <returns>the index of parking space found,
        /// or -2 if vehicle already in parking lot,
        /// or -1 if space lacks the space</returns>
        public int Add(string reg, int type, string identifier)
        {
            reg = reg.ToUpper();
            int spaceFoundIndex = -1; //meaning no empty space found

            if (Find(reg) != -1)
            {
                return -2; //meaning vehicle already in parking
            }

            for (int i = 0; i < parkingSpaces.Length; i++)
            {
                if (parkingSpaces[i].Add(reg, type, identifier))
                {
                    //successfully added car
                    spaceFoundIndex = i;
                    break;
                }
            }
            return spaceFoundIndex;
        }

        /// <summary>
        /// Adds vehicle to a specific parking space.
        /// </summary>
        /// <param name="reg">The registration number</param>
        /// <param name="type">The type of vehicle</param>
        /// <param name="identifier">The identifier of the vehicle.</param>
        /// <param name="specificSpace">The specific space to add vehicle.</param>
        /// <returns>
        /// the index of parking space,
        /// or -1 if vehicle already in parking lot,
        /// or -2 if space lacks the space
        /// </returns>
        public int Add(string reg, int type, string identifier, int specificSpace)
        {
            reg = reg.ToUpper();
            int spaceFoundIndex = -1; //meaning no empty space found

            if (Find(reg) != -1)
            {
                return -2; //meaning vehicle already in parking
            }

            if (parkingSpaces[specificSpace].Add(reg, type, identifier))
            {
                spaceFoundIndex = specificSpace;
            }

            return spaceFoundIndex;
        }

        /// <summary>
        /// Removes vehicle with registration reg.
        /// </summary>
        /// <param name="reg">registration of the vehicle to remove</param>
        /// <param name="durationParked">The time parked.</param>
        /// <returns>
        /// the space where vehicle was parked,
        /// or -1 if vehicle is not in parking
        /// </returns>
        public int Remove(string reg, out TimeSpan durationParked)
        {
            durationParked = TimeSpan.Zero;
            reg = reg.ToUpper();
            int vehicleParkedSpaceIndex = -1; // vehicle not found
            for (int i = 0; i < parkingSpaces.Length; i++)
            {
                if (parkingSpaces[i].Remove(reg, out durationParked))
                {
                    //successfully removed vehicle
                    vehicleParkedSpaceIndex = i;
                    break;
                }
            }
            return vehicleParkedSpaceIndex;
        }

        /// <summary>
        /// Finds the specified reg.
        /// </summary>
        /// <param name="reg">The reg.</param>
        /// <returns>System.Int32.</returns>
        public int Find(string reg)
        {
            reg = reg.ToUpper();
            for (int i = 0; i < parkingSpaces.Length; i++)
            {
                if (parkingSpaces[i] != null && parkingSpaces[i].Find(reg))
                {
                    return i; // return index of this car in array
                }
            }
            return -1; // not found
        }

        /// <summary>
        /// Finds the specified reg.
        /// </summary>
        /// <param name="reg">The reg.</param>
        /// <param name="size">The size.</param>
        /// <param name="identifier">The identifier.</param>
        /// <returns>System.Int32.</returns>
        public int Find(string reg, out int size, out string identifier)
        {
            reg = reg.ToUpper();
            for (int i = 0; i < parkingSpaces.Length; i++)
            {
                if (parkingSpaces[i] != null && parkingSpaces[i].Find(reg, out size, out identifier))
                {
                    return i; // return index of this car in array
                }
            }
            size = 0;
            identifier = "";
            return -1; // not found
        }

        /// <summary>
        /// Moves the specified reg.
        /// </summary>
        /// <param name="reg">The reg.</param>
        /// <param name="newSpace">The new space.</param>
        /// <returns>System.Int32.</returns>
        public int Move(string reg, int newSpace)
        {
            reg = reg.ToUpper();
            int oldSpace = Find(reg, out int size, out string identifier);
            if (oldSpace >= 0) // if exists
            {
                if (size <= parkingSpaces[newSpace].FreeSpace) // if parking space has room for vehicle
                {
                    Remove(reg, out TimeSpan diff);

                    Add(reg, size, identifier, newSpace);
                    return 1; // means it moved vehicle
                }
                else
                    return 0; // means new space doesn't have room for vehicle
            }
            return -1; // means vehicle not in parking
        }

        public void Optimise()
        {
            /*
            for (int i = 0; i < parkingSpaces.Length; i++) // find trike without bike
            {
                if (parkingSpaces[i].FindVehicleSizes().Contains(3) && parkingSpaces[i].FreeSpace == 1)
                {
                }
            }
            */
        }

        //public string[] FindRegNumInSpace(int packingSpaceNumber)
        //{
        //    List<Vehicle> vehiclesInSpace = new List<Vehicle>();
        //    ParkingSpace _PackingSpace = new ParkingSpace();

        //    string[] RegNumArray = new string[4];
        //    for (int i = 0; i < parkingSpaces.Length; i++)
        //    {
        //        if (i == packingSpaceNumber)
        //        {
        //            RegNumArray = _PackingSpace.FindRegNum();

        //        }

        //    }
        //    return RegNumArray;
        //}

        /// <summary>
        /// Contents this instance.
        /// </summary>
        /// <returns>System.String.</returns>
        public string Content()
        {
            string output = "";
            for (int i = 0; i < parkingSpaces.Length; i++)
            {
                output += $"\nSpace {i + 1}: {parkingSpaces[i].Content(i)}";
            }
            return output;
        }

        /// <summary>
        /// Visualisations this instance.
        /// </summary>
        /// <returns>System.Int32[].</returns>
        public int[] Visualisation()
        {
            int[] visualMapArray = new int[parkingSpaces.Length];
            for (int i = 0; i < parkingSpaces.Length; i++)
            {
                if (parkingSpaces[i].FreeSpace == 4) /// if parking space is empty
                {
                    visualMapArray[i] = 0;
                }
                else
                {
                    if (parkingSpaces[i].FreeSpace >= 1 && parkingSpaces[i].FreeSpace <= 4
                    ) /// if parking space is between empty and full
                    {
                        visualMapArray[i] = 1;
                    }
                    else /// if parking space is full
                    {
                        visualMapArray[i] = 2;
                    }
                }
            }
            return visualMapArray;
        }
    }
}