﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Kek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            string string_textBox = textBox.Text;
            Regex myReg0 = new Regex("([0-9] *- *[0-9])");  // 5-9 ||  1  -  5
            MatchCollection matches = myReg0.Matches(string_textBox);
            foreach (Match m in matches)
            {
                string a = m.Value;
                NewMethod(a);
            }
            Regex myReg1 = new Regex("[0-9]");
            MatchCollection matches1 = myReg1.Matches(string_textBox);
            foreach (Match m in matches1)
            {
                string a = m.Value;
                NewMethod(a);
            }
        }

        private void NewMethod(string a)
        {
            int lastIdx = a.Length - 1;
            int valfrom = Convert.ToInt32(a[0].ToString());
            int valto = Convert.ToInt32(a[lastIdx].ToString());
            for (int i = valfrom; i <= valto; i++)   //i = 1..9
            {
                switch (i)
                {
                    case (1):
                        numericUpDown1.Value = 1;
                        break;
                    case (2):
                        numericUpDown2.Value = 1;
                        break;
                    case (3):
                        numericUpDown3.Value = 1;
                        break;
                    case (4):
                        numericUpDown4.Value = 1;
                        break;
                    case (5):
                        numericUpDown5.Value = 1;
                        break;
                    case (6):
                        numericUpDown6.Value = 1;
                        break;
                    case (7):
                        numericUpDown7.Value = 1;
                        break;
                    case (8):
                        numericUpDown8.Value = 1;
                        break;
                    case (9):
                        numericUpDown9.Value = 1;
                        break;
                }
            }
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            nQuantityVar.Value = 0;
            textBox.Clear();
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            int quantityVariant = Convert.ToInt32(nQuantityVar.Value);
            //quantity task n
            List<int> listQTN = new List<int>();

            int qt1 = Convert.ToInt32(numericUpDown1.Value);
            int qt2 = Convert.ToInt32(numericUpDown2.Value);
            int qt3 = Convert.ToInt32(numericUpDown3.Value);
            int qt4 = Convert.ToInt32(numericUpDown4.Value);
            int qt5 = Convert.ToInt32(numericUpDown5.Value);
            int qt6 = Convert.ToInt32(numericUpDown6.Value);
            int qt7 = Convert.ToInt32(numericUpDown7.Value);
            int qt8 = Convert.ToInt32(numericUpDown8.Value);
            int qt9 = Convert.ToInt32(numericUpDown9.Value);
            listQTN.Add(qt1);
            listQTN.Add(qt2);
            listQTN.Add(qt3);
            listQTN.Add(qt4);
            listQTN.Add(qt5);
            listQTN.Add(qt6);
            listQTN.Add(qt7);
            listQTN.Add(qt8);
            listQTN.Add(qt9);
            ListVariant lv = new ListVariant(quantityVariant, listQTN);
        }
    }
}
