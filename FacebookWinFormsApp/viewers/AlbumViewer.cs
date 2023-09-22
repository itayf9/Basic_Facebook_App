using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BasicFacebookFeatures.albumfilter;
using BasicFacebookFeatures.exceptions;
using BasicFacebookFeatures.utilities;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.viewers
{
    internal class AlbumViewer : PictureAndNameObjectViewer
    {
        private readonly ListBox r_ListBoxPictures;
        private readonly PictureBox r_PictureBoxSelectedPicture;
        private readonly Button r_ButtonTenYearsFilter;
        private AlbumFilterHandler m_AlbumFilterHandler;

        public AlbumViewer(int i_TopLeftX, int i_TopLeftY)
            : base(i_TopLeftX, i_TopLeftY)
        {
            r_ListBoxPictures = new ListBox
            {
                FormattingEnabled = true,
                ItemHeight = 26,
                Location = new Point(i_TopLeftX, i_TopLeftY + 130),
                Name = "listBoxPictures",
                Size = new Size(160, 200),
                TabIndex = 72,
                HorizontalScrollbar = true,
            };
            r_ListBoxPictures.SelectedIndexChanged += new EventHandler(listBoxPictures_SelectedIndexChanged);
            r_ListBoxPictures.DisplayMember = FormMain.k_DisplayMemberCreatedTime;

            r_PictureBoxSelectedPicture = new PictureBox
            {
                Location = new Point(i_TopLeftX + 195, i_TopLeftY + 130),
                Name = "pictureBoxSelectedPicture",
                Size = new Size(349, 301),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 73,
                TabStop = false,
            };

            r_ButtonTenYearsFilter = new Button
            {
                Size = new Size(170, 25),
                Text = "Filter Photos - 10 Years Ago",
                Location = new Point(i_TopLeftX, i_TopLeftY + 330),
                TabIndex = 74,
                Font = new Font("Arial", 9, FontStyle.Regular),
            };
            r_ButtonTenYearsFilter.Click += new EventHandler(ButtonTenYearsFilter_Click);

            SetVisibility(false);
        }

        private void ButtonTenYearsFilter_Click(object sender, EventArgs e)
        {
            DateTime tenYearsAgo = DateTime.Now.AddYears(-10);
            LoadPicturesToListBox(m_AlbumFilterHandler, photo => photo.CreatedTime > tenYearsAgo);
            r_ButtonTenYearsFilter.Enabled = false;
        }

        public void LoadAlbumDetailsToComponents(AlbumFilterHandler i_SelectedAlbum)
        {
            m_AlbumFilterHandler = i_SelectedAlbum;
            r_ButtonTenYearsFilter.Enabled = true;
            LoadMainPictureAndNameToComponents(i_SelectedAlbum.PictureAlbumURL, i_SelectedAlbum.AlbumName);
            LoadPicturesToListBox(m_AlbumFilterHandler, photo => true);
        }

        public void LoadPicturesToListBox(AlbumFilterHandler i_SelectedAlbum, Func<Photo, bool> i_Test)
        {
            r_ListBoxPictures.Items.Clear();
            r_PictureBoxSelectedPicture.Image = null;

            try
            {
                IEnumerable<Photo> filteredPhotos = i_SelectedAlbum.GetFilteredPhotos(i_Test);
                foreach (Photo photo in filteredPhotos)
                {
                    r_ListBoxPictures.Items.Add(photo);
                }

                if (r_ListBoxPictures.Items.Count == 0)
                {
                    throw new NoDataAvailableException(FormMain.k_ContentCategoryPhotos);
                }

                SetVisibility(true);
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

        public override void AddControls(TabPage i_TabPage)
        {
            i_TabPage.Controls.Add(r_ListBoxPictures);
            i_TabPage.Controls.Add(r_PictureBoxSelectedPicture);
            i_TabPage.Controls.Add(r_ButtonTenYearsFilter);

            base.AddControls(i_TabPage);
        }

        public override void HideControls()
        {
            SetVisibility(false);

            base.HideControls();
        }

        public override void SetVisibility(bool i_IsShouldBecomeVisible)
        {
            r_ListBoxPictures.Visible = i_IsShouldBecomeVisible;
            r_PictureBoxSelectedPicture.Visible = i_IsShouldBecomeVisible;
            r_ButtonTenYearsFilter.Visible = i_IsShouldBecomeVisible;

            base.SetVisibility(i_IsShouldBecomeVisible);
        }

        private void listBoxPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox listBoxPictures = sender as ListBox;
            if (listBoxPictures.SelectedItem is Photo)
            {
                r_PictureBoxSelectedPicture.Image = (listBoxPictures.SelectedItem as Photo).ImageNormal;
            }
        }
    }
}
