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
    public partial class frmdmloaihopdong : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Form.Action = Request.RawUrl;

            if (!IsPostBack)
            {
                Loadloaihopdong("Q");
            }

        }

        protected void Loadloaihopdong(string q)
        {
            if (q == "Q")
            {
                LOAIHOPDONGBusiness hd = new LOAIHOPDONGBusiness();
                DataTable dt = hd.GetList();
                danhsachloaihopdong.DataSource = dt;
                danhsachloaihopdong.DataBind();
            }
               
        }

        protected void danhsachloaihopdong_SelectedIndexChanged(object sender, EventArgs e)
        {
            maloaihopdong.Text = danhsachloaihopdong.SelectedRow.Cells[1].Text;
            tenloaihopdong.Text = danhsachloaihopdong.SelectedRow.Cells[2].Text; 
            
        }

        protected void them_Click(object sender, EventArgs e)
        {
            LOAIHOPDONG hd = new LOAIHOPDONG();
            hd.mahd = maloaihopdong.Text;
            hd.tenhd = tenloaihopdong.Text;
            LOAIHOPDONGBusiness lhd = new LOAIHOPDONGBusiness();
            int i = lhd.Insert(hd);
            Loadloaihopdong("Q");
        }
    }
}