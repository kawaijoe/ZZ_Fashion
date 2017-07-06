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
                Database.INSTANCE.Load(customerFeedback, "SELECT * FROM Feedback ORDER BY DateTimePosted DESC", e => title.Text = "Failed to load feedback");
            }
        }

        protected void OnBound(object sender, GridViewRowEventArgs args) {
            if (args.Row.RowType == DataControlRowType.DataRow) {
                args.Row.ToolTip = "Click to select me!";
            }
        }

        protected void OnSelect(object sender, EventArgs args) {
            var row = customerFeedback.SelectedRow;

            Session["feedback-ID"] = row.Cells[0].ToString();
            Session["feedback-memberID"] = row.Cells[1].ToString();
            Session["feedback-date"] = row.Cells[2].ToString();
            Session["feedback-title"] = row.Cells[3].ToString();
            Session["feedback-text"] = row.Cells[4].ToString();

            Response.Redirect("./Response.aspx");
        }
    }
}