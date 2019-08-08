using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRApp_XKTeam.Module.BusinessObjects
{
    [Persistent("Meeting")]
    [XafDisplayName(@"Cuộc Họp")]
    [XafDefaultProperty(nameof(Ten))]
    [DefaultClassOptions]
    public class Meeting : BaseObject
    {
        public Meeting(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        
        string _ten;
        [XafDisplayName("Tên Cuộc Họp")]
        public string Ten
        {
            get => _ten;
            set => SetPropertyValue("Ten", ref _ten, value);
        }

        DateTime? _thoiGian;
        [ModelDefault("DisplayFormat", "{0:dd/MM/yyyy}")]
        [ModelDefault("EditMask", "dd/MM/yyyy")]
        [XafDisplayName("Thời Gian")]
        public DateTime? thoiGian
        {
            get => _thoiGian;
            set => SetPropertyValue("thoiGian", ref _thoiGian, value);
        }

        string _diaDiem;
        [XafDisplayName("Địa Điểm")]
        public string diaDiem
        {
            get => _diaDiem;
            set => SetPropertyValue("diaDiem", ref _diaDiem, value);
        }

        Member _chuTri;
        [XafDisplayName("Người Chủ Trì Cuộc Họp")]
        public Member chuTri
        {
            get => _chuTri;
            set => SetPropertyValue("chuTri", ref _chuTri, value);
        }

        Member _thuKi;
        [XafDisplayName("Thư Kí")]
        public Member thuKi
        {
            get => _thuKi;
            set => SetPropertyValue("thuKi", ref _thuKi, value);
        }
        int _soLuong;
        [XafDisplayName("Số Lượng")]
        public int soLuong
        {
            get => _soLuong;
            set => _soLuong = khongThamGia.Count(); //count from khongThamGia
        }

        [Association("Meeting-Members")]
        [XafDisplayName("Danh Sách Tham Gia")]
        public XPCollection<Member> thamGia
        {
            get => GetCollection<Member>(nameof(thamGia));
        }

        [XafDisplayName("Danh Sách Không Tham Gia")]
        public List<Member> khongThamGia
        {
            get => Session.Query<Member>().Where(thanhvien => !thanhvien.Hops.Contains<Meeting>(this)).ToList();
        }

    }
}
