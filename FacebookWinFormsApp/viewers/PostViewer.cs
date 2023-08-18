using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PostViewer : IViewer
    {
        private readonly Label r_LabelCaption;
        private readonly TextBox r_TextBoxCaption;
        private readonly PictureBox r_PictureBoxPost;

        public PostViewer(int i_topLeftX, int i_topLeftY)
        {
            r_LabelCaption = new Label
            {
                AutoSize = true,
                Location = new Point(i_topLeftX, i_topLeftY),
                Name = "labelCaption",
                Size = new Size(93, 26),
                TabIndex = 70,
                Text = "Caption:",
            };

            r_TextBoxCaption = new TextBox
            {
                Location = new Point(i_topLeftX, i_topLeftY + 35),
                Multiline = true,
                Name = "textBoxCaption",
                Size = new Size(520, 88),
                TabIndex = 71,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
            };

            r_PictureBoxPost = new PictureBox
            {
                Location = new Point(i_topLeftX, i_topLeftY + 70 ),
                Name = "pictureBoxPost",
                Size = new Size(520, 243),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 72,
                TabStop = false,
            };

            SetVisibility(false);
        }

        public void LoadPostDetailsToComponents(Post i_Post)
        {
            r_PictureBoxPost.Image = null;

            r_TextBoxCaption.Text = i_Post.Caption;

            if (i_Post.PictureURL != null)
            {
                r_PictureBoxPost.LoadAsync(i_Post.PictureURL);
            }

            SetVisibility(true);
        }

        public void AddControls(TabPage i_TabPage)
        {
            i_TabPage.Controls.Add(r_LabelCaption);
            i_TabPage.Controls.Add(r_TextBoxCaption);
            i_TabPage.Controls.Add(r_PictureBoxPost);
        }

        public void HideControls()
        {
            SetVisibility(false);
        }

        public void SetVisibility(bool i_IsShouldBecomeVisible)
        {
            r_LabelCaption.Visible = i_IsShouldBecomeVisible;
            r_TextBoxCaption.Visible = i_IsShouldBecomeVisible;
            r_PictureBoxPost.Visible = i_IsShouldBecomeVisible;
        }
    }
}
