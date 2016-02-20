using System;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    public string LinkString = "Server=localhost;user id=root;password=;Database=chenkuserdb37;Port=3308;charset=utf8;";

    protected void Page_Load(object sender, EventArgs e)
    {
        Session["UID"] = null;
    }

    public void btn_Login(object sender, EventArgs e)
    {
        //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('Hello World!')</SCRIPT>");
        string str_PhoneNUM = Request.Form["tf_PhoneNUM"].Trim();
        string str_Pass = Request.Form["tf_Pass"].Trim();
        string str_mysql = "select count(skf26) as coutnum from skt3 where skf53=1 and  skf26='" + str_PhoneNUM + "' and skf194='" + str_Pass + "'";

        DataSet DS = MySqlHelper.MySqlHelper.Query(str_mysql, LinkString);

        if (DS.Tables[0].Rows[0].ItemArray[0].ToString() != null && int.Parse(DS.Tables[0].Rows[0].ItemArray[0].ToString()) > 0)
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('登录成功')</SCRIPT>");
            Response.Write("<script language='javascript'>window.open('welcome.aspx?PhoneNUM=" + str_PhoneNUM + "','_parent');</script>");
        }
        else
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('登录失败')</SCRIPT>");
            Response.Write("<script language='javascript'>window.open('Login.aspx','_parent');</script>");
        }
    }

}