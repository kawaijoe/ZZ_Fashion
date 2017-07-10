using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.Marketing {
    public partial class CustomerFeedback : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                LoadMessage();
                Database.INSTANCE.Bind(
                    Feedback, 
                    "SELECT * FROM Feedback ORDER BY DateTimePosted DESC", 
                    ex => Message.Text = "Failed to retrieve customers' feedback"
                );
            }
        }

        protected void LoadMessage() {
            var message = Request.QueryString["message"];
            if (message != null) {
                Message.Text = message;
            }
        }

    }
}