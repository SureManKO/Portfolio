namespace KUC
{
    partial class Student
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
            this.labelMyProjects = new System.Windows.Forms.Label();
            this.labelProjects = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPrintPdf = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.labelSettings);
            this.groupBox1.Controls.Add(this.labelMyProjects);
            this.groupBox1.Controls.Add(this.labelProjects);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.groupBox1.Size = new System.Drawing.Size(175, 450);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // labelSettings
            // 
            this.labelSettings.AutoSize = true;
            this.labelSettings.Cursor = System.Windows.Forms.Cursors.Cross;
            this.labelSettings.Location = new System.Drawing.Point(14, 222);
            this.labelSettings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(139, 17);
            this.labelSettings.TabIndex = 4;
            this.labelSettings.Text = "Настройки профиля";
            this.labelSettings.Click += new System.EventHandler(this.labelSettings_Click);
            // 
            // labelMyProjects
            // 
            this.labelMyProjects.AutoSize = true;
            this.labelMyProjects.Location = new System.Drawing.Point(14, 148);
            this.labelMyProjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMyProjects.Name = "labelMyProjects";
            this.labelMyProjects.Size = new System.Drawing.Size(94, 17);
            this.labelMyProjects.TabIndex = 3;
            this.labelMyProjects.Text = "Ваши проеты";
            this.labelMyProjects.Click += new System.EventHandler(this.labelMyProjects_Click);
            // 
            // labelProjects
            // 
            this.labelProjects.AutoSize = true;
            this.labelProjects.Location = new System.Drawing.Point(14, 185);
            this.labelProjects.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProjects.Name = "labelProjects";
            this.labelProjects.Size = new System.Drawing.Size(113, 17);
            this.labelProjects.TabIndex = 2;
            this.labelProjects.Text = "Обзор проектов";
            this.labelProjects.Click += new System.EventHandler(this.labelProjects_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(4, 5);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(66, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(175, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(525, 371);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonPrintPdf);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(175, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(525, 43);
            this.panel2.TabIndex = 2;
            // 
            // buttonPrintPdf
            // 
            this.buttonPrintPdf.Location = new System.Drawing.Point(356, 7);
            this.buttonPrintPdf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonPrintPdf.Name = "buttonPrintPdf";
            this.buttonPrintPdf.Size = new System.Drawing.Size(154, 28);
            this.buttonPrintPdf.TabIndex = 1;
            this.buttonPrintPdf.Text = "Печать word";
            this.buttonPrintPdf.UseVisualStyleBackColor = true;
            this.buttonPrintPdf.Click += new System.EventHandler(this.buttonPrintWord_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(6, 4);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(296, 36);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Добро пожаловать";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonRequest);
            this.panel3.Controls.Add(this.buttonBack);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(175, 414);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(525, 36);
            this.panel3.TabIndex = 3;
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(388, 5);
            this.buttonRequest.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(125, 23);
            this.buttonRequest.TabIndex = 2;
            this.buttonRequest.Text = "Подать заявку";
            this.buttonRequest.UseVisualStyleBackColor = true;
            this.buttonRequest.Click += new System.EventHandler(this.buttonRequest_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Student";
            this.Text = "Student";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProjects;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelMyProjects;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.Button buttonPrintPdf;
    }
}