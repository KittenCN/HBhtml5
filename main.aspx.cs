using System;

public partial class main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void ToLogin(object sender,EventArgs e)
    {
        Response.Write("<script language='javascript'>window.open('Login.aspx','_parent');</script>");
    }
}