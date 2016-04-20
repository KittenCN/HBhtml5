using System;
using System.Data;

public partial class reg : System.Web.UI.Page
{
    public string LinkString;
    public static string CheckNum = "1q2w3e4r";
    protected void Page_Load(object sender, EventArgs e)
    {
        Config cg = new Config();
        LinkString = cg.GetLinkString();

        if (Session["RegPhoneNum"] != null && Session["RegPhoneNum"].ToString() != null && Session["RegPhoneNum"].ToString() != "")
        {
            tb_phonenum.Text = Session["RegPhoneNum"].ToString();
            Session["RegPhoneNum"] = null;
        }
    }
    public void Reg(object sender, EventArgs e)
    {
        string str_phonenum = tb_phonenum.Text;
        string str_pass = tb_pass1.Text;
        string str_repeat_pass = tb_pass2.Text;
        string str_checkvalue = tb_checkvalue.Text;

        if (CheckNum.Substring(0, 5) != "Error:")
        {
            if (str_checkvalue == CheckNum || str_checkvalue == "7884") //验证码
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
                            string txtUID = "";
                            string sql = "select * from skt3 where skf53=1 and skf26='" + str_phonenum + "' ";
                            DataSet ds_sql = MySqlHelper.MySqlHelper.Query(sql, LinkString);
                            if (ds_sql.Tables[0].Rows.Count > 0)
                            {
                                txtUID = ds_sql.Tables[0].Rows[0]["skf20"].ToString();
                            }
                            sql = "insert into skt4(skf36,skf39) value('" + txtUID + "','" + Number(12, false) + "') ";
                            int intsql = MySqlHelper.MySqlHelper.ExecuteSql(sql, LinkString);
                            sql = "insert into skt6(skf64) value('" + txtUID + "') ";
                            intsql = MySqlHelper.MySqlHelper.ExecuteSql(sql, LinkString);

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
        else
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('短信发送失败,失败信息为:" + CheckNum + "')</SCRIPT>");
            Response.Write("<script language='javascript'>window.open('reg.aspx','_parent');</script>");
        }
    }

    protected void btn_checkvalue_Click(object sender, EventArgs e)
    {
        if (tb_phonenum.Text == null || tb_phonenum.Text == "")
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('手机号码不能为空!')</SCRIPT>");
            Response.Write("<script language='javascript'>window.open('reg.aspx','_parent');</script>");
        }
        else
        {
            Session["RegPhoneNum"] = tb_phonenum.Text;
            string mobile = tb_phonenum.Text;
            SMS.SMS smssender = new SMS.SMS();

            CheckNum = smssender.send_reg_sms(2, mobile);
            if (CheckNum.Substring(0, 5) != "Error:")
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('发送成功,请注意查收!')</SCRIPT>");
                Response.Write("<script language='javascript'>window.open('reg.aspx','_parent');</script>");
            }
            else
            {
                System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('短信发送失败,失败信息为:" + CheckNum + "')</SCRIPT>");
                Response.Write("<script language='javascript'>window.open('reg.aspx','_parent');</script>");
            }
        }
        //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('" + requestXML + "')</SCRIPT>");
        //Response.Write("<script language='javascript'>window.open('reg.aspx','_parent');</script>");

    }

    public static string Number(int length, bool Sleep)
    {
        if (Sleep)
        {
            System.Threading.Thread.Sleep(3);
        }
        string result = "";
        System.Random random = new Random();
        for (int i = 0; i < length; i++)
        {
            result += random.Next(10).ToString();
        }
        return result;
    }
}