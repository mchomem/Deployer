namespace Deployer.Models;

public class Setup
{
    public Setup(string code, string description, string originPath, string destinationPath, List<string> ignoreExtensions, List<string> ignoreExactFileName)
    {
        Code = code;
        Description = description;
        OriginPath = originPath;
        DestinationPath = destinationPath;
        IgnoreExtensions = ignoreExtensions;
        IgnoreExactFileName = ignoreExactFileName;
        CreatedAt = DateTime.Now;
    }

    [JsonConstructor]
    public Setup(string code, string description, string originPath, string destinationPath, List<string> ignoreExtensions, List<string> ignoreExactFileName, DateTime createdAt, DateTime updatedAt)
    {
        Code = code;
        Description = description;
        OriginPath = originPath;
        DestinationPath = destinationPath;
        IgnoreExtensions = ignoreExtensions;
        IgnoreExactFileName = ignoreExactFileName;
        CreatedAt = createdAt;
        UpdatedAt = updatedAt;
    }

    public void Update(string description, string originPath, string destinationPath, List<string> ignoreExtensions, List<string> ignoreExactFileName)
    {
        Description = description;
        OriginPath = originPath;
        DestinationPath = destinationPath;
        IgnoreExtensions = ignoreExtensions;
        IgnoreExactFileName = ignoreExactFileName;
        UpdatedAt = DateTime.Now;
    }

    public string Code  { get; private set; }
    public string Description { get; private set; }
    public string OriginPath { get; private set; }
    public string DestinationPath { get; private set; }
    public List<string> IgnoreExtensions { get; private set; }
    public List<string> IgnoreExactFileName { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public DateTime UpdatedAt { get; private set; }
}
