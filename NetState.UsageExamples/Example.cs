using System;
using System.Threading.Tasks;

using NetState.Core.Barebones;
using NetState.Core.Barebones.StatementMetadatas;
using NetState.Core.Impl;
using NetState.Core.Impl.Predicates.Int32;
using NetState.Core.Impl.StatementMetadatas;

namespace NetState.UsageExamples {

    public class Example {

        public IStatementMetadata<int, int> ValidStatement()
        {
            return ((Func<int, int>)new SimpleExample().Add1Method)
                            .DescribeStatementMetadata(
                                new ParameterMetadata<int>(new NotZeroInt32Predicate()),
                                new ParameterMetadata<int>(new NotZeroInt32Predicate()));
        }

        public IStatementMetadata<int, int> InvalidStatement() {
            return ((Func<int, int>) new SimpleExample().Add1Method)
                .DescribeStatementMetadata(
                    new ParameterMetadata<int>(new NotZeroInt32Predicate()),
                    new ParameterMetadata<int>(new NegativeInt32Predicate()));
        }
    }

}