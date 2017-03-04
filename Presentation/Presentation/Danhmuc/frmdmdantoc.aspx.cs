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
    public partial class frmdmdantoc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Form.Action = Request.RawUrl;

            if (!IsPostBack)
            {
                LoadDT("Q");
            }
        }

        protected void LoadDT(string q)
        {
            if (q == "Q")
            {
                DANTOCBusiness dantoc = new DANTOCBusiness();
                DataTable dt = dantoc.GetList();
                Danhsachdantoc.DataSource = dt;
                Danhsachdantoc.DataBind();

            }
        }


        protected void them_Click(object sender, EventArgs e)
        {
            DANTOC dtoc = new DANTOC();
            DANTOCBusiness bdt = new DANTOCBusiness();
            dtoc.madt = madantoc.Text;
            dtoc.tendt = tendantoc.Text;
            int i = bdt.Insert(dtoc);
            LoadDT("Q");


        }

        protected void Danhsachdantoc_SelectedIndexChanged(object sender, EventArgs e)
        {
                GridViewRow row = Danhsachdantoc.SelectedRow;
                madantoc.Text = row.Cells[1].Text;
                tendantoc.Text = row.Cells[2].Text;
        }
    }
}