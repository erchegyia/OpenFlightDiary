using System;
using System.Collections.Generic;

namespace OpenFlightDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            string usage = "Usage:\n\tOpenFlightDiary.exe FlightDiaryPath OpenflightPath [overwriteAirline]";

            if (args.Length < 2)
            {
                Console.WriteLine("Too less arguments!\n" + usage);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Reading csv...");
            List<FlightDiaryEntry> flightDiaryEntryList;
            try
            {
                flightDiaryEntryList = CsvHandler.ReadAllFlightDiaryEntries(args[0]);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during csv reading!\n" + ex.Message);
                Console.ReadLine();
                return;
            }
            

            Console.WriteLine("Converting...");
            List<OpenFlightsEntry> openFlightsEntryList;
            try
            {
                openFlightsEntryList = Converter.ConvertList(flightDiaryEntryList);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during conversion!\n" + ex.Message);
                Console.ReadLine();
                return;
            }

            try
            {
                if (args.Length > 2 && (args[3].ToUpper().Equals("TRUE") || args[3].ToUpper().Equals("YES")))
                {
                    CsvHandler.WriteOpenFlightEntries(args[1], openFlightsEntryList, true);
                }
                else
                {
                    CsvHandler.WriteOpenFlightEntries(args[1], openFlightsEntryList);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during saving csv!\n" + ex.Message);
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Saved!");

            Console.ReadLine();
        }
    }
}