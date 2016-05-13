using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication1
{
    public partial class BorrowCreateAccount : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = 162.13.152.199; Initial Catalog = WebDB; User ID = sa; Password = ***********");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblBorrowerReg(CompanyTradingName,CompanyRegNumber,FirstName, SecondName,Username,Email,ConfirmEmail,Password) values('"+txtCompanyTName.Text+"','" + txtCompanyRegNum.Text + "','" +txtFirstName.Text + "','" + txtSecondName.Text + "','" + txtUsername.Text + "','" + txtEmail.Text + "','" + txtConfirmEmail.Text + "','" + txtPassword.Text + "')" ,con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}