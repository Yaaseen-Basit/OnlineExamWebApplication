using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;
using System.Drawing;

public partial class Default3 : System.Web.UI.Page
{
    int marks = 0;

    string Selans = "-1";
    int  KK =0;
    int m = 1;
    protected void Page_Load(object sender, EventArgs e)
    {
        cid.Text = Session["CandidateID"].ToString();
        TextBox1.Text = Session["CandidateFullName"].ToString();

        TextBox2.Text = Session["Exam Name"].ToString();

        TextBox3.Text = Session["No Of Questions"].ToString();

    }
    
    int i;
   
    DataSet ds;
    int k;
    String v;
   

    
    private void dclquery(String aa)
    {
        SqlConnection con=new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        ds = new DataSet();
        SqlDataAdapter oda = new SqlDataAdapter(aa, con);
        oda.Fill(ds, "abc");
        

    }
   
    protected void  Button2_Click(object sender, EventArgs e)
{

    Session["CandidateID"]=
    Session["CandidateFullName"] = TextBox1.Text;
    Session["Exam Name"] = TextBox2.Text;
    Session["No Of Questions"] = TextBox3.Text;
    Session["Score"] = Score.Text;
    Session["No Of Questions"] = TextBox3.Text;
    Session["Total Max Marks"] = Label8.Text;
    Server.Transfer("Result.aspx");
        
        
        //Session["Exam Name"] = Label6.Text;
        //Session["No Of Questions"] = Label5.Text;
        //Server.Transfer("MTresult.aspx");
}
    protected void Button3_Click(object sender, EventArgs e)
    {
        Q1.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" +Q1.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
      
    }
     
