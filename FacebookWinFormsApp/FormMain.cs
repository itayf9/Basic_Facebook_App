using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BasicFacebookFeatures.viewers;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private const string k_ContentCategoryAlbums = "Albums";
        private const string k_ContentCategoryGroups = "Groups";
        private const string k_ContentCategoryEvents = "Events";
        private const string k_ContentCategoryFaviriteTeams = "Favofrite Teams";
        private const string k_ContentCategoryLikedPages = "Liked Pages";
        private const string k_ContentCategoryFriends = "Friends";
        private const string k_ContentCategoryPosts = "Posts";
        private const string k_ContentCategoryPhotos = "Photos";

        private readonly List<IViewer> r_ProfileViewers;
        private readonly List<IViewer> r_NostalgiaViewers;
        private readonly User r_LoggedInUser;
        private readonly CommentGenerator r_CommentGenerator;

        public FormMain(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            r_ProfileViewers = new List<IViewer>();
            r_NostalgiaViewers = new List<IViewer>();
            InitializeComponent();
            List<Button> listOfInitialAnswerButtons = new List<Button> { buttonAnswer1_1, buttonAnswer1_2 };
            r_CommentGenerator = new CommentGenerator(textBoxQuestion, textBoxCommentOutput, buttonStart, buttonPostComment, labelCommentOutputExplainationCommentGenerator, flowLayoutPanelOptionButtons, listOfInitialAnswerButtons);
            FacebookService.s_CollectionLimit = 25;
            initializeProfileInformation();
            initializeViewers();
        }

        private void initializeViewers()
        {
            int profileViewersTopLeftX = 606;
            int profileViewersTopLeftY = 178;
            r_ProfileViewers.Add(new AlbumViewer(profileViewersTopLeftX, profileViewersTopLeftY));
            r_ProfileViewers.Add(new GroupViewer(profileViewersTopLeftX, profileViewersTopLeftY));
            r_ProfileViewers.Add(new PostViewer(profileViewersTopLeftX, profileViewersTopLeftY));
            r_ProfileViewers.Add(new EventViewer(profileViewersTopLeftX, profileViewersTopLeftY));
            r_ProfileViewers.Add(new FriendViewer(profileViewersTopLeftX, profileViewersTopLeftY));
            r_ProfileViewers.Add(new PageViewer(profileViewersTopLeftX, profileViewersTopLeftY));

            int nostalgiaViewerTopLeftX = 344;
            int nostalgiaViewerTopLeftY = 96;
            r_NostalgiaViewers.Add(new PhotoViewer(nostalgiaViewerTopLeftX, nostalgiaViewerTopLeftY));
            r_NostalgiaViewers.Add(new PostViewer(nostalgiaViewerTopLeftX, nostalgiaViewerTopLeftY));

            addViewersComponentsToTabPage(r_ProfileViewers, tabPageProfile);
            addViewersComponentsToTabPage(r_NostalgiaViewers, tabPageNostalgia);
        }

        private void addViewersComponentsToTabPage(List<IViewer> i_Viewers, TabPage i_TabPage)
        {
            foreach (IViewer viewer in i_Viewers)
            {
                viewer.AddControls(i_TabPage);
            }
        }

        private void initializeProfileInformation()
        {
            buttonLogout.Enabled = true;
            labelName.Text = r_LoggedInUser.Name;
            pictureBoxProfile.ImageLocation = r_LoggedInUser.PictureNormalURL;
            labelBirthDay.Text = r_LoggedInUser.Birthday;

            DateTime userBirthDay = DateTime.ParseExact(
                r_LoggedInUser.Birthday,
                "MM/dd/yyyy",
                System.Globalization.CultureInfo.InvariantCulture);

            labelAge.Text = Utillity.CalculateAge(userBirthDay);
            labelEmail.Text = r_LoggedInUser.Email;
            labelCity.Text = r_LoggedInUser.Location.Name;
            labelGender.Text = r_LoggedInUser.Gender.ToString();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();

            if (Session.IsSessionExists())
            {
                Session.DeleteSession();
            }

            this.Close();
        }

        private void buttonPosts_Click(object sender, EventArgs e)
        {
            switchShownContent(k_ContentCategoryPosts);
            listBoxContent.DisplayMember = "CreatedTime";
            List<Post> fetchedPosts = fetchPostsToList();
            foreach (Post post in fetchedPosts)
            {
                listBoxContent.Items.Add(post);
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            switchShownContent(k_ContentCategoryAlbums);
            listBoxContent.DisplayMember = "Name";
            foreach (Album album in fetchAlbumsIntoList())
            {
                listBoxContent.Items.Add(album);
            }
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            switchShownContent(k_ContentCategoryGroups);
            listBoxContent.DisplayMember = "Name";
            fetchGroups();
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            switchShownContent(k_ContentCategoryEvents);
            listBoxContent.DisplayMember = "Name";
            fetchEvents();
        }

        private void buttonFavoriteTeams_Click(object sender, EventArgs e)
        {
            switchShownContent(k_ContentCategoryFaviriteTeams);
            listBoxContent.DisplayMember = "Name";
            fetchFavoriteTeams();
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            switchShownContent(k_ContentCategoryLikedPages);
            listBoxContent.DisplayMember = "Name";
            fetchLikedPages();
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            switchShownContent(k_ContentCategoryFriends);
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
                    throw new NoDataAvailableException(k_ContentCategoryFriends);
                }
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.k_GeneralErrorMessage);
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
                    throw new NoDataAvailableException(k_ContentCategoryPosts);
                }
            }
            catch (NoDataAvailableException noDataAvailableException)
            {
                MessageBox.Show(noDataAvailableException.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.k_GeneralErrorMessage);
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
                    throw new NoDataAvailableException(k_ContentCategoryAlbums);
                }
            }
            catch (NoDataAvailableException noDataAvailableException)
            {
                MessageBox.Show(noDataAvailableException.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.k_GeneralErrorMessage);
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
                    throw new NoDataAvailableException(k_ContentCategoryGroups);
                }
            }
            catch (NoDataAvailableException noDataAvailableException)
            {
                MessageBox.Show(noDataAvailableException.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.k_GeneralErrorMessage);
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
                    throw new NoDataAvailableException(k_ContentCategoryEvents);
                }
            }
            catch (NoDataAvailableException noDataAvailableException)
            {
                MessageBox.Show(noDataAvailableException.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.k_GeneralErrorMessage);
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
                    throw new NoDataAvailableException(k_ContentCategoryFaviriteTeams);
                }
            }
            catch (NoDataAvailableException noDataAvailableException)
            {
                MessageBox.Show(noDataAvailableException.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.k_GeneralErrorMessage);
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
                    throw new NoDataAvailableException(k_ContentCategoryLikedPages);
                }
            }
            catch (NoDataAvailableException noDataAvailableException)
            {
                MessageBox.Show(noDataAvailableException.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.k_GeneralErrorMessage);
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
            (r_ProfileViewers[(int)eProfileViewerIndex.EventViewerIndex] as EventViewer).loadEventDetailsToComponents(i_SelectedEvent);
        }

        private void loadPageDetails(Page i_SelectedPage)
        {
            (r_ProfileViewers[(int)eProfileViewerIndex.PageViewerIndex] as PageViewer).loadPageDetailsToComponents(i_SelectedPage);
        }

        private void loadFriendDetails(User i_SelectedFriend)
        {
            (r_ProfileViewers[(int)eProfileViewerIndex.FriendViewerIndex] as FriendViewer).loadFriendDetailsToComponents(i_SelectedFriend);
        }

        private void loadPostDetails(Post i_SelectedPost)
        {
            (r_ProfileViewers[(int)eProfileViewerIndex.PostViewerIndex] as PostViewer).loadPostDetailsToComponents(i_SelectedPost);
        }

        private void loadGroupDetails(Group i_SelectedGroup)
        {
            (r_ProfileViewers[(int)eProfileViewerIndex.GroupViewerIndex] as GroupViewer).LoadGroupDetailsToComponents(i_SelectedGroup);
        }

        private void fetchAlbumPictures(Album i_SelectedAlbum)
        {
            (r_ProfileViewers[(int)eProfileViewerIndex.AlbumViewerIndex] as AlbumViewer).LoadAlbumDetailsToComponents(i_SelectedAlbum);
        }

        private void buttonNostalgia_Click(object sender, EventArgs e)
        {
            if (comboBoxMediaType.Text == k_ContentCategoryPhotos)
            {
                r_NostalgiaViewers[(int)eNostalgiaViewerIndex.PostViewerIndex].SetVisibility(false);
                showNostalgiaPhoto();
            }
            else if (comboBoxMediaType.Text == k_ContentCategoryPosts)
            {
                r_NostalgiaViewers[(int)eNostalgiaViewerIndex.PhotoViewerIndex].SetVisibility(false);
                showNostalgiaPost();
            }
        }

        private void showNostalgiaPhoto()
        {
            r_NostalgiaViewers[(int)eNostalgiaViewerIndex.PhotoViewerIndex].SetVisibility(true);

            Random randomGenerator = new Random();

            List<Album> fetchedAlbums = fetchAlbumsIntoList();
            List<Album> filteredNonEmptyAlbums = new List<Album>();
            foreach (Album album in fetchedAlbums)
            {
                if (album.Count != 0)
                {
                    filteredNonEmptyAlbums.Add(album);
                }
            }

            try
            {
                if (filteredNonEmptyAlbums.Count == 0)
                {
                    throw new NoDataAvailableException(k_ContentCategoryAlbums);
                }

                int indexOfRandomAlbum = randomGenerator.Next(filteredNonEmptyAlbums.Count);
                Album selectedAlbum = filteredNonEmptyAlbums[indexOfRandomAlbum];

                FacebookObjectCollection<Photo> listOfPhotosFromSelectedAlbum = selectedAlbum.Photos;

                if (listOfPhotosFromSelectedAlbum.Count == 0)
                {
                    throw new NoDataAvailableException(k_ContentCategoryPhotos);
                }

                int indexOfSelectedPhoto = randomGenerator.Next(listOfPhotosFromSelectedAlbum.Count);
                Photo selectedPhoto = listOfPhotosFromSelectedAlbum[indexOfSelectedPhoto];

                textBoxUploadDate.Visible = true;
                textBoxUploadDate.Text = $"Created on {selectedPhoto.CreatedTime}";
                (r_NostalgiaViewers[(int)eNostalgiaViewerIndex.PhotoViewerIndex] as PhotoViewer).loadRandomPhotoToComponents(selectedPhoto);
            }
            catch (NoDataAvailableException noDataAvailableException)
            {
                MessageBox.Show(noDataAvailableException.Message);
            }
            catch (Exception)
            {
                MessageBox.Show(Messages.k_GeneralErrorMessage);
            }
        }

        private void showNostalgiaPost()
        {
            r_NostalgiaViewers[(int)eNostalgiaViewerIndex.PostViewerIndex].SetVisibility(true);

            List<Post> fetchedPosts = fetchPostsToList();

            Random randomGenerator = new Random();

            int indexOfRandomPost = randomGenerator.Next(fetchedPosts.Count);
            Post selectedPost = fetchedPosts[indexOfRandomPost];

            textBoxUploadDate.Visible = true;
            textBoxUploadDate.Text = $"Created on {selectedPost.CreatedTime}";

            (r_NostalgiaViewers[(int)eNostalgiaViewerIndex.PostViewerIndex] as PostViewer).loadPostDetailsToComponents(selectedPost);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            r_CommentGenerator.startNewCommentGenerator();
        }

        private void buttonPostComment_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = r_LoggedInUser.PostStatus(textBoxCommentOutput.Text);
                MessageBox.Show("Successfully Posted!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(Messages.k_GeneralErrorMessage);
            }
        }
    }
}
