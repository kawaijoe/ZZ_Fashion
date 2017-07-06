using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.Marketing {
    public partial class IssueVoucher : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {
            if (!IsPostBack) {
                ViewState["memberID"] = Session["transaction-memberID"];
                ViewState["amount"] = Session["transaction-amount"];
                ViewState["dateCreated"] = Session["transaction-dateCreated"];

                amount.Text = "Cash voucher amount to issue: " + Session["transaction-amount"];
            }
        }

        protected void OnClick(object sender, EventArgs args) {
            issue.Enabled = false;
            issue.UseSubmitBehavior = false;

            decimal amount = DetermineVouchers(Convert.ToDouble(ViewState["amount"]));
            var created = (DateTime)ViewState["dateCreated"];
            var serial = (int) Application["serial"] + 1;
            Application["serial"] = serial;

            Database.INSTANCE.Insert(
                "INSERT INTO CashVoucher (" +
                "   MemberID, Amount, MonthIssuedFor, YearIssuedFor, DateTimeIssued, VoucherSN, Status, DateTimedRedeemed" +
                ") VALUES (" +
                "   %id, %voucherAmount, %month, %year, %issued, %serial, %status, %redeemed" +
                ")", 
                command => {
                    command.Parameters.AddWithValue("%id", Convert.ToInt32(ViewState["memberID"]));
                    command.Parameters.AddWithValue("%voucherAmount", amount);
                    command.Parameters.AddWithValue("%month", created.Month);
                    command.Parameters.AddWithValue("%year", created.Year);
                    command.Parameters.AddWithValue("%issued", DateTime.Now);
                    command.Parameters.AddWithValue("%serial", DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + serial);
                    command.Parameters.AddWithValue("%status", 0);
                    command.Parameters.AddWithValue("%redeemed", null);

                    if (command.ExecuteNonQuery() == 1) {
                        title.Text = "Your response has been saved"; ;

                    } else {
                        title.Text = "Failed to save response, please try again";
                    }

                }, exception => title.Text = "Failed to save response, please try again");
        }

        protected decimal DetermineVouchers(double spending) {
            if (spending < 200) {
                return 0;

            } else if (spending < 500) {
                return 20;

            } else if (spending < 1000) {
                return 40;

            } else if (spending < 1500) {
                return 80;

            } else {
                return 160;
            }
        }

    }
}