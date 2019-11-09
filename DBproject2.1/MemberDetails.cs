using System;

namespace DBproject2._1
{
    /// <summary>
    /// Represents a Member record
    /// </summary>
    public class MemberDetails
    {
        public string MemberId { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public DateTime JoinDate { get; set; }
    }
}