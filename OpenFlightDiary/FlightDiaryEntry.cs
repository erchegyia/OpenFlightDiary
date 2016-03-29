using System;

namespace OpenFlightDiary
{
    class FlightDiaryEntry
    {
        #region Private fields

        private DateTime date;

        private string flightNumber;

        private string fromAirport;
        private string toAirport;

        private TimeSpan depTime;
        private TimeSpan arrTime;
        private TimeSpan duration;

        private string airline;

        private string acType;
        private string acRegistration;

        private string seat;
        private string seatType;
        private string flightClass;
        private string reason;

        private string note;

        private string depId;
        private string arrId;
        private string airlineId;
        private string aircraftId;

        #endregion

        #region Properties

        internal DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        internal string FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }

        internal string FromAirport
        {
            get { return fromAirport; }
            set { fromAirport = value; }
        }

        internal string ToAirport
        {
            get { return toAirport; }
            set { toAirport = value; }
        }

        internal TimeSpan DepTime
        {
            get { return depTime; }
            set { depTime = value; }
        }

        internal TimeSpan ArrTime
        {
            get { return arrTime; }
            set { arrTime = value; }
        }

        internal TimeSpan Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        internal string Airline
        {
            get { return airline; }
            set { airline = value; }
        }

        internal string AcType
        {
            get { return acType; }
            set { acType = value; }
        }

        internal string AcRegistration
        {
            get { return acRegistration; }
            set { acRegistration = value; }
        }

        internal string Seat
        {
            get { return seat; }
            set { seat = value; }
        }

        internal string SeatType
        {
            get { return seatType; }
            set { seatType = value; }
        }

        internal string FlightClass
        {
            get { return flightClass; }
            set { flightClass = value; }
        }

        internal string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        internal string Note
        {
            get { return note; }
            set { note = value; }
        }

        internal string DepId
        {
            get { return depId; }
            set { depId = value; }
        }

        internal string ArrId
        {
            get { return arrId; }
            set { arrId = value; }
        }

        internal string AirlineId
        {
            get { return airlineId; }
            set { airlineId = value; }
        }

        internal string AircraftId
        {
            get { return aircraftId; }
            set { aircraftId = value; }
        }

        #endregion

        #region Constructor

        public FlightDiaryEntry(DateTime date, string fromAirport, string toAirport)
        {
            this.date = date;
            this.fromAirport = fromAirport;
            this.toAirport = toAirport;
        }

        #endregion
    }
}