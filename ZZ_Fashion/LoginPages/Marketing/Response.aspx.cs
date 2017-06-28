using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.Marketing {
    public partial class Response : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            GridView customerFeedback = null;
            if (Page.PreviousPage != null && (customerFeedback = (GridView) Page.PreviousPage.FindControl("customerFeedback")) != null) {
                LoadFeedback(customerFeedback);

            } else {
                Response.Redirect("./Feedback.aspx");
            }
        }


        protected void LoadFeedback(GridView customerFeedback) {
            
        }

    }
}