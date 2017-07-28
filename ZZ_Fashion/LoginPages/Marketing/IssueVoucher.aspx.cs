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
                LoadDescription();
            }
        }

        private void LoadDescription() {
            var id = Request.QueryString["id"];
            double spending;

            if (id != null && double.TryParse(Request.QueryString["spending"], out spending)) {
                var amount = DetermineAmount(spending);
                Description.Text = "Voucher amount to issue for customer " + id + " : " + amount.ToString("0.00");
                ViewState["amount"] = amount;

            } else {
                DisableConfirmButton("Invalid URL, click the cancel button to return to the previous page");
            }
        }

        protected double DetermineAmount(double spending) {
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


        protected void OnConfirm(object sender, EventArgs e) {
            DisableConfirmButton();
            Database.INSTANCE.Execute(
                "INSERT INTO CashVoucher (" +
                "   MemberID, Amount, MonthIssuedFor, YearIssuedFor, DateTimeIssued, VoucherSN, Status" +
                ") VALUES (" +
                "   %id, %voucherAmount, %month, %year, %issued, %serial, %statu" +
                ")",
                command => {
                    var parameters = command.Parameters;
                    command.Parameters.AddWithValue("%id", Convert.ToInt32(ViewState["memberID"]));
                    command.Parameters.AddWithValue("%voucherAmount", ViewState["amount"]);
                    //command.Parameters.AddWithValue("%month", created.Month);
                    //command.Parameters.AddWithValue("%year", created.Year);
                    //command.Parameters.AddWithValue("%issued", DateTime.Now);
                    //command.Parameters.AddWithValue("%serial", DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + serial);
                    command.Parameters.AddWithValue("%status", 0);

                    int inserted = command.ExecuteNonQuery();
                    if (inserted == 1) {
                        Response.Redirect("./CustomerTransactions.aspx?message=Succesfully issued voucher to customer: " + Request.QueryString["id"]);

                    } else {
                        Message.Text = "Failed to issue voucher, click the cancel button to return to the previous page";
                    }

                }, ex => Message.Text = "Failed to issue voucher, click the cancel button to return to the previous page");
        }

        protected void OnCancel(object sender, EventArgs e) {
            Response.Redirect("./CustomerTransactions.aspx?message=Cancelled issue of vouchers to customer: " + Request.QueryString["id"]);
        }


        protected void DisableConfirmButton(string message = "") {
            Message.Text = message;
            Confirm.Enabled = false;
            Confirm.UseSubmitBehavior = false;
        }

    }
}