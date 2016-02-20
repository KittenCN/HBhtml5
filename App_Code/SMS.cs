using System;
using System.IO;
using System.Net;
using System.Text;


namespace SMS
{
    /// <summary>
    /// SMS 的摘要说明
    /// </summary>
    public class SMS
    {
        string userid = "410";
        string account = "mhkj";
        string password = "mhkj123456";

        public SMS()
        { }

        public string send_reg_sms(int int_proindex,string mobile)
        {
            string RanNum = Number(6, false);
            string content = mobile + "用户,您的验证码是:" + RanNum + " 【霓虹儿童广场】";
            string RequestXML = "";

            switch(int_proindex)
            { 
                case 1:
                { 
                    //SendSms(string userid, string account, string password, string mobile, string content, string sendTime, string extno)
                    //构造soap请求信息
                    StringBuilder soap = new StringBuilder();
                    soap.Append("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                    soap.Append("<soap:Envelope xmlns:soap12=\"http://www.w3.org/2003/05/soap-envelope/\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
                    soap.Append("<soap12:Body>");
                    soap.Append("<SendSms xmlns=\"http://tempuri.org/\">");
                    soap.Append("<userid>" + userid + "</userid>");
                    soap.Append("<account>" + account + "</account>");
                    soap.Append("<password>" + password + "</password>");
                    soap.Append("<mobile>" + mobile + "</mobile>");
                    soap.Append("<content>" + content + "</content>");
                    soap.Append("<sendTime></sendTime>");
                    soap.Append("<extno></extno>");
                    soap.Append("</SendSms>");
                    soap.Append("</soap12:Body>");
                    soap.Append("</soap12:Envelope>");

                    //发起请求
                    Uri uri = new Uri("http://114.215.136.60:8888/SmsWebService.asmx?wsdl");
                    WebRequest webRequest = WebRequest.Create(uri);
                    webRequest.ContentType = "text/xml; charset=utf-8";
                    webRequest.Method = "POST";
                    using (Stream requestStream = webRequest.GetRequestStream())
                    {
                        byte[] paramBytes = Encoding.UTF8.GetBytes(soap.ToString());
                        requestStream.Write(paramBytes, 0, paramBytes.Length);
                    }

                    //响应
                    WebResponse webResponse = webRequest.GetResponse();
                    using (StreamReader myStreamReader = new StreamReader(webResponse.GetResponseStream(), Encoding.UTF8))
                    {
                        RequestXML = myStreamReader.ReadToEnd();
                    }
                    break;
                }
                case 2:
                    {
                        string str_sendUrl = "http://114.215.136.60:8888/sms.aspx?action=send&userid=" + userid + "&account=" + account + "&password=" + password + "&mobile=" + mobile + "&content=" + content + "&sendTime=&extno=";
                        HttpWebRequest webrequest = (HttpWebRequest)HttpWebRequest.Create(str_sendUrl);
                        HttpWebResponse webreponse = (HttpWebResponse)webrequest.GetResponse();
                        Stream stream = webreponse.GetResponseStream();
                        byte[] rsByte = new Byte[webreponse.ContentLength];  //save data in the stream
                        try
                        {
                            stream.Read(rsByte, 0, (int)webreponse.ContentLength);
                            RequestXML= System.Text.Encoding.UTF8.GetString(rsByte, 0, rsByte.Length).ToString();
                        }
                        catch (Exception exp)
                        {
                            RequestXML= exp.ToString();
                        }

                        break;
                    }
            }

            return RanNum;
        }

        //生成数字随机数
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
}