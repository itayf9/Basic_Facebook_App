using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private readonly List<IViewer> r_ProfileViewers;
        private readonly List<IViewer> r_NostalgiaViewers;
        private readonly User r_LoggedInUser;

        public FormMain(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            r_ProfileViewers = new List<IViewer>();
            r_NostalgiaViewers = new List<IViewer>();
            InitializeComponent();
            FacebookService.s_CollectionLimit = 25;
            initProfileInformation();
            initViewers();
        }

        private void initViewers()
        {
            r_ProfileViewers.Add(new AlbumViewer());
            r_ProfileViewers.Add(new GroupViewer());
            r_ProfileViewers.Add(new PostViewer(596, 178));
            r_ProfileViewers.Add(new EventViewer());
            r_ProfileViewers.Add(new FriendViewer());
            r_ProfileViewers.Add(new PageViewer());
            r_NostalgiaViewers.Add(new PostViewer(344, 96));
            addAllViewersComponentsToTabPage(r_ProfileViewers, tabPageProfile);
            addAllViewersComponentsToTabPage(r_NostalgiaViewers, tabPageFeatures);
        }

        private void addAllViewersComponentsToTabPage(List<IViewer> i_Viewers, TabPage i_TabPage)
        {
            foreach (IViewer viewer in i_Viewers)
            {
                viewer.AddControls(i_TabPage);
            }
        }

        private void initProfileInformation()
        {
            buttonLogout.Enabled = true;
            labelName.Text = r_LoggedInUser.Name;
            pictureBoxProfile.ImageLocation = r_LoggedInUser.PictureNormalURL;
            labelBirthDay.Text = r_LoggedInUser.Birthday;

            DateTime userBirthDay = DateTime.ParseExact(
                r_LoggedInUser.Birthday,
                "MM/dd/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);

            labelAge.Text = CalculateAge(userBirthDay);
            labelEmail.Text = r_LoggedInUser.Email;
            labelCity.Text = r_LoggedInUser.Location.Name;
            labelGender.Text = r_LoggedInUser.Gender.ToString();
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

            if (Session.IsSessionExist())
            {
                Session.DeleteSession();
            }

            this.Close();
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            switchShownContent("Posts");
            listBoxContent.DisplayMember = "CreatedTime";
            List<Post> fetchedPosts = fetchPostsToList();
            foreach (Post post in fetchedPosts)
            {
                listBoxContent.Items.Add(post);
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            switchShownContent("Albums");
            listBoxContent.DisplayMember = "Name";
            foreach (Album album in fetchAlbumsIntoList())
            {
                listBoxContent.Items.Add(album);
            }
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
                foreach (User friend in r_LoggedInUser.Friends)
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

        private List<Post> fetchPostsToList()
        {
            List<Post> listOfFetchedPosts = new List<Post>();

            try
            {
                foreach (Post post in r_LoggedInUser.Posts)
                {
                    listOfFetchedPosts.Add(post);
                }

                if (listOfFetchedPosts.Count == 0)
                {
                    throw new NoDataAvailableException("Posts");
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

            return listOfFetchedPosts;
        }

        private List<Album> fetchAlbumsIntoList()
        {
            List<Album> listOfFetchedAlbums = new List<Album>();

            try
            {
                foreach (Album album in r_LoggedInUser.Albums)
                {
                    listOfFetchedAlbums.Add(album);
                }

                if (listOfFetchedAlbums.Count == 0)
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

            return listOfFetchedAlbums;
        }

        private void fetchGroups()
        {
            try
            {
                foreach (Group group in r_LoggedInUser.Groups)
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
                foreach (Event fbEvent in r_LoggedInUser.Events)
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
                foreach (Page team in r_LoggedInUser.FavofriteTeams)
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
                foreach (Page page in r_LoggedInUser.LikedPages)
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
            hideAllViewers();
        }

        private void hideAllViewers()
        {
            foreach (IViewer viewer in r_ProfileViewers)
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
            (r_ProfileViewers[(int)eViewerIndex.EventViewerIndex] as EventViewer).loadEventDetailsToComponents(i_SelectedEvent);
        }

        private void loadPageDetails(Page i_SelectedPage)
        {
            (r_ProfileViewers[(int)eViewerIndex.PageViewerIndex] as PageViewer).loadPageDetailsToComponents(i_SelectedPage);
        }

        private void loadFriendDetails(User i_SelectedFriend)
        {
            (r_ProfileViewers[(int)eViewerIndex.FriendViewerIndex] as FriendViewer).loadFriendDetailsToComponents(i_SelectedFriend);
        }

        private void loadPostDetails(Post i_SelectedPost)
        {
            (r_ProfileViewers[(int)eViewerIndex.PostViewerIndex] as PostViewer).loadPostDetailsToComponents(i_SelectedPost);
        }

        private void loadGroupDetails(Group i_SelectedGroup)
        {
            (r_ProfileViewers[(int)eViewerIndex.GroupViewerIndex] as GroupViewer).LoadGroupDetailsToComponents(i_SelectedGroup);
        }

        private void fetchAlbumPictures(Album i_SelectedAlbum)
        {
            (r_ProfileViewers[(int)eViewerIndex.AlbumViewerIndex] as AlbumViewer).LoadAlbumDetailsToComponents(i_SelectedAlbum);
        }

        private void buttonNostalgia_Click(object sender, EventArgs e)
        {

            if (comboBoxMediaType.Text == "Photo")
            {
                r_NostalgiaViewers[0].HideControls();
                showNostalgiaPhoto();
            }
            else if (comboBoxMediaType.Text == "Post")
            {
                pictureBoxRandomPhoto.Visible = false;
                showNostalgiaPost();
            }
        }

        private void loadRandomPhotoToComponents(Photo i_SelectedPhoto)
        {
            pictureBoxRandomPhoto.Image = i_SelectedPhoto.ImageNormal;
            textBoxUploadDate.Text = i_SelectedPhoto.CreatedTime.ToString();
        }

        private void showNostalgiaPhoto()
        {
            pictureBoxRandomPhoto.Visible = true;

            Random randomGenerator = new Random();

            List<Album> fetchedAlbums = fetchAlbumsIntoList();
            List<bool> listOfIndexesOfAlbums = new List<bool>(fetchedAlbums.Count) { false };
            int indexOfRandomAlbum = randomGenerator.Next(fetchedAlbums.Count);
            Album selectedAlbum = fetchedAlbums[indexOfRandomAlbum];

            try
            {
                FacebookObjectCollection<Photo> listOfPhotosFromSelectedAlbum = selectedAlbum.Photos;

                if (listOfPhotosFromSelectedAlbum.Count == 0)
                {
                    throw new NoDataAvailableException("Photos");
                }

                int indexOfSelectedPhoto = randomGenerator.Next(listOfPhotosFromSelectedAlbum.Count);
                Photo selectedPhoto = listOfPhotosFromSelectedAlbum[indexOfSelectedPhoto];

                loadRandomPhotoToComponents(selectedPhoto);
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

        private void showNostalgiaPost()
        {

            List<Post> fetchedPosts = fetchPostsToList();

            Random randomGenerator = new Random();

            int indexOfRandomPost = randomGenerator.Next(fetchedPosts.Count);
            Post selectedPost = fetchedPosts[indexOfRandomPost];

            textBoxUploadDate.Text = selectedPost.CreatedTime.ToString();

            (r_NostalgiaViewers[0] as PostViewer).loadPostDetailsToComponents(selectedPost);
        }
    }
}
