using System;
using System.Linq;

namespace PragueParking2
{
    /// <summary>
    /// Class DebugFeatures.
    /// </summary>
    internal class DebugFeatures
    {
        /// <summary>
        /// Adds the vehicles in random spaces.
        /// </summary>
        /// <param name="parking">The parking.</param>
        /// <param name="numberOfVehicles">The number of vehicles.</param>
        public static void AddVehiclesInRandomSpaces(ref Parking parking, int numberOfVehicles)
        {
            Random rnd = new Random();

            for (int i = 0; i < numberOfVehicles; i++)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

                string reg;
                do
                {
                    reg = new string(Enumerable.Repeat(chars, rnd.Next(2, 8))
                        .Select(s => s[rnd.Next(s.Length)]).ToArray());
                } while (parking.Find(reg) != -1);

                while (parking.Add(reg, rnd.Next(1, 5), new string(Enumerable.Repeat(chars, rnd.Next(2, 8))
                           .Select(s => s[rnd.Next(s.Length)]).ToArray()), rnd.Next(0, 100)) >= 0) ;
            }
        }

        /// <summary>
        /// Adds the vehicles in order.
        /// </summary>
        /// <param name="parking">The parking.</param>
        /// <param name="numberOfVehicles">The number of vehicles.</param>
        public static void AddVehiclesInOrder(ref Parking parking, int numberOfVehicles)
        {
            Random rnd = new Random();

            for (int i = 0; i < numberOfVehicles; i++)
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

                string reg;
                do
                {
                    reg = new string(Enumerable.Repeat(chars, rnd.Next(2, 8))
                        .Select(s => s[rnd.Next(s.Length)]).ToArray());
                } while (parking.Find(reg) != -1);

                while (parking.Add(reg, rnd.Next(1, 5), new string(Enumerable.Repeat(chars, rnd.Next(2, 8))
                           .Select(s => s[rnd.Next(s.Length)]).ToArray())) >= 0) ;
            }
        }
    }
}