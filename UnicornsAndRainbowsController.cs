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
        private IBrowserNavigator m_browserNavigator;
        private IMouseCount m_mouseCount;

        public UnicornsAndRainbowsController(IUserInterface userInterface, IBrowserNavigator browserNavigator, IMouseCount mouseCount)
        {
            m_browserNavigator = browserNavigator;
            m_userInterface = userInterface;
            m_mouseCount = mouseCount;

            userInterface.OnButtonClick += ButtonClick;
        }

        void ButtonClick(string searchTerm)
        {
            m_mouseCount.Increase();

            m_userInterface.SetCount(m_mouseCount.GetCount());

            m_browserNavigator.NavigateTo(searchTerm);

        }
    }
}
