using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Member_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
    }


    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["TourguideConnectionString"].ConnectionString);
        SqlCommand MyCmd = new SqlCommand("select * from member where Mem_Email = '"+txtID.Text+"' and Mem_Pwd ='"+txtPW.Text+"'", conn);
        SqlDataReader DataReader;
        MyCmd.Parameters.Add("@Mem_Name ", SqlDbType.VarChar);//SQL的資料型態
        MyCmd.Parameters["@Mem_Name "].Value = txtID.Text;
        MyCmd.Parameters.Add("@Mem_Pwd", SqlDbType.VarChar);
        MyCmd.Parameters["@Mem_Pwd"].Value = txtPW.Text;

        try 
        {
            conn.Open();
            DataReader = MyCmd.ExecuteReader();
            if (DataReader.HasRows)
            {
                DataReader.Read();
                Session["txtID"] = DataReader["Mem_Email"].ToString();
                Session["txtPW"] = DataReader["Mem_Pwd"].ToString();
                Session["login"] = "yes";

                Response.Write("<script>alert('登入成功');</script>");
                //Response.Redirect("Member_Update.aspx?Mem_Email="+txtID.Text);
                Response.Redirect("MemberCenter.aspx?Mem_Email="+txtID.Text);
                
            }
            
            else {
                Response.Write("<script>alert('登入失敗');</script>");
            }
        }
            catch(Exception ex){
                Response.Write("其他錯誤"+ ex.Message);
            }
        }
    }

