using System;
using BasicFacebookFeatures.enums;

namespace BasicFacebookFeatures.viewers
{
    public static class ViewerFactory
    {
        public static IViewer Create(eViewerType i_ViewerType, int i_TopLeftX, int i_TopLeftY)
        {
            IViewer createdViewer;

            switch (i_ViewerType)
            {
                case eViewerType.AlbumViewer:
                    createdViewer = new AlbumViewer(i_TopLeftX, i_TopLeftY);
                    break;

                case eViewerType.GroupViewer:
                    createdViewer = new GroupViewer(i_TopLeftX, i_TopLeftY);
                    break;

                case eViewerType.PostViewer:
                    createdViewer = new PostViewer(i_TopLeftX, i_TopLeftY);
                    break;

                case eViewerType.EventViewer:
                    createdViewer = new EventViewer(i_TopLeftX, i_TopLeftY);
                    break;

                case eViewerType.FriendViewer:
                    createdViewer = new FriendViewer(i_TopLeftX, i_TopLeftY);
                    break;

                case eViewerType.PageViewer:
                    createdViewer = new PageViewer(i_TopLeftX, i_TopLeftY);
                    break;

                case eViewerType.PhotoViewer:
                    createdViewer = new PhotoViewer(i_TopLeftX, i_TopLeftY);
                    break;

                default:
                    throw new ArgumentException("Invalid viewer type.");
            }

            return createdViewer;
        }
    }
}