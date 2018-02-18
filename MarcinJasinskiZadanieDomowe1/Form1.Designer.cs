namespace MarcinJasinskiZadanieDomowe1
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.labelTitle = new System.Windows.Forms.Label();
            this.dataGridViewProfessorsRanking = new System.Windows.Forms.DataGridView();
            this.columnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFailingRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnFailedStudentsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSummary = new System.Windows.Forms.Label();
            this.textBoxSummary = new System.Windows.Forms.TextBox();
            this.labelTOP3List = new System.Windows.Forms.Label();
            this.labelAverageFailingRatio = new System.Windows.Forms.Label();
            this.textBoxAverageFailingRatio = new System.Windows.Forms.TextBox();
            this.labelAvailableResources = new System.Windows.Forms.Label();
            this.labelLowerDeficitBy1ECTS = new System.Windows.Forms.Label();
            this.labelLowerDeficitTo10ECTS = new System.Windows.Forms.Label();
            this.labelExamByPowerfulProfesor = new System.Windows.Forms.Label();
            this.labelTwoParalellExams = new System.Windows.Forms.Label();
            this.labelUnexpectedRoomChange = new System.Windows.Forms.Label();
            this.buttonUse1ECTSReduction = new System.Windows.Forms.Button();
            this.buttonUse10ECTSReduction = new System.Windows.Forms.Button();
            this.buttonUsePowerfulProfesorExam = new System.Windows.Forms.Button();
            this.buttonUseTwoParalellExams = new System.Windows.Forms.Button();
            this.buttonUseUnexpectedRoomChange = new System.Windows.Forms.Button();
            this.label1ECTSReductionLeft = new System.Windows.Forms.Label();
            this.label10ECTSReductionLeft = new System.Windows.Forms.Label();
            this.labelPowerfulProfesorExamLeft = new System.Windows.Forms.Label();
            this.labelTwoParalellExamsLeft = new System.Windows.Forms.Label();
            this.labelUnexpectedRoomChangeLeft = new System.Windows.Forms.Label();
            this.labelCurrentDate = new System.Windows.Forms.Label();
            this.timerSessionTimer = new System.Windows.Forms.Timer(this.components);
            this.labelDaysLeft = new System.Windows.Forms.Label();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessorsRanking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(13, 13);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(417, 16);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "System Eliminacji Słabych Jednostek Akademickich";
            // 
            // dataGridViewProfessorsRanking
            // 
            this.dataGridViewProfessorsRanking.AllowUserToAddRows = false;
            this.dataGridViewProfessorsRanking.AllowUserToDeleteRows = false;
            this.dataGridViewProfessorsRanking.AllowUserToResizeRows = false;
            this.dataGridViewProfessorsRanking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProfessorsRanking.ColumnHeadersHeight = 25;
            this.dataGridViewProfessorsRanking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProfessorsRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnName,
            this.columnFailingRatio,
            this.columnFailedStudentsCount});
            this.dataGridViewProfessorsRanking.Location = new System.Drawing.Point(14, 445);
            this.dataGridViewProfessorsRanking.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewProfessorsRanking.Name = "dataGridViewProfessorsRanking";
            this.dataGridViewProfessorsRanking.ReadOnly = true;
            this.dataGridViewProfessorsRanking.RowHeadersVisible = false;
            this.dataGridViewProfessorsRanking.RowHeadersWidth = 40;
            this.dataGridViewProfessorsRanking.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewProfessorsRanking.Size = new System.Drawing.Size(422, 100);
            this.dataGridViewProfessorsRanking.TabIndex = 1;
            // 
            // columnName
            // 
            this.columnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnName.HeaderText = "Imię i nazwisko";
            this.columnName.Name = "columnName";
            this.columnName.ReadOnly = true;
            this.columnName.Width = 200;
            // 
            // columnFailingRatio
            // 
            this.columnFailingRatio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.columnFailingRatio.HeaderText = "W.U.";
            this.columnFailingRatio.Name = "columnFailingRatio";
            this.columnFailingRatio.ReadOnly = true;
            this.columnFailingRatio.Width = 50;
            // 
            // columnFailedStudentsCount
            // 
            this.columnFailedStudentsCount.HeaderText = "Wysłanych na poprawki";
            this.columnFailedStudentsCount.Name = "columnFailedStudentsCount";
            this.columnFailedStudentsCount.ReadOnly = true;
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummary.Location = new System.Drawing.Point(11, 59);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(241, 17);
            this.labelSummary.TabIndex = 2;
            this.labelSummary.Text = "Sumaryczna ilość oblanych studentów:";
            // 
            // textBoxSummary
            // 
            this.textBoxSummary.Location = new System.Drawing.Point(264, 56);
            this.textBoxSummary.Name = "textBoxSummary";
            this.textBoxSummary.ReadOnly = true;
            this.textBoxSummary.Size = new System.Drawing.Size(100, 20);
            this.textBoxSummary.TabIndex = 3;
            // 
            // labelTOP3List
            // 
            this.labelTOP3List.AutoSize = true;
            this.labelTOP3List.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTOP3List.Location = new System.Drawing.Point(19, 424);
            this.labelTOP3List.Name = "labelTOP3List";
            this.labelTOP3List.Size = new System.Drawing.Size(152, 17);
            this.labelTOP3List.TabIndex = 4;
            this.labelTOP3List.Text = "TOP 3 największe kosy:";
            // 
            // labelAverageFailingRatio
            // 
            this.labelAverageFailingRatio.AutoSize = true;
            this.labelAverageFailingRatio.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAverageFailingRatio.Location = new System.Drawing.Point(11, 100);
            this.labelAverageFailingRatio.Name = "labelAverageFailingRatio";
            this.labelAverageFailingRatio.Size = new System.Drawing.Size(196, 17);
            this.labelAverageFailingRatio.TabIndex = 5;
            this.labelAverageFailingRatio.Text = "Średni współczynnik uwalania:";
            // 
            // textBoxAverageFailingRatio
            // 
            this.textBoxAverageFailingRatio.Location = new System.Drawing.Point(264, 97);
            this.textBoxAverageFailingRatio.Name = "textBoxAverageFailingRatio";
            this.textBoxAverageFailingRatio.ReadOnly = true;
            this.textBoxAverageFailingRatio.Size = new System.Drawing.Size(100, 20);
            this.textBoxAverageFailingRatio.TabIndex = 6;
            // 
            // labelAvailableResources
            // 
            this.labelAvailableResources.AutoSize = true;
            this.labelAvailableResources.Font = new System.Drawing.Font("Bookman Old Style", 14.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvailableResources.Location = new System.Drawing.Point(10, 141);
            this.labelAvailableResources.Name = "labelAvailableResources";
            this.labelAvailableResources.Size = new System.Drawing.Size(180, 22);
            this.labelAvailableResources.TabIndex = 7;
            this.labelAvailableResources.Text = "Dostępne zasoby:";
            // 
            // labelLowerDeficitBy1ECTS
            // 
            this.labelLowerDeficitBy1ECTS.AutoSize = true;
            this.labelLowerDeficitBy1ECTS.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLowerDeficitBy1ECTS.Location = new System.Drawing.Point(11, 187);
            this.labelLowerDeficitBy1ECTS.Name = "labelLowerDeficitBy1ECTS";
            this.labelLowerDeficitBy1ECTS.Size = new System.Drawing.Size(205, 17);
            this.labelLowerDeficitBy1ECTS.TabIndex = 8;
            this.labelLowerDeficitBy1ECTS.Text = "- Obniżenie deficytu o 1 ECTS";
            // 
            // labelLowerDeficitTo10ECTS
            // 
            this.labelLowerDeficitTo10ECTS.AutoSize = true;
            this.labelLowerDeficitTo10ECTS.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLowerDeficitTo10ECTS.Location = new System.Drawing.Point(11, 221);
            this.labelLowerDeficitTo10ECTS.Name = "labelLowerDeficitTo10ECTS";
            this.labelLowerDeficitTo10ECTS.Size = new System.Drawing.Size(221, 17);
            this.labelLowerDeficitTo10ECTS.TabIndex = 9;
            this.labelLowerDeficitTo10ECTS.Text = "- Obniżenie deficytu do 10 ECTS";
            // 
            // labelExamByPowerfulProfesor
            // 
            this.labelExamByPowerfulProfesor.AutoSize = true;
            this.labelExamByPowerfulProfesor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelExamByPowerfulProfesor.Location = new System.Drawing.Point(11, 256);
            this.labelExamByPowerfulProfesor.Name = "labelExamByPowerfulProfesor";
            this.labelExamByPowerfulProfesor.Size = new System.Drawing.Size(274, 17);
            this.labelExamByPowerfulProfesor.TabIndex = 10;
            this.labelExamByPowerfulProfesor.Text = "- Egzamin układa P.O.T.Ę.Ż.N.Y magister";
            // 
            // labelTwoParalellExams
            // 
            this.labelTwoParalellExams.AutoSize = true;
            this.labelTwoParalellExams.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTwoParalellExams.Location = new System.Drawing.Point(11, 293);
            this.labelTwoParalellExams.Name = "labelTwoParalellExams";
            this.labelTwoParalellExams.Size = new System.Drawing.Size(257, 17);
            this.labelTwoParalellExams.TabIndex = 11;
            this.labelTwoParalellExams.Text = "- Dwa egzaminy w tym samym czasie";
            // 
            // labelUnexpectedRoomChange
            // 
            this.labelUnexpectedRoomChange.AutoSize = true;
            this.labelUnexpectedRoomChange.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUnexpectedRoomChange.Location = new System.Drawing.Point(11, 330);
            this.labelUnexpectedRoomChange.Name = "labelUnexpectedRoomChange";
            this.labelUnexpectedRoomChange.Size = new System.Drawing.Size(213, 17);
            this.labelUnexpectedRoomChange.TabIndex = 12;
            this.labelUnexpectedRoomChange.Text = "- Niezapowiedziana zmiana sali";
            // 
            // buttonUse1ECTSReduction
            // 
            this.buttonUse1ECTSReduction.Location = new System.Drawing.Point(375, 185);
            this.buttonUse1ECTSReduction.Name = "buttonUse1ECTSReduction";
            this.buttonUse1ECTSReduction.Size = new System.Drawing.Size(61, 23);
            this.buttonUse1ECTSReduction.TabIndex = 13;
            this.buttonUse1ECTSReduction.Text = "Użyj";
            this.buttonUse1ECTSReduction.UseVisualStyleBackColor = true;
            this.buttonUse1ECTSReduction.Click += new System.EventHandler(this.buttonUse1ECTSReduction_Click);
            // 
            // buttonUse10ECTSReduction
            // 
            this.buttonUse10ECTSReduction.Location = new System.Drawing.Point(375, 219);
            this.buttonUse10ECTSReduction.Name = "buttonUse10ECTSReduction";
            this.buttonUse10ECTSReduction.Size = new System.Drawing.Size(61, 23);
            this.buttonUse10ECTSReduction.TabIndex = 14;
            this.buttonUse10ECTSReduction.Text = "Użyj";
            this.buttonUse10ECTSReduction.UseVisualStyleBackColor = true;
            this.buttonUse10ECTSReduction.Click += new System.EventHandler(this.buttonUse10ECTSReduction_Click);
            // 
            // buttonUsePowerfulProfesorExam
            // 
            this.buttonUsePowerfulProfesorExam.Location = new System.Drawing.Point(375, 254);
            this.buttonUsePowerfulProfesorExam.Name = "buttonUsePowerfulProfesorExam";
            this.buttonUsePowerfulProfesorExam.Size = new System.Drawing.Size(61, 23);
            this.buttonUsePowerfulProfesorExam.TabIndex = 15;
            this.buttonUsePowerfulProfesorExam.Text = "Użyj";
            this.buttonUsePowerfulProfesorExam.UseVisualStyleBackColor = true;
            this.buttonUsePowerfulProfesorExam.Click += new System.EventHandler(this.buttonUsePowerfulProfesorExam_Click);
            // 
            // buttonUseTwoParalellExams
            // 
            this.buttonUseTwoParalellExams.Location = new System.Drawing.Point(375, 291);
            this.buttonUseTwoParalellExams.Name = "buttonUseTwoParalellExams";
            this.buttonUseTwoParalellExams.Size = new System.Drawing.Size(61, 23);
            this.buttonUseTwoParalellExams.TabIndex = 16;
            this.buttonUseTwoParalellExams.Text = "Użyj";
            this.buttonUseTwoParalellExams.UseVisualStyleBackColor = true;
            this.buttonUseTwoParalellExams.Click += new System.EventHandler(this.buttonUseTwoParalellExams_Click);
            // 
            // buttonUseUnexpectedRoomChange
            // 
            this.buttonUseUnexpectedRoomChange.Location = new System.Drawing.Point(375, 328);
            this.buttonUseUnexpectedRoomChange.Name = "buttonUseUnexpectedRoomChange";
            this.buttonUseUnexpectedRoomChange.Size = new System.Drawing.Size(61, 23);
            this.buttonUseUnexpectedRoomChange.TabIndex = 17;
            this.buttonUseUnexpectedRoomChange.Text = "Użyj";
            this.buttonUseUnexpectedRoomChange.UseVisualStyleBackColor = true;
            this.buttonUseUnexpectedRoomChange.Click += new System.EventHandler(this.buttonUseUnexpectedRoomChange_Click);
            // 
            // label1ECTSReductionLeft
            // 
            this.label1ECTSReductionLeft.AutoSize = true;
            this.label1ECTSReductionLeft.Location = new System.Drawing.Point(328, 190);
            this.label1ECTSReductionLeft.Name = "label1ECTSReductionLeft";
            this.label1ECTSReductionLeft.Size = new System.Drawing.Size(13, 13);
            this.label1ECTSReductionLeft.TabIndex = 18;
            this.label1ECTSReductionLeft.Text = "2";
            // 
            // label10ECTSReductionLeft
            // 
            this.label10ECTSReductionLeft.AutoSize = true;
            this.label10ECTSReductionLeft.Location = new System.Drawing.Point(328, 225);
            this.label10ECTSReductionLeft.Name = "label10ECTSReductionLeft";
            this.label10ECTSReductionLeft.Size = new System.Drawing.Size(13, 13);
            this.label10ECTSReductionLeft.TabIndex = 19;
            this.label10ECTSReductionLeft.Text = "1";
            // 
            // labelPowerfulProfesorExamLeft
            // 
            this.labelPowerfulProfesorExamLeft.AutoSize = true;
            this.labelPowerfulProfesorExamLeft.Location = new System.Drawing.Point(328, 260);
            this.labelPowerfulProfesorExamLeft.Name = "labelPowerfulProfesorExamLeft";
            this.labelPowerfulProfesorExamLeft.Size = new System.Drawing.Size(13, 13);
            this.labelPowerfulProfesorExamLeft.TabIndex = 20;
            this.labelPowerfulProfesorExamLeft.Text = "1";
            // 
            // labelTwoParalellExamsLeft
            // 
            this.labelTwoParalellExamsLeft.AutoSize = true;
            this.labelTwoParalellExamsLeft.Location = new System.Drawing.Point(328, 296);
            this.labelTwoParalellExamsLeft.Name = "labelTwoParalellExamsLeft";
            this.labelTwoParalellExamsLeft.Size = new System.Drawing.Size(13, 13);
            this.labelTwoParalellExamsLeft.TabIndex = 21;
            this.labelTwoParalellExamsLeft.Text = "2";
            // 
            // labelUnexpectedRoomChangeLeft
            // 
            this.labelUnexpectedRoomChangeLeft.AutoSize = true;
            this.labelUnexpectedRoomChangeLeft.Location = new System.Drawing.Point(328, 333);
            this.labelUnexpectedRoomChangeLeft.Name = "labelUnexpectedRoomChangeLeft";
            this.labelUnexpectedRoomChangeLeft.Size = new System.Drawing.Size(13, 13);
            this.labelUnexpectedRoomChangeLeft.TabIndex = 22;
            this.labelUnexpectedRoomChangeLeft.Text = "4";
            // 
            // labelCurrentDate
            // 
            this.labelCurrentDate.AutoSize = true;
            this.labelCurrentDate.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCurrentDate.Location = new System.Drawing.Point(9, 381);
            this.labelCurrentDate.Name = "labelCurrentDate";
            this.labelCurrentDate.Size = new System.Drawing.Size(160, 28);
            this.labelCurrentDate.TabIndex = 23;
            this.labelCurrentDate.Text = "25 stycznia 2018";
            // 
            // timerSessionTimer
            // 
            this.timerSessionTimer.Interval = 1000;
            this.timerSessionTimer.Tick += new System.EventHandler(this.timerSessionTimer_Tick);
            // 
            // labelDaysLeft
            // 
            this.labelDaysLeft.AutoSize = true;
            this.labelDaysLeft.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDaysLeft.Location = new System.Drawing.Point(175, 390);
            this.labelDaysLeft.Name = "labelDaysLeft";
            this.labelDaysLeft.Size = new System.Drawing.Size(0, 16);
            this.labelDaysLeft.TabIndex = 24;
            // 
            // profesorBindingSource
            // 
            this.profesorBindingSource.DataSource = typeof(MarcinJasinskiZadanieDomowe1.Profesor);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 550);
            this.Controls.Add(this.labelDaysLeft);
            this.Controls.Add(this.labelCurrentDate);
            this.Controls.Add(this.labelUnexpectedRoomChangeLeft);
            this.Controls.Add(this.labelTwoParalellExamsLeft);
            this.Controls.Add(this.labelPowerfulProfesorExamLeft);
            this.Controls.Add(this.label10ECTSReductionLeft);
            this.Controls.Add(this.label1ECTSReductionLeft);
            this.Controls.Add(this.buttonUseUnexpectedRoomChange);
            this.Controls.Add(this.buttonUseTwoParalellExams);
            this.Controls.Add(this.buttonUsePowerfulProfesorExam);
            this.Controls.Add(this.buttonUse10ECTSReduction);
            this.Controls.Add(this.buttonUse1ECTSReduction);
            this.Controls.Add(this.labelUnexpectedRoomChange);
            this.Controls.Add(this.labelTwoParalellExams);
            this.Controls.Add(this.labelExamByPowerfulProfesor);
            this.Controls.Add(this.labelLowerDeficitTo10ECTS);
            this.Controls.Add(this.labelLowerDeficitBy1ECTS);
            this.Controls.Add(this.labelAvailableResources);
            this.Controls.Add(this.textBoxAverageFailingRatio);
            this.Controls.Add(this.labelAverageFailingRatio);
            this.Controls.Add(this.labelTOP3List);
            this.Controls.Add(this.textBoxSummary);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.dataGridViewProfessorsRanking);
            this.Controls.Add(this.labelTitle);
            this.Name = "FormMain";
            this.Text = "SESJA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProfessorsRanking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DataGridView dataGridViewProfessorsRanking;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFailingRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnFailedStudentsCount;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.TextBox textBoxSummary;
        private System.Windows.Forms.Label labelTOP3List;
        private System.Windows.Forms.Label labelAverageFailingRatio;
        private System.Windows.Forms.TextBox textBoxAverageFailingRatio;
        private System.Windows.Forms.Label labelAvailableResources;
        private System.Windows.Forms.Label labelLowerDeficitBy1ECTS;
        private System.Windows.Forms.Label labelLowerDeficitTo10ECTS;
        private System.Windows.Forms.Label labelExamByPowerfulProfesor;
        private System.Windows.Forms.Label labelTwoParalellExams;
        private System.Windows.Forms.Label labelUnexpectedRoomChange;
        private System.Windows.Forms.Button buttonUse1ECTSReduction;
        private System.Windows.Forms.Button buttonUse10ECTSReduction;
        private System.Windows.Forms.Button buttonUsePowerfulProfesorExam;
        private System.Windows.Forms.Button buttonUseTwoParalellExams;
        private System.Windows.Forms.Button buttonUseUnexpectedRoomChange;
        private System.Windows.Forms.Label label1ECTSReductionLeft;
        private System.Windows.Forms.Label label10ECTSReductionLeft;
        private System.Windows.Forms.Label labelPowerfulProfesorExamLeft;
        private System.Windows.Forms.Label labelTwoParalellExamsLeft;
        private System.Windows.Forms.Label labelUnexpectedRoomChangeLeft;
        private System.Windows.Forms.Label labelCurrentDate;
        private System.Windows.Forms.Timer timerSessionTimer;
        private System.Windows.Forms.Label labelDaysLeft;
    }
}

