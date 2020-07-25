using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cname.Text = Session["CandidateFullName"].ToString();

        ename.Text = Session["Exam Name"].ToString();

        NoQ.Text = Session["No Of Questions"].ToString();
        NoC.Text = Session["Score"].ToString();
        Mks.Text = Session["Score"].ToString();
        Tmks.Text = Session["Total Max Marks"].ToString();
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //CandidateID CandidateFullName ExamName NoOfQuestions NoOfCorrectAnswer MarksObtained TotalMarks
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=SYSTEM-9\\SQLEXPRESS;Initial Catalog=EXAM;Integrated Security=True;Pooling=False";
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;
        cmd.CommandText = "Insert into ResultTbl ([CandidateID],[CandidateFullName],[ExamName],[NoOfQuestions],[NoOfCorrectAnswer],[MarksObtained],[TotalMarks])values('" + cid.Text + "','" + cname.Text + "','" + ename.Text + "','" +NoQ.Text + "','" + NoC.Text + "','" +Mks.Text + "','" +Tmks.Text + "')";
        cmd.ExecuteNonQuery();
        Label1.Text = " U R RESULT is SUCCESSFULLY SAVED";

        con.Close();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("ReviewExam.aspx");
    }
}