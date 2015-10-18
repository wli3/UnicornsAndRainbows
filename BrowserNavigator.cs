using System;

namespace UnicornsAndRainbows
{
    public interface IBrowserNavigator
    {
        void NavigateTo(string term);
    }

    public class BrowserNavigator : IBrowserNavigator

    {
        private readonly string m_searchRoot;
        private readonly IBrowserNavigatorAdapter m_browserNavigatorAdapter;

        public BrowserNavigator(string searchRoot, IBrowserNavigatorAdapter browserNavigatorAdapter)
        {
            m_searchRoot = searchRoot;
            m_browserNavigatorAdapter = browserNavigatorAdapter;
        }

        public void NavigateTo(string term)
        {
            m_browserNavigatorAdapter.NavigateToUrl(new Uri(m_searchRoot + term));
        }
    }
}
