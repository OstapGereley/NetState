namespace NetState.Core.Barebones.IStatementMetadata
{
    interface IStatementMetadata<Arg1, R> : INotVoidStatementMetadata<R>
    {
        IParameterMetadata<Arg1> Argument1 { get; }
    }
}
