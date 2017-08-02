using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ZZ_Fashion.LoginPages.SalesPersonnel
{
    public partial class CreateCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                ddlCountry.Items.Add("Singapore");
                ddlCountry.Items.Add("Malaysia");
                ddlCountry.Items.Add("Indonesia");
                ddlCountry.Items.Add("China");
                ddlCountry.Items.Add("United States");
            }

        }
        
        protected void Add_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {

                string memberID = ID.Text;
                string name = Name.Text;
                DateTime dob = Convert.ToDateTime(DOB.Text);
                string email = Email.Text;
                string phone = Phone.Text;
                string address = Address.Text;
                string gender;
                string country = ddlCountry.SelectedValue;

                if (M.Checked == true)
                {
                    gender = "M";
                }
                else
                {
                    gender = "F";
                }

                Customer Cus = new Customer();
                Cus.ID = memberID;
                Cus.Name = name;
                Cus.DOB = dob;
                Cus.Email = email;
                Cus.Phone = phone;
                Cus.Address = address;
                Cus.Gender = gender;
                Cus.Country = country;

                int error = Cus.AddCustomer();
                if (error == 0)
                {
                    lblmsg.Text = "Customer successfully added";
                }
                else
                {
                    lblmsg.Text = "Error";
                }

            }

        }

        protected void M_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void cvError_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string strConn = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand command = new SqlCommand("Select * From Customer WHERE MemberID = @ID ", conn);

            command.Parameters.AddWithValue("@ID", ID.Text);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet result = new DataSet();

            conn.Open();

            dataAdapter.Fill(result, "ID");

            conn.Close();

            if (result.Tables["ID"].Rows.Count == 0)
            {
                args.IsValid = false;
            }
            else
                args.IsValid = true;
        }
    }
}