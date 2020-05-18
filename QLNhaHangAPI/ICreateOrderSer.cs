using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ThucTapNhom.DAO;

namespace QLNhaHangAPI
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICreateOrderSer" in both code and config file together.
    [ServiceContract]
    public interface ICreateOrderSer
    {
        [OperationContract]
        bool CreateOrder(int MaSoBan);
        [OperationContract]
        List<NhomMonAn> GetNhomMon();
        [OperationContract]
        List<MonAn> GetMonAn(string MaNhomMon);
        [OperationContract]
        PhieuYeuCau GetPYC(DateTime nyc);
        [OperationContract]
        bool ThemDatMon(DatMon dm);
        [OperationContract]
        List<DatMon> GetDatMon(int MaPYC);
        [OperationContract]
        bool GiaiPhongBan(int MaSoBan);
    }
}
