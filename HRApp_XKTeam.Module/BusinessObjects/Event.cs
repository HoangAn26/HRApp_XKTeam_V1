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
    [DefaultClassOptions]
    [Persistent("Event")]
    [DefaultProperty("tenSuKien")]
    [XafDisplayName("Sự Kiện")]
    public class Event : BaseObject
    {
        public Event(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        
        string _maSuKien;
        [XafDisplayName("Mã Sự Kiện")]
        public string maSuKien
        {
            get { return _maSuKien; }
            set { SetPropertyValue("maSuKien", ref _maSuKien, value); }
        }
        string _tenSuKien;
        [XafDisplayName("Tên Sự Kiện")]
        public string tenSuKien
        {
            get { return _tenSuKien; }
            set { SetPropertyValue("tenSuKien", ref _tenSuKien, value); }
        }
        Member _nguoiNamChinh;
        [XafDisplayName("Người Nắm Chính")]
        public Member nguoiNamChinh
        { get => _nguoiNamChinh; set => SetPropertyValue("nguoiNamChinh", ref _nguoiNamChinh, value); }

        DateTime? _thoiGian;
        [XafDisplayName("Thời Gian")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        public DateTime? thoiGian
        { get => _thoiGian; set => SetPropertyValue("thoiGian", ref _thoiGian, value);}

        string _diaDiem;
        [XafDisplayName("Địa Điểm")]
        public string diaDiem
        { get => _diaDiem; set => SetPropertyValue("diaDiem", ref _diaDiem, value); }

        int _soLuongDuKien;
        [XafDisplayName("Số Lượng Dự Kiến")]
        public int soLuongDuKien
        {
            get { return _soLuongDuKien; }
            set { SetPropertyValue("soLuongDuKien", ref _soLuongDuKien, value); }
        }

        int _soLuong;
        [XafDisplayName("Số Lượng Tham Gia")]
        public int soLuong
        {
            get => _soLuong; 
            set => SetPropertyValue("soLuong", ref _soLuong, value) ; //get from attendedEvent
        }

        [Association(@"Events-Members")]
        [XafDisplayName("Thành Viên Đăng Kí Tham Gia")]
        [VisibleInDetailView(false)]
        public XPCollection<Member> ThanhViens
        {
            get { return GetCollection<Member>("ThanhViens"); }
        }

        [Association("Event-AttendedEvents")]
        [XafDisplayName("Danh Sách Đăng Kí")]
        public XPCollection<AttendedEvent> attendedEvent
        {
            get { return GetCollection<AttendedEvent>("attendedEvent"); }
        }
        //Thay vì dùng file model để thêm listview, ta có thể query như bên dưới.
        [XafDisplayName("Danh Sách Đã Tham Gia")]
        public List<AttendedEvent> attendedEventY
        {
            get => Session.Query<AttendedEvent>().Where(thanhvien => thanhvien.diemDanh == true).ToList();
        }

    }
}
