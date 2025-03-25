namespace Deployer.Views;

public partial class MainForm : Form
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IJsonRepositoryBase<Setup> _jsonRepository;

    public MainForm(IServiceProvider serviceProvider, IJsonRepositoryBase<Setup> jsonRepository)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
        _jsonRepository = jsonRepository;
    }

    private void OpenChildForm<T>() where T : Form
    {
        var existingForm = MdiChildren.OfType<T>().FirstOrDefault();

        if (existingForm != null)
        {
            existingForm.Activate();
            return;
        }

        var form = _serviceProvider.GetRequiredService<T>();
        form.MdiParent = this;
        form.Show();
    }

    private void setupToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenChildForm<SetupForm>();
    }

    private async void processToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var exists = await _jsonRepository.CheckIfExists();

        if (!exists)
        {
            MessageBox.Show(this, "The setup don't exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            var result = MessageBox.Show(this, "Do you want to access the Setup form to create the configuration?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                OpenChildForm<SetupForm>();
            }
            return;
        }

        OpenChildForm<ProcessForm>();
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
        OpenChildForm<AboutForm>();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }
}
