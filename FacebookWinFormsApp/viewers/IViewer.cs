using System.Windows.Forms;

namespace BasicFacebookFeatures.viewers
{
    public interface IViewer
    {
        void AddControls(TabPage i_TabPageToAddControlsTo);

        void HideControls();

        void SetVisibility(bool i_IsShouldBecomeVisible);
    }
}
