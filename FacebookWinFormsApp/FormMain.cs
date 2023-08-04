using System;
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
            initProfileInformation();
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
                    throw new NoDataAvailableException();
                }

            }
            catch (Exception)
            {
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "friends"));
            }
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

                if (listBoxContent.Items.Count == 0)
                {
                    throw new NoDataAvailableException();
                }
                else
                {
                    labelViewTitle.Text = (sender as Button).Text;
                }

            } 
            catch (Exception)
            {
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "Posts"));
            }
        }

        private void buttonAlbums_Click(object sender, EventArgs e)
        {
            switchShownContent("Albums");
            listBoxContent.DisplayMember = "Name";

            try
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    listBoxContent.Items.Add(album);
                }
            }
            catch (Exception)
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
            switchShownContent("Groups");
            listBoxContent.DisplayMember = "Name";

            try
            {
                foreach (Group group in m_LoggedInUser.Groups)
                {
                    listBoxContent.Items.Add(group);
                }

                if (listBoxContent.Items.Count == 0)
                {
                    throw new NoDataAvailableException();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "groups"));
            }
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {
            switchShownContent("Events");
            listBoxContent.DisplayMember = "Name";

            try
            {
                foreach (Event fbEvent in m_LoggedInUser.Events)
                {
                    listBoxContent.Items.Add(fbEvent.Name);
                }

                if (listBoxContent.Items.Count == 0)
                {
                    throw new NoDataAvailableException();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "Events"));
            }
        }

        private void buttonFavoriteTeams_Click(object sender, EventArgs e)
        {
            switchShownContent("Favofrite Teams");
            listBoxContent.DisplayMember = "Name";

            try
            {
                foreach (Page team in m_LoggedInUser.FavofriteTeams)
                {
                    listBoxContent.Items.Add(team.Name);
                }

                if (listBoxContent.Items.Count == 0)
                {
                    throw new NoDataAvailableException();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "Favorite Teams"));
            }
        }

        private void buttonLikedPages_Click(object sender, EventArgs e)
        {
            switchShownContent("Liked Pages");
            listBoxContent.DisplayMember = "Name";

            try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxContent.Items.Add(page);
                }

                if (listBoxContent.Items.Count == 0)
                {
                    throw new NoDataAvailableException();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "liked pages"));
            }
        }

        private void switchShownContent(string i_ContentCategoryName)
        {
            labelViewTitle.Text = string.Format("{0}:", i_ContentCategoryName);
            listBoxContent.Items.Clear();
            pictureBoxSelectedContent.Image = null;
        }

        private void listBoxContent_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selectedItem = listBoxContent.SelectedItem;
            if (selectedItem is Post) 
            {
                //pictureBoxSelectedContent.ImageLocation = ((selectedItem as Post).PictureURL);
            } 
            else if (selectedItem is User)
            {
                User selectedFriend = selectedItem as User;
                pictureBoxSelectedContent.LoadAsync(selectedFriend.PictureNormalURL);
            }
            else if (selectedItem is Album)
            {
                Album selectedAlbum = selectedItem as Album;
                fetchAlbumPictures(selectedAlbum);

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

        private void fetchAlbumPictures(Album selectedAlbum)
        {
            pictureBoxSelectedContent.LoadAsync(selectedAlbum.PictureAlbumURL);
            ListBox listBoxPictures = new ListBox();
            listBoxPictures.FormattingEnabled = true;
            listBoxPictures.ItemHeight = 26;
            //listBoxPictures.Location = new System.Drawing.Point(243, 178);
            listBoxPictures.Name = "listBoxPictures";
            listBoxPictures.Size = new System.Drawing.Size(346, 368);
            listBoxPictures.TabIndex = 59;
            listBoxPictures.SelectedIndexChanged += new System.EventHandler(listBoxPictures_SelectedIndexChanged);

            /*try
            {
                foreach (Page page in m_LoggedInUser.LikedPages)
                {
                    listBoxContent.Items.Add(page);
                }

                if (listBoxContent.Items.Count == 0)
                {
                    throw new NoDataAvailableException();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "liked pages"));
            }*/

            flowLayoutPanelDescription.Controls.Add(listBoxPictures);

            

        }

        private void buttonFriends_Click(object sender, EventArgs e)
        {
            switchShownContent("Friends");
            listBoxContent.DisplayMember = "Name";

            fetchFriends();
        }

        private void listBoxPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*PictureBox pictureBoxSelectedPictureFromAlbum = new PictureBox();
            pictureBoxSelectedContent.LoadAsync(((sender as ListBox).SelectedItem as ).);

            flowLayoutPanelDescription.Controls.Add(pictureBoxSelectedPictureFromAlbum);*/

        }
    }
}
