namespace JobSearchExcelFileTool
{
    partial class MainForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.companyName = new System.Windows.Forms.TextBox();
            this.specialNote = new System.Windows.Forms.TextBox();
            this.talentAcqusition = new System.Windows.Forms.TextBox();
            this.jobDescription = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._statusSelection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.companyLink = new System.Windows.Forms.TextBox();
            this.dateApplied = new System.Windows.Forms.DateTimePicker();
            this.clear = new System.Windows.Forms.Button();
            this.OpenDirectoryDialog = new System.Windows.Forms.Button();
            this.openMessageTemplate = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this._searchCompanyName = new System.Windows.Forms.TextBox();
            this._searchSpecialNote = new System.Windows.Forms.TextBox();
            this._searchTalentAcqu = new System.Windows.Forms.TextBox();
            this._searchCareerPage = new System.Windows.Forms.TextBox();
            this._searchLinkedinPage = new System.Windows.Forms.TextBox();
            this.saveSerachButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.excelFilePathLabel = new System.Windows.Forms.Label();
            this.excelSecondFilePathLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SaveButton.Location = new System.Drawing.Point(26, 697);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveExcelFileFromInput);
            // 
            // companyName
            // 
            this.companyName.Location = new System.Drawing.Point(30, 170);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(292, 20);
            this.companyName.TabIndex = 1;
            // 
            // specialNote
            // 
            this.specialNote.Location = new System.Drawing.Point(30, 211);
            this.specialNote.Name = "specialNote";
            this.specialNote.Size = new System.Drawing.Size(292, 20);
            this.specialNote.TabIndex = 2;
            // 
            // talentAcqusition
            // 
            this.talentAcqusition.Location = new System.Drawing.Point(30, 479);
            this.talentAcqusition.Name = "talentAcqusition";
            this.talentAcqusition.Size = new System.Drawing.Size(292, 20);
            this.talentAcqusition.TabIndex = 3;
            // 
            // jobDescription
            // 
            this.jobDescription.Location = new System.Drawing.Point(30, 264);
            this.jobDescription.Name = "jobDescription";
            this.jobDescription.Size = new System.Drawing.Size(475, 180);
            this.jobDescription.TabIndex = 4;
            this.jobDescription.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Company name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Special Note";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Application Status";
            // 
            // _statusSelection
            // 
            this._statusSelection.FormattingEnabled = true;
            this._statusSelection.Location = new System.Drawing.Point(360, 171);
            this._statusSelection.Name = "_statusSelection";
            this._statusSelection.Size = new System.Drawing.Size(121, 21);
            this._statusSelection.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Job Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Talent Acquisition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Company job posting link";
            // 
            // companyLink
            // 
            this.companyLink.Location = new System.Drawing.Point(30, 525);
            this.companyLink.Name = "companyLink";
            this.companyLink.Size = new System.Drawing.Size(289, 20);
            this.companyLink.TabIndex = 12;
            // 
            // dateApplied
            // 
            this.dateApplied.Location = new System.Drawing.Point(240, 700);
            this.dateApplied.Name = "dateApplied";
            this.dateApplied.Size = new System.Drawing.Size(135, 20);
            this.dateApplied.TabIndex = 13;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Silver;
            this.clear.Location = new System.Drawing.Point(129, 697);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 15;
            this.clear.Text = "Clear Form";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // OpenDirectoryDialog
            // 
            this.OpenDirectoryDialog.BackColor = System.Drawing.Color.White;
            this.OpenDirectoryDialog.ForeColor = System.Drawing.Color.Black;
            this.OpenDirectoryDialog.Location = new System.Drawing.Point(23, 12);
            this.OpenDirectoryDialog.Name = "OpenDirectoryDialog";
            this.OpenDirectoryDialog.Size = new System.Drawing.Size(124, 23);
            this.OpenDirectoryDialog.TabIndex = 18;
            this.OpenDirectoryDialog.Text = "Create Folder";
            this.OpenDirectoryDialog.UseVisualStyleBackColor = false;
            this.OpenDirectoryDialog.Click += new System.EventHandler(this.OpenDirectoryDialog_Click);
            // 
            // openMessageTemplate
            // 
            this.openMessageTemplate.BackColor = System.Drawing.Color.Transparent;
            this.openMessageTemplate.Location = new System.Drawing.Point(403, 12);
            this.openMessageTemplate.Name = "openMessageTemplate";
            this.openMessageTemplate.Size = new System.Drawing.Size(113, 23);
            this.openMessageTemplate.TabIndex = 19;
            this.openMessageTemplate.Text = " Message Template";
            this.openMessageTemplate.UseVisualStyleBackColor = false;
            this.openMessageTemplate.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(522, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(480, 728);
            this.splitter1.TabIndex = 20;
            this.splitter1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(675, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Company Research";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(605, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Company Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(605, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Special Note";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(605, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Talent Acquisition";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(605, 366);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Career Page";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(605, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Linkedin Pgae";
            // 
            // _searchCompanyName
            // 
            this._searchCompanyName.Location = new System.Drawing.Point(608, 170);
            this._searchCompanyName.Name = "_searchCompanyName";
            this._searchCompanyName.Size = new System.Drawing.Size(325, 20);
            this._searchCompanyName.TabIndex = 27;
            // 
            // _searchSpecialNote
            // 
            this._searchSpecialNote.Location = new System.Drawing.Point(608, 240);
            this._searchSpecialNote.Name = "_searchSpecialNote";
            this._searchSpecialNote.Size = new System.Drawing.Size(325, 20);
            this._searchSpecialNote.TabIndex = 28;
            // 
            // _searchTalentAcqu
            // 
            this._searchTalentAcqu.Location = new System.Drawing.Point(608, 307);
            this._searchTalentAcqu.Name = "_searchTalentAcqu";
            this._searchTalentAcqu.Size = new System.Drawing.Size(325, 20);
            this._searchTalentAcqu.TabIndex = 29;
            // 
            // _searchCareerPage
            // 
            this._searchCareerPage.Location = new System.Drawing.Point(608, 382);
            this._searchCareerPage.Name = "_searchCareerPage";
            this._searchCareerPage.Size = new System.Drawing.Size(325, 20);
            this._searchCareerPage.TabIndex = 30;
            // 
            // _searchLinkedinPage
            // 
            this._searchLinkedinPage.Location = new System.Drawing.Point(608, 447);
            this._searchLinkedinPage.Name = "_searchLinkedinPage";
            this._searchLinkedinPage.Size = new System.Drawing.Size(325, 20);
            this._searchLinkedinPage.TabIndex = 31;
            // 
            // saveSerachButton
            // 
            this.saveSerachButton.Location = new System.Drawing.Point(608, 693);
            this.saveSerachButton.Name = "saveSerachButton";
            this.saveSerachButton.Size = new System.Drawing.Size(98, 23);
            this.saveSerachButton.TabIndex = 32;
            this.saveSerachButton.Text = "Save";
            this.saveSerachButton.UseVisualStyleBackColor = true;
            this.saveSerachButton.Click += new System.EventHandler(this.saveSerachButton_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Location = new System.Drawing.Point(835, 693);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(98, 23);
            this.clearSearchButton.TabIndex = 33;
            this.clearSearchButton.Text = "Clear";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.clearSearchButton_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(184, 57);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 22);
            this.label13.TabIndex = 34;
            this.label13.Text = "Applied Status";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 37;
            this.button1.Text = "Select Excel File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // excelFilePathLabel
            // 
            this.excelFilePathLabel.AutoSize = true;
            this.excelFilePathLabel.ForeColor = System.Drawing.Color.Red;
            this.excelFilePathLabel.Location = new System.Drawing.Point(24, 102);
            this.excelFilePathLabel.Name = "excelFilePathLabel";
            this.excelFilePathLabel.Size = new System.Drawing.Size(67, 13);
            this.excelFilePathLabel.TabIndex = 36;
            this.excelFilePathLabel.Text = "LabelAppear";
            // 
            // excelSecondFilePathLabel
            // 
            this.excelSecondFilePathLabel.AutoSize = true;
            this.excelSecondFilePathLabel.ForeColor = System.Drawing.Color.Red;
            this.excelSecondFilePathLabel.Location = new System.Drawing.Point(611, 102);
            this.excelSecondFilePathLabel.Name = "excelSecondFilePathLabel";
            this.excelSecondFilePathLabel.Size = new System.Drawing.Size(67, 13);
            this.excelSecondFilePathLabel.TabIndex = 38;
            this.excelSecondFilePathLabel.Text = "LabelAppear";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(611, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(318, 13);
            this.label14.TabIndex = 39;
            this.label14.Text = "\"Please note, information will be saved in the same file in Sheet 2\"";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1002, 728);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.excelSecondFilePathLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.excelFilePathLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.saveSerachButton);
            this.Controls.Add(this._searchLinkedinPage);
            this.Controls.Add(this._searchCareerPage);
            this.Controls.Add(this._searchTalentAcqu);
            this.Controls.Add(this._searchSpecialNote);
            this.Controls.Add(this._searchCompanyName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.openMessageTemplate);
            this.Controls.Add(this.OpenDirectoryDialog);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.dateApplied);
            this.Controls.Add(this.companyLink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._statusSelection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jobDescription);
            this.Controls.Add(this.talentAcqusition);
            this.Controls.Add(this.specialNote);
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.SaveButton);
            this.Name = "MainForm";
            this.Text = "Utility for Job Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.TextBox specialNote;
        private System.Windows.Forms.TextBox talentAcqusition;
        private System.Windows.Forms.RichTextBox jobDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox _statusSelection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox companyLink;
        private System.Windows.Forms.DateTimePicker dateApplied;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button OpenDirectoryCreation;
        private System.Windows.Forms.Button OpenDirectoryDialog;
        private System.Windows.Forms.Button openMessageTemplate;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _searchCompanyName;
        private System.Windows.Forms.TextBox _searchSpecialNote;
        private System.Windows.Forms.TextBox _searchTalentAcqu;
        private System.Windows.Forms.TextBox _searchCareerPage;
        private System.Windows.Forms.TextBox _searchLinkedinPage;
        private System.Windows.Forms.Button saveSerachButton;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label excelFilePathLabel;
        private System.Windows.Forms.Label excelSecondFilePathLabel;
        private System.Windows.Forms.Label label14;
    }
}

