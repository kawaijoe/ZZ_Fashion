using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace ZZ_Fashion.LoginPages.Customer.AppCode
{
    public class FeedBack
    {
        public int FeedbackID { get; set; }
        public string MemberID { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

        public string ResponseMessage { get; set; }


        public string ImageFileName { get; set; }


        public int ConfirmAdd()
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("INSERT INTO Feedback (MemberID, Title, Text) VALUES(@MemberID, @Title, @Text)", connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Text", Message);
            // command.Parameters.AddWithValue("@ImageFileName", ImageFileName);
            // HOW TO UPLOAD THE IMAGE TO THE DATABASE


            connection.Open();

            int count = command.ExecuteNonQuery();

            connection.Close();

            if (count != 0) // At lease one row of record updated 
            {
                return 0;
            }
            else
                return -2; // No update as the Record is not found
        }

        // after new Creation of feedback in Database
        public int FindFeedbackID()
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Feedback", connection);


            connection.Open();

            FeedbackID = Convert.ToInt32(command.ExecuteScalar());

            connection.Close();

            return FeedbackID;
        }


        public int updatePicture()
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("UPDATE Feedback SET ImageFileName = @ImageFileName WHERE MemberID = @MemberID and FeedbackID = @feedbackID ", connection);

            command.Parameters.AddWithValue("@ImageFileName", ImageFileName);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@FeedbackID", FeedbackID);

            connection.Open();

            int count = command.ExecuteNonQuery();

            connection.Close();

            if (count != 0) // At lease one row of record updated 
            {
                return 0;
            }
            else
                return -2; // No update as the Record is not found



        }


        public int findStaffResponse(ref DataSet result)
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("SELECT ResponseID, Response.FeedbackID, Response.MemberID, StaffID, Response.DateTimePosted, Response.Text FROM Response WHERE Response.FeedbackID = @selectedFeedbackID and StaffID IS NOT NULL ORDER BY DateTimePosted ASC", connection);

            command.Parameters.AddWithValue("@selectedfeedbackID", FeedbackID);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);


            connection.Open();

            dataAdapter.Fill(result, "StaffResponse");

            connection.Close();

            if (result.Tables["StaffResponse"].Rows.Count > 0)
            {
                return 0;
            }
            else
            {
                return -2;
            }
        }


        public int findCustomerResponse(ref DataSet result)
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("SELECT ResponseID, Response.FeedbackID, Response.MemberID, StaffID, Response.DateTimePosted, Response.Text FROM Response WHERE Response.FeedbackID = @selectedFeedbackID and StaffID IS NULL ORDER BY DateTimePosted ASC", connection);

            command.Parameters.AddWithValue("@selectedfeedbackID", FeedbackID);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);



            connection.Open();

            dataAdapter.Fill(result, "CustomerResponse");

            connection.Close();

            if (result.Tables["CustomerResponse"].Rows.Count > 0)
            {
                return 0;
            }
            else
            {
                return -2;
            }
        }
    }
}