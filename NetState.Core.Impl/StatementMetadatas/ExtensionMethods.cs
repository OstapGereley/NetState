using System;

using NetState.Core.Barebones;
using NetState.Core.Barebones.StatementMetadatas;

namespace NetState.Core.Impl.StatementMetadatas {

    public static class ExtensionMethods {

        public static IStatementMetadata<TArg, TResultult> DescribeStatementMetadata<TArg, TResultult>(
            this Func<TArg, TResultult> func,
            IParameterMetadata<TArg> argumentMetadata,
            IParameterMetadata<TResultult> resultMetadata) {
            return new StatementMetadata<TArg, TResultult>(
                resultMetadata,
                func,
                argumentMetadata);
        }

    }

}