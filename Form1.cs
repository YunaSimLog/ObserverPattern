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
    public partial class MainForm : Form
    {
        Form2 m_Form2;
        Form3 m_Form3;

        public MainForm()
        {
            InitializeComponent();

            m_Form2 = new Form2();
            m_Form3 = new Form3();
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
            m_Form2.Show();
        }

        private void btnShowForm3_Click(object sender, EventArgs e)
        {
            m_Form3.Show();
        }
    }
}
