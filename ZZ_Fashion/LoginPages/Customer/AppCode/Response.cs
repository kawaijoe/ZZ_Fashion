using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace ZZ_Fashion.LoginPages.Customer.AppCode
{
    public class Response
    {
        public int ResponseID { get; set; }
        public int FeedbackID { get; set; }
        public string MemberID { get; set; }

        public int StaffID { get; set; }
        public DateTime DateTimePosted { get; set; }
        public string Text { get; set; }

        public int ConfirmAdd()
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("INSERT INTO Response (FeedbackID, MemberID, DateTimePosted, Text) VALUES(@FeedbackID, @MemberID, @DateTimePosted, @Text)", connection);

            command.Parameters.AddWithValue("@FeedbackID", FeedbackID);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@DateTimePosted", DateTimePosted);
            command.Parameters.AddWithValue("@Text", Text);

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
    }


}