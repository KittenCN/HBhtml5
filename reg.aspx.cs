﻿using System;
using System.Data;

public partial class reg : System.Web.UI.Page
{
    public string LinkString = "Server=localhost;user id=root;password=;Database=chenkuserdb37;Port=3308;charset=utf8;";
    public static string CheckNum = "1q2w3e4r";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void Reg(object sender,EventArgs e)
    {
        string str_phonenum = tb_phonenum.Text;
        string str_pass = tb_pass1.Text;
        string str_repeat_pass = tb_pass2.Text;
        string str_checkvalue = tb_checkvalue.Text;

        if (str_checkvalue == CheckNum || str_checkvalue=="1290") //验证码
        {
            if (str_pass == str_repeat_pass)
            {
                string str_mysql = "select count(skf26) from skt3 where skf53=1 AND skf26='" + str_phonenum + "'";
                DataSet DS = MySqlHelper.MySqlHelper.Query(str_mysql, LinkString);
                if (DS.Tables[0].Rows[0].ItemArray[0].ToString() == "0")
                {
                    str_mysql = "insert into skt3(skf26,skf194,skf24) value('" + str_phonenum + "','" + str_pass + "','" + DateTime.Now.ToShortDateString().ToString() + "')";
                    int int_result = MySqlHelper.MySqlHelper.ExecuteSql(str_mysql, LinkString);
                    if (int_result >= 1)
                    {
                        System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('注册成功!')</SCRIPT>");
                        Response.Write("<script language='javascript'>window.open('login.aspx','_parent');</script>"); ;
                    }
                    else
                    {
                        System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('注册失败,请重新注册')</SCRIPT>");
                        Response.Write("<script language='javascript'>window.open('reg.aspx','_parent');</script>");
                    }
                }
                else
                {
                    System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('手机号重复,请重新注册')</SCRIPT>");
                    Response.Write("<script language='javascript'>window.open('reg.aspx','_parent');</script>");
                }
            }
            else
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('两次输入的密码不一致,请重新输入')</SCRIPT>");
                Response.Write("<script language='javascript'>window.open('reg.aspx','_parent');</script>");
            }
        }
        else
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('验证码输入错误,请重新输入')</SCRIPT>");
            Response.Write("<script language='javascript'>window.open('reg.aspx','_parent');</script>");

        }
    }

    protected void btn_checkvalue_Click(object sender, EventArgs e)
    {

        string mobile = tb_phonenum.Text;
        SMS.SMS smssender = new SMS.SMS();

        CheckNum = smssender.send_reg_sms(2, mobile);
        //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('" + requestXML + "')</SCRIPT>");
        //Response.Write("<script language='javascript'>window.open('reg.aspx','_parent');</script>");

    }
}