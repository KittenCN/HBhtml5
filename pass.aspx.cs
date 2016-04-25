using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class pass : System.Web.UI.Page
{
    public string LinkString;

    protected void Page_Load(object sender, EventArgs e)
    {
        Config cg = new Config();
        LinkString = cg.GetLinkString();

        string str_mysql = "";
        string str_PhoneNUM = "";

        if (Session["UID"] != null && Session["UID"].ToString() != null && Session["UID"].ToString() != "")
        {
            str_mysql = "select skf26 from skt3 where skf53=1 and skf20='" + Session["UID"].ToString() + "'";
            DataSet DSs = MySqlHelper.MySqlHelper.Query(str_mysql, LinkString);
            if (DSs.Tables[0].Rows.Count > 0 && DSs.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                str_PhoneNUM = DSs.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            else
            {
                str_PhoneNUM = Request["PhoneNUM"].Trim();
            }
        }
        if (str_PhoneNUM == null || str_PhoneNUM == "")
        {
            str_PhoneNUM = Request["PhoneNUM"].Trim();
        }

        lab_PhoneNUM.Text = str_PhoneNUM;

        if (!IsPostBack)
        {
            tb_oldpass.Text = "";
            tb_newpass.Text = "";
            tb_renewpass.Text = "";
        }
    }

    protected void btn_ok_Click(object sender, EventArgs e)
    {
        string str_PhoneNUM = lab_PhoneNUM.Text;
        string str_oldPass = tb_oldpass.Text;
        string str_mysql = "select count(skf26) as coutnum from skt3 where skf53=1 and  skf26='" + str_PhoneNUM + "' and skf194='" + str_oldPass + "'";

        DataSet DS = MySqlHelper.MySqlHelper.Query(str_mysql, LinkString);

        if (DS.Tables[0].Rows[0].ItemArray[0].ToString() != null && int.Parse(DS.Tables[0].Rows[0].ItemArray[0].ToString()) > 0)
        {
            if(tb_newpass.Text==tb_renewpass.Text)
            {
                str_mysql = "update skt3 set skf194='" + tb_newpass.Text + "' where skf53=1 and skf26='" + str_PhoneNUM + "' ";
                int int_result = MySqlHelper.MySqlHelper.ExecuteSql(str_mysql, LinkString);
                if (int_result > 0)
                {
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('更新成功,请用新密码登录')</SCRIPT>");
                    Response.Write("<script language='javascript'>window.open('Login.aspx','_parent');</script>");
                }
                else
                {
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('更新失败!')</SCRIPT>");
                    Response.Write("<script language='javascript'>window.open('pass.aspx'_parent');</script>");
                }
            }
            else
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('两次输入的新密码不同!')</SCRIPT>");
                Response.Write("<script language='javascript'>window.open('pass.aspx'_parent');</script>");
            }
        }
        else
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('原密码错误!')</SCRIPT>");
            Response.Write("<script language='javascript'>window.open('pass.aspx'_parent');</script>");
        }
    }

    protected void btn_cancel_Click(object sender, EventArgs e)
    {
        Server.Transfer("welcome.aspx?PhoneNUM=" + lab_PhoneNUM.Text + "'");
        //Response.Write("<script language='javascript'>window.open('welcome.aspx?PhoneNUM=" + lab_PhoneNUM.Text + "','_parent');</script>");
    }
}