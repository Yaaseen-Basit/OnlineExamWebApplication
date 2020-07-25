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

    SqlConnection con = new SqlConnection();
    DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";

        con.Open();
        string query = "select * from AdminTbl";
        SqlDataAdapter oda = new SqlDataAdapter(query, con);
        DataSet ds = new DataSet();
        oda.Fill(ds, "abc");
        GridView1.DataSource = ds.Tables["abc"];
        GridView1.DataBind();
    }
}