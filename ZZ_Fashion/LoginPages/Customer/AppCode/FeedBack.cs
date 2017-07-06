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

            command.ExecuteNonQuery();

            connection.Close();

            return 0;
        }

        
        public int FindFeedbackID()
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Feedback", connection);


            connection.Open();

            FeedbackID = Convert.ToInt32(command.ExecuteScalar()) + 1;

            connection.Close();

            return FeedbackID;
        }

        public int findResponse(ref DataSet result)
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("SELECT ResponseID, Response.FeedbackID, Response.MemberID, StaffID, Response.DateTimePosted, Response.Text, Title, Feedback.Text as 'Feedback Text' from Response INNER JOIN Feedback on Response.FeedbackID = Feedback.FeedbackID WHERE Response.FeedbackID = @selectedFeedbackID, StaffID IS NOT NULL;", connection);

            command.Parameters.AddWithValue("@feedbackID", FeedbackID);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

            

            connection.Open();

            dataAdapter.Fill(result, "Response");

            connection.Close();

            return 0;
        }

        
    }
}