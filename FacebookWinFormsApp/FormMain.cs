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

        public FormMain(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
            labelName.Text = m_LoggedInUser.Name;
            pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureNormalURL;
            buttonLogout.Enabled = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_LoggedInUser = null;
            this.Close();
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            labelViewTitle.Text = "Posts:";
            listBoxContent.Items.Clear();

            try
            {
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
            } 
            catch (Exception exception)
            { 

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

            try
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    listBoxContent.Items.Add(album);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(Constants.GENERAL_ERROR_MESSAGE);
            }

             if (listBoxContent.Items.Count == 0)
             {
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "Albums"));
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
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "groups"));
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
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "Events"));
            }
        }

        private void buttonFavoriteTeams_Click(object sender, EventArgs e)
        {
            labelViewTitle.Text = "Favofrite Teams:";
            listBoxContent.Items.Clear();
            listBoxContent.DisplayMember = "Name";

            try
            {
                foreach (Page team in m_LoggedInUser.FavofriteTeams)
                {
                    listBoxContent.Items.Add(team.Name);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "Favorite Teams"));
            }

            if (listBoxContent.Items.Count == 0)
            {
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "Favorite Teams"));
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
                    listBoxContent.Items.Add(page);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (listBoxContent.Items.Count == 0)
            {
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "liked pages"));
            }
        }

        private void listBoxContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = listBoxContent.SelectedItem;
            if (selectedItem is Post) 
            {
                //pictureBoxSelectedContent.ImageLocation = ((selectedItem as Post).PictureURL);
            } 
            else if (selectedItem is Album)
            {
                Album selectedAlbum = selectedItem as Album;
                pictureBoxSelectedContent.LoadAsync(selectedAlbum.PictureAlbumURL);
            }
            else if (selectedItem is Group)
            {
                Group selectedGroup = selectedItem as Group;
                pictureBoxSelectedContent.LoadAsync(selectedGroup.PictureNormalURL);
            }
            else if (selectedItem is Event)
            {
                Event selectedEvent = selectedItem as Event;
                pictureBoxSelectedContent.LoadAsync(selectedEvent.PictureNormalURL);

            }
            else if (listBoxContent.SelectedItem is Page)
            {
                Page selectedPage = selectedItem as Page;
                pictureBoxSelectedContent.LoadAsync(selectedPage.PictureNormalURL);
            }
        }
    }
}
