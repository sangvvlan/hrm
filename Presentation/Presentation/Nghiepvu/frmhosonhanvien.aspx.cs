using System;
using System.IO;
using System.Data;
using System.Collections.Generic;
using DataObject;
using Business;
using Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Presentation.Nghiepvu
{
    public partial class frmhosonhanvien : System.Web.UI.Page
    {

         protected void Page_Load(object sender, EventArgs e)
        {
            Form.Action = Request.RawUrl;

            if (!IsPostBack)
            {
                NHANVIENBusiness nhanvien = new NHANVIENBusiness();
                DataTable ds_nhanvien = nhanvien.GetList();
                danhsachnhanvien.DataSource = ds_nhanvien;
                danhsachnhanvien.DataBind();
               // -------------------------
                Load_Phong();
                Load_chucvu();
                Load_trinhdo();
                Load_chuyenmon();
                Load_dantoc();
                Load_tongiao();
                Load_bacluong();
                Load_loaihd();
                Load_gioitinh();
                Load_donvi();
            }
            
        }

        protected void danhsachnhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string manv = danhsachnhanvien.SelectedRow.Cells[2].Text;
            List_Nhanvien(manv);
        }

        protected void danhsachnhanvien_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onmouseover"] = "this.style.backgroundColor='aquamarine';";
                e.Row.Attributes["onmouseout"] = "this.style.backgroundColor='white';";
                e.Row.ToolTip = "Click last column for selecting this row.";
            }
        }

        protected void List_Nhanvien(string mnv)
        {
            try
            {
                NHANVIENBusiness nhanvien = new NHANVIENBusiness();
                DataTable tbl = nhanvien.DetailsByField("manv", mnv);

                manhanvien.Text = tbl.Rows[0]["manv"].ToString();
                hovaten.Text = tbl.Rows[0]["tennv"].ToString();
                noisinh.Text = tbl.Rows[0]["noisinh"].ToString();
                choohientai.Text = tbl.Rows[0]["noiohientai"].ToString();
                ngaysinh.Text = tbl.Rows[0]["ngaysinh"].ToString().Substring(0, 10);
                CMND.Text = tbl.Rows[0]["socmnd"].ToString();
                noisinh.Text = tbl.Rows[0]["noisinh"].ToString();
                dienthoai.Text = tbl.Rows[0]["sodt"].ToString();
                hdldso.Text = tbl.Rows[0]["sohd"].ToString();

                donvi.SelectedIndex = donvi.Items.IndexOf(donvi.Items.FindByValue(tbl.Rows[0]["donviid"].ToString()));
                machuyenmon.SelectedIndex = machuyenmon.Items.IndexOf(machuyenmon.Items.FindByValue(tbl.Rows[0]["cmid"].ToString()));
                maphong.SelectedIndex = maphong.Items.IndexOf(maphong.Items.FindByValue(tbl.Rows[0]["phongid"].ToString()));
                machucvu.SelectedIndex = machucvu.Items.IndexOf(machucvu.Items.FindByValue(tbl.Rows[0]["cvid"].ToString()));
                dantoc.SelectedIndex = dantoc.Items.IndexOf(dantoc.Items.FindByValue(tbl.Rows[0]["dantoc"].ToString()));
                tongiao.SelectedIndex = tongiao.Items.IndexOf(tongiao.Items.FindByValue(tbl.Rows[0]["tongiao"].ToString()));                
                loaihd.SelectedIndex = loaihd.Items.IndexOf(loaihd.Items.FindByValue(tbl.Rows[0]["loaihd"].ToString()));
                gioitinh.SelectedIndex = gioitinh.Items.IndexOf(gioitinh.Items.FindByValue(tbl.Rows[0]["gioitinh"].ToString()));

                giadinh.SelectedIndex = giadinh.Items.IndexOf(giadinh.Items.FindByValue(tbl.Rows[0]["giadinh"].ToString()));
                if ( tbl.Rows[0]["hinh"] == DBNull.Value )
                {
                    hinhnhanvien.ImageUrl = "/Images/noimage.png";
                }
                else
                {
                    if (File.Exists(Server.MapPath("/Images/"+ tbl.Rows[0]["hinh"].ToString())) == true)
                    {
                        hinhnhanvien.ImageUrl ="/Images/" + tbl.Rows[0]["hinh"].ToString();
                    }
                    else
                    {
                        hinhnhanvien.ImageUrl = "/Images/noimage.png";
                    }

                }


                ngayhd.Text = tbl.Rows[0]["ngayhd"].ToString().Substring(0, 10);
                ngaybd.Text = tbl.Rows[0]["ngaybd"].ToString().Substring(0, 10);

            }
            catch
            { }
 
        }

        protected void Load_Phong()
        {
            PHONGBusiness phongs = new PHONGBusiness();
            DataTable P = phongs.GetList();
            maphong.DataValueField = "phongid";
            maphong.DataTextField = "tenphong";
            maphong.DataSource = P;
            maphong.DataBind();

        }

        protected void Load_chucvu()
        {
            CHUCVUBusiness chucvus = new CHUCVUBusiness();
            DataTable CV = chucvus.GetList();
            machucvu.DataValueField = "cvid";
            machucvu.DataTextField = "tencv";
            machucvu.DataSource = CV;
            machucvu.DataBind();
        }
        
        protected void Load_trinhdo()
        {
            TRINHDOBusiness TD = new TRINHDOBusiness();
            DataTable trd = TD.GetList();
            matrinhdo.DataValueField = "tdid";
            matrinhdo.DataTextField = "tentd";
            matrinhdo.DataSource = trd;
            matrinhdo.DataBind();
        }
        
        protected void Load_chuyenmon()
        {
            CHUYENMONBusiness cm = new CHUYENMONBusiness();
            DataTable Cmon = cm.GetList();
            machuyenmon.DataValueField = "cmid";
            machuyenmon.DataTextField = "tencm";
            machuyenmon.DataSource = Cmon;
            machuyenmon.DataBind();
        }

        protected void Load_dantoc()
        {
            DANTOCBusiness dan_toc = new DANTOCBusiness();
            DataTable dt = dan_toc.GetList();
            dantoc.DataValueField = "dantocid";
            dantoc.DataTextField = "tendt";
            dantoc.DataSource = dt;
            dantoc.DataBind();
        }
        
        protected void Load_tongiao()
        {
            TONGIAOBusiness ton_giao = new TONGIAOBusiness();
            DataTable tg = ton_giao.GetList();
            tongiao.DataValueField = "tgid";
            tongiao.DataTextField = "tentg";
            tongiao.DataSource = tg;
            tongiao.DataBind();
        }
        
        protected void Load_bacluong()
        {
            MUCLUONGBusiness bac_luong = new MUCLUONGBusiness();
            DataTable bl = bac_luong.GetList();
            bacluong.DataValueField = "bacluong";
            bacluong.DataTextField = "bacluong";
            bacluong.DataSource = bl;
            bacluong.DataBind();
            
        }
        
        protected void Load_loaihd()
        {
            LOAIHOPDONGBusiness lhd = new LOAIHOPDONGBusiness();
            DataTable loai_hd = lhd.GetList();
            loaihd.DataValueField = "loaihdid";
            loaihd.DataTextField = "tenhd";
            loaihd.DataSource = loai_hd;
            loaihd.DataBind();
        
        
        }

        protected void Load_gioitinh()
        {
            GIOITINHBusiness gt = new GIOITINHBusiness();
            DataTable gti = gt.GetList();
            gioitinh.DataValueField = "gioitinhid";
            gioitinh.DataTextField = "gioitinh";
            gioitinh.DataSource = gti;
            gioitinh.DataBind();
        }

        protected void Load_donvi()
        {
            DONVIBusiness dv = new DONVIBusiness();
            DataTable dvi = dv.GetList();
            donvi.DataValueField = "donviid";
            donvi.DataTextField = "tendonvi";
            donvi.DataSource = dvi;
            donvi.DataBind();
        }
        
        protected void uphinh_Click(object sender, EventArgs e)
        {
            if (Page.IsValid && loadhinh.HasFile && CheckFileType(loadhinh.FileName))
            {

                Luuhinhvaodatabase(loadhinh.FileName,manhanvien.Text);
                string fileName = Path.Combine(Server.MapPath("~/Images"), loadhinh.FileName);
                loadhinh.SaveAs(fileName);
                List_Nhanvien(manhanvien.Text);

            }
        }

        protected void Luuhinhvaodatabase(string hinh_nv,string ma_nv)
        {
            NHANVIENBusiness hinhnv = new NHANVIENBusiness();
            Hinh_NHANVIEN n_v = new Hinh_NHANVIEN();
            n_v.manv = ma_nv;
            n_v.hinh = hinh_nv;
            hinhnv.Update_hinh(n_v);
            

           
        }

        bool CheckFileType(string fileName)
        {

            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".gif":
                    return true;
                case ".png":
                    return true;
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                default:
                    return false;
            }
        }

        protected void them_Click(object sender, EventArgs e)
        {
            try
            {
                NHANVIENBusiness nv = new NHANVIENBusiness();
                NHANVIEN n_v = new NHANVIEN();
                DataNHANVIEN dtnv = new DataNHANVIEN();
                DataTable dtsl = dtnv.DataGetListNHANVIEN();
                int sl = dtsl.Rows.Count + 1;
                manhanvien.Text = Taomanv(donvi.SelectedValue, maphong.Text, sl);
                n_v.manv = manhanvien.Text;
                n_v.honv = hovaten.Text;
                n_v.bacluong = float.Parse(bacluong.SelectedValue.ToString());
                n_v.bhxh = "";
                n_v.cmid = decimal.Parse(machuyenmon.SelectedValue);
                n_v.cvid = decimal.Parse(machucvu.SelectedValue);
                n_v.dantoc = decimal.Parse(dantoc.SelectedValue);
                n_v.donviid = decimal.Parse(donvi.SelectedValue);
                n_v.email = "";
                n_v.giadinh = decimal.Parse(giadinh.SelectedValue);
                n_v.gioitinh = decimal.Parse(gioitinh.SelectedValue);
                n_v.honv = hovaten.Text;
                n_v.loaihd = decimal.Parse(loaihd.SelectedValue);
                n_v.ngaybd = DateTime.Parse(ngaybd.Text);
                n_v.ngayct = DateTime.Parse(ngaybd.Text);
                n_v.ngayhd = DateTime.Parse(ngayhd.Text);
                n_v.ngaykt = System.DateTime.Now;
                n_v.ngaysinh = DateTime.Parse(ngaysinh.Text);
                n_v.noiohientai = choohientai.Text;
                n_v.noisinh = noisinh.Text;
                n_v.phongid = decimal.Parse(maphong.SelectedValue);
                n_v.socmnd = CMND.Text;
                n_v.sodt = dienthoai.Text;
                n_v.sohd = hdldso.Text;
                n_v.tdid = decimal.Parse(matrinhdo.SelectedValue);
                n_v.tennv = hovaten.Text;
                n_v.tongiao = decimal.Parse(tongiao.SelectedValue);
                nv.Insert(n_v);
                Luuhinhvaodatabase(loadhinh.FileName, manhanvien.Text);
            }
            catch 
            { 
            
            }

        }

        protected string Taomanv(string dv, string ph,int ts)
        {
            string s = "";

            if (dv.Length==1)
            { dv = 0 + dv; }
            if (ph.Length == 1)
            { ph = "0" + ph; }
            if (ts.ToString().Length == 1)
            {
                s = "00" + ts.ToString();
            }
            if (ts.ToString().Length == 2)
            {
                s = "0" + ts.ToString();
            }

            return dv + ph + s;
        
        }

        protected void xoa_Click(object sender, EventArgs e)
        {

        }

        protected void sua_Click(object sender, EventArgs e)
        {

        }

        protected void in_Click(object sender, EventArgs e)
        {

        }

        protected void huy_Click(object sender, EventArgs e)
        {

        }





    }
}