using System;
using System.Collections.Generic;

namespace OpenFlightDiary
{
    static class Converter
    {
        internal static List<OpenFlightsEntry> ConvertList(List<FlightDiaryEntry> list)
        {
            List<OpenFlightsEntry> reslist = new List<OpenFlightsEntry>();
            foreach (FlightDiaryEntry entry in list)
            {
                reslist.Add(Convert(entry));
            }
            return reslist;
        }

        static OpenFlightsEntry Convert(FlightDiaryEntry source)
        {
            DateTime date = new DateTime(source.Date.Year, source.Date.Month, source.Date.Day, source.DepTime.Hours, source.DepTime.Minutes, 0);
            string from = source.FromAirport.Substring(source.FromAirport.Length - 10, 3);
            string to = source.ToAirport.Substring(source.ToAirport.Length - 10, 3);
            OpenFlightsEntry result = new OpenFlightsEntry(date, from, to);

            string fnWoSpaces = source.FlightNumber.Replace(" ", "").Replace("\"","");
            result.FlightNumberWithCarrier = fnWoSpaces;
            result.FlightNumber = (fnWoSpaces.Length < 3) ? "" : fnWoSpaces.Substring(2);
            string airlineWoQuotes = source.Airline.Replace("\"", "");
            result.Airline = (airlineWoQuotes.Length > 10) ? airlineWoQuotes.Substring(0, airlineWoQuotes.Length - 9) : "";
            if (result.Airline.Equals("Transportes Aereos de Cabo Verde")) { result.Airline = "TACV"; }
            if (result.Airline.Equals("Thai Airways")) { result.Airline += " International"; }
            result.Distance = "";
            result.Duration = source.Duration;
            result.Seat = source.Seat;
            switch (source.SeatType)
            {
                case "1":
                {
                    result.SeatType = "W";
                    break;
                }
                case "2":
                {
                    result.SeatType = "M";
                    break;
                }
                case "3":
                {
                    result.SeatType = "A";
                    break;
                }
                default:
                {
                    result.SeatType = "";
                    break;
                }
            }
            switch (source.FlightClass)
            {
                case "1":
                {
                    result.FlightClass = "Y";
                    break;
                }
                case "2":
                {
                    result.FlightClass = "C";
                    break;
                }
                case "3":
                {
                    result.FlightClass = "F";
                    break;
                }
                case "4":
                {
                    result.FlightClass = "P";
                    break;
                }
                default:
                {
                    result.FlightClass = "";
                    break;
                }
            }
            switch (source.Reason)
            {
                case "1":
                {
                    result.Reason = "L";
                    break;
                }
                case "2":
                {
                    result.Reason = "B";
                    break;
                }
                case "3":
                {
                    result.Reason = "C";
                    break;
                }
                case "4":
                {
                    result.Reason = "O";
                    break;
                }
                default:
                {
                    result.Reason = "";
                    break;
                }
            }
            string typeWoSpaces = source.AcType.Replace(" ()", "").Replace("\"","");
            result.AcType = (typeWoSpaces.Length > 7) ? typeWoSpaces.Substring(0, typeWoSpaces.Length - 7) : "";
            result.AcRegistration = source.AcRegistration;
            result.Note = source.Note.Replace("\"","");

            return result;
        }
    }
}