using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.ProductManager {
    public partial class CreateProduct : System.Web.UI.Page {

        bool hasPicture = false;

        protected void Page_Init(object sender, EventArgs e) {
            EffectiveDate.SelectedDate = DateTime.Today;
        }

        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void CalendarValidate(object source, ServerValidateEventArgs args) {
            if (EffectiveDate == null || EffectiveDate.SelectedDate < DateTime.Today) {
                args.IsValid = false;
            } else {
                args.IsValid = true;
            }
        }

    }
}