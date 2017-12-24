// ***********************************************************************
// Assembly         : PragueParking
// Author           : Filip,Tomz
// Created          : 06-14-2017
//
// Last Modified By : TomzPC
// Last Modified On : 06-15-2017
// ***********************************************************************
// <copyright file="Program.cs" company="Lexicon">
//     Copyright ©  2017
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// The PragueParking namespace.
/// </summary>
///
namespace PragueParking
{
    /// <summary>
    /// Class Program.
    /// ### Parsing Examples ###
    /// " ; "
    ///
    /// "AAA111;2017-06-15 21:09:00" CAR
    /// "ASD233;2017-06-15 21:09:57;" 1x Motorbike
    /// "CCC222;2017-06-15 20:59:45;CCC333;2017-06-15 20:59:52" 2x Motorbike

    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Visualizes the array. Prints colorcoded availability.
        /// </summary>
        /// <param name="parkingPlaces">The parking places.</param>
        private static void Visualize(string[] parkingPlaces)
        {
            int lineCounter = 0;
            foreach (string item in parkingPlaces)
            {
                /// if parkingPlaces[] is empty shows [L],
                Console.BackgroundColor = ConsoleColor.DarkGray;
                if (item == "")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\u25a0 ");
                }
                else
                {
                    /// if parkingPlaces[i] aaa111; ;

                    if (item.Contains(";") && item.EndsWith(";"))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\u25a0 ", item);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\u25a0 ", item);
                    }
                }
                lineCounter++;
                ///Only show 10 eachline
                if (lineCounter % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Saves the parking array to a text file
        /// </summary>
        /// <param name="parkingPlaces">The parking places.</param>
        private static void Save(string[] parkingPlaces)
        {
            string path = @"C:\Users\elev1\Downloads\parkingplaces.txt";
            for (int i = 0; i < parkingPlaces.Length; i++)
            {
                File.WriteAllLines(path, parkingPlaces, Encoding.UTF8);
            }
        }

        /// <summary>
        /// Maps to show Info the specified parking spaces.
        /// </summary>
        /// <param name="parkingSpaces">The parking spaces.</param>
        private static void Map(string[] parkingSpaces)
        {
            Console.Clear();

            /// Loop in existed array
            for (int i = 0; i < parkingSpaces.Length; i++)
            {
                int forStupidPeople = i + 1;
                string vehicleType;
                /// Show empty
                if (parkingSpaces[i] == "")
                {
                    Console.WriteLine("Plats: {0}, -", forStupidPeople);
                }
                else
                {
                    ///Show 1x Motorbike in existed  parkingSpaces[i] remove from 6
                    if (parkingSpaces[i].Contains(";") && parkingSpaces[i].EndsWith(";"))
                    {
                        vehicleType = "MC";
                        Console.WriteLine("Plats: {0}, Fordon: {1}, Reg.nr.: {2}", forStupidPeople, vehicleType, parkingSpaces[i].Substring(0, 6));
                    }
                    else
                    {
                        ///If 2x Motorbike by finding if  tmp.Length > 2, Loops
                        ///"CCC222;2017-06-15 20:59:45;CCC333;2017-06-15 20:59:52"
                        ///Else equals car
                        string[] tmp = parkingSpaces[i].Split(';');
                        for (int j = 0; j < tmp.Length; j += 2)
                        {
                            if (tmp.Length > 2)
                            {
                                vehicleType = "MC";
                            }
                            else
                            {
                                vehicleType = "Bil";
                            }

                            Console.WriteLine("Plats: {0}, Fordon: {1}, Reg.nr.: {2}", forStupidPeople, vehicleType, tmp[j]);
                        }
                    }
                }
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Optimizes the specified parking spaces.
        /// </summary>
        /// <param name="parkingSpaces">The parking spaces.</param>
        /// <returns>System.String[].</returns>
        private static string[] Optimize(string[] parkingSpaces)
        {
            int saveIndex = -1;
            for (int i = 0; i < parkingSpaces.Length; i++)
            {
                if (parkingSpaces[i].EndsWith(";") && saveIndex == -1)
                {
                    saveIndex = i;
                }
                else if (parkingSpaces[i].EndsWith(";") && saveIndex != -1)
                {
                    parkingSpaces[saveIndex] += parkingSpaces[i].Substring(0, 24);
                    Console.WriteLine("Flytta {0} från plats {1} till plats {2}", parkingSpaces[i].Substring(0, 6), i + 1, saveIndex);

                    parkingSpaces[i] = "";
                    saveIndex = -1;
                }
            }

            /*  Goes through the elements (vehicles). If there's an empty space before a filled space, move to the left.
             for (int i = 1; i < parkingSpaces.Length; i++)
             {
                 string tmp = "";
                 if (parkingSpaces[i] != "" && parkingSpaces[i - 1] == "")
                 {
                     Console.WriteLine("Flytta {0} från plats {1} till plats {2}", parkingSpaces[i].Substring(0, 6), i, i - 1);
                     tmp = parkingSpaces[i];
                     parkingSpaces[i - 1] = parkingSpaces[i];
                     tmp = "";
                     parkingSpaces[i] = tmp;
                     Console.ReadKey();
                 }
             }
             */

            Console.ReadKey();
            return parkingSpaces;
        }

        /// <summary>
        /// Determines whether [is valid identifier] [the specified vehicle identifier].
        /// </summary>
        /// <param name="vehicleID">The vehicle identifier.</param>
        /// <returns><c>true</c> if [is valid identifier] [the specified vehicle identifier]; otherwise, <c>false</c>.</returns>
        private static bool IsValidID(string vehicleID)
        {
            /// Pattern for Reg using 3 A-Z char and 3 numbers.
            string pattern = @"[A-Z]{3}\d{3}";
            Regex rgx = new Regex(pattern);

            bool valid = rgx.IsMatch(vehicleID);

            /// Check pattern using Regex .IsMatch against vehicleID input by User
            if (valid)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Search method. Called from both Search and Collect. Returns
        /// index of vehicle if found.
        /// </summary>
        /// <param name="parkingPlaces">The parking places.</param>
        /// <param name="vehicleID">The vehicle identifier.</param>
        /// <returns>System.Int32.</returns>
        private static int Search(string[] parkingPlaces, string vehicleID)
        {
            bool found = false;
            int index = 0;
            for (int i = 0; i < parkingPlaces.Length; i++)
            {
                if (parkingPlaces[i].Contains(vehicleID))
                {
                    found = true;
                    index = i;
                    break;
                }
            }
            /// Check if (found) return position of parkingPlaces[i] that Contains"vehicleID" as int index

            if (found)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Moves the specified parking places.
        /// </summary>
        /// <param name="parkingPlaces">The parking places.</param>
        /// <param name="oldPosition">The old position.</param>
        /// <param name="newPosition">The new position.</param>
        /// <param name="vehicleID">The vehicle identifier.</param>
        /// <returns>System.String[].</returns>
        private static string[] Move(string[] parkingPlaces, int oldPosition, int newPosition, string vehicleID)
        {
            if (newPosition != oldPosition)
            {
                /// if bil or 1mc
                if (parkingPlaces[oldPosition].Length < 30)
                {
                    //check if car or mc

                    /// mc and not car
                    if (parkingPlaces[oldPosition].EndsWith(";") && ((parkingPlaces[newPosition].EndsWith(";") || parkingPlaces[newPosition] == "")))
                    {
                        /// copy
                        if (parkingPlaces[newPosition] == "")
                        {
                            parkingPlaces[newPosition] = parkingPlaces[oldPosition].Substring(0, 27);
                            Console.WriteLine($"Flytta {parkingPlaces[oldPosition].Substring(0, 6)} från plats {oldPosition + 1} till plats {newPosition + 1}");
                            parkingPlaces[oldPosition] = "";
                        }
                        ///  adds
                        else
                        {
                            parkingPlaces[newPosition] += parkingPlaces[oldPosition].Substring(0, 26);
                            Console.WriteLine($"Flytta {parkingPlaces[oldPosition].Substring(0, 6)} från plats {oldPosition + 1} till plats {newPosition + 1}");
                            parkingPlaces[oldPosition] = "";
                        }
                    }
                    /// bil
                    else if (!parkingPlaces[oldPosition].EndsWith(";") && !parkingPlaces[newPosition].EndsWith(";"))

                    {
                        parkingPlaces[newPosition] = parkingPlaces[oldPosition];
                        Console.WriteLine($"Flytta {parkingPlaces[oldPosition].Substring(0, 6)} från plats {oldPosition + 1} till plats {newPosition + 1}");
                        parkingPlaces[oldPosition] = "";
                    }
                    else
                    {
                        Console.WriteLine($"Plats {newPosition + 1} är upptagen");
                    }
                }

                /// if existed array  has 2x motor   - move 1 to up
                else if (parkingPlaces[oldPosition].Length > 30)
                {
                    string[] tempArray = parkingPlaces[oldPosition].Split(';');

                    if (tempArray[0] == vehicleID)
                    {
                        ///get 1st MC out

                        ///  if empty
                        if (parkingPlaces[newPosition] == "")
                        {
                            /// modify new array
                            parkingPlaces[newPosition] = parkingPlaces[oldPosition].Substring(0, 26) + ";";
                            /// modify old array
                            parkingPlaces[oldPosition] = parkingPlaces[oldPosition].Substring(27, 26) + ";";

                            Console.WriteLine($"Flytta {vehicleID} från plats {oldPosition + 1} till plats {newPosition + 1}");
                        }

                        /// if there is one parked.
                        else if (parkingPlaces[newPosition].EndsWith(";"))
                        {
                            parkingPlaces[newPosition] += parkingPlaces[oldPosition].Substring(0, 26);
                            parkingPlaces[oldPosition] = parkingPlaces[oldPosition].Substring(27, 26) + ";";
                            Console.WriteLine($"Flytta {vehicleID} från plats {oldPosition + 1} till plats {newPosition + 1}");
                        }
                        else
                        {
                            Console.WriteLine($"Plats {newPosition + 1} är upptagen");
                        }
                    }
                    else if (tempArray[2] == vehicleID)
                    {
                        ///get 2nd mc out
                        ///if empty

                        if (parkingPlaces[newPosition] == "")
                        {
                            parkingPlaces[newPosition] = parkingPlaces[oldPosition].Substring(26, 27) + ";";
                            parkingPlaces[oldPosition] = parkingPlaces[oldPosition].Substring(26, 27);

                            Console.WriteLine($"Flytta {vehicleID} från plats {oldPosition + 1} till plats {newPosition + 1}");
                        }

                        /// if there is one parked.
                        else if (parkingPlaces[newPosition].EndsWith(";"))
                        {
                            parkingPlaces[newPosition] += parkingPlaces[oldPosition].Substring(27, 26);
                            parkingPlaces[oldPosition] = parkingPlaces[oldPosition].Substring(0, 26) + ";";
                            Console.WriteLine($"Flytta {vehicleID} från plats {oldPosition + 1} till plats {newPosition + 1}");
                        }
                        else
                        {
                            Console.WriteLine($"Plats {newPosition + 1} är upptagen");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Den är redan parkerad där.");
            }

            return parkingPlaces;
        }

        /// <summary>
        /// Method that Collects a parked car, then removes it from the array.
        /// </summary>
        /// <param name="parkingPlaces">The parking places.</param>
        /// <param name="vehicleID">The vehicle identifier.</param>
        /// <returns>System.String[].</returns>
        private static string[] Collect(string[] parkingPlaces, string vehicleID)
        {
            /// Initiate TimeSpan = 0
            TimeSpan diff_time = TimeSpan.Zero;

            int searchResult = Search(parkingPlaces, vehicleID);
            ///Checking if to found vehicleID in parkingPlaces

            if (searchResult != -1)
            {
                TimeSpan diff = TimeSpan.Zero;

                string[] tmpArray = parkingPlaces[searchResult].Split(';');

                if (tmpArray.Length == 4)
                /// 2 MC, array length = 4
                /// if it takes more than 4 places in parkingPlaces, equals to 2MC
                {
                    /// Loop to manipulate every parkingPlaces[%2==0], == 0->2->4->N+2
                    for (int i = 0; i < tmpArray.Length; i += 2)
                    {
                        DateTime now = DateTime.Now;

                        if (tmpArray[i] != vehicleID)
                        {
                            parkingPlaces[searchResult] = tmpArray[i] + ";" + tmpArray[i + 1] + ";";
                        }
                        else
                        {
                            DateTime parkingTime = DateTime.Parse(tmpArray[i + 1]);
                            diff = now - parkingTime;
                            diff_time = diff;
                        }
                    }
                }
                else
                /// Bil och 1 MC. Array kommer vara 2 eller 3, men samma operation oavsett
                {
                    DateTime now = DateTime.Now;
                    DateTime parkingTime = DateTime.Parse(tmpArray[1]);
                    diff = now - parkingTime;
                    diff_time = diff;
                    parkingPlaces[searchResult] = "";
                }
            }
            /// Println elapsed time
            Console.WriteLine("Parkeringstid: {0}", diff_time);
            Console.ReadKey();

            return parkingPlaces;
        }

        /// <summary>
        /// Parks the specified parking places.
        /// </summary>
        /// <param name="parkingPlaces">The parking places.</param>
        /// <param name="vehicleID">The vehicle identifier.</param>
        /// <param name="vehicleType">Type of the vehicle.</param>
        /// <returns>System.String[].</returns>
        private static string[] Park(string[] parkingPlaces, string vehicleID, string vehicleType)
        {
            ///Time Stamp initiated
            DateTime parkedTime = DateTime.Now;
            int index = 0;
            bool duplicate = false;

            for (int i = 0; i < parkingPlaces.Length; i++)
            {
                if (parkingPlaces[i].Contains(vehicleID))
                {
                    duplicate = true;
                    break;
                }

                /// if it's Motorbike and parkingPlaces[i]: (or HalfFull)
                /// aaa123; => aaa123; + vehicleID+ parkedTime == aaa123;bbb123+parkedTime
                /// returns position as int index
                else if (vehicleType == "m" && parkingPlaces[i].EndsWith(";") && !parkingPlaces[i].Contains(vehicleID))
                {
                    parkingPlaces[i] += vehicleID + ";" + parkedTime;
                    index = i;
                    duplicate = false;
                    break;
                }
                /// Else If type = m and empty,
                ///
                /// Adds vehicleID;parkedTime; to parkingPlaces[i]
                /// returns position as int index
                ///
                else if (vehicleType == "m" && parkingPlaces[i] == "" && !parkingPlaces[i].Contains(vehicleID))
                {
                    parkingPlaces[i] = vehicleID + ";" + parkedTime + ";";
                    index = i;
                    duplicate = false;
                    break;
                }

                /// if  this position of an Array is empty,
                /// For park all
                /// Set ParkingPlaces[i] = vehicleID, and returns position as int index
                /// "AAA111;2017-06-15 20:59:09"
                else if (parkingPlaces[i] == "" && !parkingPlaces[i].Contains(vehicleID))
                {
                    parkingPlaces[i] = vehicleID + ";" + parkedTime;
                    index = i;
                    duplicate = false;
                    break;
                }
            }

            /// Also checks for the same name plate

            if (duplicate == true)
            {
                Console.WriteLine($"{vehicleID} är redan parkerad.");
            }
            else
            {
                Console.WriteLine("Parkera på plats: {0}", index + 1);
            }

            Console.ReadKey();
            return parkingPlaces;
        }

        /// <summary>
        /// Mains the menu.
        /// </summary>
        /// <param name="parkingPlaces">The parking places.</param>
        private static void MainMenu(string[] parkingPlaces)
        {
            string vehicleID, vehicleType;
            int newPosition, oldPosition;
            bool menu = true;

            /// loops the menu
            while (menu)
            {
                Console.Clear();
                Console.WriteLine("## Prague Parking ##\n");
                Console.Write("1. Lämna\n2. Hämta\n3. Sök\n4. Optimera\n5. Lista\n6. Flytta\n7. Töm sparfil\n8. Avsluta\n\n");

                /// Visualising Array in Real-time by looping conditions in parkingPlaces[]
                Visualize(parkingPlaces);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("\n>");
                string menuItem = Console.ReadLine();

                /// menu Display Choices.
                switch (menuItem)
                {
                    case "1":
                        Console.Write("(B)il/(M)C: ");
                        vehicleType = Console.ReadLine().ToLower();
                        /// See Asking for type Car or Motorbike
                        if (vehicleType != "b" && vehicleType != "m")
                        {
                            Console.WriteLine("Ej giltigt val.");
                            Console.ReadKey();
                            break;
                        }

                        Console.Write("Registreringsnummer: ");
                        vehicleID = Console.ReadLine().ToUpper();
                        /// Read in Type and ID from Users and send vehicleID to be checked by IsValidID method

                        if (IsValidID(vehicleID))
                        {
                            parkingPlaces = Park(parkingPlaces, vehicleID, vehicleType);
                            break;
                        }
                        else
                        /// Error Case
                        {
                            Console.WriteLine("Ej giltigt registreringsnummer.");
                            Console.ReadKey();
                            break;
                        }

                    case "2":
                        Console.Write("Registreringsnummer: ");
                        vehicleID = Console.ReadLine().ToUpper();

                        /// Read in ID from User and send vehicleID to be checked by IsValidID method then send vehicleID parkingPlaces[] to Collect

                        if (IsValidID(vehicleID))
                        {
                            parkingPlaces = Collect(parkingPlaces, vehicleID);
                            break;
                        }
                        else
                        {
                            ///Error Case
                            Console.WriteLine("Ej giltigt registreringsnummer.");
                            Console.ReadKey();
                            break;
                        }

                    case "3":
                        Console.Write("Registreringsnummer: ");
                        vehicleID = Console.ReadLine().ToUpper();
                        /// Position returns as int res using vehicleID that sent to Search

                        if (IsValidID(vehicleID))
                        {
                            oldPosition = Search(parkingPlaces, vehicleID);
                            /// Check if (found)

                            if (oldPosition != -1)
                            {
                                Console.WriteLine("{0} på plats {1}", vehicleID, oldPosition);
                            }
                            else
                            //// Error message
                            {
                                Console.WriteLine($"Kunde inte hitta {vehicleID}");
                            }
                        }
                        else
                        {
                            ///Error Case
                            Console.WriteLine($"Kunde inte hitta {vehicleID}");
                            Console.ReadKey();
                            break;
                        }
                        Console.ReadKey();
                        break;

                    case "4":
                        /// Rearrange parkingPlaces[] using Optimize();
                        parkingPlaces = Optimize(parkingPlaces);
                        break;

                    case "5":
                        /// To Map();
                        Map(parkingPlaces);
                        break;

                    case "6":
                        /// To Move();
                        ///
                        Console.Write("Registreringsnummer: ");
                        vehicleID = Console.ReadLine().ToUpper();

                        if (IsValidID(vehicleID))
                        {
                            oldPosition = Search(parkingPlaces, vehicleID);
                            /// Check if (found)

                            if (oldPosition != -1)
                            {
                                Console.WriteLine($"{vehicleID} är på plats {oldPosition + 1}");
                                Console.WriteLine("Enter new parking space: ");
                                try
                                {
                                    newPosition = Int32.Parse(Console.ReadLine()) - 1;
                                    if (newPosition < 0 && newPosition > 100)
                                    {
                                        Console.WriteLine($"Platsen finns inte");
                                        Console.ReadKey();
                                        break;
                                    }
                                    else
                                    {
                                        parkingPlaces = Move(parkingPlaces, oldPosition, newPosition, vehicleID);
                                    }
                                }
                                catch (Exception) ////+e
                                {
                                    Console.WriteLine($"Något gick fel "); ///+ e to show error
                                    break;
                                }
                            }
                            else
                            //// Error message
                            {
                                Console.WriteLine($"Kunde inte hitta {vehicleID}");
                            }
                        }
                        else
                        {
                            ///Error Case
                            Console.WriteLine($"Kunde inte hitta {vehicleID}");
                            Console.ReadKey();
                            break;
                        }
                        Console.ReadKey();

                        break;

                    case "7":
                        for (int i = 0; i < parkingPlaces.Length; i++)
                        {
                            parkingPlaces[i] = "";
                        }
                        break;

                    case "8":
                        /// Switch off loop, Save to txt-file

                        Save(parkingPlaces);
                        menu = false;
                        break;

                    default:
                        /// For all others irrelevant inputs
                        Console.WriteLine("Ogiltigt val. Tryck på valfri tangent för att fortsätta");
                        Console.ReadKey();
                        break;
                }
            }
        }

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        private static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Green;
            string[] logo = {
             " ____                               ____            _    _             \n",
            "|  _ \\ _ __ __ _  __ _ _   _  ___  |  _ \\ __ _ _ __| | _(_)_ __   __ _ \n",
            "| |_) | '__/ _` |/ _` | | | |/ _ \\ | |_) / _` | '__| |/ / | '_ \\ / _` |\n",
            "|  __/| | | (_| | (_| | |_| |  __/ |  __/ (_| | |  |   <| | | | | (_| |\n",
            "|_|   |_|  \\__,_|\\__, |\\__,_|\\___| |_|   \\__,_|_|  |_|\\_\\_|_| |_|\\__, |\n",
            "                |___/                                           |___/  \n",
            };

            /*  /// 90s Animation

              foreach (string row in logo)
              {
                  for (int i = 0; i < row.Length; i++)
                  {
                      Console.Write(row[i]);
                      Thread.Sleep(1);
                  }
              }

              Thread.Sleep(1500);
              */
            string[] parkingPlaces = new string[100];

            /// Create An array and Fill all of its size with values
            /// parkingPLaces[i] != null
            string path = @"C:\Users\elev1\Downloads\parkingplaces.txt";
            if (!File.Exists(path))
            {
                for (int i = 0; i < parkingPlaces.Length; i++)
                {
                    parkingPlaces[i] = "";
                }
            }
            else
            {
                /// Open the file to read from, save to array
                parkingPlaces = File.ReadAllLines(path, Encoding.UTF8);
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            /// Run MainMenu using parkingPlaces[]
            MainMenu(parkingPlaces);
        }
    }
}