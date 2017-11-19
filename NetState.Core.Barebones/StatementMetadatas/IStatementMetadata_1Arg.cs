using System;

namespace NetState.Core.Barebones.StatementMetadatas
{
    public interface IStatementMetadata<TArg1, TRes> : INotVoidStatementMetadata<TRes>
    {
        IParameterMetadata<TArg1> Argument1 { get; }
        Func<TArg1, TRes> Method { get; }
    }
}
