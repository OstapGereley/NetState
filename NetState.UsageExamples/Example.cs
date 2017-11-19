using System;
using System.Threading.Tasks;

using NetState.Core.Impl;
using NetState.Core.Impl.Predicates.Int32;
using NetState.Core.Impl.StatementMetadatas;

namespace NetState.UsageExamples {

    public class Example {

        public async Task StatementDeclaration(uint tryTimes) {
            var proofResult = await ((Func<int, int>) new CustomClass().CustomMethod) // prooving custom method of the custom class
                .DescribeStatementMetadata(
                    new ParameterMetadata<int>(new NotZeroInt32Predicate()), // predicates could be chainged together
                    new ParameterMetadata<int>(new NotZeroInt32Predicate()))
                .TryProof(
                    new OnlyTrueDataNTimesStatementEvaluator(tryTimes));

            if (proofResult.Success) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Statement prooved.");
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failed to proov statement:\r\n");
                Console.WriteLine(proofResult.Info); // detailed error description gonna be here
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

    }

}