using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace KUC
{
    internal class Projects
    {
        Label returnLbl;
        private bool typeSt;
        private Student st;
        private Employer Emp;
        public Student setSt {set { st = value; } }
        public Employer setEmp { set { Emp = value; } }
        public List<GroupBox> gb { get; set; }
        public Projects(bool typeSt)
        {
            gb = new List<GroupBox>();
            this.typeSt = typeSt;
        }

        public void ClearGb()
        {
            gb.Clear();
        }
        public void CreateBox(List<string> str)
        {
            GroupBox gbNew = new GroupBox();
            Panel p = new Panel();
            Label lbName = new Label();
            Label lbDescription = new Label();
            Label lbTime = new Label();
            gbNew.SuspendLayout();
            p.SuspendLayout();
            //groupBox
            gbNew.Controls.Add(p);
            gbNew.Dock = System.Windows.Forms.DockStyle.Top;
            gbNew.Name = "groupBox" + Convert.ToString(gb.Count);
            gbNew.Size = new System.Drawing.Size(600, 180);
            gbNew.TabIndex = gb.Count;
            gbNew.TabStop = false;
            //panel
            p.Controls.Add(lbName);
            p.Controls.Add(lbDescription);
            p.Controls.Add(lbTime);
            p.Location = new System.Drawing.Point(5, 10);
            p.Size = new System.Drawing.Size(425, 170);
            p.Name = Convert.ToString(Convert.ToInt32(str[0]));
            p.TabIndex = gb.Count + 1;
            p.BorderStyle = BorderStyle.FixedSingle;
            //lbName
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(5, 5);
            lbName.Name = "labelN" + Convert.ToString(Convert.ToInt32(str[0]));
            lbName.TabIndex = 0;
            lbName.Text = str[1];
            lbName.MaximumSize = p.Size;
            lbName.Click += p_ClickSt;
            lbName.Cursor = Cursors.Hand;
            //lbDescription
            lbDescription.AutoSize = true;
            lbDescription.Location = new System.Drawing.Point(5, 25);
            lbDescription.Name = "labelD" + Convert.ToString(Convert.ToInt32(str[0]));
            lbDescription.TabIndex = 0;
            lbDescription.Text = str[2];
            //lbDescription.BorderStyle = BorderStyle.FixedSingle;
            lbDescription.MaximumSize = new Size(p.Size.Width - 10, 120);
            lbDescription.Click += p_ClickSt;
            lbDescription.Cursor = Cursors.Hand;
            //lbTime
            lbTime.AutoSize = true;
            lbTime.Location = new System.Drawing.Point(5, 35 + lbDescription.Size.Height);
            lbTime.Name = "labelT" + Convert.ToString(Convert.ToInt32(str[0]) + 1);
            lbTime.Size = new System.Drawing.Size(44, 16);
            lbTime.TabIndex = 0;
            lbTime.Text = str[3];
            lbTime.Click += p_ClickSt;
            lbTime.Cursor = Cursors.Hand;
            p.Size = new System.Drawing.Size(425, lbTime.Height + lbTime.Location.Y + 10);
            gbNew.Size = new System.Drawing.Size(600, p.Size.Height + 10);
            gb.Add(gbNew);
        }
        private void p_ClickSt(object sender, EventArgs e)
        {
            using (Label lbl = sender as Label)
            {
                returnLbl = new Label();
                returnLbl.AutoSize = lbl.AutoSize;
                returnLbl.Location = lbl.Location;
                returnLbl.Name = lbl.Name;
                returnLbl.Size = lbl.Size;
                returnLbl.MaximumSize = lbl.MaximumSize;
                returnLbl.TabIndex = lbl.TabIndex;
                returnLbl.Text = lbl.Text;
                returnLbl.Click += p_ClickSt;
                returnLbl.Cursor = lbl.Cursor;
                lbl.Parent.Controls.Add(returnLbl);
                if (typeSt)
                {
                    st.panel_click(Convert.ToInt32(lbl.Name.Remove(0, 6)));
                }
                else
                {
                    Emp.panel_click(Convert.ToInt32(lbl.Name.Remove(0, 6)));
                }
            }

        }

        public Panel ShowOne(List<string> inf)
        {
            int cordY = 0;
            Panel p = new Panel();
            p.Location = new System.Drawing.Point(5, 10);
            p.Size = new System.Drawing.Size(425, 170);
            p.Name = Convert.ToString(gb.Count + 1);
            p.TabIndex = 0;
            for (int i = 0; i < inf.Count; i++)
            {
                Label lbl = new Label();
                p.Controls.Add(lbl);
                lbl.AutoSize = true;
                lbl.Location = new System.Drawing.Point(5, 5 + cordY);
                lbl.Name = "label" + Convert.ToString(gb.Count + 2);
                lbl.TabIndex = 0;
                lbl.Text = inf[i];
                lbl.MaximumSize = new System.Drawing.Size(p.Width - 5, 9000);
                cordY += lbl.Height;
            }
            p.Size = new System.Drawing.Size(425, cordY + 20);


            return p;
        }
            
    

        
    }
}
