using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BasicFacebookFeatures.exceptions;
using BasicFacebookFeatures.utilities;
using BasicFacebookFeatures.viewers;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.random_strategy
{
    internal class PhotoRandomStrategy : IRandomStrategy
    {
        private const string k_ContentCategoryAlbums = "Albums";
        private const string k_ContentCategoryPhotos = "Photos";

        private readonly TextBox r_TextBoxUploadDate;
        private readonly PhotoViewer r_PhotoViewer;

        public PhotoRandomStrategy(PhotoViewer i_PhotoViewer, TextBox i_TextBoxUploadDate)
        {
            this.r_PhotoViewer = i_PhotoViewer;
            this.r_TextBoxUploadDate = i_TextBoxUploadDate;
        }

        public void ShowRandomContent(User i_User)
        {
            const bool v_ToBeVisible = true;
            r_PhotoViewer.SetVisibility(v_ToBeVisible);

            Random randomGenerator = new Random();

            List<Album> filteredNonEmptyAlbums = new List<Album>();

            try
            {
                foreach (Album album in i_User.Albums)
                {
                    if (album.Count != 0)
                    {
                        filteredNonEmptyAlbums.Add(album);
                    }
                }

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

                r_TextBoxUploadDate.Visible = v_ToBeVisible;
                r_TextBoxUploadDate.Text = $"Created on {selectedPhoto.CreatedTime}";
                r_PhotoViewer.LoadRandomPhotoToComponents(selectedPhoto);
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
    }
}
