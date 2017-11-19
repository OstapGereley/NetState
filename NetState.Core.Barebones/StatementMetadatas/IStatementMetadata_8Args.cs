namespace NetState.Core.Barebones.StatementMetadatas {

    public interface IStatementMetadata<Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, R> : INotVoidStatementMetadata<R> {

        IParameterMetadata<Arg1> Argument1 { get; }

        IParameterMetadata<Arg2> Argument2 { get; }

        IParameterMetadata<Arg3> Argument3 { get; }

        IParameterMetadata<Arg4> Argument4 { get; }

        IParameterMetadata<Arg5> Argument5 { get; }

        IParameterMetadata<Arg6> Argument6 { get; }

        IParameterMetadata<Arg7> Argument7 { get; }

        IParameterMetadata<Arg8> Argument8 { get; }

    }

}