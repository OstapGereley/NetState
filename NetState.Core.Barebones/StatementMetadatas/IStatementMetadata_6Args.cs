namespace NetState.Core.Barebones.StatementMetadatas {

    public interface IStatementMetadata<TArg1, Arg2, Arg3, Arg4, Arg5, Arg6, R> : INotVoidStatementMetadata<R> {

        IParameterMetadata<TArg1> Argument1 { get; }

        IParameterMetadata<Arg2> Argument2 { get; }

        IParameterMetadata<Arg3> Argument3 { get; }

        IParameterMetadata<Arg4> Argument4 { get; }

        IParameterMetadata<Arg5> Argument5 { get; }

        IParameterMetadata<Arg6> Argument6 { get; }

    }

}