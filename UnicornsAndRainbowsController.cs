using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornsAndRainbows
{
    public class UnicornsAndRainbowsController
    {
        private IUserInterface m_userInterface;
        private IBrowserNavigator _mBrowserNavigator;
        private MouseCount m_mouseCount = new MouseCount();

        public UnicornsAndRainbowsController(IUserInterface userInterface, IBrowserNavigator browserNavigator)
        {
            _mBrowserNavigator = browserNavigator;
            m_userInterface = userInterface;

            userInterface.OnButtonClick += ButtonClick;
        }

        void ButtonClick(string searchTerm)
        {
            m_mouseCount.Increase();

            m_userInterface.SetCount(m_mouseCount.GetCount());

            _mBrowserNavigator.NavigateTo(searchTerm);

        }
    }
}
