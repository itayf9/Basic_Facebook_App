using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class EventViewer : PictureAndNameObjectViewer
    {

        public EventViewer(int i_TopLeftX, int i_TopLeftY)
            : base(i_TopLeftX, i_TopLeftY)
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

        public override void SetVisibility(bool i_IsShouldBecomeVisible)
        {
            base.SetVisibility(i_IsShouldBecomeVisible);
        }

        internal void loadEventDetailsToComponents(Event i_SelectedEvent)
        {
            LoadMainPictureAndNameToComponents(i_SelectedEvent.PictureNormalURL, i_SelectedEvent.Name);
        }
    }
}
