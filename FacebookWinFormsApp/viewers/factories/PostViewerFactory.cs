namespace BasicFacebookFeatures.viewers.factories
{
    public class PostViewerFactory : IViewerFactory
    {
        public IViewer CreateViewer(int i_TopLeftX, int i_TopLeftY)
        {
            return new PostViewer(i_TopLeftX, i_TopLeftY);
        }
    }
}