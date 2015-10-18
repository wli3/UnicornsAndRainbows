using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace UnicornsAndRainbows
{
    public interface IBrowserNavigatorAdapter
    {
        void NavigateToUrl(Uri uri);
    }
    class BrowserNavigatorAdapter : IBrowserNavigatorAdapter
    {
        public void NavigateToUrl(Uri uri)
        {
            Process.Start(uri.OriginalString);
        }
    }
}
