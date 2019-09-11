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
    [Persistent("FundIn")]
    [XafDisplayName("Thu Quỹ")]
    public class FundIn: BaseObject
    {
        public FundIn(Session session) : base(session) { }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
        double _soTienThu;
        int _STT;
        [XafDisplayName("STT")]
        public int STT
        {
            get => _STT;
        }
        Member _nguoiThu;
        [XafDisplayName("Người Thu")]
        public Member nguoiThu
        {
            get => _nguoiThu;
            set => SetPropertyValue("nguoiThu", ref _nguoiThu, value);
        }
        DateTime? _ngayThu;// Question mark is nullable type.
        [XafDisplayName("Ngày Thu Quỹ")]
        public DateTime? ngayThu
        {
            get => _ngayThu;
            set => SetPropertyValue("ngayThu", ref _ngayThu, value);
        }
        [XafDisplayName("Số Tiền Thu")]
        public double soTienThu
        {
            get => _soTienThu;
            set => SetPropertyValue("soTienThu", ref _soTienThu, value);
        }
        
        
        Event _suKienThu;
        [XafDisplayName("Sự Kiện Thu")]
        public Event suKienThu
        {
            get => _suKienThu;
            set => SetPropertyValue("suKienThu", ref _suKienThu, value);
        }
        string _mucDich;
        [XafDisplayName("Mục Đích")]
        public string mucDich
        {
            get => _mucDich;
            set => SetPropertyValue("mucDich", ref _mucDich, value);
        }
        FileData _tepLienQuan;
        [XafDisplayName("Tệp Liên Quan")]
        [FileTypeFilter("Bảng tính", 1, "*.xlsx")]
        [FileTypeFilter("Văn bản", 2, "*.txt", "*.doc", "*.docx")]
        [FileTypeFilter("Tất cả", 3, "*.*")]
        public FileData tepLienQuan
        {
            get => _tepLienQuan;
            set => SetPropertyValue("teLienQuan", ref _tepLienQuan, value);
        }
    }
}
