using System;
using System.Collections.Generic;
using System.Data;
using DataObject;
using Business;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation.Nguoidung
{
    public partial class frmcapnhatnguoidung : System.Web.UI.Page
    {
        

        protected void LoadQuyen(string q)
        {
            
            if (q=="Q")
            {
                TAIKHOANBusiness taikhoan = new TAIKHOANBusiness();
                DataTable dt = taikhoan.DetailsByField ("quyen","Q");
                dstaikhoan.DataSource = dt;
                dstaikhoan.DataBind();
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadQuyen("Q");
            }
        }

        protected void themmoinguoidung_Click(object sender, EventArgs e)
        {
            TAIKHOAN tk = new TAIKHOAN();
            TAIKHOANBusiness ttk = new TAIKHOANBusiness();
            tk.Taikhoan = tentaikhoan.Text;
            tk.matkhau = matkhau.Text;
            tk.quyen = quyennv.Text;
            int i= ttk.Insert(tk);
            
            LoadQuyen("Q");

        }

        protected void dstaikhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            tentaikhoan.Text = dstaikhoan.SelectedRow.Cells[1].Text;
            quyennv.SelectedItem.Text = dstaikhoan.SelectedRow.Cells[3].Text;
        }
        

   }
}