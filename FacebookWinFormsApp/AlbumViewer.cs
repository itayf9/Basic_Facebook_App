using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class AlbumViewer : PictureAndNameObjectViewer
    {
        private readonly ListBox r_ListBoxPictures;
        private readonly PictureBox r_PictureBoxSelectedPicture;

        public AlbumViewer()
            : base()
        {
            r_ListBoxPictures = new ListBox
            {
                FormattingEnabled = true,
                ItemHeight = 26,
                Location = new System.Drawing.Point(595, 290),
                Name = "listBoxPictures",
                Size = new System.Drawing.Size(205, 150),
                TabIndex = 72,
            };
            r_ListBoxPictures.SelectedIndexChanged += new EventHandler(listBoxPictures_SelectedIndexChanged);
            r_ListBoxPictures.DisplayMember = "CreatedTime";

            r_PictureBoxSelectedPicture = new PictureBox
            {
                Location = new System.Drawing.Point(806, 290),
                Name = "pictureBoxSelectedPicture",
                Size = new System.Drawing.Size(324, 301),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                TabIndex = 73,
                TabStop = false,
            };

            setVisible(false);
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

                setVisible(true);
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

        public override void AddControls(TabPage i_TabPage)
        {
            i_TabPage.Controls.Add(r_ListBoxPictures);
            i_TabPage.Controls.Add(r_PictureBoxSelectedPicture);

            base.AddControls(i_TabPage);
        }

        public override void HideControls()
        {
            setVisible(false);

            base.HideControls();
        }

        internal void setVisible(bool i_Visible)
        {
            r_ListBoxPictures.Visible = i_Visible;
            r_PictureBoxSelectedPicture.Visible = i_Visible;

            base.SetVisible(i_Visible);
        }

        private void listBoxPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            PictureBoxSelectedPicture.Image = ((sender as ListBox).SelectedItem as Photo).ImageNormal;
        }
    }
}
