using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Kek
{
    public partial class Nominate : Form
    {
        private Data _data;
        private int _QuantityVar;
        public Nominate()
        {
            InitializeComponent();
        }

        public Nominate(int QuantityVar,Data data)
        {
            InitializeComponent();
            _data = data;
            _QuantityVar = QuantityVar;
            labelQuantityVar.Text = Convert.ToString(QuantityVar);
            labelFail.Text = "";
        }
        
        private void BReset_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void BOk_Click(object sender, EventArgs e)
        {
            string strFromBox = textBox.Text;

            Regex myReg0 = new Regex(",,");
            bool ok = (myReg0.IsMatch(strFromBox)==false);

            if (ok)
            {
                Regex myReg = new Regex(",");
                MatchCollection matches = myReg.Matches(strFromBox);
                int countShit = matches.Count;
                if (countShit == _QuantityVar - 1)
                {
                    _data.SerValue(textBox.Text);
                    Close();
                }
                else
                {
                    labelFail.Text = "Не все варианты промаркированы ";
                }
            }
            else
            {
                labelFail.Text = "Неверный синтаксис";
            }
        }
    }
}
