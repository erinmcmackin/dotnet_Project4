namespace erin_mcmackin_project4
{
    partial class formSemester
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
            this.txtNumOfCoursesIn = new System.Windows.Forms.TextBox();
            this.txtNameIn = new System.Windows.Forms.TextBox();
            this.calStartDateIn = new System.Windows.Forms.DateTimePicker();
            this.comboCourseNumIn = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioOnline = new System.Windows.Forms.RadioButton();
            this.radioHybrid = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtNumOfCoursesOut = new System.Windows.Forms.TextBox();
            this.txtNameOut = new System.Windows.Forms.TextBox();
            this.txtStartDateOut = new System.Windows.Forms.TextBox();
            this.txtCourseNumOut = new System.Windows.Forms.TextBox();
            this.txtFormatOut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumOfCoursesIn
            // 
            this.txtNumOfCoursesIn.Location = new System.Drawing.Point(466, 70);
            this.txtNumOfCoursesIn.Name = "txtNumOfCoursesIn";
            this.txtNumOfCoursesIn.Size = new System.Drawing.Size(366, 38);
            this.txtNumOfCoursesIn.TabIndex = 0;
            this.txtNumOfCoursesIn.TabStop = false;
            // 
            // txtNameIn
            // 
            this.txtNameIn.Location = new System.Drawing.Point(466, 170);
            this.txtNameIn.Name = "txtNameIn";
            this.txtNameIn.Size = new System.Drawing.Size(366, 38);
            this.txtNameIn.TabIndex = 1;
            this.txtNameIn.TabStop = false;
            // 
            // calStartDateIn
            // 
            this.calStartDateIn.Location = new System.Drawing.Point(333, 280);
            this.calStartDateIn.Name = "calStartDateIn";
            this.calStartDateIn.Size = new System.Drawing.Size(499, 38);
            this.calStartDateIn.TabIndex = 2;
            this.calStartDateIn.TabStop = false;
            // 
            // comboCourseNumIn
            // 
            this.comboCourseNumIn.FormattingEnabled = true;
            this.comboCourseNumIn.Location = new System.Drawing.Point(466, 384);
            this.comboCourseNumIn.Name = "comboCourseNumIn";
            this.comboCourseNumIn.Size = new System.Drawing.Size(366, 39);
            this.comboCourseNumIn.TabIndex = 3;
            this.comboCourseNumIn.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioOnline);
            this.groupBox1.Controls.Add(this.radioHybrid);
            this.groupBox1.Location = new System.Drawing.Point(95, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Format";
            // 
            // radioOnline
            // 
            this.radioOnline.AutoSize = true;
            this.radioOnline.Location = new System.Drawing.Point(511, 48);
            this.radioOnline.Name = "radioOnline";
            this.radioOnline.Size = new System.Drawing.Size(136, 36);
            this.radioOnline.TabIndex = 1;
            this.radioOnline.Text = "Online";
            this.radioOnline.UseVisualStyleBackColor = true;
            // 
            // radioHybrid
            // 
            this.radioHybrid.AutoSize = true;
            this.radioHybrid.Location = new System.Drawing.Point(317, 48);
            this.radioHybrid.Name = "radioHybrid";
            this.radioHybrid.Size = new System.Drawing.Size(134, 36);
            this.radioHybrid.TabIndex = 0;
            this.radioHybrid.Text = "Hyprid";
            this.radioHybrid.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of Courses";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start Date";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 391);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Course Number";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(173, 642);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(271, 86);
            this.btnSet.TabIndex = 9;
            this.btnSet.TabStop = false;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(506, 642);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(271, 86);
            this.btnGet.TabIndex = 10;
            this.btnGet.TabStop = false;
            this.btnGet.Text = "Get";
            this.btnGet.UseVisualStyleBackColor = true;
            // 
            // txtNumOfCoursesOut
            // 
            this.txtNumOfCoursesOut.Location = new System.Drawing.Point(466, 789);
            this.txtNumOfCoursesOut.Name = "txtNumOfCoursesOut";
            this.txtNumOfCoursesOut.ReadOnly = true;
            this.txtNumOfCoursesOut.Size = new System.Drawing.Size(366, 38);
            this.txtNumOfCoursesOut.TabIndex = 11;
            // 
            // txtNameOut
            // 
            this.txtNameOut.Location = new System.Drawing.Point(466, 865);
            this.txtNameOut.Name = "txtNameOut";
            this.txtNameOut.ReadOnly = true;
            this.txtNameOut.Size = new System.Drawing.Size(366, 38);
            this.txtNameOut.TabIndex = 12;
            // 
            // txtStartDateOut
            // 
            this.txtStartDateOut.Location = new System.Drawing.Point(466, 943);
            this.txtStartDateOut.Name = "txtStartDateOut";
            this.txtStartDateOut.ReadOnly = true;
            this.txtStartDateOut.Size = new System.Drawing.Size(366, 38);
            this.txtStartDateOut.TabIndex = 13;
            // 
            // txtCourseNumOut
            // 
            this.txtCourseNumOut.Location = new System.Drawing.Point(466, 1027);
            this.txtCourseNumOut.Name = "txtCourseNumOut";
            this.txtCourseNumOut.ReadOnly = true;
            this.txtCourseNumOut.Size = new System.Drawing.Size(366, 38);
            this.txtCourseNumOut.TabIndex = 14;
            // 
            // txtFormatOut
            // 
            this.txtFormatOut.Location = new System.Drawing.Point(466, 1106);
            this.txtFormatOut.Name = "txtFormatOut";
            this.txtFormatOut.ReadOnly = true;
            this.txtFormatOut.Size = new System.Drawing.Size(366, 38);
            this.txtFormatOut.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(104, 795);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(258, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Number of Courses";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(104, 871);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(104, 949);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Start Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(104, 1033);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Course Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(104, 1112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "Class Format";
            // 
            // formSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 1210);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFormatOut);
            this.Controls.Add(this.txtCourseNumOut);
            this.Controls.Add(this.txtStartDateOut);
            this.Controls.Add(this.txtNameOut);
            this.Controls.Add(this.txtNumOfCoursesOut);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboCourseNumIn);
            this.Controls.Add(this.calStartDateIn);
            this.Controls.Add(this.txtNameIn);
            this.Controls.Add(this.txtNumOfCoursesIn);
            this.Name = "formSemester";
            this.Text = "Semester";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumOfCoursesIn;
        private System.Windows.Forms.TextBox txtNameIn;
        private System.Windows.Forms.DateTimePicker calStartDateIn;
        private System.Windows.Forms.ComboBox comboCourseNumIn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioOnline;
        private System.Windows.Forms.RadioButton radioHybrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.TextBox txtNumOfCoursesOut;
        private System.Windows.Forms.TextBox txtNameOut;
        private System.Windows.Forms.TextBox txtStartDateOut;
        private System.Windows.Forms.TextBox txtCourseNumOut;
        private System.Windows.Forms.TextBox txtFormatOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

