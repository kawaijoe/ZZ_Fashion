using System;
using System.Configuration;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.Marketing {
    public partial class Response : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs args) {
            IfFeedbackPresentOrElse(LoadFeedback, () => Response.Redirect("./ErrorPage.aspx"));
        }

        protected void IfFeedbackPresentOrElse(Action<GridViewRow> ifPresent, Action orElse) {
            GridView grid = null;
            if (PreviousPage != null && (grid = (GridView) PreviousPage.FindControl("customerFeedback")) != null && grid.SelectedRow != null) {
                ifPresent(grid.SelectedRow);

            } else {
                orElse();
            }
        }

        protected void LoadFeedback(GridViewRow row) {
            meta.Text = "Feedback ID: " + row.Cells[0].Text + "By: " + row.Cells[1].Text + "On: " + row.Cells[2].Text;
            feedback.Text = row.Cells[3].Text;
            oldResponse.Text = row.Cells[4].Text;
        }


        protected void OnSubmit(object sender, EventArgs args) {
            submit.Enabled = false;
            submit.UseSubmitBehavior = false;

            IfFeedbackPresentOrElse(row => {
                Database.INSTANCE.Insert("INSERT INTO Feedback (Response) VALUES(%feedbaackResponse) WHERE id = %feedbackID;", command => {
                    command.Parameters.AddWithValue("%feedbackResponse", newResponse.Text);
                    command.Parameters.AddWithValue("%feedbackID", row.RowIndex);

                if (command.ExecuteNonQuery() == 1) {
                    oldResponse.Text = newResponse.Text;
                    newResponse.Text = "";
                }

                }, exception => Response.Redirect("./ErrorPage.aspx"));
            }, () => Response.Redirect("./ErrorPage.aspx"));

            submit.Enabled = true;
            submit.UseSubmitBehavior = true;
        }

    }
}