using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicornsAndRainbows;

namespace UnicornsAndRainbowsTests
{
    class BrowserNavigatorAdapterSimulator: IBrowserNavigatorAdapter
    {
        public Uri Uri { get; set; }

        public void NavigateToUrl(Uri uri)
        {
            Uri = uri;
        }
    }
}
