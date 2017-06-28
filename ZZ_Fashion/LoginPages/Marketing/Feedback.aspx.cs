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
            if (!Page.IsPostBack) {
                RegisterAsyncTask(new PageAsyncTask(() => LoadFeedbackAsync(ConfigurationManager.ConnectionStrings["ZZFashionConnection"].ToString())));
            }
        }

        protected async Task LoadFeedbackAsync(string url) {
            try {
                using (var connection = new SqlConnection(url)) {
                    await connection.OpenAsync();
                    customerFeedback.DataSource = GetFeedback(new SqlCommand("SELECT * FROM Feedback ORDER BY FeedbackDate DESC", connection)).Result;
                    customerFeedback.DataBind();
                }
            } catch (SqlException e) {
                throw;
            }
        }

        protected async Task<DataTable> GetFeedback(SqlCommand command) {
            using (var reader = await command.ExecuteReaderAsync()) {
                var table = new DataTable();
                table.Load(reader);
                return table;
            }
        }


        protected void OnBound(object sender, GridViewRowEventArgs args) {
            if (args.Row.RowType == DataControlRowType.DataRow) {
                args.Row.ToolTip = "Click me to respond!";
                args.Row.Attributes["onclick"] = 
                    "<script language='javascript' type='text/javascript'>" +
                    "   function PerformClick() {" +
                    "       document.getElementById('<%=respond.ClientID %>').click();" +
                    "   }" +
                    "</script>";
            }
        }

    }
}