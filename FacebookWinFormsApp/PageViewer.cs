using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PageViewer : PictureAndNameObjectViewer, IViewer
    {
        private readonly Label r_LabelDescription;
        private readonly TextBox r_TextBoxDescription;

        public PageViewer() : base()
        {
            r_LabelDescription = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(595, 178),
                Name = "labelDescription",
                Size = new System.Drawing.Size(127, 26),
                TabIndex = 70,
                Text = "Description:",
            };

            r_TextBoxDescription = new TextBox
            {
                Location = new System.Drawing.Point(600, 211),
                Multiline = true,
                Name = "textBoxDescription",
                Size = new System.Drawing.Size(521, 135),
                TabIndex = 71,
                ReadOnly = true,
            };

            setVisible(false);
        }

        public void loadPageDetailsToComponents(Page i_Page)
        {
            LoadMainPictureAndNameToComponents(i_Page.PictureNormalURL, i_Page.Name);

            if (i_Page.Description != null)
            {
                r_TextBoxDescription.Text = i_Page.Description;
            }
            else
            {
                r_TextBoxDescription.Text = Constants.NO_DESCRIPTION;
            }

            setVisible(true);
        }

        public override void AddControls(TabPage i_TabPage)
        {
            i_TabPage.Controls.Add(r_LabelDescription);
            i_TabPage.Controls.Add(r_TextBoxDescription);

            base.AddControls(i_TabPage);
        }

        public override void HideControls()
        {
            setVisible(false);

            base.HideControls();
        }

        internal void setVisible(bool i_Visible)
        {
            r_LabelDescription.Visible = i_Visible;
            r_TextBoxDescription.Visible = i_Visible;

            base.SetVisible(i_Visible);
        }
    }
}
