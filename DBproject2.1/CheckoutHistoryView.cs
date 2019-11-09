using System;
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
            history.Columns.Add("Author");
            history.Columns.Add("ISBN");
            history.Columns.Add("Returned Date");

            gridCheckouts.DataSource = history;

            LoadFromDB();
        }

        private void LoadFromDB()
        {
            var cmd = DbConnection.CreateCommand();
            cmd.CommandText = "select c.CheckoutDate, b.Title, b.Author_Fname, b.Author_Lname, b.ISBN, ci.ReturnedDate " +
                                "from CHECKOUT c " +
                                "join CHECKOUT_ITEM ci on ci.CheckoutID = c.CheckoutID " +
                                "join INVENTORY i on i.Barcode = ci.InventoryID " +
                                "join BOOK b on b.ISBN = i.BookID " +
                                "where c.MemberID = @memberId " +
                                "order by c.CheckoutDate desc";
            cmd.Parameters.AddWithValue("memberId", MemberDetails.MemberId);

            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {

                    history.Rows.Add(
                        reader.GetDateTime(0).ToString("dd/MM/yyyy"),
                        reader.GetString(1),
                        string.Format("{1}, {0}", reader.GetString(2), reader.GetString(3)),
                        reader.GetString(4),
                        (reader.IsDBNull(5) ? "" : reader.GetDateTime(5).ToString("dd/MM/yyyy"))
                    );
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
