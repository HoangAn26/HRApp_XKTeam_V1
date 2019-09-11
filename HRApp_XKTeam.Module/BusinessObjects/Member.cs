using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
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
    [Persistent("Member")]
    [DefaultProperty("TenThanhVien")]
    [XafDisplayName("Thành Viên")]
    public class Member : BaseObject
    {
        public Member(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        protected override void OnSaving()
        {
            base.OnSaving();
        }

        int _STT;
        [XafDisplayName("STT")]
        public int STT
        {
            get => _STT;
            set => SetPropertyValue("STT", ref _STT, value);
        }

        string _tenThanhVien;
        [Appearance("TenThanhVien", Context = "Any", FontColor = "blue", TargetItems = "TenThanhVien", FontStyle = System.Drawing.FontStyle.Underline)]
        [XafDisplayName("Họ Và Tên")]
        public string TenThanhVien
        {
            get { return _tenThanhVien; }
            set { SetPropertyValue("TenThanhVien", ref _tenThanhVien, value); }
        }
        string _maThanhVien;
        [XafDisplayName("Mã Thành Viên")]
        public string maThanhVien
        {
            get => _maThanhVien;
            set => SetPropertyValue("maThanhVien", ref _maThanhVien, value);
            //get { return fMaThanhVien; }
            //set { SetPropertyValue("maThanhVien", ref fMaThanhVien, value); }
        }
        DateTime? _ngaySinh;
        [XafDisplayName("Ngày Sinh")]
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        public DateTime? ngaySinh
        {
            get { return _ngaySinh; }
            set { SetPropertyValue("ngaySinh", ref _ngaySinh, value); }
        }
        public enum GioiTinh
        {
            Nam = 0,
            [XafDisplayName("Nữ")]
            Nu = 1
        };
        GioiTinh _gioiTinh;
        [XafDisplayName("Giới Tính")]
        public GioiTinh gioiTinh
        {
            get { return _gioiTinh; }
            set { SetPropertyValue("gioiTinh", ref _gioiTinh, value); }
        }

        string _MSSV;
        [XafDisplayName("MSSV")]
        public string MSSV
        {
            get { return _MSSV; }
            set { SetPropertyValue("MSSV", ref _MSSV, value); }
        }
        string _sucKhoe;
        [XafDisplayName("Sức Khỏe")]
        public string sucKhoe
        {
            get { return _sucKhoe; }
            set { SetPropertyValue("sucKhoe", ref _sucKhoe, value); }
        }
        string _soDienThoai;
        [XafDisplayName("SĐT")]
        public string soDienThoai
        {
            get { return _soDienThoai; }
            set { SetPropertyValue("soDienThoai", ref _soDienThoai, value); }
        }

        HyperLinkEdit _email;
        [XafDisplayName("Email")]
        public HyperLinkEdit email
        {
            get { return _email; }
            set { SetPropertyValue("email", ref _email, value); }
        }


        HyperLinkEdit _facebook;
        [XafDisplayName("Facebook")]
        public HyperLinkEdit facebook
        {
            get => _facebook;
            set => SetPropertyValue("facebook", ref _facebook, value);
        }
        
        Department _banNganh;
        [XafDisplayName("Ban Hoạt Động")]
        [Association("Department-Members")]
        public Department banNganh
        {
            get { return _banNganh; }
            set { SetPropertyValue("banNganh", ref _banNganh, value); }
        }

        [Association(@"Events-Members")]
        [XafDisplayName("Sự Kiện Tham Gia")]
        public XPCollection<Event> SuKiens
        {
            get { return GetCollection<Event>("SuKiens"); }
        }

        Image _hinhAnh;
        [VisibleInListView(false)]
        [XafDisplayName("Hình Ảnh")]
        [ImageEditor(ListViewImageEditorMode = ImageEditorMode.PictureEdit, DetailViewImageEditorMode = ImageEditorMode.PictureEdit)]
        [ValueConverter(typeof(DevExpress.Xpo.Metadata.ImageValueConverter))]
        public Image hinhAnh
        {
            get { return _hinhAnh; }
            set { SetPropertyValue("hinhAnh", ref _hinhAnh, value); }
        }
        [Association("Meeting-Members")]
        [XafDisplayName("Các Cuộc Họp")]
        public XPCollection<Meeting> Hops
        {
            get => GetCollection<Meeting>(nameof(Hops));
        }

        int _diemThiDua;
        [XafDisplayName("Điểm Thi Đua")]
        public int diemThiDua
        {
            get => _diemThiDua;
            set => SetPropertyValue("diemThiDua", ref _diemThiDua, value);
        }
        //bool _dangKiThamGiaSuKien;
        //[XafDisplayName("Đăng Kí")]
        //public bool dangKiThamGiaSuKien
        //{ get => _dangKiThamGiaSuKien; set => SetPropertyValue("dangKiThamGiaSuKien", ref _dangKiThamGiaSuKien, value); }
    }
}
