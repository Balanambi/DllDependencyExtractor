using System;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace DllDependencyExtractor
{
    public class CustomAssemblyLoadContext : AssemblyLoadContext
    {
        private readonly string _folderPath;

        public CustomAssemblyLoadContext(string folderPath)
        {
            _folderPath = folderPath;
        }

        protected override Assembly Load(AssemblyName assemblyName)
        {
            string assemblyPath = Path.Combine(_folderPath, $"{assemblyName.Name}.dll");
            if (File.Exists(assemblyPath))
            {
                return LoadFromAssemblyPath(assemblyPath);
            }
            return null;
        }
    }
}
