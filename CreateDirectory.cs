using JobSearchExcelFileTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JobSearchExcelFileTool
{
    public partial class CreateDirectory : Form
    {
        private string folderPath = string.Empty;
        public CreateDirectory()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(folderPath))
            {
                MessageBox.Show("Please select directory to where to save folder");
            }
            else 
            { 

            var directoryFileObj = new DirectoryFile(folderPath);
            if(string.IsNullOrWhiteSpace(folderName.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK);
                folderName.Focus();
                return;
            }else 
            {
                MessageBox.Show(directoryFileObj.CreateFileInDirectory(folderName.Text));
            }

            folderName.Text = string.Empty;

            }
        }

        private void _browseDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowse = new FolderBrowserDialog();
            if(folderBrowse.ShowDialog() == DialogResult.OK)
            {
                folderPath = folderBrowse.SelectedPath;  
                label4.Text = folderPath;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
