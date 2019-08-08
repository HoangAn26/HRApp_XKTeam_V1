using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo.Metadata;
using HRApp_XKTeam.Module.BusinessObjects;

namespace HRApp_XKTeam.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class RegisterEvent : ViewController
    {
        public RegisterEvent()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            Event suKien = (Event)View.CurrentObject;//Tro vào object hiện tại đang view lên

            XPClassInfo nguoiDungInfo = suKien.Session.GetClassInfo(typeof(NguoiDung));
            NguoiDung nguoiDung = (NguoiDung)suKien.Session.GetObjectByKey(nguoiDungInfo, SecuritySystem.CurrentUserId);

            NguoiDung nguoiDung1 = suKien.Session.GetObjectByKey<NguoiDung>(SecuritySystem.CurrentUserId);

            //suKien.ThanhViens.Add(nguoiDung1.thanhVien);
            AttendedEvent thanhVienThamSuKien = ObjectSpace.CreateObject<AttendedEvent>();

            bool checkThamGia = false;

            thanhVienThamSuKien.thanhVien = nguoiDung1.thanhVien;
            //thanhVienThamSuKien.thanhVien = nguoiDung1.thanhVien;
            foreach (AttendedEvent thanh in suKien.attendedEvent)
            {
                if (thanh.thanhVien == nguoiDung1.thanhVien)
                    checkThamGia = true;
            }
            if (checkThamGia == false)
                suKien.attendedEvent.Add(thanhVienThamSuKien);
        }
    }
}
