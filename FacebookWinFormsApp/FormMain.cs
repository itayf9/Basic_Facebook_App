using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using BasicFacebookFeatures.enums;
using BasicFacebookFeatures.exceptions;
using BasicFacebookFeatures.sessions;
using BasicFacebookFeatures.utilities;
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
        private const string k_ContentCategoryFavoriteTeams = "Favofrite Teams";
        private const string k_ContentCategoryLikedPages = "Liked Pages";
        private const string k_ContentCategoryFriends = "Friends";
        private const string k_ContentCategoryPosts = "Posts";
        internal const string k_ContentCategoryPhotos = "Photos";
        internal const string k_DisplayMemberCreatedTime = "CreatedTime";
        private const string k_DisplayMemberName = "Name";
        private const string k_DisableEditProfile = "Disable Edit";
        private const string k_EditProfile = "Edit Profile";
        private const bool k_ToEnableButtons = true;

        private readonly List<IViewer> r_ProfileViewers;
        private readonly List<IViewer> r_NostalgiaViewers;
        private readonly List<Button> r_FetchButtons;
        private readonly User r_LoggedInUser;
        private bool m_IsLoadingData;


        public FormMain(User i_LoggedInUser)
        {
            r_LoggedInUser = i_LoggedInUser;
            r_ProfileViewers = new List<IViewer>();
            r_NostalgiaViewers = new List<IViewer>();
            r_FetchButtons = new List<Button>();
            InitializeComponent();
            initializeAll();
        }

        private static void setFacebookServiceConfiguration()
        {
            FacebookService.s_CollectionLimit = 25;
        }

        private void initializeAll()
        {
            initCommentGenerator();
            setFacebookServiceConfiguration();
            initializeProfileInformation();
            initializeViewers();
            initializeFetchButtons();
            setDefaultMediaType();
        }

        private void setDefaultMediaType()
        {
            comboBoxMediaType.SelectedItem = k_ContentCategoryPhotos;
        }

        private void initCommentGenerator()
        {
            List<Button> listOfInitialAnswerButtons = new List<Button> { buttonAnswer1_1, buttonAnswer1_2 };
            initializeCommentGenerator(listOfInitialAnswerButtons);
        }

        private void initializeFetchButtons()
        {
            r_FetchButtons.Add(buttonAlbums);
            r_FetchButtons.Add(buttonEvents);
            r_FetchButtons.Add(buttonFriends);
            r_FetchButtons.Add(buttonGroups);
            r_FetchButtons.Add(buttonPosts);
            r_FetchButtons.Add(buttonFavoriteTeams);
            r_FetchButtons.Add(buttonLikedPages);
        }

        private void initializeCommentGenerator(List<Button> i_ListOfInitialAnswerButtons)
        {
            CommentGenerator commentGenerator = CommentGenerator.Instance;
            commentGenerator.TextBoxQuestions = textBoxQuestion;
            commentGenerator.TextBoxCommentOutput = textBoxCommentOutput;
            commentGenerator.ButtonStart = buttonStart;
            commentGenerator.ButtonPostComment = buttonPostComment;
            commentGenerator.LabelCommentOutputExplaination = labelCommentOutputExplainationCommentGenerator;
            commentGenerator.FlowLayoutPanelAnswerButtons = flowLayoutPanelOptionButtons;
            commentGenerator.ListOfInitialAnswerButtons = i_ListOfInitialAnswerButtons;
        }

        private void initializeViewers()
        {
            int profileViewersTopLeftX = 606;
            int profileViewersTopLeftY = 178;
            createProfileViewersInSpecificLocation(profileViewersTopLeftX, profileViewersTopLeftY);

            int nostalgiaViewerTopLeftX = 344;
            int nostalgiaViewerTopLeftY = 96;
            createNostalgiaViewersInSpecificLocation(nostalgiaViewerTopLeftX, nostalgiaViewerTopLeftY);

            addViewersComponentsToTabPage(r_ProfileViewers, tabPageProfile);
            addViewersComponentsToTabPage(r_NostalgiaViewers, tabPageNostalgia);
        }

        private void createNostalgiaViewersInSpecificLocation(int i_NostalgiaViewerTopLeftX, int i_NostalgiaViewerTopLeftY)
        {
            r_NostalgiaViewers.Add(ViewerFactory.Create(eViewerType.PhotoViewer, i_NostalgiaViewerTopLeftX, i_NostalgiaViewerTopLeftY));
            r_NostalgiaViewers.Add(ViewerFactory.Create(eViewerType.PostViewer, i_NostalgiaViewerTopLeftX, i_NostalgiaViewerTopLeftY));
        }

        private void createProfileViewersInSpecificLocation(int i_ProfileViewersTopLeftX, int i_ProfileViewersTopLeftY)
        {
            r_ProfileViewers.Add(ViewerFactory.Create(eViewerType.AlbumViewer, i_ProfileViewersTopLeftX, i_ProfileViewersTopLeftY));
            r_ProfileViewers.Add(ViewerFactory.Create(eViewerType.GroupViewer, i_ProfileViewersTopLeftX, i_ProfileViewersTopLeftY));
            r_ProfileViewers.Add(ViewerFactory.Create(eViewerType.PostViewer, i_ProfileViewersTopLeftX, i_ProfileViewersTopLeftY));
            r_ProfileViewers.Add(ViewerFactory.Create(eViewerType.EventViewer, i_ProfileViewersTopLeftX, i_ProfileViewersTopLeftY));
            r_ProfileViewers.Add(ViewerFactory.Create(eViewerType.FriendViewer, i_ProfileViewersTopLeftX, i_ProfileViewersTopLeftY));
            r_ProfileViewers.Add(ViewerFactory.Create(eViewerType.PageViewer, i_ProfileViewersTopLeftX, i_ProfileViewersTopLeftY));
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
            const bool v_ToEnable = true;
            userBindingSource.DataSource = r_LoggedInUser;
            buttonLogout.Enabled = v_ToEnable;
            DateTimeProxy userBirthDay = DateTimeProxy.GetDateTimeObjectFromDateString(r_LoggedInUser.Birthday);
            labelAge.Text = userBirthDay.ToString();
            textBoxCity.Text = r_LoggedInUser.Location.Name;
            textBoxGender.Text = r_LoggedInUser.Gender.ToString();
        }

        private void toggleOtherButtons(Button i_ButtonNotToToggle, bool i_IsEnabled)
        {
            foreach (Button button in r_FetchButtons)
            {
                if (button != i_ButtonNotToToggle)
                {
                    button.Invoke(new Action(() => button.Enabled = i_IsEnabled));
                }
            }
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
            if (!m_IsLoadingData)
            {
                setLoadingState(sender as Button, !k_ToEnableButtons);

                switchShownContent(k_ContentCategoryPosts);
                listBoxContent.DisplayMember = k_DisplayMemberCreatedTime;

                Thread thread = new Thread(() =>
                    {
                        try
                        {
                            List<Post> fetchedPosts = fetchPostsIntoList();

                            Invoke(new Action(() =>
                                {
                                    listBoxContent.Items.Clear();
                                    foreach (Post post in fetchedPosts)
                                    {
                                        listBoxContent.Items.Add(post);
                                    }
                                }));
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error fetching posts: " + ex.Message);
                        }
                        finally
                        {
                            setLoadingState(sender as Button, k_ToEnableButtons);
                        }
                    });

                thread.Start();
            }
        }

        private void setLoadingState(Button i_SenderButton, bool i_ToEnable)
        {
            toggleOtherButtons(i_SenderButton, i_ToEnable);
            setLoadingLabel(!i_ToEnable);
        }

        private void setLoadingLabel(bool i_ToEnable)
        {
            labelLoading.Invoke(new Action(() => labelLoading.Visible = i_ToEnable));
            m_IsLoadingData = i_ToEnable;
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            if (m_IsLoadingData)
            {
                return;
            }

            setLoadingState(sender as Button, !k_ToEnableButtons);


            switchShownContent(k_ContentCategoryAlbums);
            listBoxContent.DisplayMember = k_DisplayMemberName;

            Thread thread = new Thread(() =>
                {
                    try
                    {
                        List<Album> fetchedAlbums = fetchAlbumsIntoList();

                        Invoke(new Action(() =>
                            {
                                listBoxContent.Items.Clear();
                                foreach (Album album in fetchedAlbums)
                                {
                                    listBoxContent.Items.Add(album);
                                }
                            }));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching albums: " + ex.Message);
                    }
                    finally
                    {
                        setLoadingState(sender as Button, k_ToEnableButtons);

                    }
                });

            thread.Start();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            if (m_IsLoadingData)
            {
                return;
            }

            setLoadingState(sender as Button, !k_ToEnableButtons);

            switchShownContent(k_ContentCategoryGroups);
            listBoxContent.DisplayMember = k_DisplayMemberName;

            Thread thread = new Thread(() =>
                {
                    try
                    {
                        List<Group> fetchedGroups = fetchGroupsAndReturnList();

                        Invoke(new Action(() =>
                            {
                                listBoxContent.Items.Clear();
                                foreach (Group group in fetchedGroups)
                                {
                                    listBoxContent.Items.Add(group);
                                }
                            }));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching groups: " + ex.Message);
                    }
                    finally
                    {
                        setLoadingState(sender as Button, k_ToEnableButtons);

                    }
                });

            thread.Start();
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            if (m_IsLoadingData)
            {
                return; // Prevent starting a new operation while one is already running
            }

            setLoadingState(sender as Button, !k_ToEnableButtons);

            switchShownContent(k_ContentCategoryEvents);
            listBoxContent.DisplayMember = k_DisplayMemberName;

            Thread thread = new Thread(() =>
                {
                    try
                    {
                        List<Event> fetchedEvents = fetchEventsAndReturnList();

                        Invoke(new Action(() =>
                            {
                                listBoxContent.Items.Clear();
                                foreach (Event facebookEvent in fetchedEvents)
                                {
                                    listBoxContent.Items.Add(facebookEvent);
                                }
                            }));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching events: " + ex.Message);
                    }
                    finally
                    {
                        setLoadingState(sender as Button, k_ToEnableButtons);
                    }
                });

            thread.Start();
        }

        private void buttonFavoriteTeams_Click(object sender, EventArgs e)
        {
            if (m_IsLoadingData)
            {
                return; // Prevent starting a new operation while one is already running
            }

            setLoadingState(sender as Button, !k_ToEnableButtons);

            switchShownContent(k_ContentCategoryFavoriteTeams);
            listBoxContent.DisplayMember = k_DisplayMemberName;

            Thread thread = new Thread(() =>
                {
                    try
                    {
                        List<Page> fetchedFavoriteTeams = fetchFavoriteTeamsAndReturnList();

                        Invoke(new Action(() =>
                            {
                                listBoxContent.Items.Clear();
                                foreach (Page team in fetchedFavoriteTeams)
                                {
                                    listBoxContent.Items.Add(team);
                                }
                            }));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching favorite teams: " + ex.Message);
                    }
                    finally
                    {
                        setLoadingState(sender as Button, k_ToEnableButtons);
                    }
                });

            thread.Start();
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            if (m_IsLoadingData)
            {
                return; // Prevent starting a new operation while one is already running
            }

            setLoadingState(sender as Button, !k_ToEnableButtons);

            switchShownContent(k_ContentCategoryLikedPages);
            listBoxContent.DisplayMember = k_DisplayMemberName;

            Thread thread = new Thread(() =>
                {
                    try
                    {
                        List<Page> fetchedLikedPages = fetchLikedPagesAndReturnList();

                        Invoke(new Action(() =>
                            {
                                listBoxContent.Items.Clear();
                                foreach (Page page in fetchedLikedPages)
                                {
                                    listBoxContent.Items.Add(page);
                                }
                            }));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching liked pages: " + ex.Message);
                    }
                    finally
                    {
                        setLoadingState(sender as Button, k_ToEnableButtons);
                    }
                });

            thread.Start();
        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            if (m_IsLoadingData)
            {
                return; // Prevent starting a new operation while one is already running
            }

            setLoadingState(sender as Button, !k_ToEnableButtons);

            switchShownContent(k_ContentCategoryFriends);
            listBoxContent.DisplayMember = k_DisplayMemberName;

            Thread thread = new Thread(() =>
                {
                    try
                    {
                        List<User> fetchedFriends = fetchFriendsAndReturnList();

                        Invoke(new Action(() =>
                            {
                                listBoxContent.Items.Clear();
                                foreach (User friend in fetchedFriends)
                                {
                                    listBoxContent.Items.Add(friend);
                                }
                            }));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error fetching friends: " + ex.Message);
                    }
                    finally
                    {
                        setLoadingState(sender as Button, k_ToEnableButtons);
                    }
                });

            thread.Start();
        }

        private List<User> fetchFriendsAndReturnList()
        {
            List<User> fetchedFriends = new List<User>();

            try
            {
                foreach (User friend in r_LoggedInUser.Friends)
                {
                    fetchedFriends.Add(friend);
                }

                if (fetchedFriends.Count == 0)
                {
                    throw new NoDataAvailableException(k_ContentCategoryFriends);
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

            return fetchedFriends;
        }

        private List<Post> fetchPostsIntoList()
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

        private List<Group> fetchGroupsAndReturnList()
        {
            List<Group> fetchedGroups = new List<Group>();

            try
            {
                foreach (Group group in r_LoggedInUser.Groups)
                {
                    fetchedGroups.Add(group);
                }

                if (fetchedGroups.Count == 0)
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

            return fetchedGroups;
        }

        private List<Event> fetchEventsAndReturnList()
        {
            List<Event> fetchedEvents = new List<Event>();

            try
            {
                foreach (Event facebookEvent in r_LoggedInUser.Events)
                {
                    fetchedEvents.Add(facebookEvent);
                }

                if (fetchedEvents.Count == 0)
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

            return fetchedEvents;
        }

        private List<Page> fetchFavoriteTeamsAndReturnList()
        {
            List<Page> fetchedFavoriteTeams = new List<Page>();

            try
            {
                foreach (Page team in r_LoggedInUser.FavofriteTeams)
                {
                    fetchedFavoriteTeams.Add(team);
                }

                if (fetchedFavoriteTeams.Count == 0)
                {
                    throw new NoDataAvailableException(k_ContentCategoryFavoriteTeams);
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

            return fetchedFavoriteTeams;
        }

        private List<Page> fetchLikedPagesAndReturnList()
        {
            List<Page> fetchedLikedPages = new List<Page>();

            try
            {
                foreach (Page page in r_LoggedInUser.LikedPages)
                {
                    fetchedLikedPages.Add(page);
                }

                if (fetchedLikedPages.Count == 0)
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

            return fetchedLikedPages;
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
            (r_ProfileViewers[(int)eProfileViewerIndex.EventViewer] as EventViewer).LoadEventDetailsToComponents(i_SelectedEvent);
        }

        private void loadPageDetails(Page i_SelectedPage)
        {
            (r_ProfileViewers[(int)eProfileViewerIndex.PageViewer] as PageViewer).LoadPageDetailsToComponents(i_SelectedPage);
        }

        private void loadFriendDetails(User i_SelectedFriend)
        {
            (r_ProfileViewers[(int)eProfileViewerIndex.FriendViewer] as FriendViewer).LoadFriendDetailsToComponents(i_SelectedFriend);
        }

        private void loadPostDetails(Post i_SelectedPost)
        {
            (r_ProfileViewers[(int)eProfileViewerIndex.PostViewer] as PostViewer).LoadPostDetailsToComponents(i_SelectedPost);
        }

        private void loadGroupDetails(Group i_SelectedGroup)
        {
            (r_ProfileViewers[(int)eProfileViewerIndex.GroupViewer] as GroupViewer).LoadGroupDetailsToComponents(i_SelectedGroup);
        }

        private void fetchAlbumPictures(Album i_SelectedAlbum)
        {
            bool v_IsLoading = true;
            setLoadingLabel(v_IsLoading);
            (r_ProfileViewers[(int)eProfileViewerIndex.AlbumViewer] as AlbumViewer).LoadAlbumDetailsToComponents(i_SelectedAlbum);
            setLoadingLabel(!v_IsLoading);
        }

        private void buttonNostalgia_Click(object sender, EventArgs e)
        {
            const bool v_ToBeVisible = true;
            if (comboBoxMediaType.Text == k_ContentCategoryPhotos)
            {
                r_NostalgiaViewers[(int)eNostalgiaViewerIndex.PostViewer].SetVisibility(!v_ToBeVisible);
                showNostalgiaPhoto();
            }
            else if (comboBoxMediaType.Text == k_ContentCategoryPosts)
            {
                r_NostalgiaViewers[(int)eNostalgiaViewerIndex.PhotoViewer].SetVisibility(!v_ToBeVisible);
                showNostalgiaPost();
            }
        }

        private void showNostalgiaPhoto()
        {
            const bool v_ToBeVisible = true;
            r_NostalgiaViewers[(int)eNostalgiaViewerIndex.PhotoViewer].SetVisibility(v_ToBeVisible);

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

                textBoxUploadDate.Visible = v_ToBeVisible;
                textBoxUploadDate.Text = $"Created on {selectedPhoto.CreatedTime}";
                (r_NostalgiaViewers[(int)eNostalgiaViewerIndex.PhotoViewer] as PhotoViewer).LoadRandomPhotoToComponents(selectedPhoto);
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
            const bool v_ToBeVisible = true;

            r_NostalgiaViewers[(int)eNostalgiaViewerIndex.PostViewer].SetVisibility(v_ToBeVisible);

            List<Post> fetchedPosts = fetchPostsIntoList();

            Random randomGenerator = new Random();

            int indexOfRandomPost = randomGenerator.Next(fetchedPosts.Count);
            Post selectedPost = fetchedPosts[indexOfRandomPost];

            textBoxUploadDate.Visible = v_ToBeVisible;
            textBoxUploadDate.Text = $"Created on {selectedPost.CreatedTime}";

            (r_NostalgiaViewers[(int)eNostalgiaViewerIndex.PostViewer] as PostViewer).LoadPostDetailsToComponents(selectedPost);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            CommentGenerator.Instance.StartNewCommentGenerator();
        }

        private void buttonPostComment_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = r_LoggedInUser.PostStatus(textBoxCommentOutput.Text);
                MessageBox.Show(Messages.k_SuccessfulPostMessage);
            }
            catch (Exception exception)
            {
                MessageBox.Show(Messages.k_GeneralErrorMessage);
            }
        }

        private void buttonEditProfile_Click(object sender, EventArgs e)
        {
            bool v_IsEditMode = true;
            if (buttonEditProfile.Text == k_EditProfile)
            {
                setReadOnlyProfileControls(!v_IsEditMode);
                buttonEditProfile.Text = k_DisableEditProfile;
            }
            else
            {
                setReadOnlyProfileControls(v_IsEditMode);
                buttonEditProfile.Text = k_EditProfile;
            }
        }

        private void setReadOnlyProfileControls(bool i_IsEditMode)
        {
            nameTextBox.ReadOnly = i_IsEditMode;
            emailTextBox.ReadOnly = i_IsEditMode;
            birthdayTextBox.ReadOnly = i_IsEditMode;
        }
    }
}
