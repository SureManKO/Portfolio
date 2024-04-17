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
    public partial class Employer : Form
    {
        int employerID; 
        TextBox textBoxDesc;
        string desc;
        Projects pr;
        BaseConnector cntr;
        int mode = 0;
        List<string> projects = new List<string>();
        public Employer(int employerID)
        {
            InitializeComponent();
            this.employerID = employerID;
            labelMyProjects.Cursor = Cursors.Hand;
            labelStudents.Cursor = Cursors.Hand;
            labelSettings.Cursor = Cursors.Hand;
            pr = new Projects(false);
            cntr = new BaseConnector();
            ModeZero();
            buttonBack.Hide();
            buttonAddOnProject.Hide();
            buttonRefuse.Hide();
            comboBoxProjects.Hide();
        }

        //
        private void ShowBoxes()
        {
            panel1.Controls.Clear();
            for (int i = pr.gb.Count - 1; i >= 0; i--)
            {
                panel1.Controls.Add(pr.gb[i]);
            }
        }

        private void ShowOneBox(Panel p)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(p);
        }


        private void ModeZero()
        {
            labelName.Text = "Добро пожаловать!";
        }

        public void panel_click(int id)
        {
            buttonBack.Show();
            if (mode == 2)
            {
                buttonAddOnProject.Show();
                buttonRefuse.Show();
                comboBoxProjects.Show();
                buttonAddOnProject.Text = "Пригласить в проект";
            }
            else if (mode == 1)
            {
                buttonAddOnProject.Show();
                buttonAddOnProject.Text = "Принять в проект";
            }
            mode = 4;
            List<string> inf = cntr.StudentInfo(id);
            ShowOneBox(pr.ShowOne(inf));

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
        private void buttonPrintWord_Click(object sender, EventArgs e)
        {
            List<List<string>> text = cntr.CustomersAndTheirProjects();
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
        //yPos += yPos + labelHeight

        private void SettingsShow()
        {
            textBoxDesc = new System.Windows.Forms.TextBox();
            Label labelDesc = new System.Windows.Forms.Label();
            Button buttonSaveSet = new System.Windows.Forms.Button();
            panel1.Controls.Clear();
            panel1.Controls.Add(textBoxDesc);
            panel1.Controls.Add(labelDesc);
            panel1.Controls.Add(buttonSaveSet);
            labelDesc.AutoSize = true;
            labelDesc.Location = new System.Drawing.Point(10, 15);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new System.Drawing.Size(96, 15);
            labelDesc.TabIndex = 2;
            labelDesc.Text = "Ваше описание";
            //
            textBoxDesc.Location = new System.Drawing.Point(10, 30);
            textBoxDesc.Name = "textBoxDesc";
            textBoxDesc.Size = new System.Drawing.Size(403, 220);
            textBoxDesc.TabIndex = 1;
            textBoxDesc.Multiline = true;
            textBoxDesc.ScrollBars = ScrollBars.Both;
            textBoxDesc.Text = cntr.StudentDesc(employerID);
            //
            buttonSaveSet.Location = new System.Drawing.Point(306, 260);
            buttonSaveSet.Name = "buttonSaveSet";
            buttonSaveSet.Size = new System.Drawing.Size(103, 31);
            buttonSaveSet.TabIndex = 0;
            buttonSaveSet.Text = "Применить";
            buttonSaveSet.UseVisualStyleBackColor = true;
            buttonSaveSet.Click += BtnSaveSetClick;
        }

        private void BtnSaveSetClick(object sender, EventArgs e)
        {
            if (cntr.SaveSet(textBoxDesc.Text, employerID))
            {
                MessageBox.Show("Изменения добавлены.");
            }
            else
            {
                MessageBox.Show("Изменения добавлены.");
            }

        }

        private void labelMyProjects_Click_1(object sender, EventArgs e)
        {
            pr.ClearGb();
            pr.setEmp = this;
            mode = 1;
            labelName.Text = "Ваши проекты";
            List<List<string>> allPr = cntr.ShowEmployerProjects(employerID);
            for (int i = 0; i < allPr.Count(); i++)
            {
                pr.CreateBox(allPr[i]);
            }
            ShowBoxes();
        }

        private void labelStudents_Click(object sender, EventArgs e)
        {
            pr.ClearGb();
            pr.setEmp = this;
            mode = 2;
            labelName.Text = "Все студенты";
            List<List<string>> allSt = cntr.ShowAllStudents();
            for (int i = 0; i < allSt.Count(); i++)
            {
                pr.CreateBox(allSt[i]);
            }
            ShowBoxes();

        }

        private void labelSettings_Click_1(object sender, EventArgs e)
        {
            mode = 3;
            labelName.Text = "Настройки профиля";
            SettingsShow();

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (mode == 4)
            {
                //List<string> list = new List<string>();
                //list.Add("1");
                //list.Add("projectName");
                //list.Add("РазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработкаРазработка");
                //list.Add("27.07.2002");
                //pr.CreateBox(list);
                //ShowBoxes();
                buttonBack.Hide();
                buttonBack.Hide();
                buttonAddOnProject.Hide();
                buttonRefuse.Hide();
                comboBoxProjects.Hide();
                ShowBoxes();
            }
        }
    }
}
