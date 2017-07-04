using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.Marketing {
    public partial class Transactions : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs args) {
            if (!IsPostBack) {
                Database.INSTANCE.Load(monthlyTransactions, "TODO: Fancy SQL statement which compiles the list", e => title.Text = "Failed to load transactions");
            }
        }

        protected void OnBound(object sender, GridViewRowEventArgs args) {
            if (args.Row.RowType == DataControlRowType.DataRow) {
                args.Row.ToolTip = "Click to select me!";
            }
        }
        protected void OnSelect(object sender, EventArgs args) {
            var row = monthlyTransactions.SelectedRow;

            Session["transaction-memberID"] = Convert.ToInt32(row.Cells[1]);
            Session["transaction-amount"] = Convert.ToDecimal(row.Cells[2]);
            Session["transaction-dateCreated"] = Convert.ToDateTime(row.Cells[1111111]);

            Response.Redirect("./IssueVoucher.aspx");
        }

    }
}