namespace BasicFacebookFeatures.viewers.factories
{
    public class FriendViewerFactory : IViewerFactory
    {
        public IViewer CreateViewer(int i_TopLeftX, int i_TopLeftY)
        {
            return new FriendViewer(i_TopLeftX, i_TopLeftY);
        }
    }
}