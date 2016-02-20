using System;
using System.Data;

public partial class welcome : System.Web.UI.Page
{
    public string LinkString = "Server=localhost;user id=root;password=;Database=chenkuserdb37;Port=3308;charset=utf8;";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string str_mysql = "";
            string str_PhoneNUM = "";

            if(Session["UID"]!=null && Session["UID"].ToString()!=null && Session["UID"].ToString()!="")
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
            if(str_PhoneNUM==null || str_PhoneNUM=="")
            {
                str_PhoneNUM = Request["PhoneNUM"].Trim();
            }
            
            lab_PhoneNUM.Text = str_PhoneNUM;
            lab_currdate.Text = DateTime.Now.ToLongDateString().ToString();           

            str_mysql = "select * from skt3 where skf53=1 and skf26='" + str_PhoneNUM + "'";
            DataSet DS = MySqlHelper.MySqlHelper.Query(str_mysql, LinkString);
            if (DS.Tables[0].Rows.Count > 0 && DS.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                string str_userid = DS.Tables[0].Rows[0].ItemArray[0].ToString();
                Session["UID"] = str_userid;
                string str_username = DS.Tables[0].Rows[0].ItemArray[1].ToString();
                string str_usersex = DS.Tables[0].Rows[0].ItemArray[2].ToString();
                string str_userbirthday = DS.Tables[0].Rows[0].ItemArray[3].ToString();
                string str_useradd = DS.Tables[0].Rows[0].ItemArray[9].ToString();
                string str_userchrname = DS.Tables[0].Rows[0].ItemArray[19].ToString();
                string str_userchrbirthday = DS.Tables[0].Rows[0].ItemArray[20].ToString();

                string str_userlevel = DS.Tables[0].Rows[0].ItemArray[16].ToString();
                string str_mysql_level = "select skf13 from skt2 where skf10=1 and skf9='" + str_userlevel + "'";
                DataSet DS1 = MySqlHelper.MySqlHelper.Query(str_mysql_level, LinkString);
                if (DS1.Tables[0].Rows.Count > 0 && DS1.Tables[0].Rows[0].ItemArray[0].ToString() != null)
                {
                    str_userlevel = DS1.Tables[0].Rows[0].ItemArray[0].ToString();
                }
                else
                {
                    str_userlevel = "";
                }
                string str_hbb = "0";
                string str_cc = "0";
                string str_mysql_money = "select skf65,skf66 from skt6 where skf91=1 and skf64='" + str_userid + "'";
                DataSet DS_money = MySqlHelper.MySqlHelper.Query(str_mysql_money, LinkString);
                if (DS_money.Tables[0].Rows.Count > 0 && DS_money.Tables[0].Rows[0].ItemArray[0].ToString() != null)
                {
                    str_hbb = DS_money.Tables[0].Rows[0].ItemArray[0].ToString();
                }
                else
                {
                    str_hbb = "0";
                }
                if (DS_money.Tables[0].Rows.Count > 0 && DS_money.Tables[0].Rows[0].ItemArray[1].ToString() != null)
                {
                    str_cc = DS_money.Tables[0].Rows[0].ItemArray[1].ToString();
                }
                else
                {
                    str_cc = "0";
                }

                tb_username.Text = str_username;
                tb_useradd.Text = str_useradd;
                tb_userbirthday.Text = str_userbirthday;
                tb_userchrbirthday.Text = str_userchrbirthday;
                tb_userchrname.Text = str_userchrname;
                tb_userphonenum.Text = str_PhoneNUM;
                if (str_usersex == "0")
                {
                    ddl_sex.SelectedValue = "0";
                    ddl_sex.SelectedIndex = 0;
                }
                else
                {
                    ddl_sex.SelectedValue = "1";
                    ddl_sex.SelectedIndex = 1;
                }
                lab_userlevel.Text = str_userlevel;
                lab_hbb.Text = str_hbb;
                lab_cc.Text = str_cc;

            }
        }
    }

    protected void btn_reset_Click(object sender, EventArgs e)
    {
        string str_PhoneNUM = "";
        string str_mysql = "";

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

        str_mysql = "select * from skt3 where skf53=1 and skf26='" + str_PhoneNUM + "'";
        DataSet DS = MySqlHelper.MySqlHelper.Query(str_mysql, LinkString);
        if (DS.Tables[0].Rows.Count > 0 && DS.Tables[0].Rows[0].ItemArray[0].ToString() != null)
        {
            string str_userid = DS.Tables[0].Rows[0].ItemArray[0].ToString();
            string str_username = DS.Tables[0].Rows[0].ItemArray[1].ToString();
            string str_usersex = DS.Tables[0].Rows[0].ItemArray[2].ToString();
            string str_userbirthday = DS.Tables[0].Rows[0].ItemArray[3].ToString();
            string str_useradd = DS.Tables[0].Rows[0].ItemArray[9].ToString();
            string str_userchrname = DS.Tables[0].Rows[0].ItemArray[19].ToString();
            string str_userchrbirthday = DS.Tables[0].Rows[0].ItemArray[20].ToString();

            string str_userlevel = DS.Tables[0].Rows[0].ItemArray[16].ToString();
            string str_mysql_level = "select skf13 from skt2 where skf10=1 and skf9='" + str_userlevel + "'";
            DataSet DS1 = MySqlHelper.MySqlHelper.Query(str_mysql_level, LinkString);
            if (DS1.Tables[0].Rows.Count > 0 && DS1.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                str_userlevel = DS1.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            else
            {
                str_userlevel = "";
            }
            string str_hbb = "0";
            string str_cc = "0";
            string str_mysql_money = "select skf65,skf66 from skt6 where skf91=1 and skf64='" + str_userid + "'";
            DataSet DS_money = MySqlHelper.MySqlHelper.Query(str_mysql_money, LinkString);
            if (DS_money.Tables[0].Rows.Count > 0 && DS_money.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                str_hbb = DS_money.Tables[0].Rows[0].ItemArray[0].ToString();
            }
            else
            {
                str_hbb = "0";
            }
            if (DS_money.Tables[0].Rows.Count > 0 && DS_money.Tables[0].Rows[0].ItemArray[1].ToString() != null)
            {
                str_cc = DS_money.Tables[0].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                str_cc = "0";
            }

            tb_username.Text = str_username;
            tb_useradd.Text = str_useradd;
            tb_userbirthday.Text = str_userbirthday;
            tb_userchrbirthday.Text = str_userchrbirthday;
            tb_userchrname.Text = str_userchrname;
            tb_userphonenum.Text = str_PhoneNUM;
            if (str_usersex == "0")
            {
                ddl_sex.SelectedValue = "0";
            }
            else
            {
                ddl_sex.SelectedValue = "1";
            }
            lab_userlevel.Text = str_userlevel;
            lab_hbb.Text = str_hbb;
            lab_cc.Text = str_cc;
        }
    }

    protected void btn_save_Click(object sender, EventArgs e)
    {
        string str_userid = "";
        string str_PhoneNUM = tb_userphonenum.Text;
        string str_mysql = "select * from skt3 where skf53=1 and skf26='" + str_PhoneNUM + "'";
        DataSet DS = MySqlHelper.MySqlHelper.Query(str_mysql, LinkString);
        if (DS.Tables[0].Rows.Count > 0 && DS.Tables[0].Rows[0].ItemArray[0].ToString() != null)
        {
            str_userid = DS.Tables[0].Rows[0].ItemArray[0].ToString();
        }

        str_mysql = "update skt3 set skf21='" + tb_username.Text + "',skf22='" + ddl_sex.SelectedValue.ToString() + "',skf23='" + tb_userbirthday.Text + "',skf29='" + tb_useradd.Text + "',skf89='" + tb_userchrname.Text + "',skf90='" + tb_userchrbirthday.Text + "' where skf53=1 and skf20='" + str_userid + "'";
        int int_result = MySqlHelper.MySqlHelper.ExecuteSql(str_mysql, LinkString);
        if (int_result >= 1)
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('保存成功!')</SCRIPT>");
            Response.Write("<script language='javascript'>window.open('welcome.aspx?PhoneNUM=" + str_PhoneNUM + "','_parent');</script>");
        }
        else
        {
            System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('保存失败!')</SCRIPT>");
            Response.Write("<script language='javascript'>window.open('welcome.aspx?PhoneNUM=" + str_PhoneNUM + "','_parent');</script>");
        }
    }
}
