using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class GroupViewer : PictureAndNameObjectViewer
    {
        private readonly Label r_LabelDescription;
        private readonly TextBox r_TextBoxDescription;

        public GroupViewer()
            : base()
        {
            r_LabelDescription = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(615, 300),
                Name = "labelDesctiption",
                Size = new System.Drawing.Size(193, 26),
                TabIndex = 70,
                Text = "Group Description:",
            };

            r_TextBoxDescription = new TextBox
            {
                Location = new System.Drawing.Point(615, 335),
                Multiline = true,
                Name = "textBoxDescription",
                Size = new System.Drawing.Size(508, 152),
                TabIndex = 71,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
            };

            setVisible(false);
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
            setVisible(false);

            base.HideControls();
        }

        internal void LoadGroupDetailsToComponents(Group i_SelectedGroup)
        {
            LoadMainPictureAndNameToComponents(i_SelectedGroup.PictureNormalURL, i_SelectedGroup.Name);
            r_TextBoxDescription.Text = i_SelectedGroup.Description;
            setVisible(true);
        }

        internal void setVisible(bool i_Visible)
        {
           r_LabelDescription.Visible = i_Visible;
           r_TextBoxDescription.Visible = i_Visible;

           base.SetVisible(i_Visible);
        }
    }
}
