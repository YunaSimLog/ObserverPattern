using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObserverPattern
{
    public partial class Form3 : Form, IListenr
    {
        TestSingletonPattern m_SinglePat; // 노트, 색상 정보

        public Form3()
        {
            InitializeComponent();

            m_SinglePat = TestSingletonPattern.Instance;
        }

        public void NotifyAction()
        {
            lbNote.Text = m_SinglePat.m_strNote;
            pnlColor.BackColor = m_SinglePat.m_pnlColor;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
