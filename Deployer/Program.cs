namespace Deployer;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var serviceCollection = new ServiceCollection();
        ConfigureServices(serviceCollection);

        ApplicationConfiguration.Initialize();

        using (ServiceProvider serviceProvider = serviceCollection.BuildServiceProvider())
        {
            MainForm mainForm = serviceProvider.GetRequiredService<MainForm>();
            Application.Run(mainForm);
        }
    }

    static void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped(typeof(IJsonRepositoryBase<>), typeof(JsonRepositoryBase<>));
        services.AddTransient<MainForm>();
        services.AddTransient<SetupForm>();
        services.AddTransient<SetupListForm>();
        services.AddTransient<ProcessForm>();
        services.AddTransient<AboutForm>();
    }
}
