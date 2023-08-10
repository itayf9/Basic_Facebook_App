using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class EventViewer : PictureAndNameObjectViewer, IViewer
    {

        public EventViewer() : base()
        {
        }

        public override void AddControls(TabPage i_TabPage)
        {
            base.AddControls(i_TabPage);
        }

        public override void HideControls()
        {
            base.HideControls();
        }

        public override void SetVisible(bool i_Visible)
        {
            base.SetVisible(i_Visible);
        }

        internal void loadEventDetailsToComponents(Event i_SelectedEvent)
        {
            LoadMainPictureAndNameToComponents(i_SelectedEvent.PictureNormalURL, i_SelectedEvent.Name);
        }
    }
}