    protected void  C4_CheckedChanged(object sender, EventArgs e)
{
   if (C4.Checked)
        {
            v = "d";
           // Q1.BackColor = Color.Green;
                        
        }
}
protected void  C3_CheckedChanged(object sender, EventArgs e)
{
   if (C3.Checked)
        {
            v = "c";
           // Q1.BackColor = Color.Green;
                        
        }
}
protected void  C2_CheckedChanged(object sender, EventArgs e)
{
       if (C2.Checked)
        {
            v = "b";
           // Q1.BackColor = Color.Green;
                        
        }
}
protected void  C1_CheckedChanged(object sender, EventArgs e)
{
       if (C1.Checked)
        {
            v = "a";
           // Q1.BackColor = Color.Green;
                        
        }
}
protected void  Button1_Click1(object sender, EventArgs e)
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
protected void  Timer1_Tick(object sender, EventArgs e)
{
    if (Label6.Text == Label1.Text)
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
protected void  save_Click(object sender, EventArgs e)
{
            SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "insert into ReviewTbl([CId],[Qno],[Question],[SelectedAns],[CorrectAns])values('" + cid.Text + "',,'" + Qno.Text + "','" + Qs.Text + "','" +v + "','" + Cans.Text + "')";
        cmd.ExecuteNonQuery();
        Label1.Text = "Your Result is saved  Successfully";
        con.Close();
}

protected void  Q2_Click(object sender, EventArgs e)
{
            Q2.BackColor = Color.DarkOrange;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string xx = "select * from QuestionTabl where Qno=" + Q2.Text + "";
            dclquery(xx);
            Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
}
protected void  Q3_Click(object sender, EventArgs e)
{
    Q3.BackColor = Color.DarkOrange;    
        SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            string xx = "select * from QuestionTabl where Qno=" + Q3.Text + "";
            dclquery(xx);
            Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
}
   
    
    protected void Q4_Click(object sender, EventArgs e)
    {
        Q4.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q4.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
       
    }
    protected void Q5_Click(object sender, EventArgs e)
    {
        Q5.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q5.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
       
    }
    protected void Q6_Click(object sender, EventArgs e)
    {
        Q6.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q6.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
     
       
    }
    protected void Q7_Click(object sender, EventArgs e)
    {
        Q7.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q7.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
       
    }
    protected void Qe_Click(object sender, EventArgs e)
    {
        Qe.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Qe.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
       
    }
    protected void Q8_Click(object sender, EventArgs e)
    {
        Q8.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q8.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
       
    }
    protected void Q9_Click(object sender, EventArgs e)
    {
        Q9.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q9.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
   
    }
    protected void Q11_Click(object sender, EventArgs e)
    {
        Q11.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q11.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
       
    }
    protected void Q10_Click(object sender, EventArgs e)
    {
    
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q10.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
      
    }
   
    protected void Q13_Click(object sender, EventArgs e)
    {
        Q13.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q13.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q14_Click(object sender, EventArgs e)
    {
        Q14.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q14.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q15_Click(object sender, EventArgs e)
    {
        Q15.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q15.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q16_Click(object sender, EventArgs e)
    {
        Q16.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q16.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q17_Click(object sender, EventArgs e)
    {
        Q17.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q17.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q18_Click(object sender, EventArgs e)
    {
        Q18.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q18.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q19_Click(object sender, EventArgs e)
    {
        Q19.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q19.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q20_Click(object sender, EventArgs e)
    {
        Q20.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q20.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q21_Click(object sender, EventArgs e)
    {
        Q21.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q21.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q22_Click(object sender, EventArgs e)
    {
        Q22.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q22.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q23_Click(object sender, EventArgs e)
    {
        Q23.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q23.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q24_Click(object sender, EventArgs e)
    {
        Q24.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q24.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q25_Click(object sender, EventArgs e)
    {
        Q25.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q25.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q26_Click(object sender, EventArgs e)
    {
        Q26.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q26.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q27_Click(object sender, EventArgs e)
    {
        Q27.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q27.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q28_Click(object sender, EventArgs e)
    {
        Q28.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q28.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q29_Click(object sender, EventArgs e)
    {
        Q29.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q29.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q30_Click(object sender, EventArgs e)
    {
        Q30.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q30.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q31_Click(object sender, EventArgs e)
    {
        Q31.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q31.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q32_Click(object sender, EventArgs e)
    {
        Q32.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q32.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q33_Click(object sender, EventArgs e)
    {
        Q33.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q33.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q34_Click(object sender, EventArgs e)
    {
        Q34.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q34.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q36_Click(object sender, EventArgs e)
    {
        Q36.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q36.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q37_Click(object sender, EventArgs e)
    {
        Q37.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q37.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q38_Click(object sender, EventArgs e)
    {
        Q38.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q38.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q35_Click(object sender, EventArgs e)
    {
        Q35.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q35.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q40_Click(object sender, EventArgs e)
    {
        Q40.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q40.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q44_Click(object sender, EventArgs e)
    {
        Q44.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q44.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q41_Click(object sender, EventArgs e)
    {
        Q41.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q41.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q42_Click(object sender, EventArgs e)
    {
        Q42.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q42.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q39_Click(object sender, EventArgs e)
    {
        Q39.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q39.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q43_Click(object sender, EventArgs e)
    {
        Q43.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q43.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q45_Click(object sender, EventArgs e)
    {
        Q45.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q45.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q46_Click(object sender, EventArgs e)
    {
        Q46.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q46.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q47_Click(object sender, EventArgs e)
    {
        Q47.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q47.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q49_Click(object sender, EventArgs e)
    {
        Q49.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q49.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
    protected void Q48_Click(object sender, EventArgs e)
    {
        Q48.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q48.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    }
  
    
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button7_Click(object sender, EventArgs e)
    {
        Q3.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q3.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
        if (C1.Checked)
        {
            Q3.BackColor = Color.Green;
        }
        else if (C2.Checked)
        {
            Q3.BackColor = Color.Green;
        }
        else if (C3.Checked)
        {
            Q3.BackColor = Color.Green;
        }
        else if (C4.Checked)
        {
            Q3.BackColor = Color.Green;
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Q2.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q2.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
       
    }
    protected void HiddenField1_ValueChanged(object sender, EventArgs e)
    {
        k = Convert.ToInt32(HiddenField1.Value);
        k = k + 10;
        HiddenField1.Value = k.ToString();
        Label5.Text = HiddenField1.Value;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "insert into ReviewTble([CId],[Qno],[Question],[SelectedAns],[CorrectAns])values('" + cid.Text + "','" + Qno.Text + "','" + Qs.Text + "','" + v + "','" + Cans.Text + "')";
        cmd.ExecuteNonQuery();
        
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
            marks = Convert.ToInt32(HiddenField3.Value);
            marks++;
            HiddenField3.Value = marks.ToString();
        }

        Score.Text = "" +marks;
        con.Close();
    }
    protected void Q12_Click(object sender, EventArgs e)
    {
        Q12.BackColor = Color.DarkOrange;
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string xx = "select * from QuestionTabl where Qno=" + Q12.Text + "";
        dclquery(xx);
        Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        C4.Text = ds.Tables[0].Rows[0].ItemArray[5].ToString();
        Cans.Text = ds.Tables[0].Rows[0].ItemArray[6].ToString();
    
    }
    protected void Button3_Click1(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        try
        {
            KK = Convert.ToInt32( HiddenField2.Value);

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
    }
    protected void HiddenField2_ValueChanged(object sender, EventArgs e)
    {

    }
}
