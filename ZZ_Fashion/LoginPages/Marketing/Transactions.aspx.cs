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
                Database.INSTANCE.Load(monthlyTransactions, "SELECT * FROM Transactions ORDER BY Spending DESC", e => title.Text = "Failed to load transactions");
            }
        }

        protected void OnBound(object sender, GridViewRowEventArgs args) {
            if (args.Row.RowType == DataControlRowType.DataRow) {
                args.Row.ToolTip = "Click to select me!";
                args.Row.Attributes["onclick"] =
                    "<script language='javascript' type='text/javascript'>" +
                    "   function PerformClick() {" +
                    "       document.getElementById('<%=submit.ClientID %>').click();" +
                    "   }" +
                    "</script>";
            }
        }

    }
}