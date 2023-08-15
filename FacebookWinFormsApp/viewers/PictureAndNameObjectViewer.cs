using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal abstract class PictureAndNameObjectViewer : IViewer
    {
        private readonly PictureBox r_PictureBoxMainPicture;
        private readonly Label r_LabelName;
        private readonly Panel r_PanelPictureAndNameArea;

        protected PictureAndNameObjectViewer(int i_TopLeftX, int i_TopLeftY)
        {
            r_PictureBoxMainPicture = new PictureBox
            {
                Location = new System.Drawing.Point(i_TopLeftX + 9, i_TopLeftY + 9),
                Name = "pictureBoxSelectedContent",
                Size = new System.Drawing.Size(110, 110),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 61,
                TabStop = false,
            };

            r_LabelName = new Label
            {
                AutoSize = false,
                Location = new System.Drawing.Point(i_TopLeftX + 120, i_TopLeftY + 9),
                Name = "labelFullName",
                Size = new System.Drawing.Size(320, 110),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 20, System.Drawing.FontStyle.Bold),
                TabIndex = 70,
                BackColor = System.Drawing.Color.White,
            };

            r_PanelPictureAndNameArea = new Panel
            {
                BackColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(i_TopLeftX, i_TopLeftY),
                Name = "panelPictureAndNameBackground",
                Size = new System.Drawing.Size(500, 128),
                TabIndex = 71,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
            };
            r_PanelPictureAndNameArea.Controls.Add(r_PictureBoxMainPicture);
            r_PanelPictureAndNameArea.Controls.Add(r_LabelName);

        }

        public PictureBox PictureBoxMainPicture
        {
            get { return r_PictureBoxMainPicture; }
        }

        public Label LabelName
        {
            get { return r_LabelName; }
        }

        public Panel PanelPictureAndNameArea
        {
            get { return r_PanelPictureAndNameArea; }
        }

        protected void LoadMainPictureAndNameToComponents(string i_PictureURL, string i_Name)
        {
            r_PictureBoxMainPicture.LoadAsync(i_PictureURL);
            LabelName.Text = i_Name;
        }

        public virtual void AddControls(TabPage i_TabPage)
        {
            i_TabPage.Controls.Add(r_PictureBoxMainPicture);
            i_TabPage.Controls.Add(r_LabelName);
            i_TabPage.Controls.Add(r_PanelPictureAndNameArea);
        }

        public virtual void HideControls()
        {
            SetVisibility(false);
        }

        public virtual void SetVisibility(bool i_IsShouldBecomeVisible)
        {
            r_PictureBoxMainPicture.Visible = i_IsShouldBecomeVisible;
            r_LabelName.Visible = i_IsShouldBecomeVisible;
            r_PanelPictureAndNameArea.Visible = i_IsShouldBecomeVisible;
        }
    }
}
