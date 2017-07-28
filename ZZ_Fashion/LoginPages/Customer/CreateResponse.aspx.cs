using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZZ_Fashion.LoginPages.Customer.AppCode;

namespace ZZ_Fashion.LoginPages.Customer
{
    public partial class CreateResponse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ResponseMemberID.Text = Session["LoginID"].ToString();
                ResponseText.Text = "Thanks SO MUCH!";
            }
        }


        protected void Submit_Click(object sender, EventArgs e)
        {
            Response objResponse = new Response();
            objResponse.MemberID = Session["LoginID"].ToString();
            objResponse.FeedbackID = Convert.ToInt32(Request.QueryString["feedbackID"]);
            objResponse.DateTimePosted = DateTime.Now;
            objResponse.Text = ResponseText.Text;

            int errorCode = objResponse.ConfirmAdd();

            if (errorCode == 0)
            {
                Response.Redirect("ViewResponse.aspx");
            }
            else if (errorCode == -2)
            {
                Message.Text = "Update was unsuccessful, did you key in the right details?";
            }

        }
    }
}