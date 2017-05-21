using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.Customer
{
    public partial class ViewResponse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Title.Text = "Male Apparel Selection Limited";
                FeedbackMsg.Text = "Male Selection of Clothing is too limited, please update your databse and add more clothes soon. I want to buy clothes for chinese new year. " +
                    "Also, please add more discounts, it will help you attract more cutomers.";

                Response.Text = "We thank you for your Feedback and will try to imporve on our website as much as we can.";
            }
        }

    }
}