using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace ZZ_Fashion.LoginPages.SalesPersonnel
{
    public class Customer
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        

        public int AddCustomer()
        {
            string strConn = ConfigurationManager.ConnectionStrings["ZZFashionCRMConnectionString"].ToString();

            SqlConnection conn = new SqlConnection(strConn);

            SqlCommand command = new SqlCommand("INSERT INTO Customer (MemberID, MName, MGender, MBirthDate, MAddress, MCountry, MTelNo, MEmailAddr)"
                + "VALUES(@ID, @Name, @Gender, @DOB, @Address, @Country, @Phone, @Email)", conn);

            command.Parameters.AddWithValue("@ID", ID);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@DOB", DOB);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);

            conn.Open();

            command.ExecuteNonQuery();

            conn.Close();

            return 0;
        }

        
    }


}