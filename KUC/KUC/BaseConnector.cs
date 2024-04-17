using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KUC
{

    internal class BaseConnector
    {
        MySqlConnection path = new MySqlConnection("server=127.0.0.1;port=3306;username=root;password=piPiPupu35;database=diplom");

        private void ConnectToBase()
        {
            if (path.State == System.Data.ConnectionState.Closed)
            {
                path.Open();
            }
        }

        private void CloseToBase()
        {
            if (path.State == System.Data.ConnectionState.Open)
            {
                path.Close();
            }
        }

        public List<List<string>> ShowAllProjects()
        {
            ConnectToBase();
            List<List<string>> projects = new List<List<string>>();
            string StringsCommand = "SELECT project_id, project_name, project_description, project_start FROM project WHERE project_status_id = 1;";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    List<string> project = new List<string>();
                    project.Add(Convert.ToString(catcher.GetInt32("project_id")));
                    project.Add(catcher.GetString("project_name"));
                    project.Add(catcher.GetString("project_description"));
                    project.Add(Convert.ToString(catcher.GetDateTime("project_start")));
                    projects.Add(project);
                }
            }
            CloseToBase();
            return projects;
        }
        public List<List<string>> ShowAllStudents()
        {
            ConnectToBase();
            List<List<string>> students = new List<List<string>>();
            string StringsCommand = "SELECT student_id, last_name, first_name, middle_name, description, contact_mail FROM student;";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    List<string> student = new List<string>();
                    student.Add(Convert.ToString(catcher.GetInt32("student_id")));
                    student.Add(catcher.GetString("last_name") + " " + catcher.GetString("first_name") + " " + catcher.GetString("middle_name"));
                    student.Add(catcher.GetString("description"));
                    student.Add(catcher.GetString("contact_mail"));
                    students.Add(student);
                }
            }
            CloseToBase();
            return students;
        }

        public List<List<string>> ShowMyProjects(int id)
        {
            ConnectToBase();
            List<List<string>> projects = new List<List<string>>();
            string StringsCommand = $"SELECT project.project_id, project_name, project_description, project_request_status.project_request_status_name FROM project join project_request on project.project_id = project_request.project_id join project_request_status on project_request_status.project_request_status_id = project_request.project_request_status_id where project_request.student_id = {id};";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    List<string> project = new List<string>();
                    project.Add(Convert.ToString(catcher.GetInt32("project_id")));
                    project.Add(catcher.GetString("project_name"));
                    project.Add(catcher.GetString("project_description"));
                    project.Add(catcher.GetString("project_request_status_name"));
                    projects.Add(project);
                }
            }
            CloseToBase();
            return projects;
        }
        //SELECT project_name, customer_name, project_direction_name, project_status_name, project_description, project_start, project_end, project_payment FROM diplom.project join project_direction on project.project_direction_id = project_direction.project_direction_id join customer on project.customer_id = customer.customer_id join project_status on project.project_status_id = project_status.project_status_id where project_id = {}
        public List<string> ProjectsInfo(int id)
        {
            ConnectToBase();
            List<string> project = new List<string>();
            project.Add(Convert.ToString(id));
            string StringsCommand = $"SELECT project_name, customer_name, project_direction_name, project_status_name, project_description, project_start, project_end, project_payment FROM diplom.project join project_direction on project.project_direction_id = project_direction.project_direction_id join customer on project.customer_id = customer.customer_id join project_status on project.project_status_id = project_status.project_status_id where project_id = {id};";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    project.Add(catcher.GetString("project_name"));
                    project.Add(catcher.GetString("customer_name"));
                    project.Add(catcher.GetString("project_direction_name"));
                    project.Add(catcher.GetString("project_status_name"));
                    project.Add(catcher.GetString("project_description"));
                    project.Add(Convert.ToString(catcher.GetDateTime("project_start")));
                    project.Add(Convert.ToString(catcher.GetDateTime("project_end")));
                    project.Add(Convert.ToString(catcher.GetInt32("project_payment")));
                }
            }
            CloseToBase();
            return project;
        }
        public List<string> StudentInfo(int id)
        {
            ConnectToBase();
            List<string> student = new List<string>();
            string StringsCommand = $"SELECT student_id, last_name, first_name, middle_name, description, contact_mail FROM student where student_id = {id};";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    student.Add(catcher.GetString("last_name") + " " + catcher.GetString("first_name") + " " + catcher.GetString("middle_name"));
                    student.Add(catcher.GetString("description"));
                    student.Add(catcher.GetString("contact_mail"));
                }
            }
            CloseToBase();
            return student;
        }

        public List<List<string>> ShowEmployerProjects(int id)
        {
            ConnectToBase();
            List<List<string>> projects = new List<List<string>>();
            string StringsCommand = $"SELECT project.project_id, project_name, project_description, project_start FROM project where project.customer_id = {id};";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    List<string> project = new List<string>();
                    project.Add(Convert.ToString(catcher.GetInt32("project_id")));
                    project.Add(catcher.GetString("project_name"));
                    project.Add(catcher.GetString("project_description"));
                    project.Add(Convert.ToString(catcher.GetDateTime("project_start")));
                    projects.Add(project);
                }
            }
            CloseToBase();
            return projects;
        }
        public int AccountId(string lgn, string pswd)
        {
            int id = -1;
            ConnectToBase();
            string StringsCommand = $"SELECT account_id FROM diplom.account where login = \"{lgn}\" and pswd = \"{pswd}\";";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    id = catcher.GetInt32("account_id");
                }
            }
            CloseToBase();

            return id;
        }

        public int StudentAccount(int id)
        {
            int result = -1;
            //SELECT student_id FROM student where account_id = 1;
            ConnectToBase();
            string StringsCommand = $"SELECT student_id FROM student where account_id = {id};";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    result = catcher.GetInt32("student_id");
                }
            }
            CloseToBase();
            return result;
        }
        public int EmployerAccount(int id)
        {
            int result = -1;
            //SELECT student_id FROM student where account_id = 1;
            ConnectToBase();
            string StringsCommand = $"SELECT customer_id FROM customer_representative where account_id = {id};";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    result = catcher.GetInt32("customer_id");
                }
            }
            CloseToBase();
            return result;
        }

        public int GetMaxProjectRequestId()
        {
            int result = -1;
            //(SELECT (MAX(account_logs_id)) + 1 from account_logs)
            ConnectToBase();
            string StringsCommand = $"(SELECT (MAX(project_request_id)) + 1 from project_request);";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    result = catcher.GetInt32("(MAX(project_request_id)) + 1");
                }
            }
            CloseToBase();
            return result;
        }
        public int GetMaxAccountLogId()
        {
            int result = -1;
            //(SELECT (MAX(account_logs_id)) + 1 from account_logs)
            ConnectToBase();
            string StringsCommand = $"(SELECT (MAX(account_logs_id)) + 1 from account_logs);";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    result = catcher.GetInt32("(MAX(account_logs_id)) + 1");
                }
            }
            CloseToBase();
            return result;
        }

        public bool StudentRequest(int prjId, int stId)
        {
            int prReqId = GetMaxProjectRequestId();
            int acLogId = GetMaxAccountLogId();
            ConnectToBase();
            try
            {
                using (MySqlCommand AddInDogovor = new MySqlCommand("student_request_and_logs", path))
                {
                    AddInDogovor.CommandType = System.Data.CommandType.StoredProcedure;
                    AddInDogovor.Parameters.AddWithValue("@pr_id", prjId);
                    AddInDogovor.Parameters.AddWithValue("@stud_id", stId);
                    AddInDogovor.Parameters.AddWithValue("@pr_req_id", prReqId);
                    AddInDogovor.Parameters.AddWithValue("@ac_log_id", acLogId);

                    
                    AddInDogovor.ExecuteNonQuery();
                }
                CloseToBase();
                return true;
            }
            catch (Exception)
            {
                CloseToBase();
                return false;
            }
        }

        public bool StudentDeleteRequest(int prjId, int stId)
        {
            int acLogId = GetMaxAccountLogId();
            ConnectToBase();
            try
            {
                using (MySqlCommand AddInDogovor = new MySqlCommand("delete_project_request", path))
                {
                    AddInDogovor.CommandType = System.Data.CommandType.StoredProcedure;
                    AddInDogovor.Parameters.AddWithValue("@pr_id", prjId);
                    AddInDogovor.Parameters.AddWithValue("@stud_id", stId);
                    AddInDogovor.Parameters.AddWithValue("@ac_log_id", acLogId);
                    AddInDogovor.ExecuteNonQuery();
                }
                CloseToBase();
                return true;
            }
            catch (Exception)
            {
                CloseToBase();
                return false;
            }
        }

        public int ProjectRequestStatusId(int prId, int stId)
        {
            ConnectToBase();
            int result = -1;
            string StringsCommand = $"SELECT project_request_status_id FROM project_request where (project_id = {prId}) AND (student_id = {stId});";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    result = catcher.GetInt32("project_request_status_id");
                }
            }
            CloseToBase();
            return result;
        }

        public List<List<string>> AllStudents()
        {
            ConnectToBase();
            List<List<string>> students = new List<List<string>>();
            string StringsCommand = $"SELECT last_name, first_name, middle_name, university_shortname,  course, description FROM diplom.student join university on student.university_id = university.university_id; ";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    List<string> student = new List<string>();
                    student.Add(catcher.GetString("last_name") + " " + catcher.GetString("first_name") + " " + catcher.GetString("middle_name"));
                    student.Add("Обучается в " + catcher.GetString("university_shortname") + " на " + Convert.ToString(catcher.GetInt32("course")) + " курсе");
                    students.Add(student);
                }
            }
            CloseToBase();
            return students;
        }

        public List<List<string>> CustomersWithJob()
        {
            ConnectToBase();
            List<List<string>> students = new List<List<string>>();
            string StringsCommand = $"SELECT customer_name, count(project_id) FROM customer join project on customer.customer_id = project.customer_id where (project_status_id = 1) or (project_status_id = 2) group by customer_name;";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    List<string> student = new List<string>();
                    student.Add(catcher.GetString("customer_name"));
                    student.Add(Convert.ToString(catcher.GetInt32("count(project_id)")));
                    students.Add(student);

                }
            }
            CloseToBase();
            return students;
        }

        public List<List<string>> EmptyStudentJob()
        {
            ConnectToBase();
            List<List<string>> projects = new List<List<string>>();
            string StringsCommand = $"SELECT project_name, count(project_request.project_request_id) FROM project left join project_request on project_request.project_id = project.project_id group by (project_name);";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    List<string> project = new List<string>();
                    project.Add(catcher.GetString("project_name"));
                    project.Add(Convert.ToString(catcher.GetInt32("count(project_request.project_request_id)")));
                    if (project[1] == "0")
                    {
                        projects.Add(project);
                    }
                }
            }
            CloseToBase();
            return projects;
        }
        public List<List<string>> CustomersAndTheirProjects()
        {
            ConnectToBase();
            List<List<string>> customers = new List<List<string>>();
            string StringsCommand = $"SELECT customer_name, project_name FROM diplom.customer join project on project.customer_id = customer.customer_id order by(customer_name);";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    List<string> customer = new List<string>();
                    customer.Add(catcher.GetString("customer_name"));
                    customer.Add(catcher.GetString("project_name"));
                    if (customers.Count == 0)
                    {
                        customers.Add(customer);
                    }
                    if (customer[0] == customers[customers.Count - 1][0])
                    {
                        customers[customers.Count - 1].Add(customer[1]);
                    }
                    else
                    {
                        customers.Add(customer);
                    }
                }
            }
            CloseToBase();
            return customers;
        }

        public List<List<string>> StudentsWithDescription()
        {
            ConnectToBase();
            List<List<string>> students = new List<List<string>>();
            string StringsCommand = $@"select first_name, last_name, middle_name, university_shortname, course from student join university on university.university_id = student.university_id where (description is not null) and (description != "");";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    List<string> student = new List<string>();
                    student.Add(catcher.GetString("last_name") + " " + catcher.GetString("first_name") + " " + catcher.GetString("middle_name"));
                    student.Add("Обучается в " + catcher.GetString("university_shortname") + " на " + Convert.ToString(catcher.GetInt32("course")) + " курсе");
                    students.Add(student);
                }
            }
            CloseToBase();
            return students;
        }
        public List<List<string>> DeadlinedProjects()
        {
            ConnectToBase();
            List<List<string>> projects = new List<List<string>>();
            string StringsCommand = $"select project_id, project_name, project_description, project_start, project_end from project where (project_end < curdate() and project_status_id <> 3)";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    List<string> project = new List<string>();
                    project.Add(Convert.ToString(catcher.GetInt32("project_id")));
                    project.Add(catcher.GetString("project_name"));
                    project.Add(catcher.GetString("project_description"));
                    project.Add(Convert.ToString(catcher.GetDateTime("project_start")));
                    project.Add(Convert.ToString(catcher.GetDateTime("project_end")));
                    projects.Add(project);
                }
            }
            CloseToBase();
            return projects;
        }

        public List<List<string>> ForgottenAccounts()
        {
            ConnectToBase();
            List<List<string>> accounts = new List<List<string>>();
            string StringsCommand = $"select account.account_id, login, max(logs_date) from account_logs join account on  account_logs.account_id = account.account_id where (Datediff(curdate(), logs_date) > 365) group by account_id";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    List<string> account = new List<string>();
                    account.Add(Convert.ToString(catcher.GetInt32("account_id")));
                    account.Add(catcher.GetString("login"));
                    account.Add(Convert.ToString(catcher.GetDateTime("max(logs_date)")));
                    accounts.Add(account);
                }
            }
            CloseToBase();
            return accounts;
        }

        //
        //

        public string StudentDesc(int id)
        {
            string result = "";
            //SELECT student_id FROM student where account_id = 1;
            ConnectToBase();
            string StringsCommand = $"SELECT description FROM student where account_id = {id};";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            using (MySqlDataReader catcher = Command.ExecuteReader())
            {
                while (catcher.Read())
                {
                    result = catcher.GetString("description");
                }
            }
            CloseToBase();
            return result;
        }

        public bool SaveSet(string desc, int id)
        {
            bool result = false;
            //UPDATE student set description = "pipipupu" where student_id = 1
            ConnectToBase();
            string StringsCommand = $"UPDATE student set description = \"{desc}\" where student_id = {id};";
            MySqlCommand Command = new MySqlCommand(StringsCommand, path);
            try
            {
                Command.ExecuteNonQuery();
                result = true;
            }
            catch
            {
                result = false;
            }
            CloseToBase();
            return result;
        }


    }
}
