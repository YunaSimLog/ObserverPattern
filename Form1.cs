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
    public partial class MainForm : Form, IListenr
    {
        ObserverSubject m_ObserSub;
        TestSingletonPattern m_SinglePat; // 노트, 색상 정보

        Form2 m_Form2;
        Form3 m_Form3;

        public MainForm()
        {
            InitializeComponent();

            m_ObserSub = new ObserverSubject();
            m_SinglePat = TestSingletonPattern.Instance;

            m_Form2 = new Form2();
            m_Form3 = new Form3();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            m_ObserSub.Attach(this);
            m_ObserSub.Attach(m_Form2);
            m_ObserSub.Attach(m_Form3);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pnlColor.BackColor = colorDialog1.Color;
        }

        private void btnShowForm2_Click(object sender, EventArgs e)
        {
            UpdateData();
            m_Form2.Show();
        }

        private void btnShowForm3_Click(object sender, EventArgs e)
        {
            UpdateData();
            m_Form3.Show();
        }

        public void NotifyAction()
        {
            tbNote.Text = m_SinglePat.m_strNote;
            pnlColor.BackColor = m_SinglePat.m_pnlColor;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            m_SinglePat.m_strNote = tbNote.Text;
            m_SinglePat.m_pnlColor = pnlColor.BackColor;

            m_ObserSub.Update();
        }
    }
}
