using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace DllDependencyExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup dependency injection
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IDllAnalyzer, DllAnalyzer>()
                .BuildServiceProvider();

            var dllAnalyzer = serviceProvider.GetService<IDllAnalyzer>();

            string folderPath = @"C:\Path\To\Your\Dlls"; // Change this to your folder path

            var namespaceClasses = dllAnalyzer.GetNamespacesAndClasses(folderPath);
            var dllDependencies = dllAnalyzer.GetDllDependencies(folderPath);

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
