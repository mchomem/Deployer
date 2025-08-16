namespace Deployer.Views
{
    partial class SetupListForm
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
            groupBoxRecords = new GroupBox();
            dataGridViewSetups = new DataGridView();
            buttonNewRecord = new Button();
            Code = new DataGridViewTextBoxColumn();
            Description = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Process = new DataGridViewImageColumn();
            groupBoxRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSetups).BeginInit();
            SuspendLayout();
            // 
            // groupBoxRecords
            // 
            groupBoxRecords.Controls.Add(dataGridViewSetups);
            groupBoxRecords.Location = new Point(12, 62);
            groupBoxRecords.Name = "groupBoxRecords";
            groupBoxRecords.Size = new Size(788, 438);
            groupBoxRecords.TabIndex = 0;
            groupBoxRecords.TabStop = false;
            groupBoxRecords.Text = "Records";
            // 
            // dataGridViewSetups
            // 
            dataGridViewSetups.AllowUserToAddRows = false;
            dataGridViewSetups.AllowUserToDeleteRows = false;
            dataGridViewSetups.AllowUserToResizeColumns = false;
            dataGridViewSetups.AllowUserToResizeRows = false;
            dataGridViewSetups.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSetups.Columns.AddRange(new DataGridViewColumn[] { Code, Description, Edit, Process });
            dataGridViewSetups.Location = new Point(12, 22);
            dataGridViewSetups.Name = "dataGridViewSetups";
            dataGridViewSetups.RowHeadersVisible = false;
            dataGridViewSetups.Size = new Size(770, 410);
            dataGridViewSetups.TabIndex = 0;
            dataGridViewSetups.CellContentClick += dataGridViewSetups_CellContentClick;
            // 
            // buttonNewRecord
            // 
            buttonNewRecord.Location = new Point(12, 12);
            buttonNewRecord.Name = "buttonNewRecord";
            buttonNewRecord.Size = new Size(75, 23);
            buttonNewRecord.TabIndex = 1;
            buttonNewRecord.Text = "New";
            buttonNewRecord.UseVisualStyleBackColor = true;
            buttonNewRecord.Click += buttonNewRecord_Click;
            // 
            // Code
            // 
            Code.HeaderText = "Code";
            Code.Name = "Code";
            // 
            // Description
            // 
            Description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Description.HeaderText = "Description";
            Description.Name = "Description";
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Edit.FillWeight = 50F;
            Edit.HeaderText = "Edit";
            Edit.Image = Properties.Resources.page_edit;
            Edit.Name = "Edit";
            Edit.Resizable = DataGridViewTriState.True;
            Edit.Width = 33;
            // 
            // Process
            // 
            Process.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Process.FillWeight = 50F;
            Process.HeaderText = "Process";
            Process.Image = Properties.Resources.application_osx_terminal;
            Process.Name = "Process";
            Process.Width = 53;
            // 
            // SetupListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 512);
            Controls.Add(buttonNewRecord);
            Controls.Add(groupBoxRecords);
            Name = "SetupListForm";
            Text = "SetupListForm";
            Load += SetupListForm_Load;
            groupBoxRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSetups).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxRecords;
        private DataGridView dataGridViewSetups;
        private Button buttonNewRecord;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Description;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Process;
    }
}