using System;
using System.Threading.Tasks;

using NetState.Core.Impl;
using NetState.Core.Impl.Predicates.Int32;
using NetState.Core.Impl.StatementMetadatas;

namespace NetState.UsageExamples {

    public class Example {

        public async Task StatementDeclaration() {
            var proofResult = await ((Func<int, int>) new CustomClass()
                    .CustomMethod)
                .DescribeStatementMetadata(
                    new ParameterMetadata<int>(new PositiveInt32Predicate()),
                    new ParameterMetadata<int>(new PositiveInt32Predicate()))
                .TryProof(new OnlyTrueDataNTimesStatementEvaluator(1000));

            if (proofResult.Success) {
                // we're fine
            } else {
                var errorDescription = proofResult.Info; // detailed error description gonna be here
            }
        }

    }

}