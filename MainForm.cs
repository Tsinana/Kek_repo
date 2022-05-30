using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Text.RegularExpressions;

namespace Kek
{
    public partial class MainForm : Form
    {

        private Word.Application _app;

        public MainForm()
        {
            InitializeComponent();
            _app = new Word.Application();
            _app.Visible = false;
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
            //try
            //{
                int quantityVariant = Convert.ToInt32(nQuantityVar.Value);
                Data data = new Data();
                List<string> listQTNVarName = new List<string>();

                if (checkBox.Checked)
                {
                    Nominate t = new Nominate(quantityVariant, data);
                    t.ShowDialog();
                    string str = data.GetValue();
                    Regex myReg = new Regex("([А-Я]*[а-я]+)");
                    MatchCollection matches = myReg.Matches(str);
                    foreach (Match m in matches)
                    {
                        string name = m.Value;
                        listQTNVarName.Add(name);
                    }
                }
                else
                {
                    for (int i = 1; i <= quantityVariant; i++)
                    {
                        string name = Convert.ToString(i);
                        listQTNVarName.Add(name);
                    }
                }


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

                ListVariant lv = new ListVariant(quantityVariant, listQTN, listQTNVarName);

                saveText(lv);

                Finish t1 = new Finish();
                t1.ShowDialog();
                Close();
            //}
            /*catch
            {
                Close();
            }*/
        }
        
        private void saveText(ListVariant lv)
        {
            int quantityVariant = Convert.ToInt32(nQuantityVar.Value);
            
            try
            {
                //string title = folderTestTB.Text + @"\Варианты.docx";
                Word.Document doc = _app.Documents.Add();
                List<Variant> listVar = lv.GetListVar();

                foreach (Variant version in listVar)
                {
                    doc.Paragraphs.Last.Range.Text = version.GetValue();
                    doc.Paragraphs.Add();
                    doc.Paragraphs.Last.Range.InsertBreak(Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak); //разрыв между страницами
                }

                //устанавливаем для всего текста шрифт, размер и т.д.
                for (int i = 1; i <= doc.Paragraphs.Count; ++i)
                {
                    doc.Paragraphs[i].Range.Font.Name = "Times New Roman";
                    doc.Paragraphs[i].Range.Font.Size = 14;
                    doc.Paragraphs[i].Range.Paragraphs.TabIndent(-1);
                    doc.Paragraphs[i].Range.Paragraphs.SpaceBefore = 0;
                    doc.Paragraphs[i].Range.Paragraphs.SpaceAfter = 0;
                }

                
                doc.Save();// =(
                doc.Close();
                _app.Quit();

                Excel.Application ex = new Microsoft.Office.Interop.Excel.Application();
                ex.Visible = false;

                Excel.Workbook workBook = ex.Workbooks.Add();
                Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);

                int ii = 2;
                int jj = 1;

                int quantityVar = listVar.Count;
                int forDD = listVar[0].GetAnsValue().Count;
                for (int i = 1; i <= forDD; i++)
                {
                    sheet.Cells[1, jj+1] = String.Format(Convert.ToString(jj));
                    jj++;
                }


                foreach (Variant version in listVar)
                {
                    List<string> listStr = version.GetAnsValue();

                    string name = version.GetName();
                    sheet.Cells[ii, 1] = String.Format(name);

                    jj = 2;
                    foreach (string str in listStr)
                    {
                        sheet.Cells[ii, jj] = String.Format(str);
                        jj++;
                    }
                    ii++;
                }

                workBook.Save();
                workBook.Close();

                ex.Quit();
            }
                catch
                {
                    Close();
                }
        }
    }
}
