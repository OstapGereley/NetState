namespace NetState.Core.Barebones.StatementMetadatas {

    public interface IStatementMetadata<TArg1, Arg2, R> : INotVoidStatementMetadata<R> {

        IParameterMetadata<TArg1> Argument1 { get; }

        IParameterMetadata<Arg2> Argument2 { get; }

    }

}