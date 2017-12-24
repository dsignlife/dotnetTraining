using System;
using System.Text.RegularExpressions;

namespace PragueParking2
{
    /// <summary>
    /// Class Features.
    /// </summary>
    internal class Features
    {
        /// <summary>
        /// Inputs the registration.
        /// </summary>
        /// <returns>String.</returns>
        public static String InputRegistration()
        {
            Regex rg = new Regex(@"^[a-zA-Z0-9]+$"); // adds regex for accepting a-z,A-Z,0-9
            Console.WriteLine("Please input the registration number");
            string reg = Console.ReadLine();

            while (!rg.IsMatch(reg))
            {
                Console.WriteLine("Not a valid registration. Only A-Z and 0-9 accepted.");
                Console.WriteLine("Please input the registration number");
                reg = Console.ReadLine();
            }
            reg = reg.ToUpper(); //make it uppercase
            return reg;
        }

        /// <summary>
        /// Handles waiting for user to continue.
        /// </summary>
        public static void PressToContine()
        {
            Console.WriteLine("\n_________________________");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }

        /// <summary>
        /// Prints the visualisation map.
        /// </summary>
        /// <param name="park">The park.</param>
        public static void PrintVisualisationMap(ref Parking park)
        {
            int[] visualMapArray = park.Visualisation();
            for (int i = 0; i < visualMapArray.Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                if (visualMapArray[i] == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\u25a0 ");
                }
                else
                {
                    if (visualMapArray[i] == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\u25a0 ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\u25a0 ");
                    }
                }
                ///Only show 10 eachline
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
            Console.ResetColor();
        }

        /// <summary>
        /// Formats the string of duration parked.
        /// </summary>
        /// <param name="duration">The duration.</param>
        /// <returns>System.String.</returns>
        public static string FormatStringOfDurationParked(TimeSpan duration)
        {
            string returnString = "";

            //Print days
            if (duration.Days == 1)
            {
                returnString += "1 day, ";
            }
            else if (duration.Days > 1)
            {
                returnString += duration.Days + " days, ";
            }

            //Print hours
            if (duration.Hours == 1)
            {
                returnString += "1 hour, ";
            }
            else if (duration.Hours > 1)
            {
                returnString += duration.Hours + " hours, ";
            }

            if (duration.Hours >= 1) //print "and" if 1 hour or longer
            {
                returnString += "and ";
            }

            //Print minutes
            if (duration.Minutes == 1)
            {
                returnString += "1 minute";
            }
            else if (duration.Minutes > 1 || duration.Minutes == 0)
            {
                returnString += duration.Minutes + " minutes";
            }

            //Print seconds
            if (duration.Hours < 1) //only print seconds if under 1 hour
            {
                returnString += " and";

                if (duration.Seconds == 1)
                {
                    returnString += " 1 second";
                }
                else if (duration.Seconds > 1 || duration.Seconds == 0)
                {
                    returnString += " " + duration.Seconds + " seconds";
                }
            }
            return returnString;
        }
    }
}