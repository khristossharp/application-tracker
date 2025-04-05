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

namespace JobSearchExcelFileTool
{
    public partial class MessageFollowUp: Form
    {   
        MessageType message = new MessageType();
        
        public MessageFollowUp()
        {
            InitializeComponent();
           
            _selectMessageType.Items.AddRange(message.messageType);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listOfResponses = message.GetPredefinedData();
            responseBox.Text = listOfResponses[_selectMessageType.SelectedIndex];

        }
    }
}
