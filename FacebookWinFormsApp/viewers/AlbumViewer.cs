using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class AlbumViewer : PictureAndNameObjectViewer
    {
        private readonly ListBox r_ListBoxPictures;
        private readonly PictureBox r_PictureBoxSelectedPicture;

        public AlbumViewer(int i_TopLeftX, int i_TopLeftY)
            : base(i_TopLeftX, i_TopLeftY)
        {
            r_ListBoxPictures = new ListBox
            {
                FormattingEnabled = true,
                ItemHeight = 26,
                Location = new System.Drawing.Point(i_TopLeftX, i_TopLeftY + 130),
                Name = "listBoxPictures",
                Size = new System.Drawing.Size(140, 150),
                TabIndex = 72,
                HorizontalScrollbar = true,
            };
            r_ListBoxPictures.SelectedIndexChanged += new EventHandler(listBoxPictures_SelectedIndexChanged);
            r_ListBoxPictures.DisplayMember = "CreatedTime";

            r_PictureBoxSelectedPicture = new PictureBox
            {
                Location = new System.Drawing.Point(i_TopLeftX + 195, i_TopLeftY + 130),
                Name = "pictureBoxSelectedPicture",
                Size = new System.Drawing.Size(349, 301),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                TabIndex = 73,
                TabStop = false,
            };

            SetVisibility(false);
        }

        public ListBox ListBoxPictures
        {
            get { return r_ListBoxPictures; }
        }

        public PictureBox PictureBoxSelectedPicture
        {
            get { return r_PictureBoxSelectedPicture; }
        }

        internal void LoadAlbumDetailsToComponents(Album i_SelectedAlbum)
        {
            LoadMainPictureAndNameToComponents(i_SelectedAlbum.PictureAlbumURL, i_SelectedAlbum.Name);
            LoadPicturesToListBox(i_SelectedAlbum);
        }

        public void LoadPicturesToListBox(Album i_SelectedAlbum)
        {
            r_ListBoxPictures.Items.Clear();
            r_PictureBoxSelectedPicture.Image = null;

            try
            {
                foreach (Photo photo in i_SelectedAlbum.Photos)
                {
                    r_ListBoxPictures.Items.Add(photo);
                }

                if (r_ListBoxPictures.Items.Count == 0)
                {
                    throw new NoDataAvailableException("Photos");
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

            base.SetVisibility(i_IsShouldBecomeVisible);
        }

        private void listBoxPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            PictureBoxSelectedPicture.Image = ((sender as ListBox).SelectedItem as Photo).ImageNormal;
        }
    }
}
