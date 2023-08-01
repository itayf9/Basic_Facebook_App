using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private User m_LoggedInUser;

        public FormMain(User i_m_LoggedInUser)
        {
            m_LoggedInUser = i_m_LoggedInUser;
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
            labelName.Text = m_LoggedInUser.Name;
            pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureNormalURL;
            buttonLogout.Enabled = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_LoggedInUser = null;
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            labelViewTitle.Text = "Posts:";
            listBoxContent.Items.Clear();

            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (post.Message != null)
                {
                    listBoxContent.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxContent.Items.Add(post.Caption);
                }
                else
                {
                    listBoxContent.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBoxContent.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
            else
            {
                labelViewTitle.Text = (sender as Button).Text;
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            labelViewTitle.Text = "Albums:";

            listBoxContent.Items.Clear();
            listBoxContent.DisplayMember = "Name";
            foreach (Album album in m_LoggedInUser.Albums)
            {
                listBoxContent.Items.Add(album);
            }

            if (listBoxContent.Items.Count == 0)
            {
                MessageBox.Show("No Albums to retrieve :(");
            }
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            labelViewTitle.Text = "Groups:";
            listBoxContent.Items.Clear();
            listBoxContent.DisplayMember = "Name";

            try
            {
                foreach (Group group in m_LoggedInUser.Groups)
                {
                    listBoxContent.Items.Add(group.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxContent.Items.Count == 0)
            {
                MessageBox.Show("No groups to retrieve :(");
            }
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            labelViewTitle.Text = "Events:";
            listBoxContent.Items.Clear();
            listBoxContent.DisplayMember = "Name";
            foreach (Event fbEvent in m_LoggedInUser.Events)
            {
                listBoxContent.Items.Add(fbEvent.Name);
            }

            if (listBoxContent.Items.Count == 0)
            {
                MessageBox.Show("No Events to retrieve :(");
            }
        }

        private void buttonFavoriteTeams_Click(object sender, EventArgs e)
        {
            labelViewTitle.Text = "Favofrite Teams:";
            listBoxContent.Items.Clear();
            listBoxContent.DisplayMember = "Name";
            foreach (Page team in m_LoggedInUser.FavofriteTeams)
            {
                listBoxContent.Items.Add(team.Name);
            }

            if (listBoxContent.Items.Count == 0)
            {
                MessageBox.Show("No Favorite Teams to retrieve :(");
            }
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            labelViewTitle.Text = "Liked Pages:";
            listBoxContent.Items.Clear();
            listBoxContent.DisplayMember = "Name";

            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxContent.Items.Add(page.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxContent.Items.Count == 0)
            {
                MessageBox.Show("No liked pages to retrieve :(");
            }
        }
    }
}
