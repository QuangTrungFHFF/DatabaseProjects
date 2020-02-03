using System;
using System.Collections.Generic;
using System.Text;

namespace Testing
{
    class Ticket
    {
        public Guid GuidID { get; private set; }
        public string Name { get; private set; }
        public string VehicleID { get; private set; }
        public string Passport { get; private set; }
        public string Notes { get; private set; }
        public DateTime TicketDay { get; private set; }
        public DateTime TicketIssue { get; private set; }
        public string Officer { get; private set; }
        public Ticket(string name, string vehicleId, string passport, string note, DateTime ticketDay, string officer)
        {
            this.GuidID = Guid.NewGuid();
            this.Name = name;
            this.VehicleID = vehicleId;
            this.Passport = passport;
            this.Notes = note;
            this.TicketDay = ticketDay;
            this.TicketIssue = DateTime.Today;
            this.Officer = officer;
        }
        public override string ToString()
        {
            return string.Format($"{GuidID} | {Name} | {VehicleID} | {Passport} | {Notes} | {TicketDay} | {TicketIssue} | {Officer}");
        }
    }
}
