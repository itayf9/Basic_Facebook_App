using System.Windows.Forms;
using BasicFacebookFeatures.utilities;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.viewers
{
    internal class PageViewer : PictureAndNameObjectViewer
    {
        private readonly Label r_LabelDescription;
        private readonly TextBox r_TextBoxDescription;

        public PageViewer(int i_TopLeftX, int i_TopLeftY)
            : base(i_TopLeftX, i_TopLeftY)
        {
            r_LabelDescription = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX, i_TopLeftY + 130),
                Name = "labelDescription",
                Size = new System.Drawing.Size(127, 26),
                TabIndex = 70,
                Text = "Description:",
            };

            r_TextBoxDescription = new TextBox
            {
                Location = new System.Drawing.Point(i_TopLeftX, i_TopLeftY + 165),
                Multiline = true,
                Name = "textBoxDescription",
                Size = new System.Drawing.Size(521, 135),
                TabIndex = 71,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
            };

            SetVisibility(false);
        }

        public void LoadPageDetailsToComponents(Page i_Page)
        {
            LoadMainPictureAndNameToComponents(i_Page.PictureNormalURL, i_Page.Name);

            if (i_Page.Description != null)
            {
                r_TextBoxDescription.Text = i_Page.Description;
            }
            else
            {
                r_TextBoxDescription.Text = Messages.k_NodescriptionMessage;
            }

            SetVisibility(true);
        }

        public override void AddControls(TabPage i_TabPage)
        {
            i_TabPage.Controls.Add(r_LabelDescription);
            i_TabPage.Controls.Add(r_TextBoxDescription);

            base.AddControls(i_TabPage);
        }

        public override void HideControls()
        {
            SetVisibility(false);

            base.HideControls();
        }

        public override void SetVisibility(bool i_IsShouldBecomeVisible)
        {
            r_LabelDescription.Visible = i_IsShouldBecomeVisible;
            r_TextBoxDescription.Visible = i_IsShouldBecomeVisible;

            base.SetVisibility(i_IsShouldBecomeVisible);
        }
    }
}
