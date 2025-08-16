namespace Deployer.Views;

public partial class ProcessForm : MdiChieldFormBase
{
    private Setup deployerSetup = null!;

    private readonly IJsonRepositoryBase<Setup> _jsonRepository;

    public ProcessForm(IJsonRepositoryBase<Setup> jsonRepository)
    {
        _jsonRepository = jsonRepository;
        InitializeComponent();
        this.labelStatusValue.Text = string.Empty;
    }

    private async void ProcessForm_VisibleChanged(object sender, EventArgs e)
    {
        await this.LoadJson();
    }

    private async void buttonStartCopy_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(this, "Are you sure you want to proceed?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if(result == DialogResult.No || result == DialogResult.Cancel)
            return;

        Invoke(new Action(() => {
            this.buttonStartCopy.Enabled = false;
        }));

        await Task.Run(() => CopyFilesAndDirectories());

        Invoke(new Action(() => {
            this.buttonStartCopy.Enabled = true;
        }));
    }

    private async Task LoadJson()
    {
        deployerSetup = await _jsonRepository.GetAsync(TransferData.Code);
        this.labelOriginPathValue.Text = deployerSetup.OriginPath;
        this.labelDestinationPathValue.Text = deployerSetup.DestinationPath;
    }

    private async Task CopyFilesAndDirectories()
    {
        if (!Directory.Exists(deployerSetup.OriginPath))
        {
            MessageBox.Show("The origin path don't exits.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        var amoutFiles = Directory.GetFiles(deployerSetup.OriginPath);

        if (amoutFiles.Length == 0)
        {
            MessageBox.Show($"The refered path {deployerSetup.OriginPath} is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        Invoke(new Action(() => { 
            this.dataGridViewLog.Rows.Clear();
        }));

        var files = Directory.GetFiles(deployerSetup.OriginPath, "*", SearchOption.AllDirectories);

        Invoke(new Action(() =>
        {
            progressBarCopyFiles.Minimum = 0;
            progressBarCopyFiles.Maximum = files.Length;
            progressBarCopyFiles.Value = 0;

            labelStatusValue.Text = "Copying file";
            buttonStartCopy.Enabled = false;
        }));

        await Task.Run(() =>
        {
            for (int i = 0; i < files.Length; i++)
            {
                string sourceFile = files[i];
                string fileName = Path.GetRelativePath(deployerSetup.OriginPath, sourceFile);
                string extension = fileName.Split('.').Last();

                // Ignora as extenções.
                if(deployerSetup.IgnoreExtensions.Contains(extension))
                    continue;

                string exactfileName = Path.GetFileNameWithoutExtension(fileName);

                // Ignora o nome exato do arquivo.
                if (deployerSetup.IgnoreExactFileName.Contains(exactfileName))
                    continue;

                string destinationFile = Path.Combine(deployerSetup.DestinationPath, fileName);

                // Cria o diretório do arquivo no destino, se necessário
                Directory.CreateDirectory(Path.GetDirectoryName(destinationFile)!);

                try
                {
                    // Copia o arquivo
                    File.Copy(sourceFile, destinationFile, true);
                    
                    Invoke(new Action(() => {
                        this.dataGridViewLog.Rows.Add($"File {fileName} copied.", DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss"));
                    }));
                }
                catch (Exception e)
                {
                    Invoke(new Action(() => { 
                        this.dataGridViewLog.Rows.Add(e.Message, DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss"));
                    }));
                }

                // Atualiza a barra de progresso na thread da UI
                Invoke(new Action(() =>
                {
                    progressBarCopyFiles.Value = i + 1;
                    labelStatusValue.Text = $"Copyed file: {fileName} - {i + 1}/{files.Length} ...";
                }));
            }
        });

        Invoke(new Action(() =>
        {
            labelStatus.Text = "Done";
            buttonStartCopy.Enabled = true;
            progressBarCopyFiles.Value = 0;
            MessageBox.Show(this, "Files copied to destination.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }));
    }
}
