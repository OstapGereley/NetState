﻿namespace NetState.Core.Barebones.StatementMetadatas {

    public interface IStatementMetadata<Arg1, Arg2, Arg3, R> : INotVoidStatementMetadata<R> {

        IParameterMetadata<Arg1> Argument1 { get; }

        IParameterMetadata<Arg2> Argument2 { get; }

        IParameterMetadata<Arg3> Argument3 { get; }

    }

}