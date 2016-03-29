using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OpenFlightDiary
{
    static class CsvHandler
    {
        static internal List<FlightDiaryEntry> ReadAllFlightDiaryEntries(string path)
        {
            List<FlightDiaryEntry> resList = new List<FlightDiaryEntry>();
            bool header = true;
            foreach (string line in File.ReadAllLines(path))
            {
                //ignore header
                if (header)
                {
                    header = false;
                    continue;
                }

                string[] columns = line.Split(',');
                FlightDiaryEntry entry = new FlightDiaryEntry(DateTime.Parse(columns[0]),columns[2],columns[3]);
                entry.FlightNumber = columns[1];
                entry.DepTime = TimeSpan.Parse(columns[4]);
                entry.ArrTime = TimeSpan.Parse(columns[5]);
                entry.Duration = TimeSpan.Parse(columns[6]);
                entry.Airline = columns[7];
                entry.AcType = columns[8];
                entry.AcRegistration = columns[9];
                entry.Seat = columns[10];
                entry.SeatType = columns[11];
                entry.FlightClass = columns[12];
                entry.Reason = columns[13];
                entry.Note = columns[14];
                entry.DepId = columns[15];
                entry.ArrId = columns[16];
                entry.AirlineId = columns[17];
                entry.AircraftId = columns[18];
                resList.Add(entry);
            }
            return resList;
        }

        static internal void WriteOpenFlightEntries(string path, List<OpenFlightsEntry> list)
        {
            WriteOpenFlightEntries(path, list, false);
        }

        static internal void WriteOpenFlightEntries(string path, List<OpenFlightsEntry> list, bool overwriteAirline)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Date,From,To,Flight_Number,Airline,Distance,Duration,Seat,Seat_Type,Class,Reason,Plane,Registration,Trip,Note,From_OID,To_OID,Airline_OID,Plane_OID");
            foreach (OpenFlightsEntry entry in list)
            {
                StringBuilder line = new StringBuilder();
                sb.Append(entry.DateTime.ToString("yyyy-MM-dd hh:mm"));
                sb.Append(",");
                sb.Append(entry.FromIata);
                sb.Append(",");
                sb.Append(entry.ToIata);
                sb.Append(",");
                if (overwriteAirline)
                {
                    sb.Append(entry.FlightNumberWithCarrier);
                    sb.Append(",,");
                }
                else
                {
                    sb.Append(entry.FlightNumber);
                    sb.Append(",");
                    sb.Append(entry.Airline);
                    sb.Append(",");
                }
                sb.Append(entry.Distance);
                sb.Append(",");
                sb.Append(entry.Duration.Hours.ToString("D2") + ":" + entry.Duration.Minutes.ToString("D2"));
                sb.Append(",");
                sb.Append(entry.Seat);
                sb.Append(",");
                sb.Append(entry.SeatType);
                sb.Append(",");
                sb.Append(entry.FlightClass);
                sb.Append(",");
                sb.Append(entry.Reason);
                sb.Append(",");
                sb.Append(entry.AcType);
                sb.Append(",");
                sb.Append(entry.AcRegistration);
                sb.Append(",");
                sb.Append(entry.TripId);
                sb.Append(",");
                sb.Append(entry.Note);
                sb.Append(",");
                sb.Append(entry.FromOid);
                sb.Append(",");
                sb.Append(entry.ToOid);
                sb.Append(",");
                sb.Append(entry.AirlineOid);
                sb.Append(",");
                sb.Append(entry.PlaneOid);
                sb.AppendLine(line.ToString());
            }
            File.WriteAllText(path, sb.ToString());
        }
    }
}