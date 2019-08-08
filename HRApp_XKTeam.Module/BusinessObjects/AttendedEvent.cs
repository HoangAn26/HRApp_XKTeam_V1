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
    [Persistent("AttendedEvent")]
    [XafDisplayName("Danh Sách Tham Gia Sự Kiện")]
    public class AttendedEvent: BaseObject
    {
        public AttendedEvent(Session session) : base(session) { }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        bool _diemDanh;
        [XafDisplayName("Điểm Danh")]
        [Appearance("", Enabled = true, Criteria = "IsAdmin = true", Context = "Any")]//only admin can access this property
        public bool diemDanh { get => _diemDanh; set => SetPropertyValue("diemDanh", ref _diemDanh, value); }

        Member _thanhVien;
        [XafDisplayName("Thành Viên Đã Tham Gia")]
        public Member thanhVien { get => _thanhVien; set => SetPropertyValue("thanhVien", ref _thanhVien, value); }

        Event _suKien;
        [Association("Event-AttendedEvents")]
        [XafDisplayName("Sự Kiện")]
        public Event suKien { get => _suKien; set => SetPropertyValue("suKien", ref _suKien, value); }
    }
}
