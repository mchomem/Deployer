namespace Deployer.Views
{
    partial class SetupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            folderBrowserDialog = new FolderBrowserDialog();
            tabControl = new TabControl();
            tabPageMaintenance = new TabPage();
            groupBoxIgnoredExactFileName = new GroupBox();
            buttonRemoveIgnoredExactFileName = new Button();
            buttonAddIgnoredExactFileName = new Button();
            listBoxIgnoredExactFileName = new ListBox();
            textBoxIgnoredExactFileName = new TextBox();
            groupBoxIgnoredExtensionsFile = new GroupBox();
            buttonRemoveIgnoredExtensionsFile = new Button();
            buttonAddIgnoredExtensionsFile = new Button();
            listBoxIgnoredExtensionsFile = new ListBox();
            textBoxIgnoredExtensionsFile = new TextBox();
            buttonClearValueDestinationPath = new Button();
            buttonClearValueOriginPath = new Button();
            buttonSave = new Button();
            buttonChooseDestinationPath = new Button();
            textBoxDestinationPath = new TextBox();
            labelDestinationPath = new Label();
            buttonChooseOriginPath = new Button();
            labelOriginPath = new Label();
            textBoxOriginPath = new TextBox();
            tabPageJsonContent = new TabPage();
            textBoxContentJsonFile = new TextBox();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelCreatedAt = new ToolStripStatusLabel();
            toolStripStatusLabelCreatedAtValue = new ToolStripStatusLabel();
            toolStripStatusLabelUpdatedAt = new ToolStripStatusLabel();
            toolStripStatusLabelUpdatedAtValue = new ToolStripStatusLabel();
            tabControl.SuspendLayout();
            tabPageMaintenance.SuspendLayout();
            groupBoxIgnoredExactFileName.SuspendLayout();
            groupBoxIgnoredExtensionsFile.SuspendLayout();
            tabPageJsonContent.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageMaintenance);
            tabControl.Controls.Add(tabPageJsonContent);
            tabControl.Location = new Point(12, 12);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1010, 580);
            tabControl.TabIndex = 10;
            // 
            // tabPageMaintenance
            // 
            tabPageMaintenance.Controls.Add(groupBoxIgnoredExactFileName);
            tabPageMaintenance.Controls.Add(groupBoxIgnoredExtensionsFile);
            tabPageMaintenance.Controls.Add(buttonClearValueDestinationPath);
            tabPageMaintenance.Controls.Add(buttonClearValueOriginPath);
            tabPageMaintenance.Controls.Add(buttonSave);
            tabPageMaintenance.Controls.Add(buttonChooseDestinationPath);
            tabPageMaintenance.Controls.Add(textBoxDestinationPath);
            tabPageMaintenance.Controls.Add(labelDestinationPath);
            tabPageMaintenance.Controls.Add(buttonChooseOriginPath);
            tabPageMaintenance.Controls.Add(labelOriginPath);
            tabPageMaintenance.Controls.Add(textBoxOriginPath);
            tabPageMaintenance.Location = new Point(4, 29);
            tabPageMaintenance.Name = "tabPageMaintenance";
            tabPageMaintenance.Padding = new Padding(3);
            tabPageMaintenance.Size = new Size(1002, 547);
            tabPageMaintenance.TabIndex = 0;
            tabPageMaintenance.Text = "Maintenance";
            tabPageMaintenance.UseVisualStyleBackColor = true;
            // 
            // groupBoxIgnoredExactFileName
            // 
            groupBoxIgnoredExactFileName.Controls.Add(buttonRemoveIgnoredExactFileName);
            groupBoxIgnoredExactFileName.Controls.Add(buttonAddIgnoredExactFileName);
            groupBoxIgnoredExactFileName.Controls.Add(listBoxIgnoredExactFileName);
            groupBoxIgnoredExactFileName.Controls.Add(textBoxIgnoredExactFileName);
            groupBoxIgnoredExactFileName.Location = new Point(357, 159);
            groupBoxIgnoredExactFileName.Name = "groupBoxIgnoredExactFileName";
            groupBoxIgnoredExactFileName.Size = new Size(300, 369);
            groupBoxIgnoredExactFileName.TabIndex = 10;
            groupBoxIgnoredExactFileName.TabStop = false;
            groupBoxIgnoredExactFileName.Text = "Ignored Exact File Name";
            // 
            // buttonRemoveIgnoredExactFileName
            // 
            buttonRemoveIgnoredExactFileName.Location = new Point(172, 129);
            buttonRemoveIgnoredExactFileName.Name = "buttonRemoveIgnoredExactFileName";
            buttonRemoveIgnoredExactFileName.Size = new Size(94, 29);
            buttonRemoveIgnoredExactFileName.TabIndex = 3;
            buttonRemoveIgnoredExactFileName.Text = "Remove";
            buttonRemoveIgnoredExactFileName.UseVisualStyleBackColor = true;
            buttonRemoveIgnoredExactFileName.Click += buttonRemoveIgnoredExactFileName_Click;
            // 
            // buttonAddIgnoredExactFileName
            // 
            buttonAddIgnoredExactFileName.Location = new Point(172, 94);
            buttonAddIgnoredExactFileName.Name = "buttonAddIgnoredExactFileName";
            buttonAddIgnoredExactFileName.Size = new Size(94, 29);
            buttonAddIgnoredExactFileName.TabIndex = 2;
            buttonAddIgnoredExactFileName.Text = "Add";
            buttonAddIgnoredExactFileName.UseVisualStyleBackColor = true;
            buttonAddIgnoredExactFileName.Click += buttonAddIgnoredExactFileName_Click;
            // 
            // listBoxIgnoredExactFileName
            // 
            listBoxIgnoredExactFileName.FormattingEnabled = true;
            listBoxIgnoredExactFileName.Location = new Point(6, 94);
            listBoxIgnoredExactFileName.Name = "listBoxIgnoredExactFileName";
            listBoxIgnoredExactFileName.SelectionMode = SelectionMode.MultiSimple;
            listBoxIgnoredExactFileName.Size = new Size(150, 244);
            listBoxIgnoredExactFileName.TabIndex = 1;
            // 
            // textBoxIgnoredExactFileName
            // 
            textBoxIgnoredExactFileName.Location = new Point(6, 39);
            textBoxIgnoredExactFileName.Name = "textBoxIgnoredExactFileName";
            textBoxIgnoredExactFileName.Size = new Size(269, 27);
            textBoxIgnoredExactFileName.TabIndex = 0;
            textBoxIgnoredExactFileName.KeyPress += textBoxIgnoredExactFileName_KeyPress;
            // 
            // groupBoxIgnoredExtensionsFile
            // 
            groupBoxIgnoredExtensionsFile.Controls.Add(buttonRemoveIgnoredExtensionsFile);
            groupBoxIgnoredExtensionsFile.Controls.Add(buttonAddIgnoredExtensionsFile);
            groupBoxIgnoredExtensionsFile.Controls.Add(listBoxIgnoredExtensionsFile);
            groupBoxIgnoredExtensionsFile.Controls.Add(textBoxIgnoredExtensionsFile);
            groupBoxIgnoredExtensionsFile.Location = new Point(6, 159);
            groupBoxIgnoredExtensionsFile.Name = "groupBoxIgnoredExtensionsFile";
            groupBoxIgnoredExtensionsFile.Size = new Size(300, 369);
            groupBoxIgnoredExtensionsFile.TabIndex = 20;
            groupBoxIgnoredExtensionsFile.TabStop = false;
            groupBoxIgnoredExtensionsFile.Text = "Ignored Extensions File";
            // 
            // buttonRemoveIgnoredExtensionsFile
            // 
            buttonRemoveIgnoredExtensionsFile.Location = new Point(193, 129);
            buttonRemoveIgnoredExtensionsFile.Name = "buttonRemoveIgnoredExtensionsFile";
            buttonRemoveIgnoredExtensionsFile.Size = new Size(94, 29);
            buttonRemoveIgnoredExtensionsFile.TabIndex = 3;
            buttonRemoveIgnoredExtensionsFile.Text = "Remove";
            buttonRemoveIgnoredExtensionsFile.UseVisualStyleBackColor = true;
            buttonRemoveIgnoredExtensionsFile.Click += buttonRemoveIgnoredExtensionsFile_Click;
            // 
            // buttonAddIgnoredExtensionsFile
            // 
            buttonAddIgnoredExtensionsFile.Location = new Point(193, 94);
            buttonAddIgnoredExtensionsFile.Name = "buttonAddIgnoredExtensionsFile";
            buttonAddIgnoredExtensionsFile.Size = new Size(94, 29);
            buttonAddIgnoredExtensionsFile.TabIndex = 2;
            buttonAddIgnoredExtensionsFile.Text = "Add";
            buttonAddIgnoredExtensionsFile.UseVisualStyleBackColor = true;
            buttonAddIgnoredExtensionsFile.Click += buttonAddIgnoredExtensionsFile_Click;
            // 
            // listBoxIgnoredExtensionsFile
            // 
            listBoxIgnoredExtensionsFile.FormattingEnabled = true;
            listBoxIgnoredExtensionsFile.Location = new Point(18, 94);
            listBoxIgnoredExtensionsFile.Name = "listBoxIgnoredExtensionsFile";
            listBoxIgnoredExtensionsFile.SelectionMode = SelectionMode.MultiSimple;
            listBoxIgnoredExtensionsFile.Size = new Size(150, 244);
            listBoxIgnoredExtensionsFile.TabIndex = 1;
            // 
            // textBoxIgnoredExtensionsFile
            // 
            textBoxIgnoredExtensionsFile.Location = new Point(18, 39);
            textBoxIgnoredExtensionsFile.Name = "textBoxIgnoredExtensionsFile";
            textBoxIgnoredExtensionsFile.Size = new Size(269, 27);
            textBoxIgnoredExtensionsFile.TabIndex = 0;
            textBoxIgnoredExtensionsFile.KeyPress += textBoxIgnoredExtensionsFile_KeyPress;
            // 
            // buttonClearValueDestinationPath
            // 
            buttonClearValueDestinationPath.Location = new Point(894, 111);
            buttonClearValueDestinationPath.Name = "buttonClearValueDestinationPath";
            buttonClearValueDestinationPath.Size = new Size(94, 29);
            buttonClearValueDestinationPath.TabIndex = 19;
            buttonClearValueDestinationPath.Text = "Clear";
            buttonClearValueDestinationPath.UseVisualStyleBackColor = true;
            buttonClearValueDestinationPath.Click += buttonClearValueDestinationPath_Click;
            // 
            // buttonClearValueOriginPath
            // 
            buttonClearValueOriginPath.Location = new Point(894, 41);
            buttonClearValueOriginPath.Name = "buttonClearValueOriginPath";
            buttonClearValueOriginPath.Size = new Size(94, 29);
            buttonClearValueOriginPath.TabIndex = 18;
            buttonClearValueOriginPath.Text = "Clear";
            buttonClearValueOriginPath.UseVisualStyleBackColor = true;
            buttonClearValueOriginPath.Click += buttonClearValueOriginPath_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(894, 499);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 17;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonChooseDestinationPath
            // 
            buttonChooseDestinationPath.Location = new Point(859, 110);
            buttonChooseDestinationPath.Name = "buttonChooseDestinationPath";
            buttonChooseDestinationPath.Size = new Size(29, 29);
            buttonChooseDestinationPath.TabIndex = 16;
            buttonChooseDestinationPath.Text = "...";
            buttonChooseDestinationPath.UseVisualStyleBackColor = true;
            buttonChooseDestinationPath.Click += buttonChooseDestinationPath_Click;
            // 
            // textBoxDestinationPath
            // 
            textBoxDestinationPath.Location = new Point(6, 111);
            textBoxDestinationPath.Name = "textBoxDestinationPath";
            textBoxDestinationPath.ReadOnly = true;
            textBoxDestinationPath.Size = new Size(847, 27);
            textBoxDestinationPath.TabIndex = 15;
            // 
            // labelDestinationPath
            // 
            labelDestinationPath.AutoSize = true;
            labelDestinationPath.Location = new Point(6, 88);
            labelDestinationPath.Name = "labelDestinationPath";
            labelDestinationPath.Size = new Size(120, 20);
            labelDestinationPath.TabIndex = 14;
            labelDestinationPath.Text = "Destination Path:";
            // 
            // buttonChooseOriginPath
            // 
            buttonChooseOriginPath.Location = new Point(859, 42);
            buttonChooseOriginPath.Name = "buttonChooseOriginPath";
            buttonChooseOriginPath.Size = new Size(29, 29);
            buttonChooseOriginPath.TabIndex = 13;
            buttonChooseOriginPath.Text = "...";
            buttonChooseOriginPath.UseVisualStyleBackColor = true;
            buttonChooseOriginPath.Click += buttonChooseOriginPath_Click;
            // 
            // labelOriginPath
            // 
            labelOriginPath.AutoSize = true;
            labelOriginPath.Location = new Point(6, 12);
            labelOriginPath.Name = "labelOriginPath";
            labelOriginPath.Size = new Size(85, 20);
            labelOriginPath.TabIndex = 12;
            labelOriginPath.Text = "Origin Path:";
            // 
            // textBoxOriginPath
            // 
            textBoxOriginPath.Location = new Point(6, 43);
            textBoxOriginPath.Name = "textBoxOriginPath";
            textBoxOriginPath.ReadOnly = true;
            textBoxOriginPath.Size = new Size(847, 27);
            textBoxOriginPath.TabIndex = 11;
            // 
            // tabPageJsonContent
            // 
            tabPageJsonContent.Controls.Add(textBoxContentJsonFile);
            tabPageJsonContent.Location = new Point(4, 29);
            tabPageJsonContent.Name = "tabPageJsonContent";
            tabPageJsonContent.Padding = new Padding(3);
            tabPageJsonContent.Size = new Size(1002, 547);
            tabPageJsonContent.TabIndex = 1;
            tabPageJsonContent.Text = "Json Content";
            tabPageJsonContent.UseVisualStyleBackColor = true;
            // 
            // textBoxContentJsonFile
            // 
            textBoxContentJsonFile.Location = new Point(6, 6);
            textBoxContentJsonFile.Multiline = true;
            textBoxContentJsonFile.Name = "textBoxContentJsonFile";
            textBoxContentJsonFile.ReadOnly = true;
            textBoxContentJsonFile.Size = new Size(990, 535);
            textBoxContentJsonFile.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCreatedAt, toolStripStatusLabelCreatedAtValue, toolStripStatusLabelUpdatedAt, toolStripStatusLabelUpdatedAtValue });
            statusStrip1.Location = new Point(0, 604);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1036, 26);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCreatedAt
            // 
            toolStripStatusLabelCreatedAt.Name = "toolStripStatusLabelCreatedAt";
            toolStripStatusLabelCreatedAt.Size = new Size(81, 20);
            toolStripStatusLabelCreatedAt.Text = "Created at:";
            // 
            // toolStripStatusLabelCreatedAtValue
            // 
            toolStripStatusLabelCreatedAtValue.Name = "toolStripStatusLabelCreatedAtValue";
            toolStripStatusLabelCreatedAtValue.Size = new Size(143, 20);
            toolStripStatusLabelCreatedAtValue.Text = "00/00/0000 00:00:00";
            // 
            // toolStripStatusLabelUpdatedAt
            // 
            toolStripStatusLabelUpdatedAt.Name = "toolStripStatusLabelUpdatedAt";
            toolStripStatusLabelUpdatedAt.Size = new Size(87, 20);
            toolStripStatusLabelUpdatedAt.Text = "Updated at:";
            // 
            // toolStripStatusLabelUpdatedAtValue
            // 
            toolStripStatusLabelUpdatedAtValue.Name = "toolStripStatusLabelUpdatedAtValue";
            toolStripStatusLabelUpdatedAtValue.Size = new Size(143, 20);
            toolStripStatusLabelUpdatedAtValue.Text = "00/00/0000 00:00:00";
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 630);
            Controls.Add(statusStrip1);
            Controls.Add(tabControl);
            Name = "SetupForm";
            Text = "Deployer - Setup";
            Load += SetupForm_Load;
            tabControl.ResumeLayout(false);
            tabPageMaintenance.ResumeLayout(false);
            tabPageMaintenance.PerformLayout();
            groupBoxIgnoredExactFileName.ResumeLayout(false);
            groupBoxIgnoredExactFileName.PerformLayout();
            groupBoxIgnoredExtensionsFile.ResumeLayout(false);
            groupBoxIgnoredExtensionsFile.PerformLayout();
            tabPageJsonContent.ResumeLayout(false);
            tabPageJsonContent.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FolderBrowserDialog folderBrowserDialog;
        private TabControl tabControl;
        private TabPage tabPageMaintenance;
        private TabPage tabPageJsonContent;
        private TextBox textBoxContentJsonFile;
        private GroupBox groupBoxIgnoredExactFileName;
        private Button buttonRemoveIgnoredExactFileName;
        private Button buttonAddIgnoredExactFileName;
        private ListBox listBoxIgnoredExactFileName;
        private TextBox textBoxIgnoredExactFileName;
        private GroupBox groupBoxIgnoredExtensionsFile;
        private Button buttonRemoveIgnoredExtensionsFile;
        private Button buttonAddIgnoredExtensionsFile;
        private ListBox listBoxIgnoredExtensionsFile;
        private TextBox textBoxIgnoredExtensionsFile;
        private Button buttonClearValueDestinationPath;
        private Button buttonClearValueOriginPath;
        private Button buttonSave;
        private Button buttonChooseDestinationPath;
        private TextBox textBoxDestinationPath;
        private Label labelDestinationPath;
        private Button buttonChooseOriginPath;
        private Label labelOriginPath;
        private TextBox textBoxOriginPath;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelCreatedAt;
        private ToolStripStatusLabel toolStripStatusLabelCreatedAtValue;
        private ToolStripStatusLabel toolStripStatusLabelUpdatedAt;
        private ToolStripStatusLabel toolStripStatusLabelUpdatedAtValue;
    }
}
