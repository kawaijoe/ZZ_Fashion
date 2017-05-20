# ZZ_Fashion
DWA Assignment

## Coding Convention

```
        protected void Login_Click(object sender, EventArgs e) {
            string loginID = LoginID.Text;
            string password = Password.Text;
            string userType = "";
            
            if (rdoStaff.Checked) {
                userType = "Staff";
            } else {
                userType = "Customer";
            }
        
            if (auth(loginID, password, userType)) {
                Session["LoginID"] = loginID;
                Session["LoggedInTime"] = DateTime.Now.ToString();
                
                Response.Redirect("Main.aspx");
            } else {
                lblMessage.Text = "Invalid Login Credentials";
            }
        }

        protected bool auth(String loginID, String password, String userType) {
            return loginID == "abc@npbook.com"
                    && password == "pass1234"
                    && userType == "Staff";
        }
```
