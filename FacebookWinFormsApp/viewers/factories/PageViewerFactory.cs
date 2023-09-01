namespace BasicFacebookFeatures.viewers.factories
{
    public class PageViewerFactory : IViewerFactory
    {
        public IViewer CreateViewer(int i_TopLeftX, int i_TopLeftY)
        {
            return new PageViewer(i_TopLeftX, i_TopLeftY);
        }
    }
}