namespace Deployer.Views;

public partial class AboutForm : MdiChieldFormBase
{
    public AboutForm()
    {
        InitializeComponent();
    }

    private void AboutForm_Load(object sender, EventArgs e)
    {
        StringBuilder text = new StringBuilder();
        text.AppendLine("This tool is intended to assist in the deployment process of applications that are still distributed in the on promise format");
        text.AppendLine();
        text.AppendLine("It is merely a facilitator for these operations");
        text.AppendLine();
        text.AppendLine("Misael C. Homem.");
        labelTextAbout.Text = text.ToString();
    }
}
