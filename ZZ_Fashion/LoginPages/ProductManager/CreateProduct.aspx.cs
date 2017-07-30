using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient; 
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.ProductManager {
    public partial class CreateProduct : System.Web.UI.Page {

        protected void Page_Init(object sender, EventArgs e) {
            EffectiveDate.SelectedDate = DateTime.Today;
        }

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void CalendarValidate(object source, ServerValidateEventArgs args) {
            if (EffectiveDate == null || EffectiveDate.SelectedDate < DateTime.Today) {
                args.IsValid = false;
            } else {
                args.IsValid = true;
            }
        }

        protected void Submit_Click(object sender, EventArgs e) {
            string fileName = "";

            //Read connection string "DWABookConnectionString" from web.config file.
            string strConn = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            //Instatitate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            string query = "";
            if (UploadPhoto.HasFile) {
                string fileExtension = Path.GetExtension(UploadPhoto.FileName);

                string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

                SqlConnection connection = new SqlConnection(stringConnection);

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Product", connection);


                connection.Open();

                int Id = Convert.ToInt32(command.ExecuteScalar()) + 1;

                connection.Close();

                fileName = Id.ToString() + fileExtension;
                string FileSavePath = MapPath("~/Images/Product/" + fileName);
                
                // Save image in application 'Images' folder
                UploadPhoto.SaveAs(FileSavePath);

                query = "INSERT INTO Product (ProductTitle, ProductImage, Price, EffectiveDate) " +
                    "VALUES (@productTitle, @productImage, @price, @effectiveDate)";
                
            } else {
                query = "INSERT INTO Product (ProductTitle, Price, EffectiveDate) " +
                    "VALUES (@productTitle, @price, @effectiveDate)";
            }

            //Instantiate a SqlCommand object, supply it with SQL statement INSERT
            //and the connection object for connecting to the database.
            SqlCommand cmd = new SqlCommand(query, conn);

            if(UploadPhoto.HasFile)
                cmd.Parameters.AddWithValue("@productImage", fileName);

            cmd.Parameters.AddWithValue("@productTitle", ProductTitle.Text);
            cmd.Parameters.AddWithValue("@price", Price.Text);
            cmd.Parameters.AddWithValue("@effectiveDate", EffectiveDate.SelectedDate);

            //A connection to database must be opened before any operations made.
            conn.Open();

            //ExecuteNonQuery is used for INSERT, UPDATE, DELETE SQL statement.
            cmd.ExecuteNonQuery();

            //A connection should be closed after operations.
            conn.Close();

            status.Text = "Product have been added!";
            Response.Redirect("/ProductManager/ViewProduct");
        }

        protected void Price_TextChanged(object sender, EventArgs e) {

        }
    }
}