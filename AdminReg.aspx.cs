using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into AdminTbl ([Name],[Address],[Contact],[Email],[Uname],[Pswd],[RPswd],[SecurityQuestion],[SecurityAns])values('" + Cname.Text + "','" + Caddress.Text + "','" + Ccontact.Text + "','" + Eid.Text + "','" + UN.Text + "','" + pswd.Text + "','" + rpswd.Text + "','" + SQ.SelectedItem.Text + "','" + SA.Text + "')";
            cmd.ExecuteNonQuery();
            TextBox1.Text = " U R REGISTERD AS ADMIN";

            con.Close();
        
    }
}