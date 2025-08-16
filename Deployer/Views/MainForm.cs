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

    public void OpenChildForm<T>() where T : Form
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
        OpenChildForm<SetupListForm>();
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
