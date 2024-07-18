using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace DllDependencyExtractor
{
    public class CustomAssemblyLoadContext : AssemblyLoadContext
    {
        private readonly string _folderPath;
        private readonly HashSet<string> _loadedAssemblies = new HashSet<string>();

        public CustomAssemblyLoadContext(string folderPath)
        {
            _folderPath = folderPath;
        }

        protected override Assembly Load(AssemblyName assemblyName)
        {
            string assemblyPath = Path.Combine(_folderPath, $"{assemblyName.Name}.dll");
            if (File.Exists(assemblyPath))
            {
                return LoadAssemblyAndDependencies(assemblyPath);
            }

            // Try to load the assembly from the default context
            try
            {
                return Default.LoadFromAssemblyName(assemblyName);
            }
            catch (FileNotFoundException)
            {
                // Log that the assembly was not found
                Logger.Error($"Assembly '{assemblyName.Name}' could not be found.");
                return null;
            }
        }

        private Assembly LoadAssemblyAndDependencies(string assemblyPath)
        {
            string assemblyName = Path.GetFileNameWithoutExtension(assemblyPath);
            if (_loadedAssemblies.Contains(assemblyName))
            {
                return null;
            }

            Logger.Info($"Loading assembly: {assemblyPath}");
            var assembly = LoadFromAssemblyPath(assemblyPath);
            _loadedAssemblies.Add(assemblyName);

            // Load dependencies recursively
            foreach (var referencedAssembly in assembly.GetReferencedAssemblies())
            {
                if (!_loadedAssemblies.Contains(referencedAssembly.Name))
                {
                    Load(referencedAssembly);
                }
            }

            return assembly;
        }
    }
}
