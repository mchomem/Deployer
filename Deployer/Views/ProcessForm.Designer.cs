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
            Log = new DataGridViewTextBoxColumn();
            CopiedAt = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLog).BeginInit();
            SuspendLayout();
            // 
            // buttonStartCopy
            // 
            buttonStartCopy.Location = new Point(607, 69);
            buttonStartCopy.Margin = new Padding(3, 2, 3, 2);
            buttonStartCopy.Name = "buttonStartCopy";
            buttonStartCopy.Size = new Size(82, 22);
            buttonStartCopy.TabIndex = 0;
            buttonStartCopy.Text = "Start Copy";
            buttonStartCopy.UseVisualStyleBackColor = true;
            buttonStartCopy.Click += buttonStartCopy_Click;
            // 
            // progressBarCopyFiles
            // 
            progressBarCopyFiles.Location = new Point(10, 43);
            progressBarCopyFiles.Margin = new Padding(3, 2, 3, 2);
            progressBarCopyFiles.Name = "progressBarCopyFiles";
            progressBarCopyFiles.Size = new Size(679, 22);
            progressBarCopyFiles.TabIndex = 1;
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(10, 17);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(42, 15);
            labelStatus.TabIndex = 2;
            labelStatus.Text = "Status:";
            // 
            // labelOriginPath
            // 
            labelOriginPath.AutoSize = true;
            labelOriginPath.Location = new Point(10, 115);
            labelOriginPath.Name = "labelOriginPath";
            labelOriginPath.Size = new Size(43, 15);
            labelOriginPath.TabIndex = 3;
            labelOriginPath.Text = "Origin:";
            // 
            // labelDestinationPath
            // 
            labelDestinationPath.AutoSize = true;
            labelDestinationPath.Location = new Point(10, 146);
            labelDestinationPath.Name = "labelDestinationPath";
            labelDestinationPath.Size = new Size(70, 15);
            labelDestinationPath.TabIndex = 4;
            labelDestinationPath.Text = "Destination:";
            // 
            // labelOriginPathValue
            // 
            labelOriginPathValue.AutoSize = true;
            labelOriginPathValue.Location = new Point(105, 115);
            labelOriginPathValue.Name = "labelOriginPathValue";
            labelOriginPathValue.Size = new Size(73, 15);
            labelOriginPathValue.TabIndex = 5;
            labelOriginPathValue.Text = "{origin path}";
            // 
            // labelDestinationPathValue
            // 
            labelDestinationPathValue.AutoSize = true;
            labelDestinationPathValue.Location = new Point(105, 146);
            labelDestinationPathValue.Name = "labelDestinationPathValue";
            labelDestinationPathValue.Size = new Size(101, 15);
            labelDestinationPathValue.TabIndex = 6;
            labelDestinationPathValue.Text = "{destination path}";
            // 
            // labelStatusValue
            // 
            labelStatusValue.AutoSize = true;
            labelStatusValue.Location = new Point(105, 17);
            labelStatusValue.Name = "labelStatusValue";
            labelStatusValue.Size = new Size(46, 15);
            labelStatusValue.TabIndex = 7;
            labelStatusValue.Text = "{status}";
            // 
            // dataGridViewLog
            // 
            dataGridViewLog.AllowUserToAddRows = false;
            dataGridViewLog.AllowUserToDeleteRows = false;
            dataGridViewLog.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLog.Columns.AddRange(new DataGridViewColumn[] { Log, CopiedAt });
            dataGridViewLog.Location = new Point(10, 188);
            dataGridViewLog.Margin = new Padding(3, 2, 3, 2);
            dataGridViewLog.Name = "dataGridViewLog";
            dataGridViewLog.RowHeadersVisible = false;
            dataGridViewLog.RowHeadersWidth = 51;
            dataGridViewLog.Size = new Size(679, 141);
            dataGridViewLog.TabIndex = 8;
            // 
            // Log
            // 
            Log.HeaderText = "Log";
            Log.MinimumWidth = 6;
            Log.Name = "Log";
            Log.Width = 500;
            // 
            // CopiedAt
            // 
            CopiedAt.HeaderText = "Copied at";
            CopiedAt.MinimumWidth = 6;
            CopiedAt.Name = "CopiedAt";
            CopiedAt.Width = 180;
            // 
            // ProcessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(dataGridViewLog);
            Controls.Add(labelStatusValue);
            Controls.Add(labelDestinationPathValue);
            Controls.Add(labelOriginPathValue);
            Controls.Add(labelDestinationPath);
            Controls.Add(labelOriginPath);
            Controls.Add(labelStatus);
            Controls.Add(progressBarCopyFiles);
            Controls.Add(buttonStartCopy);
            Margin = new Padding(3, 2, 3, 2);
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
        private DataGridViewTextBoxColumn Log;
        private DataGridViewTextBoxColumn CopiedAt;
    }
}