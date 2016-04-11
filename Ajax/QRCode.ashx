<%@ WebHandler Language="C#" Class="QRCode" %>

using System;
using System.Web;
using System.Drawing;
using ThoughtWorks.QRCode.Codec;
using System.IO;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;
using System.Drawing.Imaging;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

public class QRCode : IHttpHandler, IRequiresSessionState
{
    readonly string currentPath = System.Web.HttpContext.Current.Server.MapPath("..\\QRCode");

    public void ProcessRequest(HttpContext context)
    {
        string strCardNum = context.Request.QueryString["CardNum"].Replace("'", "");
        Bitmap bmp = null;
        if (strCardNum != null && strCardNum != "" && strCardNum != "0")
        {
            SaveImg(currentPath, strCardNum, Create_ImgCodeI(strCardNum));
            bmp = new Bitmap(@currentPath + "\\" + strCardNum + ".png");
            //bmp = new Bitmap(@"E:\\workstation\\HTML5\\HBhtml5\\QRCode\\654459625115.png");
            //清除该页输出缓存，设置该页无缓存 
            context.Response.Buffer = true;
            context.Response.ExpiresAbsolute = System.DateTime.Now.AddMilliseconds(0);
            context.Response.Expires = 0;
            context.Response.CacheControl = "no-cache";
            context.Response.AppendHeader("Pragma", "No-Cache");
            //将验证码图片写入内存流，并将其以 "image/Png" 格式输出 
            MemoryStream ms = new MemoryStream();
            try
            {
                bmp.Save(ms, ImageFormat.Png);
                context.Response.ClearContent();
                context.Response.ContentType = "image/Png";
                context.Response.BinaryWrite(ms.ToArray());
            }
            finally
            {
                //显式释放资源 
                bmp.Dispose();
                //g.Dispose();
            }
        }
    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }

    /// <summary>
    /// 保存图片
    /// </summary>
    /// <param name="strPath">保存路径</param>
    /// <param name="img">图片</param>
    public void SaveImg(string strPath, string strFileName, Bitmap img)
    {
        //保存图片到目录
        if (Directory.Exists(strPath))
        {
            //文件名称
            string guid = strFileName + ".png";
            Bitmap bm = new Bitmap(img);
            bm.Save(strPath + "/" + guid, System.Drawing.Imaging.ImageFormat.Png);
        }
        else
        {
            //当前目录不存在，则创建
            Directory.CreateDirectory(strPath);
        }
    }

    public Bitmap Create_ImgCodeI(string codeNumber)
    {
        EncodingOptions options = null;
        BarcodeWriter writer = null;

        options = new EncodingOptions
        {
            //DisableECI = true,  
            //CharacterSet = "UTF-8",  
            Width = 300,
            Height = 50
        };
        writer = new BarcodeWriter();
        writer.Format = BarcodeFormat.ITF;
        writer.Options = options;

        Bitmap bitmap = writer.Write(codeNumber);
        return bitmap;
    }
}