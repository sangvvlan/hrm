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
    public partial class frmdmphongban : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Form.Action = Request.RawUrl;

            if (!IsPostBack)
            {
                LoadPhong("Q");
            
            }
        }

        protected void LoadPhong(string q)
        {
            PHONGBusiness p = new PHONGBusiness();
            DataTable dt = p.GetList();
            danhsachphongban.DataSource = dt;
            danhsachphongban.DataBind();

        }

        protected void danhsachphongban_SelectedIndexChanged(object sender, EventArgs e)
        {
            maphong.Text = danhsachphongban.SelectedRow.Cells[1].Text;
            tenphong.Text = danhsachphongban.SelectedRow.Cells[2].Text;
            dienthoai.Text = danhsachphongban.SelectedRow.Cells[3].Text;
            
        }

        protected void them_Click(object sender, EventArgs e)
        {
            PHONG po = new PHONG();
            po.maphong = maphong.Text;
            po.tenphong = tenphong.Text;
            po.Dienthoai = dienthoai.Text;
            PHONGBusiness bP = new PHONGBusiness();
            bP.Insert(po);
            LoadPhong("Q");
        }
    }
}