using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InFundWebCode;

namespace WebApplication1
{
    public partial class BorrowerProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack == false)
            {
                if (Request.QueryString["id"] != null)
                {
                    //Load up the correct person's profile
                    //In this case it will first need to recognise that the profile belongs to a borrower
                    UserObject usr = new UserObject(Request.QueryString["id"]);
                    imgBorrower.ImageUrl = usr.GetCurrentBorrowerProfilePhoto();
                    lbBorrower.Text = usr.GetCurrentBorrowerProfileName();
                    lbBorrowerStatus.Text = usr.GetCurrentBorrowerStatus();

                }
            }
        }
    }
}