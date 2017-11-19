namespace NetState.Core.Barebones.StatementMetadatas {

    public interface IStatementMetadata<TArg1, TArg2, TArg3, Arg4, Arg5, Arg6, Arg7, R> : INotVoidStatementMetadata<R> {

        IParameterMetadata<TArg1> Argument1 { get; }

        IParameterMetadata<TArg2> Argument2 { get; }

        IParameterMetadata<TArg3> Argument3 { get; }

        IParameterMetadata<Arg4> Argument4 { get; }

        IParameterMetadata<Arg5> Argument5 { get; }

        IParameterMetadata<Arg6> Argument6 { get; }

        IParameterMetadata<Arg7> Argument7 { get; }

    }

}