using System;
using System.Configuration;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.Marketing {
    public partial class Response : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs args) {
            if (!IsPostBack) {
                ViewState["feedbackID"] = Session["feedbackID"];
                ViewState["customerID"] = Session["customerID"];

                meta.Text = "Feedback ID: " + Session["feedbackId"] + "By: " + Session["name"] + "On: " + Session["date"];
                feedback.Text = Session["feedback"].ToString();
            }
        }

        protected void OnSubmit(object sender, EventArgs args) {
            submit.Enabled = false;
            submit.UseSubmitBehavior = false;

            Database.INSTANCE.Insert(
                "INSERT INTO Response (FeedbackID, MemberID, StaffID, DateTimePosted, Text) VALUES (%id, %customer, %staff, %posted, %text)", 
                command => {
                    command.Parameters.AddWithValue("%id", Convert.ToInt32(ViewState["feedbackID"]));
                    command.Parameters.AddWithValue("%customer", Convert.ToInt32(ViewState["customerID"]));
                    command.Parameters.AddWithValue("%staff", Convert.ToInt32(Session["staffID"]));
                    command.Parameters.AddWithValue("%posted", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff"));
                    command.Parameters.AddWithValue("%text", newResponse.Text);

                    if (command.ExecuteNonQuery() == 1) {
                        title.Text = "Your response has been saved";

                        oldResponse.Text = newResponse.Text;
                        newResponse.Text = "";

                    } else {
                        title.Text = "Failed to save response, please try again";

                        submit.Enabled = true;
                        submit.UseSubmitBehavior = true;
                    }

            }, exception => Response.Redirect("./ErrorPage.aspx"));
        }

    }
}