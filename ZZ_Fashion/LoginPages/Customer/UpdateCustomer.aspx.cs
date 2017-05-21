using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.Customer
{
    public partial class UpdateCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack){
                Name.Text = "David Chew";
                Gender.Text = "Male";
                BirthDate.Text = "19/06/1987";
                PhoneNum.Text = "98748323";
                EmailAddr.Text = "S11233343@connect.np.edu.sg";
                ResidentialAddr.Text = "123 East Coast Road, Singapore 783920";
                Country.Text = "Singapore";
            }

        }

        protected void ChangePass_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }

        protected void SaveChanges_Click(object sender, EventArgs e)
        {
            Response.Redirect("Profile.aspx");
        }
    }
}