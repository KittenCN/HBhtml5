using System;
using System.Data;

public partial class point : System.Web.UI.Page
{
    public string LinkString;
    protected void Page_Load(object sender, EventArgs e)
    {
        Config cg = new Config();
        LinkString = cg.GetLinkString();
        if (!IsPostBack)
        {
            string str_userid = Session["UID"].ToString();

            //string str_mysql = "SELECT skf77-skf76 AS '增加储值', skf79-skf78 AS '增加哈宝币', skf81-skf80 AS '增加赠送哈宝币',skf82 AS '生成时间' FROM skt7 WHERE skf73='" + str_userid + "'";
            string str_mysql = "SELECT skf79-skf78 AS '增加哈宝币', skf81-skf80 AS '增加冻结哈宝币',skf82 AS '生成时间' FROM skt7 WHERE (skf79-skf78<>0 or skf81-skf80<>0) and skf73='" + str_userid + "'";
            DataSet DS = MySqlHelper.MySqlHelper.Query(str_mysql, LinkString);
            if (DS.Tables[0].Rows.Count > 0 && DS.Tables[0].Rows[0].ItemArray[0].ToString() != null)
            {
                gv_hbb.DataSource = DS;
                gv_hbb.DataBind();
            }
            else
            {
                //System.Web.HttpContext.Current.Response.Write("<SCRIPT LANGUAGE='JavaScript'>alert('没有查询到数据!')</SCRIPT>");
                str_mysql = "SELECT '-' AS '增加哈宝币', '-' AS '增加冻结哈宝币','-' AS '生成时间'";
                DS = MySqlHelper.MySqlHelper.Query(str_mysql, LinkString);
                gv_hbb.DataSource = DS;
                gv_hbb.DataBind();
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