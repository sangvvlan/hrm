using System;
using System.Collections.Generic;
using System.Data;
using DataObject;
using Business;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation
{
    public partial class frmdmtrinhdo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Form.Action = Request.RawUrl;

            if (!IsPostBack)
            {
                LoadTrinhdo("Q");
            }
        }
        protected void LoadTrinhdo(string q)
        {
            TRINHDOBusiness tdo = new TRINHDOBusiness();
            DataTable dt = tdo.GetList();
            danhsachtrinhdo.DataSource = dt;
            danhsachtrinhdo.DataBind();

        }

        protected void danhsachtrinhdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            matrinhdo.Text = danhsachtrinhdo.SelectedRow.Cells[1].Text;
            tentrinhdo.Text = danhsachtrinhdo.SelectedRow.Cells[2].Text;
        }

        protected void them_Click(object sender, EventArgs e)
        {
            TRINHDO tdo = new TRINHDO();
            tdo.matd = matrinhdo.Text;
            tdo.tentd = tentrinhdo.Text;
            TRINHDOBusiness td = new TRINHDOBusiness();
            td.Insert(tdo);
            LoadTrinhdo("Q");
        }

        protected void xoa_Click(object sender, EventArgs e)
        {

        }
    }
}