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

                CreateResponse.Visible = false;
            }
        }


        protected void gvFeedback_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateResponse.Visible = true;

            int selectedfeedbackID = Convert.ToInt32(gvFeedback.SelectedDataKey[0]);

            FeedBack objfeedback = new FeedBack();

            DataSet resultStaff = new DataSet();

            DataSet resultCustomer = new DataSet();

            //Response objResponse = new Response();
            
            objfeedback.FeedbackID = selectedfeedbackID;

            // objResponse.FeedbackID = selectedfeedbackID;

            // For Staff response GridView
            int errorCodeStaff = objfeedback.findStaffResponse(ref resultStaff);
            // For Customer Response GridView
            int errorCodeCustomer = objfeedback.findCustomerResponse(ref resultCustomer);


            if (errorCodeStaff == 0)
            {
                gvStaffResponse.DataSource = resultStaff.Tables["StaffResponse"];

                gvStaffResponse.DataBind();

                lblStaffMessage.Text = "";

                gvStaffResponse.Visible = true;
            }
            if (errorCodeCustomer == 0)
            {
                gvCustomerResponse.DataSource = resultCustomer.Tables["CustomerResponse"];

                gvCustomerResponse.DataBind();

                lblCustomerMessage.Text = "";

                gvCustomerResponse.Visible = true;
            }
                        else if (errorCodeStaff == -2)
            {
                lblStaffMessage.Text = "There are no Responses yet";
                gvStaffResponse.Visible = false;
                lblCustomerMessage.Text = "";
                gvCustomerResponse.Visible = false;
            }
            else if (errorCodeCustomer == -2)
            {
                lblStaffMessage.Text = "There are no Responses from the Customer yet";
                gvCustomerResponse.Visible = false;
            }




        }

        public void displayFeedbackList()
        {

            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("SELECT * FROM Feedback Where MemberID = @MemberID ", connection);

            command.Parameters.AddWithValue("@MemberID", Session["loginID"]);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            DataSet result = new DataSet();

            connection.Open();

            dataAdapter.Fill(result, "FeedBack");

            connection.Close();

            gvFeedback.DataSource = result.Tables["FeedBack"];

            gvFeedback.DataBind();

     
        }

        protected void CreateFeedback_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateFeedback.aspx");
        }

        protected void CreateResponse_Click(object sender, EventArgs e)
        {
            string strValues;
            int selectedfeedbackID = Convert.ToInt32(gvFeedback.SelectedDataKey[0]);
            // retrieve the inputs
            strValues = "feedbackID=" + selectedfeedbackID;
            // display the values
            Server.UrlEncode(strValues);
            Response.Redirect("CreateResponse.aspx?"+strValues);
        }
    }
}