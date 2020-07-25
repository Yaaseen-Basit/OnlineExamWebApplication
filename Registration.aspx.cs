using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Insert into CandidateReg ([Cname],[Caddress],[Ccontact],[Qual],[Email],[Uname],[Pswd],[RPswd],[SecurityQuestion],[SecurityAns])values('" + Cname.Text + "','" + Caddress.Text + "','" + Ccontact.Text + "','" + Qualification.Text + "','" + Eid.Text + "','" + UN.Text + "','" + pswd.Text + "','" + rpswd.Text + "','" + SQ.SelectedItem.Text + "','" + SA.Text + "')";
            cmd.ExecuteNonQuery();

            con.Close();
        }
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
            con.Open();
           

            string aa = "select MAX(Cid)from CandidateReg ";

            DataSet ds = new DataSet();
            SqlDataAdapter oda = new SqlDataAdapter(aa, con);
            oda.Fill(ds, "abc");
            Label2.Text = ds.Tables[0].Rows[0].ItemArray.GetValue(0).ToString();
          // int  b = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
          // Label2.Text = b.ToString();
            oda.Dispose();
            con.Close();
        }
        msg.Text = "You are Now A Registered Candidate Login To  your Account and Your ID is = "+Label2.Text;
    }
    protected void msg_TextChanged(object sender, EventArgs e)
    {

    }
}