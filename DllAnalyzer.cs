using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Loader;

namespace DllDependencyExtractor
{
    public class DllAnalyzer : IDllAnalyzer
    {
        public Hashtable GetNamespacesAndClasses(string folderPath)
        {
            Hashtable namespaceClasses = new Hashtable();

            foreach (string dllPath in Directory.GetFiles(folderPath, "*.dll"))
            {
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(dllPath);

                foreach (var type in assembly.GetTypes())
                {
                    if (!namespaceClasses.ContainsKey(type.Namespace))
                    {
                        namespaceClasses[type.Namespace] = new List<string>();
                    }

                    ((List<string>)namespaceClasses[type.Namespace]).Add(type.Name);
                }
            }

            return namespaceClasses;
        }

        public Dictionary<string, List<string>> GetDllDependencies(string folderPath)
        {
            Dictionary<string, List<string>> dllDependencies = new Dictionary<string, List<string>>();

            foreach (string dllPath in Directory.GetFiles(folderPath, "*.dll"))
            {
                var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(dllPath);

                // Get the dependent DLLs
                List<string> dependencies = new List<string>();
                foreach (var referencedAssembly in assembly.GetReferencedAssemblies())
                {
                    dependencies.Add(referencedAssembly.FullName);
                }

                dllDependencies[Path.GetFileName(dllPath)] = dependencies;
            }

            return dllDependencies;
        }
    }
}
