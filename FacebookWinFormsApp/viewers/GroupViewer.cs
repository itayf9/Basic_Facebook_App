using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.viewers
{
    internal class GroupViewer : PictureAndNameObjectViewer
    {
        private readonly Label r_LabelDescription;
        private readonly TextBox r_TextBoxDescription;

        public GroupViewer(int i_TopLeftX, int i_TopLeftY)
            : base(i_TopLeftX, i_TopLeftY)
        {
            r_LabelDescription = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX, i_TopLeftY + 130),
                Name = "labelDesctiption",
                Size = new System.Drawing.Size(193, 26),
                TabIndex = 70,
                Text = "Group Description:",
            };

            r_TextBoxDescription = new TextBox
            {
                Location = new System.Drawing.Point(i_TopLeftX, i_TopLeftY + 165),
                Multiline = true,
                Name = "textBoxDescription",
                Size = new System.Drawing.Size(508, 152),
                TabIndex = 71,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
            };

            SetVisibility(false);
        }

        public Label LabelDecription
        {
            get { return r_LabelDescription; }
        }

        public TextBox TextBoxDescription
        {
            get { return r_TextBoxDescription; }
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

        public void LoadGroupDetailsToComponents(Group i_SelectedGroup)
        {
            LoadMainPictureAndNameToComponents(i_SelectedGroup.PictureNormalURL, i_SelectedGroup.Name);
            r_TextBoxDescription.Text = i_SelectedGroup.Description;
            SetVisibility(true);
        }

        public override void SetVisibility(bool i_IsShouldBecomeVisible)
        {
           r_LabelDescription.Visible = i_IsShouldBecomeVisible;
           r_TextBoxDescription.Visible = i_IsShouldBecomeVisible;

           base.SetVisibility(i_IsShouldBecomeVisible);
        }
    }
}
