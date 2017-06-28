using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace ZZ_Fashion.LoginPages.Customer.AppCode
{
    public class CustomerStuff
    {
        public string MemberID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string ResidentialAddr { get; set; }
        public string Country { get; set; }
        public string PhoneNum { get; set; }
        public string EmailAddr { get; set; }
        public string PassWord { get; set; }
       
        
        
        

        public int ConfirmAdd()
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("UPDATE Customer SET MAddress = @ResidentialAddr, MTelNo = @PhoneNum, MEmailAddr = @EmailAddr WHERE MemberID = @MemberID", connection);

            command.Parameters.AddWithValue("@ResidentialAddr", ResidentialAddr);
            command.Parameters.AddWithValue("@PhoneNum", PhoneNum);
            command.Parameters.AddWithValue("@EmailAddr", EmailAddr);
            command.Parameters.AddWithValue("@MemberID", MemberID);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            return 0;
        }

        public int changePassWord()
        {
            string stringConnection = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection connection = new SqlConnection(stringConnection);

            SqlCommand command = new SqlCommand("UPDATE Customer SET MPassword = @password WHERE MemberID = @MemberID", connection);

            command.Parameters.AddWithValue("@password", PassWord);
            command.Parameters.AddWithValue("@MemberID", MemberID);

            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

            return 0;
        }


    }
}