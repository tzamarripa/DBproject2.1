using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBproject2._1
{
    public class LibrarianAccount
    {
        public int ID { get; internal set; }
        public string Firstname { get; internal set; }
        public string Lastname { get; internal set; }
        public DateTime StartDate { get; internal set; }
        public bool IsAdmin { get; internal set; }
        public string Street { get; internal set; }
        public string City { get; internal set; }
        public string State { get; internal set; }
        public string ZipCode { get; internal set; }
        public string PasswordHash { get; internal set; }
    }
}
