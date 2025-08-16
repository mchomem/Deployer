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
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            textBoxCode = new TextBox();
            labelCode = new Label();
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
            tabControl.Location = new Point(10, 9);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(884, 524);
            tabControl.TabIndex = 10;
            // 
            // tabPageMaintenance
            // 
            tabPageMaintenance.Controls.Add(textBoxDescription);
            tabPageMaintenance.Controls.Add(labelDescription);
            tabPageMaintenance.Controls.Add(textBoxCode);
            tabPageMaintenance.Controls.Add(labelCode);
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
            tabPageMaintenance.Location = new Point(4, 24);
            tabPageMaintenance.Margin = new Padding(3, 2, 3, 2);
            tabPageMaintenance.Name = "tabPageMaintenance";
            tabPageMaintenance.Padding = new Padding(3, 2, 3, 2);
            tabPageMaintenance.Size = new Size(876, 496);
            tabPageMaintenance.TabIndex = 0;
            tabPageMaintenance.Text = "Maintenance";
            tabPageMaintenance.UseVisualStyleBackColor = true;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(256, 38);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(491, 23);
            textBoxDescription.TabIndex = 24;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(256, 20);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(70, 15);
            labelDescription.TabIndex = 23;
            labelDescription.Text = "Description:";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(6, 38);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.Size = new Size(214, 23);
            textBoxCode.TabIndex = 22;
            // 
            // labelCode
            // 
            labelCode.AutoSize = true;
            labelCode.Location = new Point(6, 20);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(38, 15);
            labelCode.TabIndex = 21;
            labelCode.Text = "Code:";
            // 
            // groupBoxIgnoredExactFileName
            // 
            groupBoxIgnoredExactFileName.Controls.Add(buttonRemoveIgnoredExactFileName);
            groupBoxIgnoredExactFileName.Controls.Add(buttonAddIgnoredExactFileName);
            groupBoxIgnoredExactFileName.Controls.Add(listBoxIgnoredExactFileName);
            groupBoxIgnoredExactFileName.Controls.Add(textBoxIgnoredExactFileName);
            groupBoxIgnoredExactFileName.Location = new Point(312, 189);
            groupBoxIgnoredExactFileName.Margin = new Padding(3, 2, 3, 2);
            groupBoxIgnoredExactFileName.Name = "groupBoxIgnoredExactFileName";
            groupBoxIgnoredExactFileName.Padding = new Padding(3, 2, 3, 2);
            groupBoxIgnoredExactFileName.Size = new Size(262, 277);
            groupBoxIgnoredExactFileName.TabIndex = 10;
            groupBoxIgnoredExactFileName.TabStop = false;
            groupBoxIgnoredExactFileName.Text = "Ignored Exact File Name";
            // 
            // buttonRemoveIgnoredExactFileName
            // 
            buttonRemoveIgnoredExactFileName.Image = Properties.Resources.delete;
            buttonRemoveIgnoredExactFileName.Location = new Point(222, 97);
            buttonRemoveIgnoredExactFileName.Margin = new Padding(3, 2, 3, 2);
            buttonRemoveIgnoredExactFileName.Name = "buttonRemoveIgnoredExactFileName";
            buttonRemoveIgnoredExactFileName.Size = new Size(30, 22);
            buttonRemoveIgnoredExactFileName.TabIndex = 3;
            buttonRemoveIgnoredExactFileName.UseVisualStyleBackColor = true;
            buttonRemoveIgnoredExactFileName.Click += buttonRemoveIgnoredExactFileName_Click;
            // 
            // buttonAddIgnoredExactFileName
            // 
            buttonAddIgnoredExactFileName.Image = Properties.Resources.add;
            buttonAddIgnoredExactFileName.Location = new Point(222, 70);
            buttonAddIgnoredExactFileName.Margin = new Padding(3, 2, 3, 2);
            buttonAddIgnoredExactFileName.Name = "buttonAddIgnoredExactFileName";
            buttonAddIgnoredExactFileName.Size = new Size(30, 22);
            buttonAddIgnoredExactFileName.TabIndex = 2;
            buttonAddIgnoredExactFileName.UseVisualStyleBackColor = true;
            buttonAddIgnoredExactFileName.Click += buttonAddIgnoredExactFileName_Click;
            // 
            // listBoxIgnoredExactFileName
            // 
            listBoxIgnoredExactFileName.FormattingEnabled = true;
            listBoxIgnoredExactFileName.ItemHeight = 15;
            listBoxIgnoredExactFileName.Location = new Point(16, 70);
            listBoxIgnoredExactFileName.Margin = new Padding(3, 2, 3, 2);
            listBoxIgnoredExactFileName.Name = "listBoxIgnoredExactFileName";
            listBoxIgnoredExactFileName.SelectionMode = SelectionMode.MultiSimple;
            listBoxIgnoredExactFileName.Size = new Size(200, 184);
            listBoxIgnoredExactFileName.TabIndex = 1;
            // 
            // textBoxIgnoredExactFileName
            // 
            textBoxIgnoredExactFileName.Location = new Point(16, 29);
            textBoxIgnoredExactFileName.Margin = new Padding(3, 2, 3, 2);
            textBoxIgnoredExactFileName.Name = "textBoxIgnoredExactFileName";
            textBoxIgnoredExactFileName.Size = new Size(236, 23);
            textBoxIgnoredExactFileName.TabIndex = 0;
            textBoxIgnoredExactFileName.KeyPress += textBoxIgnoredExactFileName_KeyPress;
            // 
            // groupBoxIgnoredExtensionsFile
            // 
            groupBoxIgnoredExtensionsFile.Controls.Add(buttonRemoveIgnoredExtensionsFile);
            groupBoxIgnoredExtensionsFile.Controls.Add(buttonAddIgnoredExtensionsFile);
            groupBoxIgnoredExtensionsFile.Controls.Add(listBoxIgnoredExtensionsFile);
            groupBoxIgnoredExtensionsFile.Controls.Add(textBoxIgnoredExtensionsFile);
            groupBoxIgnoredExtensionsFile.Location = new Point(5, 189);
            groupBoxIgnoredExtensionsFile.Margin = new Padding(3, 2, 3, 2);
            groupBoxIgnoredExtensionsFile.Name = "groupBoxIgnoredExtensionsFile";
            groupBoxIgnoredExtensionsFile.Padding = new Padding(3, 2, 3, 2);
            groupBoxIgnoredExtensionsFile.Size = new Size(262, 277);
            groupBoxIgnoredExtensionsFile.TabIndex = 20;
            groupBoxIgnoredExtensionsFile.TabStop = false;
            groupBoxIgnoredExtensionsFile.Text = "Ignored Extensions File";
            // 
            // buttonRemoveIgnoredExtensionsFile
            // 
            buttonRemoveIgnoredExtensionsFile.Image = Properties.Resources.delete;
            buttonRemoveIgnoredExtensionsFile.Location = new Point(221, 97);
            buttonRemoveIgnoredExtensionsFile.Margin = new Padding(3, 2, 3, 2);
            buttonRemoveIgnoredExtensionsFile.Name = "buttonRemoveIgnoredExtensionsFile";
            buttonRemoveIgnoredExtensionsFile.Size = new Size(30, 22);
            buttonRemoveIgnoredExtensionsFile.TabIndex = 3;
            buttonRemoveIgnoredExtensionsFile.UseVisualStyleBackColor = true;
            buttonRemoveIgnoredExtensionsFile.Click += buttonRemoveIgnoredExtensionsFile_Click;
            // 
            // buttonAddIgnoredExtensionsFile
            // 
            buttonAddIgnoredExtensionsFile.Image = Properties.Resources.add;
            buttonAddIgnoredExtensionsFile.Location = new Point(221, 70);
            buttonAddIgnoredExtensionsFile.Margin = new Padding(3, 2, 3, 2);
            buttonAddIgnoredExtensionsFile.Name = "buttonAddIgnoredExtensionsFile";
            buttonAddIgnoredExtensionsFile.Size = new Size(30, 22);
            buttonAddIgnoredExtensionsFile.TabIndex = 2;
            buttonAddIgnoredExtensionsFile.UseVisualStyleBackColor = true;
            buttonAddIgnoredExtensionsFile.Click += buttonAddIgnoredExtensionsFile_Click;
            // 
            // listBoxIgnoredExtensionsFile
            // 
            listBoxIgnoredExtensionsFile.FormattingEnabled = true;
            listBoxIgnoredExtensionsFile.ItemHeight = 15;
            listBoxIgnoredExtensionsFile.Location = new Point(16, 70);
            listBoxIgnoredExtensionsFile.Margin = new Padding(3, 2, 3, 2);
            listBoxIgnoredExtensionsFile.Name = "listBoxIgnoredExtensionsFile";
            listBoxIgnoredExtensionsFile.SelectionMode = SelectionMode.MultiSimple;
            listBoxIgnoredExtensionsFile.Size = new Size(199, 184);
            listBoxIgnoredExtensionsFile.TabIndex = 1;
            // 
            // textBoxIgnoredExtensionsFile
            // 
            textBoxIgnoredExtensionsFile.Location = new Point(16, 29);
            textBoxIgnoredExtensionsFile.Margin = new Padding(3, 2, 3, 2);
            textBoxIgnoredExtensionsFile.Name = "textBoxIgnoredExtensionsFile";
            textBoxIgnoredExtensionsFile.Size = new Size(236, 23);
            textBoxIgnoredExtensionsFile.TabIndex = 0;
            textBoxIgnoredExtensionsFile.KeyPress += textBoxIgnoredExtensionsFile_KeyPress;
            // 
            // buttonClearValueDestinationPath
            // 
            buttonClearValueDestinationPath.Location = new Point(782, 146);
            buttonClearValueDestinationPath.Margin = new Padding(3, 2, 3, 2);
            buttonClearValueDestinationPath.Name = "buttonClearValueDestinationPath";
            buttonClearValueDestinationPath.Size = new Size(82, 22);
            buttonClearValueDestinationPath.TabIndex = 19;
            buttonClearValueDestinationPath.Text = "Clear";
            buttonClearValueDestinationPath.UseVisualStyleBackColor = true;
            buttonClearValueDestinationPath.Click += buttonClearValueDestinationPath_Click;
            // 
            // buttonClearValueOriginPath
            // 
            buttonClearValueOriginPath.Location = new Point(782, 94);
            buttonClearValueOriginPath.Margin = new Padding(3, 2, 3, 2);
            buttonClearValueOriginPath.Name = "buttonClearValueOriginPath";
            buttonClearValueOriginPath.Size = new Size(82, 22);
            buttonClearValueOriginPath.TabIndex = 18;
            buttonClearValueOriginPath.Text = "Clear";
            buttonClearValueOriginPath.UseVisualStyleBackColor = true;
            buttonClearValueOriginPath.Click += buttonClearValueOriginPath_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(782, 444);
            buttonSave.Margin = new Padding(3, 2, 3, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(82, 22);
            buttonSave.TabIndex = 17;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonChooseDestinationPath
            // 
            buttonChooseDestinationPath.Location = new Point(752, 146);
            buttonChooseDestinationPath.Margin = new Padding(3, 2, 3, 2);
            buttonChooseDestinationPath.Name = "buttonChooseDestinationPath";
            buttonChooseDestinationPath.Size = new Size(25, 22);
            buttonChooseDestinationPath.TabIndex = 16;
            buttonChooseDestinationPath.Text = "...";
            buttonChooseDestinationPath.UseVisualStyleBackColor = true;
            buttonChooseDestinationPath.Click += buttonChooseDestinationPath_Click;
            // 
            // textBoxDestinationPath
            // 
            textBoxDestinationPath.Location = new Point(5, 147);
            textBoxDestinationPath.Margin = new Padding(3, 2, 3, 2);
            textBoxDestinationPath.Name = "textBoxDestinationPath";
            textBoxDestinationPath.ReadOnly = true;
            textBoxDestinationPath.Size = new Size(742, 23);
            textBoxDestinationPath.TabIndex = 15;
            // 
            // labelDestinationPath
            // 
            labelDestinationPath.AutoSize = true;
            labelDestinationPath.Location = new Point(5, 130);
            labelDestinationPath.Name = "labelDestinationPath";
            labelDestinationPath.Size = new Size(97, 15);
            labelDestinationPath.TabIndex = 14;
            labelDestinationPath.Text = "Destination Path:";
            // 
            // buttonChooseOriginPath
            // 
            buttonChooseOriginPath.Location = new Point(752, 94);
            buttonChooseOriginPath.Margin = new Padding(3, 2, 3, 2);
            buttonChooseOriginPath.Name = "buttonChooseOriginPath";
            buttonChooseOriginPath.Size = new Size(25, 22);
            buttonChooseOriginPath.TabIndex = 13;
            buttonChooseOriginPath.Text = "...";
            buttonChooseOriginPath.UseVisualStyleBackColor = true;
            buttonChooseOriginPath.Click += buttonChooseOriginPath_Click;
            // 
            // labelOriginPath
            // 
            labelOriginPath.AutoSize = true;
            labelOriginPath.Location = new Point(5, 71);
            labelOriginPath.Name = "labelOriginPath";
            labelOriginPath.Size = new Size(70, 15);
            labelOriginPath.TabIndex = 12;
            labelOriginPath.Text = "Origin Path:";
            // 
            // textBoxOriginPath
            // 
            textBoxOriginPath.Location = new Point(5, 94);
            textBoxOriginPath.Margin = new Padding(3, 2, 3, 2);
            textBoxOriginPath.Name = "textBoxOriginPath";
            textBoxOriginPath.ReadOnly = true;
            textBoxOriginPath.Size = new Size(742, 23);
            textBoxOriginPath.TabIndex = 11;
            // 
            // tabPageJsonContent
            // 
            tabPageJsonContent.Controls.Add(textBoxContentJsonFile);
            tabPageJsonContent.Location = new Point(4, 24);
            tabPageJsonContent.Margin = new Padding(3, 2, 3, 2);
            tabPageJsonContent.Name = "tabPageJsonContent";
            tabPageJsonContent.Padding = new Padding(3, 2, 3, 2);
            tabPageJsonContent.Size = new Size(876, 496);
            tabPageJsonContent.TabIndex = 1;
            tabPageJsonContent.Text = "Json Content";
            tabPageJsonContent.UseVisualStyleBackColor = true;
            // 
            // textBoxContentJsonFile
            // 
            textBoxContentJsonFile.Location = new Point(5, 4);
            textBoxContentJsonFile.Margin = new Padding(3, 2, 3, 2);
            textBoxContentJsonFile.Multiline = true;
            textBoxContentJsonFile.Name = "textBoxContentJsonFile";
            textBoxContentJsonFile.ReadOnly = true;
            textBoxContentJsonFile.Size = new Size(867, 402);
            textBoxContentJsonFile.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCreatedAt, toolStripStatusLabelCreatedAtValue, toolStripStatusLabelUpdatedAt, toolStripStatusLabelUpdatedAtValue });
            statusStrip1.Location = new Point(0, 535);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(906, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCreatedAt
            // 
            toolStripStatusLabelCreatedAt.Name = "toolStripStatusLabelCreatedAt";
            toolStripStatusLabelCreatedAt.Size = new Size(64, 17);
            toolStripStatusLabelCreatedAt.Text = "Created at:";
            // 
            // toolStripStatusLabelCreatedAtValue
            // 
            toolStripStatusLabelCreatedAtValue.Name = "toolStripStatusLabelCreatedAtValue";
            toolStripStatusLabelCreatedAtValue.Size = new Size(110, 17);
            toolStripStatusLabelCreatedAtValue.Text = "00/00/0000 00:00:00";
            // 
            // toolStripStatusLabelUpdatedAt
            // 
            toolStripStatusLabelUpdatedAt.Name = "toolStripStatusLabelUpdatedAt";
            toolStripStatusLabelUpdatedAt.Size = new Size(68, 17);
            toolStripStatusLabelUpdatedAt.Text = "Updated at:";
            // 
            // toolStripStatusLabelUpdatedAtValue
            // 
            toolStripStatusLabelUpdatedAtValue.Name = "toolStripStatusLabelUpdatedAtValue";
            toolStripStatusLabelUpdatedAtValue.Size = new Size(110, 17);
            toolStripStatusLabelUpdatedAtValue.Text = "00/00/0000 00:00:00";
            // 
            // SetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 557);
            Controls.Add(statusStrip1);
            Controls.Add(tabControl);
            Margin = new Padding(3, 2, 3, 2);
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
        private Label labelCode;
        private TextBox textBoxCode;
        private Label labelDescription;
        private TextBox textBoxDescription;
    }
}
