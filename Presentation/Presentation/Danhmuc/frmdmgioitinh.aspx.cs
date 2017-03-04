using System;
using System.Collections.Generic;
using System.Data;
using DataObject;
using Business;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation.Danhmuc
{
    public partial class frmdmgioitinh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Form.Action = Request.RawUrl;
            if (!IsPostBack)
            {
                LoadGioiTinh("Q");
            }
        }
        protected void LoadGioiTinh(string q)
        {
            GIOITINHBusiness gt = new GIOITINHBusiness();
            DataTable dt = gt.GetList();
            danhsachgioitinh.DataSource = dt;
            danhsachgioitinh.DataBind();

        }

        protected void danhsachgioitinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            gioitinh_id.Text = danhsachgioitinh.SelectedRow.Cells[1].Text;
            gioitinh.Text = danhsachgioitinh.SelectedRow.Cells[2].Text;
        }

        protected void them_Click(object sender, EventArgs e)
        {
            GIOITINH gti = new GIOITINH();
            gti.gioitinhid = int.Parse (gioitinh_id.Text);
            gti.gioitinh = gioitinh.Text;
            GIOITINHBusiness GTB = new GIOITINHBusiness();
            GTB.Insert(gti);
            
            LoadGioiTinh("Q");
        }
    }
}
