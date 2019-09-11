namespace HRAp_XKTeam.Module.Web {
    partial class HRAp_XKTeamAspNetModule {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            // 
            // HRAp_XKTeamAspNetModule
            // 
            this.RequiredModuleTypes.Add(typeof(HRApp_XKTeam.Module.HRApp_XKTeamModule));
            this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Chart.Web.ChartAspNetModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Notifications.Web.NotificationsAspNetModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.PivotChart.Web.PivotChartAspNetModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Scheduler.Web.SchedulerAspNetModule));
			this.RequiredModuleTypes.Add(typeof(DevExpress.ExpressApp.Validation.Web.ValidationAspNetModule));
        }

        #endregion
    }
}