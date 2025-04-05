namespace JobSearchExcelFileTool
{
    partial class CreateDirectory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDirectory));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.folderName = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.folderBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this._browseDirectory = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // folderName
            // 
            this.folderName.AcceptsReturn = true;
            resources.ApplyResources(this.folderName, "folderName");
            this.folderName.Name = "folderName";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // _browseDirectory
            // 
            resources.ApplyResources(this._browseDirectory, "_browseDirectory");
            this._browseDirectory.Name = "_browseDirectory";
            this._browseDirectory.UseVisualStyleBackColor = true;
            this._browseDirectory.Click += new System.EventHandler(this._browseDirectory_Click);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // CreateDirectory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._browseDirectory);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.folderName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateDirectory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox folderName;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowse;
        private System.Windows.Forms.Button _browseDirectory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}