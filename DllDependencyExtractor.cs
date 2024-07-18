using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;

namespace DllDependencyExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string folderPath = @"C:\Path\To\Your\Dlls"; // Change this to your folder path

            Hashtable namespaceClasses = new Hashtable();
            Dictionary<string, List<string>> dllDependencies = new Dictionary<string, List<string>>();

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

                // Get the dependent DLLs
                List<string> dependencies = new List<string>();
                foreach (var referencedAssembly in assembly.GetReferencedAssemblies())
                {
                    dependencies.Add(referencedAssembly.FullName);
                }

                dllDependencies[Path.GetFileName(dllPath)] = dependencies;
            }

            // Display the namespaces and classes
            foreach (DictionaryEntry entry in namespaceClasses)
            {
                Console.WriteLine($"Namespace: {entry.Key}");
                foreach (var className in (List<string>)entry.Value)
                {
                    Console.WriteLine($"\tClass: {className}");
                }
            }

            // Display the DLL dependencies
            Console.WriteLine("\nDLL Dependencies:");
            foreach (var entry in dllDependencies)
            {
                Console.WriteLine($"DLL: {entry.Key}");
                foreach (var dependency in entry.Value)
                {
                    Console.WriteLine($"\tDependency: {dependency}");
                }
            }
        }
    }
}
