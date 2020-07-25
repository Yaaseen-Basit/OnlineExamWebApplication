using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

public partial class Default4 : System.Web.UI.Page
{
   
    int KK=0;
    int k;
    DataSet ds;
    int count = 0;
    string Selans = "-1";
   

    protected void Page_Load(object sender, EventArgs e)
    {
    //    TextBox1.Text = Session["CandidateFullName"].ToString();

    //    TextBox2.Text = Session["Exam Name"].ToString();

    //    TextBox3.Text = Session["No Of Questions"].ToString();

    }
    private void dclquery(String aa)
    {
        SqlConnection con=new SqlConnection();
       con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        ds = new DataSet();
        SqlDataAdapter sda = new SqlDataAdapter(aa, con);
        sda.Fill(ds, "abc");
        

    }
    protected void TextBox2_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
               
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        try
        {
            KK = Convert.ToInt32(HiddenField2.Value);

            KK = KK + 1;
            HiddenField2.Value = KK.ToString();
            string xx = "select * from QuestionTabl where Qno=" + KK + "";
            dclquery(xx);
            Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
            Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
            C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
            C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
            C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
            C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
            Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();

        }
        catch
        {

        }
        //if (C1.Checked)
        //{
        //    Selans = "a";
        //}
        //else if (C2.Checked)
        //{
        //    Selans = "b";
        //}
        //else if (C3.Checked)
        //{
        //    Selans = "c";
        //}
        //else if (C4.Checked)
        //{
        //    Selans = "d";
        //}
        
        //if (Cans.Text == Selans)
        //{
        //    count = Convert.ToInt32(HiddenField3.Value);
        //    count++;

        //    HiddenField3.Value = count.ToString();
        //}
        //Score.Text = "" + count;

       
    }
    
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        if (Label6.Text == Label4.Text)
        {
            Timer1.Enabled = false;
            k = Convert.ToInt32(HiddenField1.Value);
            Response.Redirect("Result.aspx");
        }
        else
        {
            Timer1.Enabled = true;
        }
        k = Convert.ToInt32(HiddenField1.Value);
        k = k + 1;
        HiddenField1.Value = k.ToString();
        Label5.Text = HiddenField1.Value;
        Label12.Text = DateTime.Now.ToString();
        Label10.Text = DateTime.Now.ToString();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
    }
    protected void Button3_Click1(object sender, EventArgs e)
    {
       
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
    protected void HiddenField1_ValueChanged(object sender, EventArgs e)
    {
        k = Convert.ToInt32(HiddenField1.Value);
        k = k + 10;
        HiddenField1.Value = k.ToString();
        Label5.Text = HiddenField1.Value;
        
    }
    protected void Button1_Click1(object sender, EventArgs e)
    {
        Timer1.Enabled = true;
        
        string xx = "select * from QuestionTabl where Qno=" + 1 + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["No Of Questions"] = TextBox3.Text;
        Session["Score"] = Score.Text;
        Session["Exam Name"] = TextBox2.Text;
        Server.Transfer("MTresult.aspx");
    }

    protected void HiddenField2_ValueChanged(object sender, EventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (C1.Checked)
        {
            Selans = "a";
        }
        else if (C2.Checked)
        {
            Selans = "b";
        }
        else if (C3.Checked)
        {
            Selans = "c";
        }
        else if (C4.Checked)
        {
            Selans = "d";
        }

        if (Cans.Text == Selans)
        {
            count = Convert.ToInt32(HiddenField3.Value);
            count++;

            HiddenField3.Value = count.ToString();
        }
        Score.Text = "" + count;

    }
}