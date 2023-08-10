using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FriendViewer : PictureAndNameObjectViewer, IViewer
    {
        private readonly Label r_LabelBirthdayTitle;
        private readonly Label r_LabelBirthdayValue;
        private readonly Label r_LabelGenderTitle;
        private readonly Label r_LabelGenderValue;

        public FriendViewer() : base()
        {
            r_LabelBirthdayTitle = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(595, 178),
                Name = "labelBirthdayTitle",
                Size = new System.Drawing.Size(98, 26),
                TabIndex = 70,
                Text = "Birthday:",
            };

            r_LabelBirthdayValue = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(699, 178),
                Name = "labelBirthdayValue",
                Size = new System.Drawing.Size(96, 26),
                TabIndex = 71,
                Text = "0/0/0001",
            };

            r_LabelGenderTitle = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(595, 214),
                Name = "labelGenderTitle",
                Size = new System.Drawing.Size(90, 26),
                TabIndex = 72,
                Text = "Gender:",
            };

            r_LabelGenderValue = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(699, 214),
                Name = "labelGenderValue",
                Size = new System.Drawing.Size(60, 26),
                TabIndex = 73,
                Text = "male",
            };

            setVisible(false);
        }

        public void loadFriendDetailsToComponents(User i_Friend)
        {
            LoadMainPictureAndNameToComponents(i_Friend.PictureNormalURL, i_Friend.Name);

            r_LabelBirthdayValue.Text = i_Friend.Birthday.ToString();
            r_LabelGenderValue.Text = i_Friend.Gender.ToString();

            setVisible(true);
        }

        public override void AddControls(TabPage i_TabPage)
        {
            i_TabPage.Controls.Add(r_LabelGenderValue);
            i_TabPage.Controls.Add(r_LabelGenderTitle);
            i_TabPage.Controls.Add(r_LabelBirthdayValue);
            i_TabPage.Controls.Add(r_LabelBirthdayTitle);

            base.AddControls(i_TabPage);
        }

        public override void HideControls()
        {
            setVisible(false);

            base.HideControls();
        }

        internal void setVisible(bool i_Visible)
        {
            r_LabelGenderValue.Visible = i_Visible;
            r_LabelGenderTitle.Visible = i_Visible;
            r_LabelBirthdayValue.Visible = i_Visible;
            r_LabelBirthdayTitle.Visible = i_Visible;

            base.SetVisible(i_Visible);
        }
    }
}
