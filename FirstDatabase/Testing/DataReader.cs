using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Testing
{
    class DataReader
    {
        public List<Guid> GuidID { get; private set; }
        public List<string> Names { get; private set; }
        public List<string> VehicleIDs { get; private set; }
        public List<string> Passports { get; private set; }
        public List<string> Notes { get; private set; }
        public List<DateTime> TicketDays { get; private set; }
        public List<DateTime> TicketIssue { get; private set; }
        public string Officer { get; private set; }
        public DataReader(string officer)
        {
            this.GuidID = new List<Guid>();
            this.Names = new List<string>();
            this.VehicleIDs = new List<string>();
            this.Passports = new List<string>();
            this.Notes = new List<string>();
            this.TicketDays = new List<DateTime>();
            this.TicketIssue = new List<DateTime>();
            this.Officer = officer;
        }
        public void GetDataFromCSV(string path)
        {
            using StreamReader streamReader = new StreamReader(path);
            string line;
            while((line = streamReader.ReadLine())!=null)
            {
                string[] row = line.Split(',', StringSplitOptions.RemoveEmptyEntries);

                this.GuidID.Add(Guid.NewGuid());
                this.TicketIssue.Add(DateTime.Now);
                this.VehicleIDs.Add(row[0]);
                this.Passports.Add(row[1]);
                this.Notes.Add(row[2]);
                this.TicketDays.Add(DateTime.Parse(row[3]));
                this.Names.Add(row[4]);
            }

        }

    }
}
