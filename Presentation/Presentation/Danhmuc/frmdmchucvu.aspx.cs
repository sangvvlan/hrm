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
    public partial class frmdmchucvu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Form.Action = Request.RawUrl;
            if (!IsPostBack)
            {
                LoadChucVu("Q");
            }
        }
        protected void LoadChucVu(string q)
        {
            CHUCVUBusiness cvu = new CHUCVUBusiness();
            DataTable dt = cvu.GetList();
            danhsachchucvu.DataSource = dt;
            danhsachchucvu.DataBind();

        }
        protected void danhsachchucvu_SelectedIndexChanged(object sender, EventArgs e)
        {
            machucvu.Text = danhsachchucvu.SelectedRow.Cells[1].Text;
            tenchucvu.Text = danhsachchucvu.SelectedRow.Cells[2].Text;
        }

        protected void them_Click(object sender, EventArgs e)
        {
            CHUCVU cv = new CHUCVU();
            cv.macv = machucvu.Text;
            cv.tencv = tenchucvu.Text;
            CHUCVUBusiness chucvu = new CHUCVUBusiness();
            chucvu.Insert(cv);
            LoadChucVu("Q");
        }
    }
}