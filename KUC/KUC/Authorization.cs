using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KUC
{
    public partial class Authorization : Form
    {
        BaseConnector cntr;
        public Authorization()
        {
            InitializeComponent();
            textBoxEmpty();
            cntr = new BaseConnector();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                AdminPan ap = new AdminPan();
                this.Hide();
                ap.ShowDialog();
                this.Show();

            }
            else
            {
                if (textBox1.Text == "Логин" && textBox2.Text == "Пароль")
                {
                    //MessageBox.Show("Заполните оба поля.", "Ошибка");

                    //Employer emp = new Employer(6);
                    //this.Hide();
                    //emp.ShowDialog();
                    //this.Show();
                    //
                    Student st = new Student(1);
                    this.Hide();
                    st.ShowDialog();
                    this.Show();
                }
                else
                {
                    int usrId = cntr.AccountId(textBox1.Text, textBox2.Text);
                    if (usrId != -1)
                    {
                        int id = cntr.StudentAccount(usrId);
                        if (id != -1)
                        {
                            Student st = new Student(id);
                            this.Hide();
                            st.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            id = cntr.EmployerAccount(usrId);
                            Employer emp = new Employer(id);
                            this.Hide();
                            emp.ShowDialog();
                            this.Show();

                        }

                    }
                    else
                    {
                        MessageBox.Show("Пользователя с такими данными не был найден.", "Ошибка");
                    }
                }
            
            }

            //Label lbName = new Label();
            //lbName.AutoSize = true;
            //lbName.Location = new System.Drawing.Point(50, 50);
            //lbName.Name = "label" + Convert.ToString(2);
            //lbName.Size = new System.Drawing.Size(44, 16);
            //lbName.TabIndex = 0;
            //lbName.Text = "I'm working";
            //this.Controls.Add(lbName);
        }

        private void textBoxEmpty()
        {
            if (textBox1.Text=="")
            {
                textBox1.Text = "Логин";
                textBox1.ForeColor = Color.Gray;
            }
            if (textBox2.Text == "")
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = "Пароль";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBoxEmpty();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.ForeColor == Color.Black)
            {
                return;
            }
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.ForeColor == Color.Black)
            {
                return;
            }
            textBox2.PasswordChar = '*';
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBoxEmpty();
        }
    }
}
