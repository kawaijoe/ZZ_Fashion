using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.ProductManager {
    public partial class UpdateProducts : System.Web.UI.Page {

        string ProductId = "1";

        protected void Page_Load(object sender, EventArgs e) {
            ProductId = Request.QueryString["productid"];
            Load_Data();
        }

        protected void Load_Data() {
            //Read connection string "DWABookConnectionString" from web.config file.
            string strConn = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            //Instatitate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE ProductID = " + ProductId, conn);

            //Instantiate a DataAdapter object and pass the SqlCommand object
            //Created as parameter.
            SqlDataAdapter daProduct = new SqlDataAdapter(cmd);

            //Create a DataSet object to contain the records retrieved from database
            DataSet result = new DataSet();

            //A connection must be opened before any operation made.
            conn.Open();

            //Use DataAdapter to fetch data to a table "StaffDetails" in DataSet.
            //Dataset "result" will store the result of the SELECT operation.
            daProduct.Fill(result, "Product");

            //A connection should always be closed, whether error occurs or not.
            conn.Close();

            if (result.Tables["Product"].Rows.Count > 0) {
                if (!DBNull.Value.Equals(result.Tables["Product"].Rows[0]["ProductTitle"]))
                    ProductTitle.Text = Convert.ToString(result.Tables["Product"].Rows[0]["ProductTitle"]);

                if (!DBNull.Value.Equals(result.Tables["Product"].Rows[0]["Price"]))
                    Price.Text = Convert.ToString(result.Tables["Product"].Rows[0]["Price"]);

                if (!DBNull.Value.Equals(result.Tables["Product"].Rows[0]["EffectiveDate"]))
                    EffectiveDate.SelectedDate = Convert.ToDateTime(result.Tables["Product"].Rows[0]["EffectiveDate"]);

                if (!DBNull.Value.Equals(result.Tables["Product"].Rows[0]["Obsolete"])) {
                    if (DateTime.Now <= Convert.ToDateTime(result.Tables["Product"].Rows[0]["EffectiveDate"]).AddYears(1)) {
                        if (result.Tables["Product"].Rows[0]["Obsolete"].ToString() == "0")
                            ObsoleteOne.Checked = true;
                        ObsoleteZero.Enabled = false;
                        ObsoleteOne.Enabled = false;
                    }
                }
            }
        }

        protected void Update_Click(object sender, EventArgs e) {
            string fileName = "";

            //Read connection string "DWABookConnectionString" from web.config file.
            string strConn = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            //Instatitate a SqlConnection object with the Connection String read.
            SqlConnection conn = new SqlConnection(strConn);

            string query = "";
            if (UploadPhoto.HasFile) {
                string fileExtension = Path.GetExtension(UploadPhoto.FileName);

                fileName = ProductId.ToString() + fileExtension;
                string FileSavePath = MapPath("~/Images/Product/" + fileName);

                if (File.Exists(FileSavePath))
                    File.Delete(FileSavePath);

                // Save image in application 'Images' folder
                UploadPhoto.SaveAs(FileSavePath);

                query = "UPDATE Product SET ProductTitle=@title, ProductImage=@image, Price=@price, EffectiveDate=@date, Obsolete=@obsolete WHERE ProductID = " + ProductId;

            } else {
                query = "UPDATE Product SET ProductTitle=@title, Price=@price, EffectiveDate=@date, Obsolete=@obsolete WHERE ProductID = " + ProductId;
            }

            //Instantiate a SqlCommand object, supply it with SQL statement INSERT
            //and the connection object for connecting to the database.
            SqlCommand cmd = new SqlCommand(query, conn);

            if (UploadPhoto.HasFile)
                cmd.Parameters.AddWithValue("@image", fileName);

            cmd.Parameters.AddWithValue("@title", ProductTitle.Text.ToString());
            cmd.Parameters.AddWithValue("@price", Price.Text.ToString());
            cmd.Parameters.AddWithValue("@date", EffectiveDate.SelectedDate);

            if (ObsoleteOne.Checked)
                cmd.Parameters.AddWithValue("@obsolete", 1);
            else
                cmd.Parameters.AddWithValue("@obsolete", 0);

            //A connection to database must be opened before any operations made.
            conn.Open();

            //ExecuteNonQuery is used for INSERT, UPDATE, DELETE SQL statement.
            cmd.ExecuteNonQuery();

            //A connection should be closed after operations.
            conn.Close();

            Response.Redirect("/LoginPages/ProductManager/ViewProduct");

        }
    }
}