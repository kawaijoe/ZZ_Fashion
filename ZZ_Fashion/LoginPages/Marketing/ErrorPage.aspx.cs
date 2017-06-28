using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.Marketing {
    public partial class ErrorPageaspx : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void OnRedirect(object sender, EventArgs args) {
            Response.Redirect("./Feedback.aspx");
        }
    }
}