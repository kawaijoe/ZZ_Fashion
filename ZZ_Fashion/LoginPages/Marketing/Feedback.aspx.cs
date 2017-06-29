using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.Marketing {
    public partial class Feedback : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs args) {
            if (!IsPostBack) {
                Database.INSTANCE.Load(customerFeedback, "SELECT * FROM Feedback ORDER BY FeedbackDate DESC", e => title.Text = "Failed to load feedback");
            }
        }//cunt

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