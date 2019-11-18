using System;
using System.Collections.Generic;

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

    /// <summary>
    /// Represents a book that matched the user's search term(s).
    /// </summary>
    public class BookSearchResult
    {
        public string Title { get; set; }
        public string PublishDate { get; set; }
        public string ISBN { get; set; }
        public string Barcode { get; set; }
        public int Quantity { get; set; }
        public List<Author> Authors { get; set; }

        public BookSearchResult()
        {
            Authors = new List<Author>(2);
        }
    }

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