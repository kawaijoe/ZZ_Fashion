using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.Public {
    public partial class Login : System.Web.UI.Page {

        protected void Page_Init(object sender, EventArgs e) {
            RadioButtonCustomer.Checked = true;
        }

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void Signin_Click(object sender, EventArgs e) {

            string user = UserID.Text;
            string pass = Password.Text;

            //Read connection string "DWABookConnectionString" from web.config file.
            string strConn = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            //Instatitate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            string query = "";

            if (RadioButtonCustomer.Checked)
                query = "SELECT * FROM Customer WHERE MemberID=@user AND MPassword=@pass";
            else
                query = "SELECT * FROM Staff WHERE StaffID=@user AND SPassword=@pass";

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);

            //Instantiate a DataAdapter object and pass the SqlCommand object
            //Created as parameter.
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            //Create a DataSet object to contain the records retrieved from database
            DataSet result = new DataSet();

            conn.Open();
            dataAdapter.Fill(result, "table");
            conn.Close();

            try {
                if (RadioButtonCustomer.Checked) {
                    if (!DBNull.Value.Equals(result.Tables["table"].Rows[0]["MemberID"])) {
                        Session.Add("LoginID", result.Tables["table"].Rows[0]["MemberID"].ToString());
                        Session.Add("Type", "Customer");
                        redirect();
                    } else {
                        lblMessage.Text = "Invalid Login Credentials";
                    }
                } else {
                    if (!DBNull.Value.Equals(result.Tables["table"].Rows[0]["StaffID"])) {
                        Session.Add("LoginID", result.Tables["table"].Rows[0]["StaffID"].ToString());
                        Session.Add("Type", result.Tables["table"].Rows[0]["SAppt"].ToString());
                        redirect();
                    } else {
                        lblMessage.Text = "Invalid Login Credentials";
                    }
                }
            } catch (IndexOutOfRangeException i) {
                lblMessage.Text = "Invalid Login Credentials";
            }
            
        }

        public void redirect() {
            switch (Session["Type"].ToString()) {
                case "Customer":
                    Response.Redirect("/LoginPages/Customer/CustomerHomePage.aspx");
                    break;

                case "Marketing Personnel":
                    Response.Redirect("/LoginPages/Marketing/CustomerFeedback.aspx");
                    break;

                case "Product Manager":
                    Response.Redirect("/LoginPages/ProductManager/ViewProduct.aspx");
                    break;

                case "Sales Personnel":
                    Response.Redirect("/LoginPages/SalesPersonnel/CreateCustomer.aspx");
                    break;

                default:
                    break;
            }

        }

    }
}