namespace Deployer.Views
{
    partial class MainForm
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
            menuStrip = new MenuStrip();
            setToolStripMenuItem = new ToolStripMenuItem();
            setupToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { setToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Padding = new Padding(5, 2, 0, 2);
            menuStrip.Size = new Size(700, 24);
            menuStrip.TabIndex = 3;
            menuStrip.Text = "menuStrip1";
            // 
            // setToolStripMenuItem
            // 
            setToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setupToolStripMenuItem, toolStripMenuItem1, exitToolStripMenuItem });
            setToolStripMenuItem.Name = "setToolStripMenuItem";
            setToolStripMenuItem.Size = new Size(46, 20);
            setToolStripMenuItem.Text = "Main";
            // 
            // setupToolStripMenuItem
            // 
            setupToolStripMenuItem.Image = Properties.Resources.cog;
            setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            setupToolStripMenuItem.Size = new Size(184, 26);
            setupToolStripMenuItem.Text = "Setup";
            setupToolStripMenuItem.Click += setupToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(181, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Image = Properties.Resources.door_out;
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(184, 26);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem1 });
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(44, 20);
            aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            aboutToolStripMenuItem1.Image = Properties.Resources.information;
            aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            aboutToolStripMenuItem1.Size = new Size(107, 22);
            aboutToolStripMenuItem1.Text = "About";
            aboutToolStripMenuItem1.Click += aboutToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Deployer";
            WindowState = FormWindowState.Maximized;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip;
        private ToolStripMenuItem setToolStripMenuItem;
        private ToolStripMenuItem setupToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem1;
    }
}