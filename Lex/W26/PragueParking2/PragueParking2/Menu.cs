using System;

namespace PragueParking2
{
    [Serializable]
    public class Menu
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Menu"/> class.
        /// </summary>
        public Menu()
        {
            MenuPage();
        }

        /// <summary>
        /// Menus the page.
        /// </summary>
        public void MenuPage()
        {
            bool menu = true;
            Parking park = new Parking();

            while (menu)
            {
                Console.Clear();
                Console.WriteLine("## Prague Parking ##\n");
                Console.Write(
                    "1. ADD\n2. Remove\n3. Search\n4. Optimize\n5. Show List\n6. Move\n7. Save/Load\n8. Add random cars\n9. Add random cars in order\n0. Exit\n\n");
                Features.PrintVisualisationMap(ref park);
                Console.WriteLine("Empty spaces left: " + park.EmptySpaces);
                Console.WriteLine("Partly empty spaces left: " + park.PartlyEmptySpaces);

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("===== ADD NEW VEHICLE ===== ");
                        string reg = Features.InputRegistration();
                        int size = 0;

                        do
                        {
                            try
                            {
                                Console.WriteLine("Choose type {1=B,2=Mc,3=Tri,4=Car}: ");
                                size = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("must be within 1-4");
                            }
                        } while (size < 1 || size > 4);

                        string identification = "";

                        switch (size)
                        {
                            case 4:
                                Console.WriteLine("Enter your car's color: ");
                                identification = Console.ReadLine();
                                Console.WriteLine(
                                    $"Reg = {reg}\nSize = {size} \nIden = {identification} \nType: Car \nTime: {DateTime.Now}");

                                break;

                            case 2:
                                Console.WriteLine("Enter your mc's brand: ");
                                identification = Console.ReadLine();
                                Console.WriteLine(
                                    $"Reg = {reg}\nSize = {size} \nIden = {identification} \nType: Mc \nTime: {DateTime.Now}");
                                break;

                            case 3:
                                Console.WriteLine("Enter your tricycle's brand: ");
                                identification = Console.ReadLine();
                                Console.WriteLine(
                                    $"Reg = {reg}\nSize = {size} \nIden = {identification} \nType: Tri \nTime: {DateTime.Now}");
                                break;

                            case 1:
                                Console.WriteLine("Enter your bike's color: ");
                                identification = Console.ReadLine();
                                Console.WriteLine(
                                    $"Reg = {reg}\nSize = {size} \nIden = {identification} \nType: Bike \nTime: {DateTime.Now}");
                                break;

                            default:
                                Console.WriteLine("TOMZOOB");
                                break;
                        }
                        int parkingSpaceIndex = park.Add(reg, size, identification);
                        if (parkingSpaceIndex == -1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("No parking space for this vehicle found");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine($"Park this vehicle at space {parkingSpaceIndex}");
                        }
                        Features.PressToContine();
                        break;

                    //remove
                    case "2":
                        Console.WriteLine("===== CHECK OUT VEHICLE ===== ");
                        ;
                        int spaceParkedIndex = park.Remove(Features.InputRegistration(), out TimeSpan duration);
                        if (spaceParkedIndex == -1)
                        {
                            Console.WriteLine("Can't find that Vehicle.");
                        }
                        else
                        {
                            Console.WriteLine(
                                $"Vehicle is parked at {spaceParkedIndex + 1} and has been parked for {Features.FormatStringOfDurationParked(duration)}.");
                        }
                        Features.PressToContine();
                        break;
                    //search
                    case "3":
                        Console.WriteLine("===== FIND VEHICLE ===== ");
                        int parkedSpace = park.Find(Features.InputRegistration());

                        if (parkedSpace == -1)
                        {
                            Console.WriteLine("Can't find that Vehicle.");
                        }
                        else
                        {
                            Console.WriteLine($"Vehicle is parked at {parkedSpace + 1}");
                        }
                        Features.PressToContine();
                        break;

                    //optimize
                    case "4":
                        break;
                    //show list

                    case "5":
                        //Parking content = new Parking();
                        Console.Clear();
                        Console.WriteLine(park.Content());
                        Console.ReadKey();
                        break;

                    // move
                    case "6":
                        Console.WriteLine("===== MOVE VEHICLE ===== ");
                        string input = Features.InputRegistration();
                        int newPos = 0;

                        do
                        {
                            try
                            {
                                Console.WriteLine("Where do you want to move: ");
                                newPos = Int32.Parse(Console.ReadLine());
                            }
                            catch (Exception)
                            {
                                Console.Clear();
                                Console.WriteLine("must be within 1-100");
                            }
                        } while (newPos < 1 || newPos > 100);

                        switch (park.Move(input, newPos - 1))
                        {
                            case -1:
                                Console.WriteLine("Vehicle not in parking");
                                break;

                            case 1:
                                Console.WriteLine("You can now move the vehicle to " + newPos);
                                break;

                            case 0:
                                Console.WriteLine("New space doesn't have room for vehicle");
                                break;
                        }

                        Features.PressToContine();

                        break;
                    //Save and Load
                    case "7":

                        Console.WriteLine("1 to Save, 0 to Load");
                        string Path = @"C:\Users\TomzPC\Desktop\ParkingData.bin";
                        switch (Console.ReadLine())
                        {
                            case "0":

                                Console.WriteLine("Loading from BIN");
                                park = (Parking) ReadFromBin.ReadFromBinaryFile<object>(Path);
                                Console.WriteLine("Completed.");

                                break;

                            case "1":

                                Console.WriteLine("Saving to BIN..");
                                WriteToBin.WriteToBinaryFile<object>(Path, park);
                                Console.WriteLine("Completed.");

                                break;

                            default:
                                break;
                        }

                        break;
                    // debug
                    case "8":
                        Console.WriteLine("===== ADDING RANDOM CARS ===== ");
                        Console.WriteLine("Input number of cars to add");
                        try
                        {
                            DebugFeatures.AddVehiclesInRandomSpaces(ref park, int.Parse(Console.ReadLine()));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Write a real int");
                        }

                        break;

                    case "9":
                        Console.WriteLine("===== ADDING RANDOM CARS IN ORDER ===== ");
                        Console.WriteLine("Input number of cars to add");
                        try
                        {
                            DebugFeatures.AddVehiclesInOrder(ref park, int.Parse(Console.ReadLine()));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Write a real int");
                        }
                        break;

                    case "0":
                        menu = false;
                        break;

                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }
        }
    }
}