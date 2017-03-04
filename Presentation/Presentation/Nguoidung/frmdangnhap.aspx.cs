using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using DataObject;
using Business;

namespace Presentation.Nguoidung
{
    public partial class frmdangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Dangnhap.Focus();
            }


        }

        protected void Dangnhap_Authenticate(object sender, AuthenticateEventArgs e)
        {
            TAIKHOANBusiness Tk = new TAIKHOANBusiness();
            DataTable dt = Tk.DetailsByField("Taikhoan", Dangnhap.UserName);
            DataTable dtmk = Tk.DetailsByField("matkhau", Dangnhap.Password);
            try
            {
                if ((dt.Rows.Count == 1) && (dtmk.Rows.Count == 1))
                {
                    string q;
                    q = dt.Rows[0][2].ToString();
                    Response.Redirect("/nguoidung/ok/"+q);
                    //Response.Redirect("~/Nguoidung/frmOk.aspx?Quyen=" + q);
                }
            }
            catch
            { 
                
            }
            
                
        }
    }
}