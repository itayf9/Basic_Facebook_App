namespace BasicFacebookFeatures.viewers.factories
{
    public class AlbumViewerFactory : IViewerFactory
    {
        public IViewer CreateViewer(int i_TopLeftX, int i_TopLeftY)
        {
            return new AlbumViewer(i_TopLeftX, i_TopLeftY);
        }
    }
}