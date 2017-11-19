namespace NetState.Core.Barebones.IStatementMetadata
{
    public interface IStatementMetadata<Arg1, Arg2, R> : INotVoidStatementMetadata<R>
    {
        IParameterMetadata<Arg1> Argument1 { get; }

        IParameterMetadata<Arg2> Argument2 { get; }
    }
}
