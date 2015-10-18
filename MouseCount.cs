using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicornsAndRainbows
{
    class MouseCount
    {
        private int m_count;

        public void Increase()
        {
            m_count++;
        }

        public int GetCount()
        {
            return m_count;
        }
    }
}
