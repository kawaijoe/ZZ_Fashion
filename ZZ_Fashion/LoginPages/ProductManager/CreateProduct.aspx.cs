using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZZ_Fashion.LoginPages.ProductManager {
    public partial class CreateProduct : System.Web.UI.Page {

        protected void Page_Init(object sender, EventArgs e) {
            EffectiveDate.SelectedDate = System.DateTime.Today;
        }

        protected void Page_Load(object sender, EventArgs e) {
            //Page.DataBind();
        }
    }
}