using System;
using System.Collections;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.slideshow
{
    internal class Slideshow : IEnumerable<Photo>
    {
        public Slideshow(Album album)
        {
            Album = album;
        }

        public Album Album { get; set; }

        public string PictureAlbumURL
        {
            get { return Album.PictureAlbumURL; }
        }

        public string AlbumName
        {
            get { return Album.Name; }
        }

        public IEnumerator<Photo> GetEnumerator()
        {
            return GetFilteredPhotos(photo => true).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<Photo> GetFilteredPhotos(Func<Photo, bool> i_Test)
        {
            foreach (Photo photo in Album.Photos)
            {
                if (i_Test(photo))
                {
                    yield return photo;
                }
            }
        }
    }
}
