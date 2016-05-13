using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InFundWebCode;

namespace WebApplication1.controls
{
    public partial class Login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack==false)
            {
                if (Session["UserID"] == null)
                {
                    pnLogin.Visible = true;
                    pnWelcome.Visible = false;
                }
                else
                {
                    UserObject usr = new UserObject(Session["UserID"].ToString());
                    //Username is currently misrepresented. As the Borrowe name is the Trading name of the business,
                    //Username should represent the director or signatory to whom the user profile belongs 
                    lbUserName.Text = usr.GetCurrentBorrowerProfileName();
                    pnLogin.Visible = false;
                    pnWelcome.Visible = true;
                }
            }
        }

        protected void bnLogin_Click(object sender, EventArgs e)
        {
            LoginUser usr = new LoginUser();
            string UserID = usr.Login(txtUsername.Text, txtPassword.Text);
            if (UserID == "")
            {
                lbError.Text = "Username / Password not Recognised. Please Try again.";
            }
            else
            {
                Session.Add("UserID", UserID);
                UserObject usr2 = new UserObject(Session["UserID"].ToString());
                pnLogin.Visible = false;
                pnWelcome.Visible = true;
                Response.Redirect("BorrowerProfile.aspx?id="+UserID);
            }
        }


    }
}
