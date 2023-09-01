namespace BasicFacebookFeatures.viewers.factories
{
    public class GroupViewerFactory : IViewerFactory
    {
        public IViewer CreateViewer(int i_TopLeftX, int i_TopLeftY)
        {
            return new GroupViewer(i_TopLeftX, i_TopLeftY);
        }
    }
}