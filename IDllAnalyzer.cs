namespace DllDependencyExtractor
{
    public interface IDllAnalyzer
    {
        Hashtable GetNamespacesAndClasses(string folderPath);
        Dictionary<string, List<string>> GetDllDependencies(string folderPath);
    }
}
