using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZZ_Fashion.LoginPages.Customer.AppCode;
using System.Data.SqlClient;
using System.Configuration;


namespace ZZ_Fashion.LoginPages.Customer
{
    public partial class UpdateCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

                SqlConnection connection = new SqlConnection(stringConnection);

                SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE MemberID = @MemberID", connection);

                command.Parameters.AddWithValue("@MemberID", Session["LoginID"]);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    NameLabel.Text = reader[1].ToString();
                    Gender.Text = reader[2].ToString();
                    BirthDate.Text = reader[3].ToString();
                    ResidentialAddr.Text = reader[4].ToString();
                    Country.Text = reader[5].ToString();
                    PhoneNum.Text = reader[6].ToString();
                    EmailAddr.Text = reader[7].ToString();
                }

                connection.Close();

            }
            /* Tried to use Query String, Didnt Work So Far
             * 
            Name.Text = Request.QueryString["Name"];
            Gender.Text = Request.QueryString["Gender"];
            BirthDate.Text = Request.QueryString["BirthDate"];
            ResidentialAddr.Text = Request.QueryString["ResidentialAddr"];
            Country.Text = Request.QueryString["Country"];
            PhoneNum.Text = Request.QueryString["PhoneNum"];
            EmailAddr.Text = Request.QueryString["EmailAddr"];
            */
        }

        protected void ChangePass_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }

        protected void SaveChanges_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                CustomerStuff objCustomer = new CustomerStuff();
                objCustomer.ResidentialAddr = ResidentialAddr.Text;
                objCustomer.PhoneNum = PhoneNum.Text;
                objCustomer.EmailAddr = EmailAddr.Text;
                objCustomer.MemberID = Session["LoginID"].ToString();

                int errorCode = objCustomer.ConfirmAdd();

                if (errorCode == 0)
                {
                    Response.Redirect("Profile.aspx");
                }
                else
                {
                    Message.Text = "Update was unsuccessful, did you key in the right details?";
                }
            }
            
        }

        protected void ValidPhoneNum_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = (args.Value.Length == 8);
        }

        protected void UniqueEmail_ServerValidate(object source, ServerValidateEventArgs args)
        {
            CustomerStuff objCustomer = new CustomerStuff();
            objCustomer.EmailAddr = EmailAddr.Text;
            objCustomer.MemberID = Session["LoginID"].ToString();
            if(objCustomer.checkEmail() == 1)
            {
                args.IsValid = true;
            }
            else if(EmailAddr.Text == "")
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void UniquePhoneNum_ServerValidate(object source, ServerValidateEventArgs args)
        {
            CustomerStuff objCustomer = new CustomerStuff();
            objCustomer.PhoneNum = PhoneNum.Text;
            objCustomer.MemberID = Session["LoginID"].ToString();
            if (objCustomer.checkPhoneNum() == 1)
            {
                args.IsValid = true;
            }
            else if (PhoneNum.Text == "")
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }
    }
}