namespace KUC
{
    partial class Employer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelStudents = new System.Windows.Forms.Label();
            this.labelMyProjects = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxProjects = new System.Windows.Forms.ComboBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRefuse = new System.Windows.Forms.Button();
            this.buttonAddOnProject = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSettings);
            this.groupBox1.Controls.Add(this.labelStudents);
            this.groupBox1.Controls.Add(this.labelMyProjects);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(175, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Location = new System.Drawing.Point(10, 172);
            this.labelSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(139, 17);
            this.labelSettings.TabIndex = 2;
            this.labelSettings.Text = "Настройки профиля";
            this.labelSettings.Click += new System.EventHandler(this.labelSettings_Click_1);
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Location = new System.Drawing.Point(10, 132);
            this.labelStudents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(74, 17);
            this.labelStudents.TabIndex = 1;
            this.labelStudents.Text = "Студенты";
            this.labelStudents.Click += new System.EventHandler(this.labelStudents_Click);
            // 
            // labelMyProjects
            // 
            this.labelMyProjects.AutoSize = true;
            this.labelMyProjects.Location = new System.Drawing.Point(10, 89);
            this.labelMyProjects.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyProjects.Name = "labelMyProjects";
            this.labelMyProjects.Size = new System.Drawing.Size(101, 17);
            this.labelMyProjects.TabIndex = 0;
            this.labelMyProjects.Text = "Ваши проекты";
            this.labelMyProjects.Click += new System.EventHandler(this.labelMyProjects_Click_1);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(175, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 366);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBoxProjects);
            this.panel2.Controls.Add(this.buttonBack);
            this.panel2.Controls.Add(this.buttonRefuse);
            this.panel2.Controls.Add(this.buttonAddOnProject);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(175, 416);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 34);
            this.panel2.TabIndex = 2;
            // 
            // comboBoxProjects
            // 
            this.comboBoxProjects.FormattingEnabled = true;
            this.comboBoxProjects.Location = new System.Drawing.Point(102, 4);
            this.comboBoxProjects.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProjects.Name = "comboBoxProjects";
            this.comboBoxProjects.Size = new System.Drawing.Size(264, 24);
            this.comboBoxProjects.TabIndex = 3;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(6, 1);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(88, 28);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonRefuse
            // 
            this.buttonRefuse.Location = new System.Drawing.Point(194, 4);
            this.buttonRefuse.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefuse.Name = "buttonRefuse";
            this.buttonRefuse.Size = new System.Drawing.Size(173, 28);
            this.buttonRefuse.TabIndex = 0;
            this.buttonRefuse.Text = "Отказать в принятии";
            this.buttonRefuse.UseVisualStyleBackColor = true;
            // 
            // buttonAddOnProject
            // 
            this.buttonAddOnProject.Location = new System.Drawing.Point(373, 4);
            this.buttonAddOnProject.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddOnProject.Name = "buttonAddOnProject";
            this.buttonAddOnProject.Size = new System.Drawing.Size(148, 28);
            this.buttonAddOnProject.TabIndex = 0;
            this.buttonAddOnProject.Text = "Принять на проект";
            this.buttonAddOnProject.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(175, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 50);
            this.panel3.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelName.Location = new System.Drawing.Point(7, 5);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(296, 36);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Добро пожаловать";
            // 
            // Employer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Employer";
            this.Text = "Employer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Label labelMyProjects;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAddOnProject;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonRefuse;
        private System.Windows.Forms.ComboBox comboBoxProjects;
    }
}