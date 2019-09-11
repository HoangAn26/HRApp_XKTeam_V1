using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using DevExpress.ExpressApp.Win.Utils;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Svg;
using DevExpress.XtraSplashScreen;

namespace HRApp_XKTeam.Win {
    public partial class XafSplashScreen : SplashScreen {
        protected override void DrawContent(GraphicsCache graphicsCache, Skin skin) {
            Rectangle bounds = ClientRectangle;
            bounds.Width--; bounds.Height--;
            graphicsCache.Graphics.DrawRectangle(graphicsCache.GetPen(Color.FromArgb(255, 87, 87, 87), 1), bounds);
        }
        protected void UpdateLabelsPosition() {
            labelApplicationName.CalcBestSize();
            int newLeft = (Width - labelApplicationName.Width) / 2;
            labelApplicationName.Location = new Point(newLeft, labelApplicationName.Top);
            labelSubtitle.CalcBestSize();
            newLeft = (Width - labelSubtitle.Width) / 2;
            labelSubtitle.Location = new Point(newLeft, labelSubtitle.Top);
        }
        public XafSplashScreen() {
            InitializeComponent();
            this.labelCopyright.Text = 
                DateTime.Now.Date.ToString();
            UpdateLabelsPosition();
        }
        
        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg) {
            base.ProcessCommand(cmd, arg);
            if((UpdateSplashCommand)cmd == UpdateSplashCommand.Description) {
                labelStatus.Text = (string)arg;
            }
        }
        
        #endregion

        public enum SplashScreenCommand {
        }

        private void pcApplicationName_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void labelApplicationName_Click(object sender, EventArgs e)
        {

        }

        private void labelCopyright_Click(object sender, EventArgs e)
        {

        }

        private void XafSplashScreen_Load(object sender, EventArgs e)
        {

        }

        private void peLogo_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBarControl_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}