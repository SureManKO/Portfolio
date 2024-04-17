using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace KUC
{
    public partial class AdminPan : Form
    {
        BaseConnector cntr;
        public AdminPan()
        {
            InitializeComponent();
            cntr = new BaseConnector();
            string[] forms = new string[9];
            forms[0] = "Список обучающихся";
            forms[1] = "Список работодателей, предоставляющих работу";
            forms[2] = "Список заказов с активным поиском";
            forms[3] = "Список заказов работодателей";
            forms[4] = "Список создавших своё резюме";
            forms[5] = "Список просроченных проектов";
            forms[6] = "Список заказов, на которые не откликнулись";
            forms[7] = "Список забытых аккаунтов";
            forms[8] = "Список ";
            for (int i = 0; i < forms.Length; i++)
            {
                comboBox.Items.Add(forms[i]);
            }
            comboBox.SelectedIndex = 0;
        }
        public void WordHelper(string Texto, string path)
        {
            var word = new Word.Application();
            word.Visible = true;
            word.WindowState = Word.WdWindowState.wdWindowStateNormal;
            Word.Document doc = word.Documents.Add();
            Word.Paragraph paragraph;
            paragraph = doc.Paragraphs.Add();
            paragraph.Range.Text = Texto;
            doc.SaveAs(path);
            doc.Close();
            word.Quit();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<List<string>> text = CreateText();
            string s = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "docx Files | *.docx";
            sfd.DefaultExt = "docx";
            for (int i = 0; i < text.Count; i++)
            {
                for (int j = 0; j < text[i].Count; j++)
                {
                    s += text[i][j] + "\n";
                }
                s += "\n\n--------------------------------------------------\n\n\n";
            }
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                WordHelper(s, sfd.FileName);
            }

        }

        private List<List<string>> CreateText()
        {
            List<List<string>> result = new List<List<string>>();
            if (comboBox.SelectedIndex == 0)
            {
                result = cntr.AllStudents();
            }
            else if (comboBox.SelectedIndex == 1)
            {
                result =  cntr.CustomersWithJob();
            }
            else if (comboBox.SelectedIndex == 2)
            {
                cntr.ShowAllProjects();
            }
            else if(comboBox.SelectedIndex == 3)
            {
                result = cntr.CustomersAndTheirProjects();
            }
            else if (comboBox.SelectedIndex == 4)
            {
                result = cntr.StudentsWithDescription();
            }
            else if (comboBox.SelectedIndex == 5)
            {
                result = cntr.DeadlinedProjects();
            }
            else if (comboBox.SelectedIndex == 6)
            {
                result = cntr.EmptyStudentJob();
            }
            else if (comboBox.SelectedIndex == 7)
            {
                result = cntr.ForgottenAccounts();
            }
            else if (comboBox.SelectedIndex == 8)
            {

            }

            return result;
        }
    }
}