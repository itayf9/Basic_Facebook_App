using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class PostViewer : IViewer
    {
        private readonly Label r_LabelCaption;
        private readonly TextBox r_TextBoxCaption;
        private readonly PictureBox r_PictureBoxPost;

        public PostViewer()
        {
            r_LabelCaption = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(596, 178),
                Name = "labelCaption",
                Size = new System.Drawing.Size(93, 26),
                TabIndex = 70,
                Text = "Caption:",
            };

            r_TextBoxCaption = new TextBox
            {
                Location = new System.Drawing.Point(601, 208),
                Multiline = true,
                Name = "textBoxCaption",
                Size = new System.Drawing.Size(520, 88),
                TabIndex = 71,
                ReadOnly = true,
            };

            r_PictureBoxPost = new PictureBox
            {
                Location = new System.Drawing.Point(601, 304),
                Name = "pictureBoxPost",
                Size = new System.Drawing.Size(520, 243),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                TabIndex = 72,
                TabStop = false,
            };

            setVisible(false);
        }

        public void loadPostDetailsToComponents(Post i_Post)
        {
            r_PictureBoxPost.Image = null;

            r_TextBoxCaption.Text = i_Post.Caption;

            if (i_Post.PictureURL != null)
            {
                r_PictureBoxPost.LoadAsync(i_Post.PictureURL);
            }

            setVisible(true);
        }

        public void AddControls(TabPage i_TabPage)
        {
            i_TabPage.Controls.Add(r_LabelCaption);
            i_TabPage.Controls.Add(r_TextBoxCaption);
            i_TabPage.Controls.Add(r_PictureBoxPost);
        }

        public void HideControls()
        {
            setVisible(false);
        }

        internal void setVisible(bool i_Visible)
        {
            r_LabelCaption.Visible = i_Visible;
            r_TextBoxCaption.Visible = i_Visible;
            r_PictureBoxPost.Visible = i_Visible;
        }
    }
}
