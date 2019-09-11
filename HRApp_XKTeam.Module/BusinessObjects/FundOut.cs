using DevExpress.Data.Filtering;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HRApp_XKTeam.Module.BusinessObjects
{
    [Persistent("FundOut")]
    [XafDisplayName("Chi Quỹ")]
    public class FundOut: BaseObject
    {
        public FundOut(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        int _STT;
        [XafDisplayName("STT")]
        public int STT
        {
            get => _STT;
        }
        Member _nguoiChi;
        [XafDisplayName("Người Chi")]
        public Member nguoiChi
        {
            get => _nguoiChi;
            set => SetPropertyValue("nguoiChi", ref _nguoiChi, value);
        }
        DateTime? _ngayChi;// Question mark is nullable type.
        [XafDisplayName("Ngày Chi Quỹ")]
        public DateTime? ngayChi
        {
            get => _ngayChi;
            set => SetPropertyValue("ngayChi", ref _ngayChi, value);
        }
        double _soTienChi;
        [XafDisplayName("Số Tiền Chi")]
        public double soTienChi
        {
            get => _soTienChi;
            set => SetPropertyValue("soTienChi", ref _soTienChi, value);
        }
        
        bool _thanhToan;
        [XafDisplayName("Thanh Toán")]
        public bool thanhToan
        {
            get => _thanhToan;
            set => SetPropertyValue("thanhToan", ref _thanhToan, value);
        }
        Event _suKienChi;
        [XafDisplayName("Sự Kiện Chi")]
        public Event suKienchi
        {
            get => _suKienChi;
            set => SetPropertyValue("suKienChi", ref _suKienChi, value);
        }
        string _mucDich;
        [XafDisplayName("Mục Đích")]
        public string mucDich
        {
            get => _mucDich;
            set => SetPropertyValue("mucDich", ref _mucDich, value);
        }
        FileData _bangChiTiet;
        [XafDisplayName("Bảng Chi Tiết")]
        public FileData bangChiTiet
        {
            get => _bangChiTiet;
            set => SetPropertyValue("bangChiTiet", ref _bangChiTiet, value);
        }
        
    }
}
