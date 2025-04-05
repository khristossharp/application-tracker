using System;
using JobSearchExcelFileTool;
using System.Collections.Generic;
using System.Linq;

using System.Windows.Forms;


namespace JobSearchExcelFileTool
{
    public partial class MainForm : Form
    {
        private string[] _excelExtensions = { ".xls", ".xlsx", ".xlsm", ".xlsb" };
        private string _excelFullFilePath = string.Empty;
        private string _excelFileName = string.Empty;

        public MainForm()
        {
            InitializeComponent();
            dateApplied.Text = DateTime.Now.ToString("d");
            excelFilePathLabel.Visible = false;
            excelSecondFilePathLabel.Visible = false;
            _statusSelection.Items.AddRange(new string[] { "Applied", "Need to Apply" });

            _excelFullFilePath =  Properties.Settings.Default.LastFullFilePath;
            _excelFileName = Properties.Settings.Default.LastFileName;

            if (!string.IsNullOrEmpty(_excelFileName))
            {
                //Display cacheable file name
                excelFilePathLabel.Text = _excelFileName;
                excelFilePathLabel.Visible = true;

                excelSecondFilePathLabel.Text = _excelFileName;
                excelSecondFilePathLabel.Visible = true;
            }

        }

        //Select file function
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!_excelExtensions.Any(ex => dialog.SafeFileName.Contains(ex)))
                {
                    MessageBox.Show("Program accept only: .xls, .xlsx, .xlsm, .xlsb");
                    return;
                }
            }

            if (string.IsNullOrEmpty(_excelFullFilePath) || _excelFileName != dialog.SafeFileName)
            {
                //Storing file path in settings program 
                Properties.Settings.Default.LastFullFilePath = dialog.FileName;
                Properties.Settings.Default.LastFileName = dialog.SafeFileName;
                Properties.Settings.Default.Save();
                //end 

                _excelFullFilePath = dialog.FileName;

                excelFilePathLabel.Text = "File Name: " + dialog.SafeFileName;
                excelFilePathLabel.Visible = true;

                excelSecondFilePathLabel.Text = "File Name: " + dialog.SafeFileName;
                excelSecondFilePathLabel.Visible = true;
            }

           
        }

        // Applied form Save record section 
        private void SaveExcelFileFromInput(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(_excelFullFilePath))
            {
                MessageBox.Show("Please selected the file");
                return;
            }

            

            Excel excel = new Excel(_excelFullFilePath);

            string appliedStatus = (_statusSelection.SelectedItem == null) ? "Applied" : _statusSelection.SelectedItem.ToString();

            List<string> listOfResults = new List<string>()
            { companyName.Text , specialNote.Text, appliedStatus, jobDescription.Text,talentAcqusition.Text,companyLink.Text, dateApplied.Text };

            excel.FindEmptyCellInFirstColumn(listOfResults);
            MessageBox.Show("Succesfully saved");
        }
        //clear form

        private void clear_Click(object sender, EventArgs e)
        {
            companyName.Text = specialNote.Text =jobDescription.Text = talentAcqusition.Text =companyLink.Text = dateApplied.Text = string.Empty;
        }
        //end applied form


        //Company Search section
        private void saveSerachButton_Click(object sender, EventArgs e)
        {
            Excel excel = new Excel(_excelFullFilePath, 2);
            List<string> listOfSearchValues = new List<string>()
            { _searchCompanyName.Text, _searchSpecialNote.Text, _searchTalentAcqu.Text ,_searchCareerPage.Text,  _searchLinkedinPage.Text};
            excel.FindEmptyCellInFirstColumn(listOfSearchValues);
            MessageBox.Show("Succesfully saved");
        }
        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            _searchCompanyName.Text = _searchSpecialNote.Text = _searchTalentAcqu.Text  = _searchCareerPage.Text =   _searchLinkedinPage.Text = string.Empty;
        }
        //end section


        //Open Directory utility
        private void OpenDirectoryDialog_Click(object sender, EventArgs e)
        {
            var directory = new CreateDirectory();
            directory.ShowDialog();
        }
        

        //Message FollowUp
        private void button1_Click(object sender, EventArgs e)
        {
            var templates = new MessageFollowUp();
            templates.ShowDialog();
        }
        //end
      


    }
}
