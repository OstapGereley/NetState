using System;
using System.Collections.Generic;
using System.Linq;

using NetState.Core.Barebones.StatementMetadatas;
using NetState.Core.Impl;
using NetState.UsageExamples;

namespace NetState.Sandbox {

    internal class Program {

        private static void Main(
            string[] args) {
            EnsureDataGeneratorsMappingIsValid();

            TryProveStatements(
                new Example().ValidStatement(),
                new Example().InvalidStatement());

            "End of the execution.".PrintAsNormal();
            Console.Read();
        }

        private static void TryProveStatements(
            params IStatementMetadata<int, int>[] statements) {
            foreach (var statement in statements) {
                var statementProofResult = statement.TryProof(new OnlyTrueDataNTimesStatementProver(100)).Result;
                if (statementProofResult.Success) "Statement proved.".PrintAsSuccess();
                else $"Failed to prove statement:\r\n{statementProofResult.Info}\r\n".PrintAsError();
            }
        }

        private static void EnsureDataGeneratorsMappingIsValid() {
            "Validating predicates -> data generatos mapping...".PrintAsNormal();
            var dataGeneratorsMap = new StartupProcedure().MapDataGenerators();
            foreach (var kvp in dataGeneratorsMap.Select(
                kvp => new KeyValuePair<string, string>(
                    kvp.Key.Name.Replace(
                        "Predicate",
                        string.Empty),
                    kvp.Value.GetType().Name.Replace(
                        "DataGenerator",
                        string.Empty))).Where(kvp => kvp.Key != kvp.Value)) ("Predicate to data generator mapping is wrong: naming convention violated.\r\n" + $"{kvp.Key}Predicate was mapped to the {kvp.Value}DataGenerator...\r\n").PrintAsError();

            "...done.".PrintAsNormal();
        }

    }

}