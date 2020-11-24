using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormUI
{
    public class Person
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public string Credit_card { get; set; }       

        public string FullInfo 
        { 
            get
            {
                return $"{first_name} {last_name} ({email})";
            }             
        }
    }
}
