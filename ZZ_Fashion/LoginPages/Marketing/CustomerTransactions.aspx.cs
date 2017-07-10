using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.Marketing {
    public partial class CustomerTransactions : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                Database.INSTANCE.Bind(Transactions, 
                    "SELECT MemberID, SUM(Total) AS 'Spending' FROM SalesTransaction " +
                    "WHERE " +
                    "   DATEPART(m, DateCreated) = DATEPART(m, DATEADD(m, -1, GETDATE())) " +
                    "   AND DATEPART(yyyy, DateCreated) = DATEPART(yyyy, DATEADD(m, -1, GETDATE())) " +
                    "GROUP BY MemberID ORDER BY Spending DESC; ", ex => Message.Text = "");
            }
        }

        protected void LoadMessage() {
            var message = Request.QueryString["message"];
            if (message != null) {
                Message.Text = message;
            }
        }

    }

}