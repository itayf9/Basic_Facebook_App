using System;
using System.Windows.Forms;
using BasicFacebookFeatures.viewers;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.random_strategy
{
    internal class PostRandomStrategy : IRandomStrategy
    {
        private readonly PostViewer r_PostViewer;
        private readonly TextBox r_TextBoxUploadDate;

        public PostRandomStrategy(PostViewer i_PostViewer, TextBox i_TextBoxUploadDate)
        {
            this.r_PostViewer = i_PostViewer;
            this.r_TextBoxUploadDate = i_TextBoxUploadDate;
        }

        public void ShowRandomContent(User i_User)
        {
            const bool v_ToBeVisible = true;

            r_PostViewer.SetVisibility(v_ToBeVisible);

            Random randomGenerator = new Random();

            int indexOfRandomPost = randomGenerator.Next(i_User.Posts.Count);
            Post selectedPost = i_User.Posts[indexOfRandomPost];

            r_TextBoxUploadDate.Visible = v_ToBeVisible;
            r_TextBoxUploadDate.Text = $"Created on {selectedPost.CreatedTime}";

            r_PostViewer.LoadPostDetailsToComponents(selectedPost);
        }
    }
}
