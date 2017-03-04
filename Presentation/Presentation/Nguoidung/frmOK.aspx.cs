using System;
using System.Data;
using System.Collections.Generic;
using DataObject;
using Business;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation.Nguoidung
{
    public partial class frmOK : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String s = Request.QueryString["Quyen"];
            TAIKHOANBusiness taikhoan = new TAIKHOANBusiness();
            DataTable dt = taikhoan.DetailsByField("quyen",s);
            Danhsachnguoidung.DataSource = dt;
            Danhsachnguoidung.DataBind();

        }
    }
}