using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    internal class AlbumViewer
    {
        private readonly ListBox r_ListBoxPictures;
        private readonly PictureBox r_PictureBoxSelectedPicture;
        private Album m_Album;

        public AlbumViewer()
        {
            r_ListBoxPictures = new ListBox();
            r_ListBoxPictures.FormattingEnabled = true;
            r_ListBoxPictures.ItemHeight = 26;
            r_ListBoxPictures.Location = new System.Drawing.Point(595, 178);
            r_ListBoxPictures.Name = "listBoxPictures";
            r_ListBoxPictures.Size = new System.Drawing.Size(205, 342);
            r_ListBoxPictures.TabIndex = 70;
            r_ListBoxPictures.SelectedIndexChanged += new EventHandler(listBoxPictures_SelectedIndexChanged);
            r_ListBoxPictures.DisplayMember = "CreatedTime";
            r_ListBoxPictures.Visible = false;

            r_PictureBoxSelectedPicture = new PictureBox();
            r_PictureBoxSelectedPicture.Location = new System.Drawing.Point(806, 178);
            r_PictureBoxSelectedPicture.Name = "pictureBoxSelectedPicture";
            r_PictureBoxSelectedPicture.Size = new System.Drawing.Size(324, 301);
            r_PictureBoxSelectedPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            r_PictureBoxSelectedPicture.TabIndex = 71;
            r_PictureBoxSelectedPicture.TabStop = false;
            r_PictureBoxSelectedPicture.Visible = false;
        }

        public ListBox ListBoxPictures
        { 
            get { return r_ListBoxPictures; }
        }

        public PictureBox PictureBoxSelectedPicture 
        { 
            get { return r_PictureBoxSelectedPicture; }
        }

        public Album Album
        { 
            set { m_Album = value;
                loadPicturesToListBox();
            } 
        }

        public void setVisible(bool i_Visible)
        {
            r_ListBoxPictures.Visible = i_Visible;
            r_PictureBoxSelectedPicture.Visible = i_Visible;
        }

        private void listBoxPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            PictureBoxSelectedPicture.Image = ((sender as ListBox).SelectedItem as Photo).ImageNormal;
        }

        private void loadPicturesToListBox()
        {
            r_ListBoxPictures.Items.Clear();
            r_PictureBoxSelectedPicture.Image = null;

            try
            {
                foreach (Photo photo in m_Album.Photos)
                {
                    r_ListBoxPictures.Items.Add(photo);
                }

                if (r_ListBoxPictures.Items.Count == 0)
                {
                    throw new NoDataAvailableException();
                }
            }
            catch (Exception)
            {
                MessageBox.Show(string.Format(Constants.NO_ITEMS_TO_RETREIVE_MESSAGE, "Photos"));
            }
        }


    }
}
