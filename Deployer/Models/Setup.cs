namespace Deployer.Models;

public class Setup
{
    public Setup(string originPath, string destinationPath, List<string> ignoreExtensions, List<string> ignoreExactFileName)
    {
        OriginPath = originPath;
        DestinationPath = destinationPath;
        IgnoreExtensions = ignoreExtensions;
        IgnoreExactFileName = ignoreExactFileName;
    }

    public void SetCreatedAt()
        => CreatedAt = DateTime.Now;

    public void SetUpdatedAt()
        => UpdatedAt = DateTime.Now;

    public string OriginPath { get; private set; }
    public string DestinationPath { get; private set; }
    public List<string> IgnoreExtensions { get; private set; }
    public List<string> IgnoreExactFileName { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
}
