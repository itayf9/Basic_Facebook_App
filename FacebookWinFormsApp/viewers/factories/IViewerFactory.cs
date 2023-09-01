namespace BasicFacebookFeatures.viewers.factories
{
    public interface IViewerFactory
    {
        IViewer CreateViewer(int i_TopLeftX, int i_TopLeftY);
    }
}