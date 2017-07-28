using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZZ_Fashion.LoginPages.Customer.AppCode;
using System.IO;

namespace ZZ_Fashion.LoginPages.Customer
{
    public partial class CreateFeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TitleFeedBack.Text = "Male Apparel Selection Limited";
                FeedBackMsg.Text = "Male Selection of Clothing is too limited, please update your databse and add more clothes soon. I want to buy clothes for chinese new year. " +
                    "Also, please add more discounts, it will help you attract more cutomers.";
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            FeedBack objFeedBack = new FeedBack();
            objFeedBack.MemberID = Session["LoginID"].ToString();
            objFeedBack.Title = TitleFeedBack.Text;
            objFeedBack.Message = FeedBackMsg.Text;

            int errorCode = objFeedBack.ConfirmAdd();

            if (errorCode == 0)
            {
                string PhotoFeedbackID = "";
                if (UploadFeedbackPhoto.HasFile == true)
                {
                    // find the filename extension of the file to be uploaded
                    string fileExtension = Path.GetExtension(UploadFeedbackPhoto.FileName);

                    // find FeedbackID of this image so that it can be used as Image name
                    PhotoFeedbackID = objFeedBack.FindFeedbackID().ToString();

                    // Image name to be saved in 'Images' folder
                    string FileSavePath = MapPath("~/Images/Feedback/" + "images-" + PhotoFeedbackID + fileExtension);

                    // Save image in application 'Images' folder
                    UploadFeedbackPhoto.SaveAs(FileSavePath);

                    // to View image in Webpage using Image Control
                    FeedbackImage.ImageUrl = "~/Images/Feedback/" + UploadFeedbackPhoto;

                    objFeedBack.ImageFileName = FileSavePath;

                    // use an UPDATE SQL line to update the existing feedback record to add the image name 
                }

                Response.Redirect("ViewResponse.aspx");
            }
            else
            {
                Message.Text = "Update was unsuccessful, did you key in the right details?";
            }


            
        }
    }
}