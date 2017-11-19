using System;

using NetState.Core.Barebones;
using NetState.Core.Barebones.StatementMetadatas;

namespace NetState.Core.Impl.StatementMetadatas {

    public static class ExtensionMethods {

        public static IStatementMetadata<TArg, TResult> DescribeStatementMetadata<TArg, TResult>(
            this Func<TArg, TResult> func, 
            IParameterMetadata<TArg> argumentMetadata, 
            IParameterMetadata<TResult> resultMetadata) {
            return new StatementMetadata<TArg, TResult>(resultMetadata, func, argumentMetadata);
        }

    }

}