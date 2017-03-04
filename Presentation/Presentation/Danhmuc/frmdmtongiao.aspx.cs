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
    public partial class frmdmtongiao : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Form.Action = Request.RawUrl;

            if (!IsPostBack)
            {
                LoadTongiao("Q");
            }
        }
        protected void LoadTongiao(string q)
        {
            TONGIAOBusiness tg = new TONGIAOBusiness();
            DataTable dt = tg.GetList();
            danhsachtongiao.DataSource = dt;
            danhsachtongiao.DataBind();

        }
        protected void them_Click(object sender, EventArgs e)
        {
            TONGIAO tgiao = new TONGIAO();
            tgiao.matg = matongiao.Text;
            tgiao.tentg = tentongiao.Text;
            TONGIAOBusiness tgi = new TONGIAOBusiness();
            tgi.Insert(tgiao);
            LoadTongiao("Q");

        }

        protected void danhsachtongiao_SelectedIndexChanged(object sender, EventArgs e)
        {
            matongiao.Text = danhsachtongiao.SelectedRow.Cells[1].Text;
            tentongiao.Text = danhsachtongiao.SelectedRow.Cells[2].Text;
        }
    }
}