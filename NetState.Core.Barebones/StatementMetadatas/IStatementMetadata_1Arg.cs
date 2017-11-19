using System;

namespace NetState.Core.Barebones.StatementMetadatas {

    public interface IStatementMetadata<TArg1, TResult> : INotVoidStatementMetadata<TResult> {

        IParameterMetadata<TArg1> Argument1 { get; }

        Func<TArg1, TResult> Method { get; }

    }

}