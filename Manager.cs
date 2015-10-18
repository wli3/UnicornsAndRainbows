using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornsAndRainbows
{
    public class Manager
    {
        private IUserInterface m_userInterface;
        private Configuration m_configuration;
        private IBrowserNavigator m_browserNavigator;
        private MouseCount m_mouseCount = new MouseCount();

        public Manager(IUserInterface userInterface, Configuration configuration, IBrowserNavigator browserNavigator)
        {
            m_browserNavigator = browserNavigator;
            m_configuration = configuration;
            m_userInterface = userInterface;

            userInterface.OnButtonClick += ButtonClick;
        }

        void ButtonClick(string searchTerm)
        {
            m_mouseCount.Increase();

            m_userInterface.SetCount(m_mouseCount.GetCount());

            m_browserNavigator.NavigateToUrl(new Uri(m_configuration.SearchRoot + searchTerm));

        }
    }
}
