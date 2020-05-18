using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ThucTapNhom.DAO;

namespace QLNhaHangAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CreateOrderSer" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CreateOrderSer.svc or CreateOrderSer.svc.cs at the Solution Explorer and start debugging.
    public class CreateOrderSer : ICreateOrderSer
    {
        QLNhaHangEntities db = new QLNhaHangEntities();
        public bool CreateOrder(int MaSoBan)
        {
            try
            {
                PhieuYeuCau pyc = new PhieuYeuCau();
                pyc.NgayYeuCau = DateTime.Now;
                db.PhieuYeuCau.Add(pyc);
                db.SaveChanges();
                BanAn ba = db.BanAn.Find(MaSoBan);
                ba.MaPhieuYeuCau = pyc.MaPhieuYeuCau;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public List<NhomMonAn> GetNhomMon()
        {
            List<NhomMonAn> nma = new List<NhomMonAn>();
            var nm = db.NhomMonAn.ToList();
            foreach (var n in nm)
            {
                NhomMonAn na = new NhomMonAn();
                na.MaNhomMon = n.MaNhomMon;
                na.TenNhomMon = n.TenNhomMon;
                nma.Add(na);
            }
            return nma;
        }
        public List<MonAn> GetMonAn(string MaNhomMon)
        {
            var ma = db.MonAn.Where(m => m.MaNhomMon == MaNhomMon).ToList();
            List<MonAn> mo = new List<MonAn>();
            foreach(var mon in ma)
            {
                MonAn mn = new MonAn();
                mn.MaMon = mon.MaMon;
                mn.TenMon = mon.TenMon;
                mn.DonGia = mon.DonGia;
                mo.Add(mn);
            }
            return mo;
        }
        public PhieuYeuCau GetPYC(DateTime nyc)
        {
            var pc = db.PhieuYeuCau.Where(p => p.NgayYeuCau == nyc).OrderByDescending(p => p.MaPhieuYeuCau).FirstOrDefault();
            PhieuYeuCau pyc = new PhieuYeuCau();
            pyc.MaPhieuYeuCau = pc.MaPhieuYeuCau;
            pyc.NgayYeuCau = pc.NgayYeuCau;
            pyc.MaKH = pc.MaKH;
            return pyc;
        }
        public bool ThemDatMon(DatMon dm)
        {
            try
            {
                DatMon datmon = new DatMon();
                datmon.MaPhieuYeuCau = dm.MaPhieuYeuCau;
                datmon.MaMon = dm.MaMon;
                datmon.SoLuong = dm.SoLuong;
                db.DatMon.Add(datmon);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<DatMon> GetDatMon(int MaPYC)
        {
            var dm = db.DatMon.Where(d => d.MaPhieuYeuCau == MaPYC).ToList();
            List<DatMon> da = new List<DatMon>();
            foreach (var dt in dm)
            {
                DatMon mn = new DatMon();
                mn.MaMon = dt.MaMon;
                mn.MaPhieuYeuCau = dt.MaPhieuYeuCau;
                mn.SoLuong = dt.SoLuong;
                da.Add(mn);
            }
            return da;
        }
        public bool GiaiPhongBan(int MaSoBan)
        {
            try
            {
                var ba = db.BanAn.Find(MaSoBan);
                ba.MaPhieuYeuCau = null;
                db.SaveChanges();
                return true;
            }
           catch(Exception e)
            {
                return false;
            }
        }
    }
}
