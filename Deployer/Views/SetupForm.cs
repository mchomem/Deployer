namespace Deployer.Views;

public partial class SetupForm : MdiChieldFormBase
{
    private readonly IJsonRepositoryBase<Setup> _jsonRepository;
    private Setup Setup { get; set; }

    public SetupForm(IJsonRepositoryBase<Setup> jsonRepository)
    {
        _jsonRepository = jsonRepository;
        InitializeComponent();
    }

    private async void SetupForm_Load(object sender, EventArgs e)
    {
        await LoadJson();
    }

    public async Task LoadJson()
    {
        try
        {
            Setup = await _jsonRepository.GetAsync(TransferData.Code);
            
            if (Setup is null)
                return;

            this.textBoxCode.Enabled = false;
            this.textBoxCode.Text = Setup.Code;
            this.textBoxDescription.Text = Setup.Description;
            this.textBoxOriginPath.Text = Setup.OriginPath;
            this.textBoxDestinationPath.Text = Setup.DestinationPath;
            this.listBoxIgnoredExtensionsFile.Items.AddRange(Setup.IgnoreExtensions.ToArray());
            this.listBoxIgnoredExactFileName.Items.AddRange(Setup.IgnoreExactFileName.ToArray());

            this.toolStripStatusLabelCreatedAtValue.Text = Setup.CreatedAt.ToString("dd/MM/yyyy HH:mm:ss");
            this.toolStripStatusLabelUpdatedAtValue.Text = Setup.UpdatedAt.ToString("dd/MM/yyyy HH:mm:ss");

            this.textBoxContentJsonFile.Text = JsonSerializer.Serialize(Setup, new JsonSerializerOptions { WriteIndented = true });
        }
        catch (Exception e)
        {
            MessageBox.Show(this, e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void buttonChooseOriginPath_Click(object sender, EventArgs e)
    {
        this.folderBrowserDialog.Reset();
        var dialogResult = this.folderBrowserDialog.ShowDialog(this);

        if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)
        {
            this.textBoxOriginPath.Text = this.folderBrowserDialog.SelectedPath;
        }
    }

    private void buttonChooseDestinationPath_Click(object sender, EventArgs e)
    {
        this.folderBrowserDialog.Reset();
        var dialogResult = this.folderBrowserDialog.ShowDialog(this);

        if (dialogResult == DialogResult.OK || dialogResult == DialogResult.Yes)
        {
            this.textBoxDestinationPath.Text = this.folderBrowserDialog.SelectedPath;
        }
    }

    private async void buttonSave_Click(object sender, EventArgs e)
    {
        await this.Save();
        await ClearForm();
        await this.LoadJson();
    }

    private void buttonClearValueOriginPath_Click(object sender, EventArgs e)
    {
        this.textBoxOriginPath.Text = string.Empty;
    }

    private void buttonClearValueDestinationPath_Click(object sender, EventArgs e)
    {
        this.textBoxDestinationPath.Text = string.Empty;
    }

    private void buttonAddIgnoredExtensionsFile_Click(object sender, EventArgs e)
    {
        this.AddIgnoredExtensionsFile();
    }

    private void textBoxIgnoredExtensionsFile_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
            this.AddIgnoredExtensionsFile();
    }

    private void buttonRemoveIgnoredExtensionsFile_Click(object sender, EventArgs e)
    {
        if (this.listBoxIgnoredExtensionsFile.SelectedItems.Count == 0)
        {
            MessageBox.Show(this, "Select an item to remove it.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        for (int i = this.listBoxIgnoredExtensionsFile.SelectedIndices.Count - 1; i >= 0; i--)
        {
            this.listBoxIgnoredExtensionsFile.Items.RemoveAt(this.listBoxIgnoredExtensionsFile.SelectedIndices[i]);
        }
    }

    private void buttonAddIgnoredExactFileName_Click(object sender, EventArgs e)
    {
        this.AddIgnoredExactFileName();
    }

    private void textBoxIgnoredExactFileName_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar == (char)Keys.Enter)
            this.AddIgnoredExactFileName();
    }

    private void buttonRemoveIgnoredExactFileName_Click(object sender, EventArgs e)
    {
        if (this.listBoxIgnoredExactFileName.SelectedItems.Count == 0)
        {
            MessageBox.Show(this, "Select an item to remove it.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        for (int i = this.listBoxIgnoredExactFileName.SelectedIndices.Count - 1; i >= 0; i--)
        {
            this.listBoxIgnoredExactFileName.Items.RemoveAt(this.listBoxIgnoredExactFileName.SelectedIndices[i]);
        }
    }

    private void AddIgnoredExtensionsFile()
    {
        if (string.IsNullOrEmpty(this.textBoxIgnoredExtensionsFile.Text))
        {
            MessageBox.Show(this, "Type ignored extension file.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (this.listBoxIgnoredExtensionsFile.Items.Contains(this.textBoxIgnoredExtensionsFile.Text))
            return;

        this.listBoxIgnoredExtensionsFile.Items.Add(this.textBoxIgnoredExtensionsFile.Text);
        this.textBoxIgnoredExtensionsFile.Text = string.Empty;
    }

    private void AddIgnoredExactFileName()
    {
        if (string.IsNullOrEmpty(this.textBoxIgnoredExactFileName.Text))
        {
            MessageBox.Show(this, "Type ignored exact file name list is empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (this.listBoxIgnoredExactFileName.Items.Contains(this.textBoxIgnoredExactFileName.Text))
            return;

        this.listBoxIgnoredExactFileName.Items.Add(this.textBoxIgnoredExactFileName.Text);
        this.textBoxIgnoredExactFileName.Text = string.Empty;
    }

    private async Task ClearForm()
    {
        await Task.Run(() =>
        {
            this.Invoke((Action)(() =>
            {
                this.textBoxCode.Text = string.Empty;
                this.textBoxDescription.Text = string.Empty;
                this.textBoxOriginPath.Text = string.Empty;
                this.textBoxDestinationPath.Text = string.Empty;
                this.listBoxIgnoredExtensionsFile.Items.Clear();
                this.listBoxIgnoredExactFileName.Items.Clear();
            }));
        });
    }

    private async Task Save()
    {
        var code = this.textBoxCode.Text.Trim();
        var description = this.textBoxDescription.Text.Trim();
        var originPath = this.textBoxOriginPath.Text;
        var destinationPath = this.textBoxDestinationPath.Text;
        var ignoredExtensions = new List<string>();

        foreach (var item in this.listBoxIgnoredExtensionsFile.Items)
            ignoredExtensions.Add(item.ToString()!);

        var ignoredExactFileName = new List<string>();

        foreach (var item in listBoxIgnoredExactFileName.Items)
            ignoredExactFileName.Add(item.ToString()!);

        Setup setup;

        if (Setup is null)
        {
            setup = new Setup(code, description, originPath, destinationPath, ignoredExtensions, ignoredExactFileName);
            await _jsonRepository.CreateAsync(setup);
        }
        else
        {
            setup = Setup;
            setup.Update(description, originPath, destinationPath, ignoredExtensions, ignoredExactFileName);
            
            await _jsonRepository.UpdateAsync(setup.Code, setup);
        }

        MessageBox.Show(this, $"Setup saved.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        this.tabControl.SelectedIndex = 1;
    }
}
