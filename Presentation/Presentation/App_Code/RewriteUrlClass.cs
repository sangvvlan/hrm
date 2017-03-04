using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation.App_Code
{
    public class RewriteUrlClass : IHttpModule
    {
        public void Dispose()
        {
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += Context_BeginRequest;
        }

        private static void Context_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication httpApplication = (HttpApplication)sender;
            string url = httpApplication.Request.RawUrl.ToLower();

            // Nếu là Url ảo như sau"
            if (url.Contains("/nguoidung/dangnhap"))
            {
                // Thì Url thực mà Server cần xử lý là:
                httpApplication.Context.RewritePath("/Nguoidung/frmdangnhap.aspx");
            }
            if (url.Contains("/nguoidung/ok/q"))
            {
                // Thì Url thực mà Server cần xử lý là:
                httpApplication.Context.RewritePath("/Nguoidung/frmOk.aspx?Quyen=Q");
            }
            if (url.Contains("/nghiepvu/nhanvien"))
            {
                // Thì Url thực mà Server cần xử lý là:
                httpApplication.Context.RewritePath("/Nghiepvu/frmhosonhanvien.aspx");
            }
            if (url.Contains("/gioitinh/nam"))
            {
                httpApplication.Context.RewritePath("/Danhmuc/frmdmgioitinh.aspx");
            }
            if (url.Contains("/chucvu/cv"))
            {
                httpApplication.Context.RewritePath("/Danhmuc/frmdmchucvu.aspx");
            }
            if (url.Contains("/trinhdo/dh"))
            {
                httpApplication.Context.RewritePath("/Danhmuc/frmdmtrinhdo.aspx");
            }
            if (url.Contains("/tongia/p"))
            {
                httpApplication.Context.RewritePath("/Danhmuc/frmdmtongiao.aspx");
            }
            if (url.Contains("/phongban/p"))
            {
                httpApplication.Context.RewritePath("/Danhmuc/frmdmphongban.aspx");
            }
            if (url.Contains("/loaihopdong/p"))
            {
                httpApplication.Context.RewritePath("/Danhmuc/frmdmloaihopdong.aspx");
            }
            if (url.Contains("/dantoc/p"))
            {
                httpApplication.Context.RewritePath("/Danhmuc/frmdmdantoc.aspx");
            }
            if (url.Contains("/nguoidung/p"))
            {
                httpApplication.Context.RewritePath("/Nguoidung/frmcapnhatnguoidung.aspx");
            }

            // Tùy thuộc vào quy tắt Rewrite mà chúng ta xử lý.
            // Một trong những cách hiệu quả nhất là dùng Regex Expression.

        }
    }
}