using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal abstract class PictureAndNameObjectViewer : IViewer
    {
        private readonly PictureBox r_PictureBoxMainPicture;
        private readonly Label r_LabelName;
        private readonly Panel r_PanelPictureAndNameArea;

        protected PictureAndNameObjectViewer()
        {
            r_PictureBoxMainPicture = new PictureBox
            {
                Location = new System.Drawing.Point(1014, 178),
                Name = "pictureBoxSelectedContent",
                Size = new System.Drawing.Size(110, 110),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 61,
                TabStop = false,
            };

            r_LabelName = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(128, 12),
                Name = "labelFullName",
                Size = new System.Drawing.Size(173, 26),
                TabIndex = 70,
            };

            r_PanelPictureAndNameArea = new Panel
            {
                BackColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(606, 178),
                Name = "panelPictureAndNameBackground",
                Size = new System.Drawing.Size(395, 137),
                TabIndex = 71,
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
            SetVisible(false);
        }

        public virtual void SetVisible(bool i_Visible)
        {
            r_PictureBoxMainPicture.Visible = i_Visible;
            r_LabelName.Visible = i_Visible;
            r_PanelPictureAndNameArea.Visible = i_Visible;
        }
    }
}
