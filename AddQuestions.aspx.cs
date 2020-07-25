using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection();
    DataSet ds = new DataSet();
    int b =0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //{//<
    //        try
    //        {
    //            KK = KK - 1;
    //            string xx = "select * from tblUSER where ID=" + KK + "";
    //            dclquery(xx);
    //            textBox1.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
    //            textBox2.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
    //            textBox3.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
    //            textBox4.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
    //            textBox5.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
    //        }
    //        catch (Exception ee)
    //        {
    //            MessageBox.Show(ee.Message);
    //        }


    private void dclquery(string aa)
    {
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        ds = new DataSet();
        SqlDataAdapter oda = new SqlDataAdapter(aa, con);
        oda.Fill(ds, "abc");
        GridView1.DataSource = ds.Tables["abc"];

    }
     protected void Button1_Click(object sender, EventArgs e)
    {
        //Qno Question  choice1 choice2 choice3 choice4 Ans
        //SqlConnection con = new SqlConnection();
        //con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        //con.Open();
        //SqlCommand cmd = new SqlCommand();
        //cmd.Connection = con;
        //cmd.CommandText = "insert into QuestionTbl([Qno],[Question],[choice1],[choice2],[choice3],[choice4],[Ans])values('"+Qno.Text+"','" + Qs.Text + "','" + C1.Text + "','" + C2.Text + "', '" + C3.Text + "','" + C4.Text + "','" + Ans.SelectedItem.Text + "')";
        //cmd.ExecuteNonQuery();
        //msg1.Text = "Questions are inserted Successfully";
        //con.Close();

        //con.Open();
        //string query = "select * from QuestionTbl";
        //SqlDataAdapter oda = new SqlDataAdapter(query, con);
        //DataSet ds = new DataSet();
        //oda.Fill(ds, "abc");
        //GridView1.DataSource = ds.Tables["abc"];
        //GridView1.DataBind();
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        string query = "insert into QuestionTabl values('" + Qs.Text + "','" + C1.Text + "','" + C2.Text + "', '" + C3.Text + "','" + C4.Text + "','" + Ans.SelectedItem.Text + "')";
         //  cmd.CommandText = "insert into QuestionTbl([Question],[choice1],[choice2],[choice3],[choice4],[Ans])values('" + Qno.Text + "','" + Qs.Text + "','" + C1.Text + "','" + C2.Text + "', '" + C3.Text + "','" + C4.Text + "','" + Ans.SelectedItem.Text + "')";
        cmd.CommandText=query;
         cmd.ExecuteNonQuery();
        MSG.Text = "Questions are inserted Successfully";
        con.Close();

        con.Open();
        string query1 = "select * from QuestionTabl";
        SqlDataAdapter oda = new SqlDataAdapter(query1, con);
        DataSet ds = new DataSet();
        oda.Fill(ds, "abc");
        GridView1.DataSource = ds.Tables["abc"];
        GridView1.DataBind();
        con.Close();


    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Update QuestionTabl set Question= '" + Qs.Text + "',choice1='" + C1.Text + "',choice2='" + C2.Text + "',choice3='" + C3.Text + "',choice4='" + C4.Text + "',Ans='" + Ans.SelectedItem + "'where Qno =" + Questno.Text + "";


        //cmd.CommandText = "select * from QuestionTbl where Qno=" +Questno.Text + "";
       
        //Qno.Text = ds.Tables[0].Rows[0].ItemArray[0].ToString();
        //Qs.Text = ds.Tables[0].Rows[0].ItemArray[1].ToString();
        //C1.Text = ds.Tables[0].Rows[0].ItemArray[2].ToString();
        //C2.Text = ds.Tables[0].Rows[0].ItemArray[3].ToString();
        //C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        //C3.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        //C4.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        //Ans.Text = ds.Tables[0].Rows[0].ItemArray[4].ToString();
        cmd.ExecuteNonQuery();
        MSG.Text = "Questions are Changed Successfully";

        con.Close();
        con.Open();
        string query = "select * from QuestionTabl";
        SqlDataAdapter oda = new SqlDataAdapter(query, con);
        DataSet ds = new DataSet();
        oda.Fill(ds, "abc");
        GridView1.DataSource = ds.Tables["abc"];
        GridView1.DataBind();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "select * from QuestionTabl'" + QnoD.Text + "'";
        cmd.ExecuteNonQuery();
        MSG.Text = "All Questions are Displayed Below ";
        con.Close();

        con.Open();
        string query = "select * from QuestionTabl";
        SqlDataAdapter oda = new SqlDataAdapter(query, con);
        DataSet ds = new DataSet();
        oda.Fill(ds, "abc");
        GridView1.DataSource = ds.Tables["abc"];
        GridView1.DataBind();
       
        
        
        // string kk = "delete from Questiontbl where Qno=" + QnoD.Text + "";
        
    }

    public string query { get; set; }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Qno.Text = "";
        Qs.Text = "";
        C1.Text = "";
        C2.Text = "";
        C3.Text = "";
        C4.Text = "";
        Ans.Text = "";
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
     
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        
        string aa = "select MAX(Qno)from QuestionTabl ";
       
        DataSet ds = new DataSet();
        SqlDataAdapter oda = new SqlDataAdapter(aa, con);
        oda.Fill(ds, "abc");
        GridView1.DataSource = ds.Tables["abc"];
        b = Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[0].ToString());
        Qno.Text = b.ToString();
        
       // string xx = "select * from   QuestionTbl where Qno=" + b + "";
        //dclquery(xx);

       
    }
}