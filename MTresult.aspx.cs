using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MTresult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        TextBox1.Text = Session["Score"].ToString();
    Label4.Text = Session["Exam Name"].ToString();

    Label5.Text = Session["No Of Questions"].ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
}