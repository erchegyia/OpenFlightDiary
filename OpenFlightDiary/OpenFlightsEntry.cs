using System;

namespace OpenFlightDiary
{
    class OpenFlightsEntry
    {
        #region Private fields

        private DateTime dateTime;

        private string fromIata;
        private string toIata;

        private string flightNumber;
        private string flightNumberWithCarrier;
        private string airline;

        private string distance;
        private TimeSpan duration;

        private string seat;
        private string seat_type;
        private string flightClass;
        private string reason;

        private string acType;
        private string acRegistration;

        private string tripId;

        private string note;

        private string fromOid;
        private string toOid;
        private string airlineOid;
        private string planeOid;

        #endregion

        #region Properties

        internal DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }

        internal string FromIata
        {
            get { return fromIata; }
            set { fromIata = value; }
        }

        internal string ToIata
        {
            get { return toIata; }
            set { toIata = value; }
        }

        internal string FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }

        internal string FlightNumberWithCarrier
        {
            get { return flightNumberWithCarrier; }
            set { flightNumberWithCarrier = value; }
        }

        internal string Airline
        {
            get { return airline; }
            set { airline = value; }
        }

        internal string Distance
        {
            get { return distance; }
            set { distance = value; }
        }

        internal TimeSpan Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        internal string Seat
        {
            get { return seat; }
            set { seat = value; }
        }

        internal string SeatType
        {
            get { return seat_type; }
            set { seat_type = value; }
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

        internal string TripId
        {
            get { return tripId; }
            set { tripId = value; }
        }

        internal string Note
        {
            get { return note; }
            set { note = value; }
        }

        internal string FromOid
        {
            get { return fromOid; }
        }

        internal string ToOid
        {
            get { return toOid; }
        }

        internal string AirlineOid
        {
            get { return airlineOid; }
        }

        internal string PlaneOid
        {
            get { return planeOid; }
        }

        #endregion

        #region Constructor

        public OpenFlightsEntry(DateTime dateTime, string fromIata, string toIata)
        {
            this.dateTime = dateTime;
            this.fromIata = fromIata;
            this.toIata = toIata;
        }

        #endregion
    }
}