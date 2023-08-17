using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class FriendViewer : PictureAndNameObjectViewer
    {
        private readonly Label r_LabelBirthdayTitle;
        private readonly Label r_LabelBirthdayValue;
        private readonly Label r_LabelGenderTitle;
        private readonly Label r_LabelGenderValue;
        private readonly Label r_LabelHomeTownTitle;
        private readonly Label r_LabelHomeTownValue;

        public FriendViewer(int i_TopLeftX, int i_TopLeftY)
            : base(i_TopLeftX, i_TopLeftY)
        {
            r_LabelBirthdayTitle = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX, i_TopLeftY + 130),
                Name = "labelBirthdayTitle",
                Size = new System.Drawing.Size(98, 26),
                TabIndex = 70,
                Text = "Birthday:",
            };

            r_LabelBirthdayValue = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX + 84, i_TopLeftY + 130),
                Name = "labelBirthdayValue",
                Size = new System.Drawing.Size(96, 26),
                TabIndex = 71,
                Text = "0/0/0001",
            };

            r_LabelGenderTitle = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX, i_TopLeftY + 165),
                Name = "labelGenderTitle",
                Size = new System.Drawing.Size(90, 26),
                TabIndex = 72,
                Text = "Gender:",
            };

            r_LabelGenderValue = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX + 84, i_TopLeftY + 165),
                Name = "labelGenderValue",
                Size = new System.Drawing.Size(60, 26),
                TabIndex = 73,
                Text = "male",
            };

            r_LabelHomeTownTitle = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX, i_TopLeftY + 200),
                Name = "labelHomeTownTitle",
                Size = new System.Drawing.Size(90, 26),
                TabIndex = 74,
                Text = "City:",
            };

            r_LabelHomeTownValue = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX + 84, i_TopLeftY + 200),
                Name = "labelHomeTownValue",
                Size = new System.Drawing.Size(60, 26),
                TabIndex = 75,
                Text = "Tel Aviv",
            };

            SetVisibility(false);
        }

        public void loadFriendDetailsToComponents(User i_Friend)
        {
            LoadMainPictureAndNameToComponents(i_Friend.PictureNormalURL, i_Friend.Name);

            r_LabelBirthdayValue.Text = i_Friend.Birthday;
            r_LabelGenderValue.Text = i_Friend.Gender.ToString();
            r_LabelHomeTownValue.Text = i_Friend.Location.Name;

            SetVisibility(true);
        }

        public override void AddControls(TabPage i_TabPage)
        {
            i_TabPage.Controls.Add(r_LabelGenderValue);
            i_TabPage.Controls.Add(r_LabelGenderTitle);
            i_TabPage.Controls.Add(r_LabelBirthdayValue);
            i_TabPage.Controls.Add(r_LabelBirthdayTitle);
            i_TabPage.Controls.Add(r_LabelHomeTownValue);
            i_TabPage.Controls.Add(r_LabelHomeTownTitle);

            base.AddControls(i_TabPage);
        }

        public override void HideControls()
        {
            SetVisibility(false);

            base.HideControls();
        }

        public override void SetVisibility(bool i_IsShouldBecomeVisible)
        {
            r_LabelGenderValue.Visible = i_IsShouldBecomeVisible;
            r_LabelGenderTitle.Visible = i_IsShouldBecomeVisible;
            r_LabelBirthdayValue.Visible = i_IsShouldBecomeVisible;
            r_LabelBirthdayTitle.Visible = i_IsShouldBecomeVisible;
            r_LabelHomeTownValue.Visible = i_IsShouldBecomeVisible;
            r_LabelHomeTownTitle.Visible = i_IsShouldBecomeVisible;

            base.SetVisibility(i_IsShouldBecomeVisible);
        }
    }
}
