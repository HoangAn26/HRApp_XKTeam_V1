using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.ComponentModel;

namespace HRApp_XKTeam.Module.BusinessObjects
{
    [DefaultClassOptions]
    [Persistent("Department")]
    [DefaultProperty("tenBanNganh")]
    [XafDisplayName("Ban Ngành")]
    public class Department : BaseObject
    {
        public Department(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        
        string _maBanNganh;
        [XafDisplayName("Mã Ban Ngành")]
        public string maBanNganh
        {
            get { return _maBanNganh; }
            set { SetPropertyValue("maBanNganh", ref _maBanNganh, value); }
        }
        string _tenBanNganh;
        [XafDisplayName("Tên Ban Ngành")]
        public string tenBanNganh
        {
            get { return _tenBanNganh; }
            set { SetPropertyValue("tenBanNganh", ref _tenBanNganh, value); }
        }
        DateTime? _ngayThanhLap;
        [XafDisplayName("Ngày Thành Lập")]
        public DateTime? ngayThanhLap
        {
            get { return _ngayThanhLap; }
            set { SetPropertyValue("ngayThanhLap", ref _ngayThanhLap, value); }
        }
        int _soLuong;
        [XafDisplayName("Số Lượng")]
        public int soLuong
        {
            get { return _soLuong; }
            set { SetPropertyValue("soLuong", ref _soLuong, value); }
        }
        string _moTa;
        [XafDisplayName("Mô Tả Hoạt Động")]
        public string moTa
        {
            get { return _moTa; }
            set { SetPropertyValue("moTa", ref _moTa, value); }
        }
        Member _truongBan;
        [XafDisplayName("Trưởng Ban")]
        public Member truongBan
        {
            get { return _truongBan; }
            set { SetPropertyValue("truongBan", ref _truongBan, value); }
        }

        [Association("Department-Members")]
        [XafDisplayName("Danh Sách Thành Viên")]
        public XPCollection<Member> thanhViens
        {
            get { return GetCollection<Member>("thanhViens"); }
        }
    }
}
