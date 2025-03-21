namespace Deployer.Views
{
    partial class ProcessForm
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
            buttonStartCopy = new Button();
            progressBarCopyFiles = new ProgressBar();
            labelStatus = new Label();
            labelOriginPath = new Label();
            labelDestinationPath = new Label();
            labelOriginPathValue = new Label();
            labelDestinationPathValue = new Label();
            labelStatusValue = new Label();
            dataGridViewLog = new DataGridView();
            ExceptionMessage = new DataGridViewTextBoxColumn();
            FileName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).BeginInit();
            SuspendLayout();
            // 
            // buttonStartCopy
            // 
            buttonStartCopy.Location = new Point(694, 92);
            buttonStartCopy.Name = "buttonStartCopy";
            buttonStartCopy.Size = new Size(94, 29);
            buttonStartCopy.TabIndex = 0;
            buttonStartCopy.Text = "Start Copy";
            buttonStartCopy.UseVisualStyleBackColor = true;
            buttonStartCopy.Click += buttonStartCopy_Click;
            // 
            // progressBarCopyFiles
            // 
            progressBarCopyFiles.Location = new Point(12, 57);
            progressBarCopyFiles.Name = "progressBarCopyFiles";
            progressBarCopyFiles.Size = new Size(776, 29);
            progressBarCopyFiles.TabIndex = 1;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(12, 23);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(52, 20);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Status:";
            // 
            // labelOriginPath
            // 
            labelOriginPath.AutoSize = true;
            labelOriginPath.Location = new Point(12, 153);
            labelOriginPath.Name = "labelOriginPath";
            labelOriginPath.Size = new Size(53, 20);
            labelOriginPath.TabIndex = 3;
            labelOriginPath.Text = "Origin:";
            // 
            // labelDestinationPath
            // 
            labelDestinationPath.AutoSize = true;
            labelDestinationPath.Location = new Point(12, 194);
            labelDestinationPath.Name = "labelDestinationPath";
            labelDestinationPath.Size = new Size(88, 20);
            labelDestinationPath.TabIndex = 4;
            labelDestinationPath.Text = "Destination:";
            // 
            // labelOriginPathValue
            // 
            labelOriginPathValue.AutoSize = true;
            labelOriginPathValue.Location = new Point(120, 153);
            labelOriginPathValue.Name = "labelOriginPathValue";
            labelOriginPathValue.Size = new Size(92, 20);
            labelOriginPathValue.TabIndex = 5;
            labelOriginPathValue.Text = "{origin path}";
            // 
            // labelDestinationPathValue
            // 
            labelDestinationPathValue.AutoSize = true;
            labelDestinationPathValue.Location = new Point(120, 194);
            labelDestinationPathValue.Name = "labelDestinationPathValue";
            labelDestinationPathValue.Size = new Size(127, 20);
            labelDestinationPathValue.TabIndex = 6;
            labelDestinationPathValue.Text = "{destination path}";
            // 
            // labelStatusValue
            // 
            labelStatusValue.AutoSize = true;
            labelStatusValue.Location = new Point(120, 23);
            labelStatusValue.Name = "labelStatusValue";
            labelStatusValue.Size = new Size(57, 20);
            labelStatusValue.TabIndex = 7;
            labelStatusValue.Text = "{status}";
            // 
            // dataGridViewLog
            // 
            dataGridViewLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLog.Columns.AddRange(new DataGridViewColumn[] { ExceptionMessage, FileName });
            dataGridViewLog.Location = new Point(12, 250);
            dataGridViewLog.Name = "dataGridViewLog";
            dataGridViewLog.RowHeadersVisible = false;
            dataGridViewLog.RowHeadersWidth = 51;
            dataGridViewLog.Size = new Size(776, 188);
            dataGridViewLog.TabIndex = 8;
            // 
            // ExceptionMessage
            // 
            ExceptionMessage.HeaderText = "Exception Message";
            ExceptionMessage.MinimumWidth = 6;
            ExceptionMessage.Name = "ExceptionMessage";
            ExceptionMessage.Width = 500;
            // 
            // FileName
            // 
            FileName.HeaderText = "File Name";
            FileName.MinimumWidth = 6;
            FileName.Name = "FileName";
            FileName.Width = 300;
            // 
            // ProcessForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewLog);
            Controls.Add(labelStatusValue);
            Controls.Add(labelDestinationPathValue);
            Controls.Add(labelOriginPathValue);
            Controls.Add(labelDestinationPath);
            Controls.Add(labelOriginPath);
            Controls.Add(labelStatus);
            Controls.Add(progressBarCopyFiles);
            Controls.Add(buttonStartCopy);
            Name = "ProcessForm";
            Text = "Process";
            VisibleChanged += ProcessForm_VisibleChanged;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStartCopy;
        private ProgressBar progressBarCopyFiles;
        private Label labelStatus;
        private Label labelOriginPath;
        private Label labelDestinationPath;
        private Label labelOriginPathValue;
        private Label labelDestinationPathValue;
        private Label labelStatusValue;
        private DataGridView dataGridViewLog;
        private DataGridViewTextBoxColumn ExceptionMessage;
        private DataGridViewTextBoxColumn FileName;
    }
}