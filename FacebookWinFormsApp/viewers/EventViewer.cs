using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class EventViewer : PictureAndNameObjectViewer
    {
        private readonly Label r_LabelEventStartTimeTitle;
        private readonly Label r_LabelEventStartTimeValue;
        private readonly Label r_LabelEventEndTimeTitle;
        private readonly Label r_LabelEventEndTimeValue;
        private readonly Label r_LabelAttendingCountTitle;
        private readonly Label r_LabelAttendingCountValue;
        private readonly Label r_LabelLocationTitle;
        private readonly Label r_LabelLocationValue;
        private readonly TextBox r_TextBoxDescription;

        public EventViewer(int i_TopLeftX, int i_TopLeftY)
            : base(i_TopLeftX, i_TopLeftY)
        {
            r_LabelEventStartTimeTitle = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX, i_TopLeftY + 130),
                Size = new System.Drawing.Size(98, 26),
                TabIndex = 70,
                Text = "Start Time:",
            };

            r_LabelEventStartTimeValue = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX + 84, i_TopLeftY + 130),
                Size = new System.Drawing.Size(96, 26),
                TabIndex = 71,
                Text = "0/0/0001",
            };

            r_LabelEventEndTimeTitle = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX, i_TopLeftY + 165),
                Size = new System.Drawing.Size(90, 26),
                TabIndex = 72,
                Text = "End Time:",
            };

            r_LabelEventEndTimeValue = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX + 84, i_TopLeftY + 165),
                Size = new System.Drawing.Size(60, 26),
                TabIndex = 73,
                Text = "0/0/0001",
            };

            r_LabelAttendingCountTitle = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX + 200, i_TopLeftY + 130),
                Size = new System.Drawing.Size(90, 26),
                TabIndex = 74,
                Text = "Attending Count:",
            };

            r_LabelAttendingCountValue = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX + 284, i_TopLeftY + 130),
                Size = new System.Drawing.Size(60, 26),
                TabIndex = 75,
                Text = "10",
            };

            r_LabelLocationTitle = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX + 200, i_TopLeftY + 165),
                Size = new System.Drawing.Size(90, 26),
                TabIndex = 76,
                Text = "Location:",
            };

            r_LabelLocationValue = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(i_TopLeftX + 284, i_TopLeftY + 165),
                Size = new System.Drawing.Size(60, 26),
                TabIndex = 77,
                Text = "Tel Aviv",
            };

            r_TextBoxDescription = new TextBox
            {
                Location = new System.Drawing.Point(i_TopLeftX, i_TopLeftY + 165),
                Multiline = true,
                Size = new System.Drawing.Size(521, 135),
                TabIndex = 78,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
            };

            SetVisibility(false);
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
            r_LabelEventStartTimeTitle.Visible = i_IsShouldBecomeVisible;
            r_LabelEventStartTimeValue.Visible = i_IsShouldBecomeVisible;
            r_LabelEventEndTimeTitle.Visible = i_IsShouldBecomeVisible;
            r_LabelEventEndTimeValue.Visible = i_IsShouldBecomeVisible;
            r_LabelAttendingCountTitle.Visible = i_IsShouldBecomeVisible;
            r_LabelAttendingCountValue.Visible = i_IsShouldBecomeVisible;
            r_LabelLocationTitle.Visible = i_IsShouldBecomeVisible;
            r_LabelLocationValue.Visible = i_IsShouldBecomeVisible;
            r_TextBoxDescription.Visible = i_IsShouldBecomeVisible;
            base.SetVisibility(i_IsShouldBecomeVisible);
        }

        public void LoadEventDetailsToComponents(Event i_SelectedEvent)
        {
            LoadMainPictureAndNameToComponents(i_SelectedEvent.PictureNormalURL, i_SelectedEvent.Name);
        }
    }
}
