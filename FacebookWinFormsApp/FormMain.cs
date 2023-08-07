using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly List<IViewer> r_Viewers;
        private User m_LoggedInUser;

        public FormMain(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
            r_Viewers = new List<IViewer>();
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
            initProfileInformation();
            initViewers();
        }

        private void initViewers()
        {
            r_Viewers.Add(new AlbumViewer());
            r_Viewers.Add(new GroupViewer());
            r_Viewers.Add(new PostViewer());
            r_Viewers.Add(new EventViewer());
            r_Viewers.Add(new FriendViewer());
            r_Viewers.Add(new PageViewer());
            addAllViewersComponents(tabPageProfile);
        }

        private void addAllViewersComponents(TabPage tabPageProfile)
        {
            foreach (IViewer viewer in r_Viewers)
            {
                viewer.AddControls(tabPageProfile);
            }
        }

        private void initProfileInformation()
        {
            buttonLogout.Enabled = true;
            labelName.Text = m_LoggedInUser.Name;
            pictureBoxProfile.ImageLocation = m_LoggedInUser.PictureNormalURL;
            labelBirthDay.Text = m_LoggedInUser.Birthday;

            DateTime userBirthDay = DateTime.ParseExact(
                m_LoggedInUser.Birthday,
                "MM/dd/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);

            labelAge.Text = CalculateAge(userBirthDay);
            labelEmail.Text = m_LoggedInUser.Email;
            labelCity.Text = m_LoggedInUser.Location.Name;
            labelGender.Text = m_LoggedInUser.Gender.ToString();
        }

        private string CalculateAge(DateTime i_BirthDay)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - i_BirthDay.Year;

            if (i_BirthDay > today.AddYears(-age))
            {
                age--;
            }

            return age.ToString();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            m_LoggedInUser = null;
            this.Close();
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            switchShownContent("Posts");
            listBoxContent.DisplayMember = "CreatedTime";
            fetchPosts();
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            switchShownContent("Albums");
            listBoxContent.DisplayMember = "Name";
            fetchAlbums();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            switchShownContent("Groups");
            listBoxContent.DisplayMember = "Name";
            fetchGroups();
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            switchShownContent("Events");
            listBoxContent.DisplayMember = "Name";
            fetchEvents();
        }

        private void buttonFavoriteTeams_Click(object sender, EventArgs e)
        {
            switchShownContent("Favofrite Teams");
            listBoxContent.DisplayMember = "Name";
            fetchFavoriteTeams();
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            switchShownContent("Liked Pages");
            listBoxContent.DisplayMember = "Name";
            fetchLikedPages();
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            switchShownContent("Friends");
            listBoxContent.DisplayMember = "Name";

            fetchFriends();
        }

        private void fetchFriends()
        {
            try
            {
                foreach (User friend in m_LoggedInUser.Friends)
                {
                    listBoxContent.Items.Add(friend);
                }

                if (listBoxContent.Items.Count == 0)
                {
                    throw new NoDataAvailableException("Friends");
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Constants.GENERAL_ERROR_MESSAGE);
            }
        }

        private void fetchPosts()
        {
            try
            {
                foreach (Post post in m_LoggedInUser.Posts)
                {
                    listBoxContent.Items.Add(post);
                }

                if (listBoxContent.Items.Count == 0)
                {
                    throw new NoDataAvailableException("Photos");
                }
            }
            catch (NoDataAvailableException noDataAvailableException)
            {
                MessageBox.Show(noDataAvailableException.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Constants.GENERAL_ERROR_MESSAGE);
            }
        }

        private void fetchAlbums()
        {
            try
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    listBoxContent.Items.Add(album);
                }

                if (listBoxContent.Items.Count == 0)
                {
                    throw new NoDataAvailableException("Albums");
                }
            }
            catch (NoDataAvailableException noDataAvailableException)
            {
                MessageBox.Show(noDataAvailableException.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Constants.GENERAL_ERROR_MESSAGE);
            }
        }

        private void fetchGroups()
        {
            try
            {
                foreach (Group group in m_LoggedInUser.Groups)
                {
                    listBoxContent.Items.Add(group);
                }

                if (listBoxContent.Items.Count == 0)
                {
                    throw new NoDataAvailableException("Groups");
                }
            }
            catch (NoDataAvailableException noDataAvailableException)
            {
                MessageBox.Show(noDataAvailableException.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Constants.GENERAL_ERROR_MESSAGE);
            }
        }

        private void fetchEvents()
        {
            try
            {
                foreach (Event fbEvent in m_LoggedInUser.Events)
                {
                    listBoxContent.Items.Add(fbEvent.Name);
                }

                if (listBoxContent.Items.Count == 0)
                {
                    throw new NoDataAvailableException("Events");
                }
            }
            catch (NoDataAvailableException noDataAvailableException)
            {
                MessageBox.Show(noDataAvailableException.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Constants.GENERAL_ERROR_MESSAGE);
            }
        }

        private void fetchFavoriteTeams()
        {
            try
            {
                foreach (Page team in m_LoggedInUser.FavofriteTeams)
                {
                    listBoxContent.Items.Add(team);
                }

                if (listBoxContent.Items.Count == 0)
                {
                    throw new NoDataAvailableException("Favofite Teams");
                }
            }
            catch (NoDataAvailableException noDataAvailableException)
            {
                MessageBox.Show(noDataAvailableException.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Constants.GENERAL_ERROR_MESSAGE);
            }
        }

        private void fetchLikedPages()
        {
            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxContent.Items.Add(page);
                }

                if (listBoxContent.Items.Count == 0)
                {
                    throw new NoDataAvailableException("Liked Pages");
                }
            }
            catch (NoDataAvailableException noDataAvailableException)
            {
                MessageBox.Show(noDataAvailableException.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Constants.GENERAL_ERROR_MESSAGE);
            }
        }

        private void switchShownContent(string i_ContentCategoryName)
        {
            labelViewTitle.Text = string.Format("{0}:", i_ContentCategoryName);
            listBoxContent.Items.Clear();
            pictureBoxSelectedContent.Image = null;
            hideAllViewers();
        }

        private void hideAllViewers()
        {
            foreach (IViewer viewer in r_Viewers)
            {
                viewer.HideControls();
            }
        }

        private void listBoxContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = listBoxContent.SelectedItem;

            switch (selectedItem)
            {
                case Post selectedPost:
                    loadPostDetails(selectedPost);
                    break;

                case User selectedFriend:
                    loadFriendDetails(selectedFriend);
                    break;

                case Album selectedAlbum:
                    fetchAlbumPictures(selectedAlbum);
                    break;

                case Group selectedGroup:
                    loadGroupDetails(selectedGroup);

                    break;

                case Event selectedEvent:
                    loadEventDetails(selectedEvent);
                    break;

                case Page selectedPage:
                    loadPageDetails(selectedPage);
                    break;
            }
        }

        private void loadEventDetails(Event i_SelectedEvent)
        {
            pictureBoxSelectedContent.LoadAsync(i_SelectedEvent.PictureNormalURL);
            (r_Viewers[(int)eViewerIndex.EventViewerIndex] as EventViewer).loadEventDetailsToComponents(i_SelectedEvent);
        }

        private void loadPageDetails(Page i_SelectedPage)
        {
            pictureBoxSelectedContent.LoadAsync(i_SelectedPage.PictureNormalURL);
            (r_Viewers[(int)eViewerIndex.PageViewerInde] as PageViewer).loadPageDetailsToComponents(i_SelectedPage);
        }

        private void loadFriendDetails(User i_SelectedFriend)
        {
            pictureBoxSelectedContent.LoadAsync(i_SelectedFriend.PictureNormalURL);
            (r_Viewers[(int)eViewerIndex.FriendViewerIndex] as FriendViewer).loadFriendDetailsToComponents(i_SelectedFriend);
        }

        private void loadPostDetails(Post i_SelectedPost)
        {
            (r_Viewers[(int)eViewerIndex.PostViewerIndex] as PostViewer).loadPostDetailsToComponents(i_SelectedPost);
        }

        private void loadGroupDetails(Group i_SelectedGroup)
        {
            pictureBoxSelectedContent.LoadAsync(i_SelectedGroup.PictureNormalURL);
            (r_Viewers[(int)eViewerIndex.GroupViewerIndex] as GroupViewer).LoadGroupDetailsToComponents(i_SelectedGroup);
        }

        private void fetchAlbumPictures(Album i_SelectedAlbum)
        {
            pictureBoxSelectedContent.LoadAsync(i_SelectedAlbum.PictureAlbumURL);
            (r_Viewers[(int)eViewerIndex.AlbumViewerIndex] as AlbumViewer).LoadPicturesToListBox(i_SelectedAlbum);
        }
    }
}
