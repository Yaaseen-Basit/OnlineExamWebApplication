using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AdminLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (UN.Text == pswd.Text)
        {
            Response.Redirect("ExamQuestions");
        }
        else
        {
            TextBox3.Text = "Your password and username is incorrect Try Again";
        }
    }
}