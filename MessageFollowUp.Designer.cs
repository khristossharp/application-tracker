namespace JobSearchExcelFileTool
{
    partial class MessageFollowUp
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
            this._selectMessageType = new System.Windows.Forms.ComboBox();
            this.responseBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _selectMessageType
            // 
            this._selectMessageType.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._selectMessageType.FormattingEnabled = true;
            this._selectMessageType.ItemHeight = 22;
            this._selectMessageType.Location = new System.Drawing.Point(64, 102);
            this._selectMessageType.Name = "_selectMessageType";
            this._selectMessageType.Size = new System.Drawing.Size(444, 30);
            this._selectMessageType.TabIndex = 0;
            this._selectMessageType.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // responseBox
            // 
            this.responseBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseBox.Location = new System.Drawing.Point(63, 185);
            this.responseBox.Name = "responseBox";
            this.responseBox.ReadOnly = true;
            this.responseBox.Size = new System.Drawing.Size(702, 178);
            this.responseBox.TabIndex = 1;
            this.responseBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Message Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Message template response";
            // 
            // MessageFollowUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 642);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this._selectMessageType);
            this.Name = "MessageFollowUp";
            this.Text = "MessageFollowUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _selectMessageType;
        private System.Windows.Forms.RichTextBox responseBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}