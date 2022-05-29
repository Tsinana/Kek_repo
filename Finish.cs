using System;
using System.Windows.Forms;

namespace Kek
{
    public partial class Finish : Form
    {
        public Finish()
        {
            InitializeComponent();
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
