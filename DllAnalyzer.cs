using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace DllDependencyExtractor
{
    public class DllAnalyzer : IDllAnalyzer
    {
        public Hashtable GetNamespacesAndClasses(string folderPath)
        {
            Hashtable namespaceClasses = new Hashtable();

            Logger.Info($"Scanning DLLs in folder: {folderPath}");

            foreach (string dllPath in Directory.GetFiles(folderPath, "*.dll"))
            {
                Logger.Info($"Processing DLL: {dllPath}");
                try
                {
                    //var context = new CustomAssemblyLoadContext(folderPath);
                    //var assembly = context.LoadFromAssemblyPath(dllPath);
                    
                    // Load assembly in reflection-only context
                    var assembly = Assembly.ReflectionOnlyLoadFrom(dllPath);
                    LoadReferencedAssembliesRecursively(assembly);

                    foreach (var type in assembly.GetTypes())
                    {
                        if (!namespaceClasses.ContainsKey(type.Namespace))
                        {
                            namespaceClasses[type.Namespace] = new List<string>();
                        }

                        ((List<string>)namespaceClasses[type.Namespace]).Add(type.Name);
                    }
                }
                catch (ReflectionTypeLoadException ex)
                {
                    Logger.Error($"Unable to load one or more of the requested types from {dllPath}.", ex);
                    foreach (var loaderException in ex.LoaderExceptions)
                    {
                        Logger.Error(loaderException.Message, loaderException);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Error($"An error occurred while processing {dllPath}.", ex);
                }
            }

            Logger.Info("Completed scanning namespaces and classes.");
            return namespaceClasses;
        }

        public Dictionary<string, List<string>> GetDllDependencies(string folderPath)
        {
            Dictionary<string, List<string>> dllDependencies = new Dictionary<string, List<string>>();

            Logger.Info($"Scanning DLL dependencies in folder: {folderPath}");

            foreach (string dllPath in Directory.GetFiles(folderPath, "*.dll"))
            {
                Logger.Info($"Processing DLL: {dllPath}");
                try
                {
                    var context = new CustomAssemblyLoadContext(folderPath);
                    var assembly = context.LoadFromAssemblyPath(dllPath);

                    // Get the dependent DLLs
                    List<string> dependencies = new List<string>();
                    foreach (var referencedAssembly in assembly.GetReferencedAssemblies())
                    {
                        dependencies.Add(referencedAssembly.FullName);
                    }

                    dllDependencies[Path.GetFileName(dllPath)] = dependencies;
                }
                catch (Exception ex)
                {
                    Logger.Error($"An error occurred while processing {dllPath}.", ex);
                }
            }

            Logger.Info("Completed scanning DLL dependencies.");
            return dllDependencies;
        }
        private void LoadReferencedAssembliesRecursively(Assembly assembly)
        {
            foreach (var referencedAssemblyName in assembly.GetReferencedAssemblies())
            {
                try
                {
                    var loadedAssembly = Assembly.ReflectionOnlyLoad(referencedAssemblyName.FullName);
                    LoadReferencedAssembliesRecursively(loadedAssembly);
                }
                catch (FileNotFoundException)
                {
                    // Log the missing assembly
                    Logger.Error($"Referenced assembly '{referencedAssemblyName.FullName}' could not be found.");
                }
                catch (Exception ex)
                {
                    Logger.Error($"An error occurred while loading referenced assembly '{referencedAssemblyName.FullName}'.", ex);
                }
            }
        }
    }
}
