﻿using System;
using System.Data;

public partial class money : System.Web.UI.Page
{
    public string LinkString = "Server=localhost;user id=root;password=;Database=chenkuserdb37;Port=3308;charset=utf8;";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            string str_userid = Session["UID"].ToString();

            string str_mysql = "SELECT skf77 AS '储值', skf79 AS '积分', skf81 AS '赠送积分',skf82 AS '生成时间' FROM skt7 WHERE skf73='" + str_userid + "'";
            DataSet DS = MySqlHelper.MySqlHelper.Query(str_mysql, LinkString);
            if (DS.Tables[0].Rows.Count > 0 && DS.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                gv_cc.DataSource = DS;
                gv_cc.DataBind();
            }

            str_mysql = "select skf26 from skt3 where skf53=1 and skf20='" + Session["UID"].ToString() + "'";
            DataSet DSs = MySqlHelper.MySqlHelper.Query(str_mysql, LinkString);
            if (DSs.Tables[0].Rows.Count > 0 && DSs.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                lab_PhoneNUM.Text = DSs.Tables[0].Rows[0].ItemArray[0].ToString();
            }
        }
    }
}