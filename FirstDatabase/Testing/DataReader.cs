﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Testing
{
    class DataReader
    {
        public List<Ticket> Tickets { get; private set; }
        public string Officer { get; private set; }
        public DataReader(string officer, string path)
        {
            this.Tickets = new List<Ticket>();
            this.Officer = officer;
            this.GetDataFromCSV(path);
        }

        private void GetDataFromCSV(string path)
        {
            using StreamReader streamReader = new StreamReader(path);
            string line;
            while((line = streamReader.ReadLine())!=null)
            {
                if(IsValid(line))
                {
                    string[] row = line.Split(';', StringSplitOptions.RemoveEmptyEntries);
                    string vehicleID = row[0];
                    string passport = row[1];
                    string note = row[2];
                    DateTime ticketDay = DateTime.Parse(row[3]);
                    string name = row[4];

                    this.Tickets.Add(new Ticket(name, vehicleID, passport, note, ticketDay, this.Officer));
                }                
            }
        }

        /// <summary>
        /// Check if input data is valid
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private static bool IsValid(string line)
        {
            string[] row = line.Split(';', StringSplitOptions.RemoveEmptyEntries);
            
            if(row.Length !=5)
            {
                return false;
            }

            if(!DateTime.TryParse(row[3],out _))
            {
                return false;
            }
            return true;
        }
        public void PrintData()
        {
            foreach(var ticket in this.Tickets)
            {
                Console.WriteLine(ticket.ToString());
            }
        }

    }
}
