using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.viewers
{
    internal class PhotoViewer : IViewer
    {
        private readonly PictureBox r_PictureBoxRandomPhoto;

        public PhotoViewer(int i_TopLeftX, int i_TopLeftY)
        {
            r_PictureBoxRandomPhoto = new PictureBox();
            r_PictureBoxRandomPhoto.Location = new System.Drawing.Point(i_TopLeftX, i_TopLeftY);
            r_PictureBoxRandomPhoto.Name = "pictureBoxRandomPhoto";
            r_PictureBoxRandomPhoto.Size = new System.Drawing.Size(786, 451);
            r_PictureBoxRandomPhoto.TabIndex = 2;
            r_PictureBoxRandomPhoto.TabStop = false;
        }

        public void AddControls(TabPage i_TabPage)
        {
            i_TabPage.Controls.Add(r_PictureBoxRandomPhoto);
        }

        public void HideControls()
        {
            SetVisibility(false);
        }

        public void SetVisibility(bool i_IsShouldBecomeVisible)
        {
            r_PictureBoxRandomPhoto.Visible = i_IsShouldBecomeVisible;
        }

        public void loadRandomPhotoToComponents(Photo i_SelectedPhoto)
        {
            r_PictureBoxRandomPhoto.Image = i_SelectedPhoto.ImageNormal;
        }
    }
}
