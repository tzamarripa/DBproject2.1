using System;

namespace DBproject2._1
{
    /// <summary>
    /// Represents a Member record
    /// </summary>
    public class MemberDetails
    {
        public string MemberId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime JoinDate { get; set; }
    }

    public class Author
    {
        public int ID  { get; set; }
        public string Firstname { get; set; }
        public string MiddleInitial { get; set; }
        public string Lastname { get; set; }
        public string FriendlyName
        {
            get
            {
                if (MiddleInitial == null || MiddleInitial.Length == 0)
                {
                    return string.Format("{0} {1}", Firstname, Lastname);
                }
                else
                {
                    return string.Format("{0} {1}. {2}", Firstname, MiddleInitial, Lastname);
                }
            }
        }
    }
}