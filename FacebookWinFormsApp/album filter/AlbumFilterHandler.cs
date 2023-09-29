using System;
using System.Collections;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.albumfilter
{
    internal class AlbumFilterHandler : IEnumerable<Photo>
    {
        public AlbumFilterHandler(Album i_Album)
        {
            Album = i_Album;
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
            const bool v_AcceptPhoto = true;
            return GetFilteredPhotos(photo => v_AcceptPhoto).GetEnumerator();
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