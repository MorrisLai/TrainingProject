using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Member_Update : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlDataSource1.SelectParameters["Mem_Email"].DefaultValue = Session["txtID"].ToString();
        
        
    }
    protected void FormView1_ItemUpdated(object sender, FormViewUpdatedEventArgs e)
    {
        FormView1.DataBind();
        Response.Redirect("index.aspx");
    }
    protected void FormView1_ItemUpdating(object sender, FormViewUpdateEventArgs e)
    {
        //Label Mem_Pwd= (Label)FormView1.FindControl("Mem_Pwd");
        //Label Mem_Nation= (Label)FormView1.FindControl("Mem_Nation");
        //Label Mem_City=     (Label)FormView1.FindControl("Mem_City");
        //Label Mem_Mobile = (Label)FormView1.FindControl("Mem_Mobile");
        //e.NewValues["Mem_Pwd"] = Mem_Pwd.Text;
        //e.NewValues["Mem_Nation"] = Mem_Nation.Text;
        //e.NewValues["Mem_City"] = Mem_City.Text;
        //e.NewValues["Mem_Mobile"] = Mem_Mobile.Text;
    }
}
