namespace BasicFacebookFeatures.viewers.factories
{
    public class EventViewerFactory : IViewerFactory
    {
        public IViewer CreateViewer(int i_TopLeftX, int i_TopLeftY)
        {
            return new EventViewer(i_TopLeftX, i_TopLeftY);
        }
    }
}