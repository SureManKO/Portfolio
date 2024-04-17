using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Word = Microsoft.Office.Interop.Word;

namespace KUC
{
    public partial class Student : Form
    {
        TextBox textBoxDesc;
        int stid;
        string desc;
        Projects pr;
        BaseConnector cntr;
        int mode = 0; 
        //modes:
        //0 - start
        //1 - my prjcts
        //2 - all prjcts
        //3 - settings
        //4 - current prjct
        //5 - acnt settings
        public Student(int stid)
        {
            InitializeComponent();
            this.stid = stid;
            labelMyProjects.Cursor = Cursors.Hand;
            labelProjects.Cursor = Cursors.Hand;
            labelSettings.Cursor = Cursors.Hand;
            pr = new Projects(true);
            cntr = new BaseConnector();
            ModeZero();
            buttonBack.Hide();
            buttonRequest.Hide();
            buttonPrintPdf.Hide();
        }

        private void ShowBoxes()
        {
            panel1.Controls.Clear();
            for (int i = pr.gb.Count - 1; i >= 0 ; i--)
            {
                panel1.Controls.Add(pr.gb[i]);
            }
        }

        private void ShowOneBox(Panel p)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(p);
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
                buttonRequest.Hide();
                ShowBoxes();
            }
        }

        private void labelProjects_Click(object sender, EventArgs e)
        {
            pr.ClearGb();
            pr.setSt = this;
            mode = 2;
            labelName.Text = "Все доступные проекты";
            List<List<string>> allPr = cntr.ShowAllProjects();
            for (int i = 0; i < allPr.Count(); i++)
            {
                pr.CreateBox(allPr[i]);
            }
            buttonBack.Hide();
            buttonRequest.Hide();
            ShowBoxes();
        }

        private void ModeZero()
        {
            labelName.Text = "Добро пожаловать!";
        }

        private void labelMyProjects_Click(object sender, EventArgs e)
        {
            pr.ClearGb();
            pr.setSt = this;
            mode = 1;
            labelName.Text = "Ваши проекты";
            List<List<string>> allPr = cntr.ShowMyProjects(stid);
            for (int i = 0; i < allPr.Count(); i++)
            {
                pr.CreateBox(allPr[i]);
            }
            buttonBack.Hide();
            buttonRequest.Hide();
            ShowBoxes();

        }

        private void labelSettings_Click(object sender, EventArgs e)
        {
            mode = 3;
            labelName.Text = "Настройки профиля";
            SettingsShow();
            buttonBack.Hide();
            buttonRequest.Hide();


        }

        public void panel_click(int id)
        {
            buttonBack.Show();
            int prjrqstst = cntr.ProjectRequestStatusId(id, stid);
            if (prjrqstst == -1)
            {
                buttonRequest.Text = "Подать заявку";
                buttonRequest.Show();
            }
            else if (prjrqstst == 1)
            {
                buttonRequest.Text = "Удалить заявку";
                buttonRequest.Show();
            }
            mode = 4;
            List<string> inf = cntr.ProjectsInfo(id);
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
            textBoxDesc.Text = cntr.StudentDesc(stid);
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
            if(cntr.SaveSet(textBoxDesc.Text, stid))
            {
                MessageBox.Show("Изменения добавлены.");
            }
            else
            {
                MessageBox.Show("Изменения не добавлены.");
            }

        }

        private void buttonRequest_Click(object sender, EventArgs e)
        {
            if (buttonRequest.Text == "Подать заявку")
            {
                if (cntr.StudentRequest(Convert.ToInt32(panel1.Controls[0].Controls[0].Text), stid))
                {
                    MessageBox.Show("Изменения добавлены.");
                }
                else
                {
                    MessageBox.Show("Изменения не добавлены.");
                }
            }
            else if (buttonRequest.Text == "Удалить заявку")
            {
                if (cntr.StudentDeleteRequest(Convert.ToInt32(panel1.Controls[0].Controls[0].Text), stid))
                {
                    MessageBox.Show("Изменения добавлены.");
                }
                else
                {
                    MessageBox.Show("Изменения не добавлены.");
                }
                
            }
            buttonBack_Click(null, null);
        }
    }
}
