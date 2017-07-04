using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using ZZ_Fashion.LoginPages.Customer.AppCode;

namespace ZZ_Fashion.LoginPages.Customer
{
    public partial class ViewResponse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                displayFeedbackList();
            }
        }

        protected void AddFeedBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateFeedback.aspx");
        }

        protected void gvFeedback_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedfeedbackID = Convert.ToInt32(gvFeedback.SelectedDataKey[0]);

            FeedBack objfeedback = new FeedBack();

            DataSet result = new DataSet();



            objfeedback.FeedbackID = selectedfeedbackID;

            gvResponse.DataSource = result.Tables["FeedBack"];

            gvResponse.DataBind();

            
        }

        public void displayFeedbackList()
        {

            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("select ResponseID, Response.FeedbackID, Response.MemberID, StaffID, Response.DateTimePosted, Response.Text, Title, Feedback.Text as 'Feedback Text' from Response INNER JOIN Feedback on Response.FeedbackID = Feedback.FeedbackID WHERE Response.MemberID = @MemberID ;", connection);

            command.Parameters.AddWithValue("@MemberID", Session["loginID"]);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataSet result = new DataSet();

            connection.Open();

            dataAdapter.Fill(result, "FeedBack");

            connection.Close();

            gvFeedback.DataSource = result.Tables["FeedBack"];

            gvFeedback.DataBind();

     
        }
    }
}