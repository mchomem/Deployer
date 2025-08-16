namespace Deployer.Views;

public partial class SetupListForm : MdiChieldFormBase
{
    private readonly IServiceProvider _serviceProvider;
    private readonly IJsonRepositoryBase<Setup> _jsonRepository;

    public SetupListForm(IServiceProvider serviceProvider, IJsonRepositoryBase<Setup> jsonRepository)
    {
        InitializeComponent();
        _serviceProvider = serviceProvider;
        _jsonRepository = jsonRepository;
    }

    private async void SetupListForm_Load(object sender, EventArgs e)
    {
        await LoadJson();
    }

    private async Task LoadJson()
    {
        var setups = await _jsonRepository.GetAllAsync();

        foreach (var setup in setups)
        {
            this.dataGridViewSetups.Rows.Add(setup.Code, setup.Description);
        }
    }

    private void buttonNewRecord_Click(object sender, EventArgs e)
    {
        if (this.MdiParent is MainForm main)
        {
            main.OpenChildForm<SetupForm>();
        }
    }

    private void dataGridViewSetups_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        // Ignorar clique no cabeçalho
        if (e.RowIndex < 0) return;

        if (this.dataGridViewSetups.Columns[e.ColumnIndex].Name == "Edit")
        {
            var code = this.dataGridViewSetups.Rows[e.RowIndex].Cells["Code"].Value.ToString();

            if (this.MdiParent is MainForm main)
            {
                TransferData.Code = code;
                main.OpenChildForm<SetupForm>();
                this.Close();
            }
        }
        else if (this.dataGridViewSetups.Columns[e.ColumnIndex].Name == "Process")
        {
            var code = this.dataGridViewSetups.Rows[e.RowIndex].Cells["Code"].Value.ToString();

            if (this.MdiParent is MainForm main)
            {
                TransferData.Code = code;
                main.OpenChildForm<ProcessForm>();
                this.Close();
            }
        }
    }
}
