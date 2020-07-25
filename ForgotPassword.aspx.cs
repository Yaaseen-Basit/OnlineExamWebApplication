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
        cmd.CommandText = "select pswd from CanditateReg where SecurityQuestion ="+ SQ.SelectedItem.Text + "'and SecurityAns='" + SA.Text + "')";
        SqlDataReader dr;
            dr= cmd.ExecuteReader();
            if (dr.Read())
                Label1.Text = dr[0].ToString();
            else
                Label1.Text = "Try Again";

        cmd.ExecuteNonQuery();
        con.Close();
       
    }
}