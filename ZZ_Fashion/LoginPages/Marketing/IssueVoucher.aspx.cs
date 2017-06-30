using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.Marketing {
    public partial class IssueVoucher : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void OnClick(object sender, EventArgs args) {
            issue.Enabled = false;
            issue.UseSubmitBehavior = false;

            decimal amount = DetermineVouchers(Convert.ToDouble(ViewState["spending"]));

            Database.INSTANCE.Insert(
                "INSERT INTO CashVoucher (" +
                "   MemberID, Amount, MonthIssuedFor, YearIssuedFor, DateTimeIssued, VoucherSN, Status, DateTimedRedeemed" +
                ") VALUES (" +
                "   %id, %voucherAmount, %month, %year, %issued, %serial, %status, %redeemed" +
                ")", 
                command => {
                    command.Parameters.AddWithValue("%id", Convert.ToInt32(ViewState["customerID"]));
                    command.Parameters.AddWithValue("%voucherAmount", amount);
                    //TODO
                });
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