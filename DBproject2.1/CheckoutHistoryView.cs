using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBproject2._1
{
    public partial class CheckoutHistoryView : Form
    {
        public MemberDetails MemberDetails { get; set; }
        public SqlConnection DbConnection { get; set; }

        private DataTable history;

        public CheckoutHistoryView()
        {
            InitializeComponent();
        }

        private void CheckoutHistoryView_Load(object sender, EventArgs e)
        {
            history = new DataTable();

            history.Columns.Add("Checkout Date");
            history.Columns.Add("Title");
            history.Columns.Add("Author(s)");
            history.Columns.Add("ISBN");
            history.Columns.Add("Returned Date");

            gridCheckouts.DataSource = history;

            var records = LoadFromDB();

            foreach(var rec in records)
            {
                Info r = (Info)rec;
                history.Rows.Add(r.CheckoutDate, r.Title, r.Authors.GetNames(), r.ISBN, r.ReturnedDate);
            }
        }

        private ICollection LoadFromDB()
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select b.ISBN, c.CheckoutDate, b.Title, ci.ReturnedDate, a.Fname, a.Minit, a.Lname " +
                                "from CHECKOUT c " +
                                "join CHECKOUT_ITEM ci on ci.CheckoutID = c.CheckoutID " +
                                "join INVENTORY i on i.Barcode = ci.InventoryID " +
                                "join BOOK b on b.ISBN = i.BookID " +
                                "join BOOK_AUTHOR ba on ba.BookID = b.ISBN " +
                                "join AUTHOR a on a.ID = ba.AuthorID " +
                                "where c.MemberID = @memberId " +
                                "order by c.CheckoutDate desc";
            cmd.Parameters.AddWithValue("memberId", MemberDetails.MemberId);

            Hashtable t = new Hashtable();

            using (var reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    var ISBN = reader.GetString(0);

                    var item = (Info)t[ISBN];

                    if (item == null)
                    {
                        item = new Info()
                        {
                            ISBN = ISBN,
                            CheckoutDate = reader.GetDateTime(1).ToString("dd/MM/yyyy"),
                            Title = reader.GetString(2),
                            ReturnedDate = reader.IsDBNull(3) ? "" : reader.GetDateTime(3).ToString("dd/MM/yyyy")
                        };

                        t[ISBN] = item;
                    }

                    item.Authors.Add(new Author()
                    {
                        Firstname = reader.GetString(4),
                        MiddleInitial = (reader.IsDBNull(5) ? null : reader.GetString(5)),
                        Lastname = reader.GetString(6)
                    });
                }
            }

            return t.Values;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private class Info
        {
            internal string ISBN { get; set; }
            internal string CheckoutDate { get; set; }
            internal string Title { get; set; }
            internal string ReturnedDate { get; set; }
            internal List<Author> Authors { get; set; }

            public Info()
            {
                Authors = new List<Author>(2);
            }
        }
    }
}
