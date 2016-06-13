using System;
using System.Data;

public partial class money : System.Web.UI.Page
{
    public string LinkString;
    protected void Page_Load(object sender, EventArgs e)
    {
        Config cg = new Config();
        LinkString = cg.GetLinkString();
        if (!IsPostBack)
        {
            string str_userid = Session["UID"].ToString();

            //string str_mysql = "SELECT skf165 as '卡号',skf167 as '支付金额',skf173 as '支付日期' ";
            //str_mysql = str_mysql + " FROM skt14 ";
            //str_mysql = str_mysql + " WHERE skf159 = '14' ";
            //str_mysql = str_mysql + " AND(skf158 IN(SELECT skf37 FROM skt4 WHERE skf36 = '" + str_userid + "' AND skf54 = 1) ";
            //str_mysql = str_mysql + " OR skf158 IN(SELECT skf38 FROM skt4 WHERE skf36 = '" + str_userid + "' AND skf54 = 1) ";
            //str_mysql = str_mysql + " OR skf158 IN(SELECT skf39 FROM skt4 WHERE skf36 = '" + str_userid + "' AND skf54 = 1)) ";
            string str_mysql = "SELECT skf77-skf76 AS '增加储值',skf82 AS '生成时间' FROM skt7 WHERE skf77-skf76<>0 and skf73='" + str_userid + "' ORDER BY skf82 DESC LIMIT 0,20";
            DataSet DS = MySqlHelper.MySqlHelper.Query(str_mysql, LinkString);
            if (DS.Tables[0].Rows.Count > 0 && DS.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                gv_cc.DataSource = DS;
                gv_cc.DataBind();
            }
            else
            {
                str_mysql = "SELECT '-' AS '增加储值','-' AS '生成时间'";
                DS = MySqlHelper.MySqlHelper.Query(str_mysql, LinkString);
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