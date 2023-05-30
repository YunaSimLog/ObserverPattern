using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class TestSingletonPattern
    {
        private static TestSingletonPattern Inst = null;

        public string m_strNote { get; set; }
        public Color m_pnlColor { get; set; }

        public static TestSingletonPattern Instance
        {
            get
            {
                if (Inst == null)
                    Inst = new TestSingletonPattern();
                return Inst;
            }
        }

        private TestSingletonPattern()
        {
            m_strNote = "";
            m_pnlColor = Color.White;
        }
    }
}
