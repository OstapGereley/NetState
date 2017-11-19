using System;
using System.Collections.Generic;
using System.Linq;

using NetState.Core.Impl;

namespace NetState.Sandbox {

    class Program {

        static void Main(
            string[] args) {
            EnsureDataGeneratorsMappingIsValid();

            Console.Read();
        }

        private static void EnsureDataGeneratorsMappingIsValid() {
            Console.WriteLine("Validating predicates -> data generatos mapping...");
            Console.ForegroundColor = ConsoleColor.Red;
            var dataGeneratorsMap = new StartupProcedure().MapDataGenerators();
            foreach (var kvp in dataGeneratorsMap.Select(
                kvp => new KeyValuePair<string, string>(
                    kvp.Key.Name.Replace(
                        "Predicate",
                        string.Empty),
                    kvp.Value.GetType().Name.Replace(
                        "DataGenerator", 
                        string.Empty))).Where(kvp => kvp.Key != kvp.Value)) {
                Console.WriteLine($"Predicate to data generator mapping is wrong: naming convention violated.\r\n" + $"{kvp.Key}Predicate was mapped to the {kvp.Value}DataGenerator...\r\n");
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("...done.");
        }

    }

}