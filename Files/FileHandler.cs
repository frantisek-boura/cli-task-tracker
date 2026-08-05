using System.Security;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CliTaskTracker.Files;

using Task = CliTaskTracker.Task.Task;

public class FileHandler(string filePath) : IFileHandler
{
    public string FilePath { get; } = filePath;
    
    public List<Task> LoadTasks()
    {
        try
        {
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
                return [];
            }
            
            string contents = File.ReadAllText(FilePath);
            if (string.IsNullOrWhiteSpace(contents)) return [];
            
            return JsonSerializer.Deserialize<List<Task>>(contents) ?? [];
        }
        catch (Exception e)
        {
            if (e is JsonException)
            {
                throw new InvalidTaskFileFormat("Could not read from the local taskfile.");
            } 
            if (e is IOException || e is UnauthorizedAccessException || e is SecurityException)
            {
                throw new CouldNotHandleFileException("Could not read from file due to an unexpected file error or due to security restrictions.");
            }
            
            throw new UnknownErrorException("An unknown error occurred.");
        }
    }

    public void SaveTasks(List<Task> tasks)
    {
        try
        {
            string contents = JsonSerializer.Serialize(tasks);
            File.WriteAllText(FilePath, contents);
        }
        catch (Exception e)
        {
            if (e is IOException || e is UnauthorizedAccessException || e is SecurityException)
            {
                throw new CouldNotHandleFileException("Could not save to file due to an unexpected file error or due to security restrictions.");
            }
            
            throw new UnknownErrorException("An unknown error occurred.");
        }
    }
}